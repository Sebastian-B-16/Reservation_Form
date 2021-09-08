using System.Data.SQLite;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Data;

namespace Licenta_V1
{
    public static class DataBase
    {//fields
        public static string _username;
        private static SQLiteConnection _dbConnection;
        private static SQLiteCommand _command;
        private static string _sqlCommand;
        private static string _dbPath = Path.GetPathRoot(System.Environment.CurrentDirectory) + "DB";
        private static string _dbFilePath;
        public static void CreateDbFile()
        {
            if (!string.IsNullOrEmpty(_dbPath) && !Directory.Exists(_dbPath))
                Directory.CreateDirectory(_dbPath);
            _dbFilePath = _dbPath + "\\DataFile.db";
            if (!File.Exists(_dbFilePath))
            {
                SQLiteConnection.CreateFile(_dbFilePath);
            }
        }

        public static string CreateDbConnection()
        {
            var strCon = $"Data Source={_dbFilePath};";
            _dbConnection = new SQLiteConnection(strCon);
            _dbConnection.Open();
            _command = _dbConnection.CreateCommand();
            CreateLogInTableIfNotExist();
            CreateReservationsTableIfNotExist();
            _dbConnection.Close();
            return strCon;
        }
        private static void CreateLogInTableIfNotExist()
        {
            if (_dbConnection.State == ConnectionState.Closed)
                _dbConnection.Open();
            if (CheckIfExist("Acc")) return;
            string CreateAccountsTable = $"CREATE TABLE Acc (id INTEGER, username TEXT NOT NULL UNIQUE, password TEXT NOT NULL, salt TEXT NOT NULL, type TEXT NOT NULL, PRIMARY KEY(id AUTOINCREMENT))";
            ExecuteQuery(CreateAccountsTable);
            if (_dbConnection.State == ConnectionState.Open)
                _dbConnection.Close();
        }

        private static void CreateReservationsTableIfNotExist()
        {
            if (_dbConnection.State == ConnectionState.Closed)
                _dbConnection.Open();
            if (CheckIfExist("Reservations")) return;
            string CreateReservationsTable = $"CREATE TABLE Reservations (id INTEGER, date TEXT NOT NULL, name TEXT NOT NULL, nrPres INTEGER NOT NULL, nrTable INTEGER NOT NULL, PRIMARY KEY(id AUTOINCREMENT))";
            ExecuteQuery(CreateReservationsTable);
            if (_dbConnection.State == ConnectionState.Open)
                _dbConnection.Close();
        }

        private static bool CheckIfExist(string type)
        {
            if (_dbConnection.State == ConnectionState.Closed)
                _dbConnection.Open();
            _command.CommandText = $"SELECT name FROM sqlite_master WHERE name='{type}'";
            var result = _command.ExecuteScalar();
            if (_dbConnection.State == ConnectionState.Open)
                _dbConnection.Close();

            return result != null && result.ToString() == type.ToString();
        }
        private static void ExecuteQuery(string sqlCommand)
        {
            if (_dbConnection.State == ConnectionState.Closed)
                _dbConnection.Open();
            using (var triggerCommand = _dbConnection.CreateCommand())
            {
                triggerCommand.CommandText = sqlCommand;
                try
                {
                    var x = triggerCommand.ExecuteNonQuery();
                    if (_dbConnection.State == ConnectionState.Open)
                        _dbConnection.Close();
                }
                catch (Exception ex)
                {
                    if (_dbConnection.State == ConnectionState.Open)
                        _dbConnection.Close();
                }
            }

            if (_dbConnection.State == ConnectionState.Open)
                _dbConnection.Close();
        }

        public static string GetData()
        {
            if (_dbConnection.State == ConnectionState.Closed)
                _dbConnection.Open();
            var jsonString = "";
            var command = new SQLiteCommand();
            command.Connection = _dbConnection;
            command.CommandText = $"Select * FROM Reservations";
            var result = command.ExecuteReader();
            while (result.Read())
            {
                var x = result.GetValues();
                        var id = int.Parse(x[0]);
                        var data = x[1];
                        var name = x[2];
                        var nrPers = x[3];
                var nrTable = x[4];
                        jsonString += $"{id}#{data}#{name}#{nrPers}#{nrTable}|";
            }

            if (_dbConnection.State == ConnectionState.Open)
                _dbConnection.Close();
            return jsonString;
        }

        public static void InsertAccount(string username, string passwordText, string type)
        {
            if (_dbConnection.State == ConnectionState.Closed)
                _dbConnection.Open();
            var passwordSalt = Guid.NewGuid().ToString();
            var passwordHashed = ComputeHash(passwordText, passwordSalt);
            var command = $"INSERT INTO Acc VALUES('{CountRecords() + 1}','{username}','{passwordHashed}','{passwordSalt}','{type}')";
            ExecuteQuery(command);
            if (_dbConnection.State == ConnectionState.Open)
                _dbConnection.Close();

        }
        public static string ComputeHash(string passwordPlainText, string saltString)
        {
            // Convert plain text into a byte array.
            byte[] saltBytes = Encoding.UTF8.GetBytes(saltString);

            // Convert plain text into a byte array.
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(passwordPlainText);

            // Allocate array, which will hold plain text and salt.
            byte[] plainTextWithSaltBytes =
                    new byte[plainTextBytes.Length + saltBytes.Length];

            // Copy plain text bytes into resulting array.
            for (int i = 0; i < plainTextBytes.Length; i++)
                plainTextWithSaltBytes[i] = plainTextBytes[i];

            // Append salt bytes to the resulting array.
            for (int i = 0; i < saltBytes.Length; i++)
                plainTextWithSaltBytes[plainTextBytes.Length + i] = saltBytes[i];

            // Because we support multiple hashing algorithms, we must define
            // hash object as a common (abstract) base class. We will specify the
            // actual hashing algorithm class later during object creation.
            HashAlgorithm hash;

            hash = new SHA256Managed();

            // Compute hash value of our plain text with appended salt.
            byte[] hashBytes = hash.ComputeHash(plainTextWithSaltBytes);

            // Create array which will hold hash and original salt bytes.
            byte[] hashWithSaltBytes = new byte[hashBytes.Length +
                                                saltBytes.Length];

            // Copy hash bytes into resulting array.
            for (int i = 0; i < hashBytes.Length; i++)
                hashWithSaltBytes[i] = hashBytes[i];

            // Append salt bytes to the result.
            for (int i = 0; i < saltBytes.Length; i++)
                hashWithSaltBytes[hashBytes.Length + i] = saltBytes[i];

            // Convert result into a base64-encoded string.
            string hashValue = Convert.ToBase64String(hashWithSaltBytes);

            // Return the result.
            return hashValue;
        }
        public static int CountRecords()
        {
            if (_dbConnection.State == ConnectionState.Closed)
                _dbConnection.Open();

            var command = new SQLiteCommand();
            object result;
            command.Connection = _dbConnection;
            command.CommandText = $"SELECT Count(*) FROM Acc";
            result = command.ExecuteScalar();
            if (_dbConnection.State == ConnectionState.Open)
                _dbConnection.Close();
            return Convert.ToInt32(result);
        }
        public static int CountRecordsForReservations()
        {
            if (_dbConnection.State == ConnectionState.Closed)
                _dbConnection.Open();

            var command = new SQLiteCommand();
            object result;
            command.Connection = _dbConnection;
            command.CommandText = $"SELECT Count(*) FROM Reservations";
            result = command.ExecuteScalar();
            if (_dbConnection.State == ConnectionState.Open)
                _dbConnection.Close();
            return Convert.ToInt32(result);
        }

        public static bool AccountIsCorrect(string username, string password)
        {
            _username = username;
            if (_dbConnection.State == ConnectionState.Closed)
                _dbConnection.Open();
            var searchAccountCommand = new SQLiteCommand();
            searchAccountCommand.Connection = _dbConnection;
            searchAccountCommand.CommandText = $"SELECT * FROM Acc WHERE username = '{username}'";
            var result = searchAccountCommand.ExecuteReader();

            if (!result.Read() || result == null)
            {
                if (_dbConnection.State == ConnectionState.Open)
                    _dbConnection.Close();
                return false;
            }

            if (result.Read() == true)
            {
                var dbUsername = result["username"].ToString();
                var dbPasswordHashed = result["password"].ToString();
                var dbPasswordSalt = result["salt"].ToString();
                ControlUserType = result["type"].ToString();
                if (dbPasswordHashed != ComputeHash(password, dbPasswordSalt))
                {
                    if (_dbConnection.State == ConnectionState.Open)
                        _dbConnection.Close();
                    return false;
                }
                if (_dbConnection.State == ConnectionState.Open)
                    _dbConnection.Close();
                
                return true;
            }

            return false;
        }
        public static string ControlUserType { get; 
            set; }

        public static void InsertReservations(string date, string name, int nrPers, int nrTable)
        {
            if (_dbConnection.State == ConnectionState.Closed)
                _dbConnection.Open();
            var command = $"INSERT INTO Reservations VALUES('{CountRecordsForReservations()+1}','{date}','{name}','{nrPers}','{nrTable}')";
            ExecuteQuery(command);
            if (_dbConnection.State == ConnectionState.Open)
                _dbConnection.Close();
        }

    }
}
