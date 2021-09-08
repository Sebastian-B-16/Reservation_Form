using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Licenta_V1.Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btn in this.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.Gainsboro;
                    (btn as Button).FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                BtnRegisterDone.BackColor = ThemeColor.SecondaryColor;
                BtnRegisterDone.BackColor = ThemeColor.PrimaryColor;
                /*----------------------------------------------------*/
                TbUsername.BackColor = ThemeColor.PrimaryColor;
                TbUsername.BackColor = ThemeColor.SecondaryColor;
                /*----------------------------------------------------*/
                TbPassword.BackColor = ThemeColor.PrimaryColor;
                TbPassword.BackColor = ThemeColor.SecondaryColor;
                /*----------------------------------------------------*/

            }
        }

        private void BtnRegisterDone_Click(object sender, EventArgs e)
        {
            DataBase._username = TbUsername.Text;
            DataBase.InsertAccount(TbUsername.Text, TbPassword.Text, "user"); //<--- Add another account to the database.
            MessageBox.Show("Registration complete! ");
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
