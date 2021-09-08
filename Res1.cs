using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Licenta_V1.ResForms
{
    public partial class Res1 : Form
    {
        int flag = -1;
        public Res1()
        {
           
            InitializeComponent();
            panelListForTable1.Hide();
            panelListForTable2.Hide();
            panelListForTable3.Hide();
            panelListForTable4.Hide();
            panelListForTable5.Hide();
            panelListForTable6.Hide();
            panelListForTable7.Hide();
            panelListForTable8.Hide();
            panelListForTable9.Hide();
            panelListForTable10.Hide();
            panelListForTable11.Hide();
            panelListForTable12.Hide();
            allReservations = DataBase.GetData();
            lblDataRez.Text = GetListOfRez(allReservations);
            LoadTheme();
        }

        private string GetListOfRez(string allReservations)
        {
            var strRez = "";
            var records = allReservations.Split("|");
            foreach(var record in records)
            {
                if (string.IsNullOrEmpty(record))
                    return strRez;
                var properties = record.Split("#");
                strRez += properties[0] + " " + properties[1] + " " + properties[2] + " " + properties[3] + " " + properties[4] + "\n";
            }
            return strRez;
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
                BtnResForTable1.BackColor = ThemeColor.SecondaryColor;
                BtnResForTable1.BackColor = ThemeColor.PrimaryColor;
                BtnResForTable2.BackColor = ThemeColor.SecondaryColor;
                BtnResForTable2.BackColor = ThemeColor.PrimaryColor;
                BtnResForTable3.BackColor = ThemeColor.SecondaryColor;
                BtnResForTable3.BackColor = ThemeColor.PrimaryColor;
                BtnResForTable4.BackColor = ThemeColor.SecondaryColor;
                BtnResForTable4.BackColor = ThemeColor.PrimaryColor;
                BtnResForTable5.BackColor = ThemeColor.SecondaryColor;
                BtnResForTable5.BackColor = ThemeColor.PrimaryColor;
                BtnResForTable6.BackColor = ThemeColor.SecondaryColor;
                BtnResForTable6.BackColor = ThemeColor.PrimaryColor;
                BtnResForTable7.BackColor = ThemeColor.SecondaryColor;
                BtnResForTable7.BackColor = ThemeColor.PrimaryColor;
                BtnResForTable8.BackColor = ThemeColor.SecondaryColor;
                BtnResForTable8.BackColor = ThemeColor.PrimaryColor;
                BtnResForTable9.BackColor = ThemeColor.SecondaryColor;
                BtnResForTable9.BackColor = ThemeColor.PrimaryColor;
                BtnResForTable10.BackColor = ThemeColor.SecondaryColor;
                BtnResForTable10.BackColor = ThemeColor.PrimaryColor;
                BtnResForTable11.BackColor = ThemeColor.SecondaryColor;
                BtnResForTable11.BackColor = ThemeColor.PrimaryColor;
                BtnResForTable12.BackColor = ThemeColor.SecondaryColor;
                BtnResForTable12.BackColor = ThemeColor.PrimaryColor;
                /*-----------------------------------------------------*/

            }
        }
        private void RezDataTable(RoundButtons control, DateTimePicker datepicker , TextBox tbname , TextBox nrp)
        {
            allReservations = DataBase.GetData();
            if (control.BackColor == Color.SlateGray)
            {
                control.BackColor = System.Drawing.Color.Red;
                var date = datepicker.Text;
                var name = tbname.Text;
                var nrPers = int.Parse(nrp.Text);

                if (!string.IsNullOrEmpty(date) && !string.IsNullOrEmpty(name) && nrPers != 0) //campurile nu sunt goale
                {
                    DataBase.InsertReservations(date, name, nrPers, int.Parse(control.Text.Split(" ")[1]));
                }
                // Res1 test = new Res1(); this.Hide(); test.Show();
            }
        }
     
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();     
        }

        private void rbTable1_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
                panelListForTable1.Hide();
            else
                panelListForTable1.Show();
        }

        private void rbTable2_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
                panelListForTable2.Hide();
            else
                panelListForTable2.Show();
        }

        private void rbTable3_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
                panelListForTable3.Hide();
            else
                panelListForTable3.Show();
        }

        private void rbTable4_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
                panelListForTable4.Hide();
            else
                panelListForTable4.Show();
        }

        private void rbTable5_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
                panelListForTable5.Hide();
            else
                panelListForTable5.Show();
        }

        private void rbTable6_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
                panelListForTable6.Hide();
            else
                panelListForTable6.Show();
        }

        private void rbTable7_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
                panelListForTable7.Hide();
            else
                panelListForTable7.Show();
        }

        private void rbTable8_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
                panelListForTable8.Hide();
            else
                panelListForTable8.Show();
        }
        private void rbTable9_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
                panelListForTable9.Hide();
            else
                panelListForTable9.Show();
        }

        private void rbTable10_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
                panelListForTable10.Hide();
            else
                panelListForTable10.Show();
        }

        private void rbTable11_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
                panelListForTable11.Hide();
            else
                panelListForTable11.Show();
        }

        private void rbTable12_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
                panelListForTable12.Hide();
            else
                panelListForTable12.Show();
        }

        private void panelListForTable1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void panelListForTable2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelListForTable3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelListForTable4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BtnResForTable1_Click(object sender, EventArgs e)
        {
            RezDataTable(rbTable1, dateTimePicker1, tbName1, tbNrPersTable1);

        }

        private string allReservations;
        private void BtnResForTable2_Click(object sender, EventArgs e)
        {
            RezDataTable(rbTable2, dateTimePicker2, tbName2, textBox1);
        }

        private void BtnResForTable3_Click(object sender, EventArgs e)
        {
            RezDataTable(rbTable3, dateTimePicker3, tbName3, textBox3);
        }

        private void BtnResForTable4_Click(object sender, EventArgs e)
        {
            RezDataTable(rbTable4, dateTimePicker4, tbName4, textBox4);
        }

        private void btnResForTable5_Click(object sender, EventArgs e)
        {
            RezDataTable(rbTable5, dateTimePicker5, tbName5, textBox9);
        }

        private void btnResForTable6_Click(object sender, EventArgs e)
        {
            RezDataTable(rbTable6, dateTimePicker6, tbName6, textBox8);
        }

        private void btnResForTable7_Click(object sender, EventArgs e)
        {
            RezDataTable(rbTable7, dateTimePicker7, tbName7, textBox7);
        }

        private void btnResForTable8_Click(object sender, EventArgs e)
        {
            RezDataTable(rbTable8, dateTimePicker8, tbName8, textBox6);
        }

        private void BtnResForTable9_Click(object sender, EventArgs e)
        {
            RezDataTable(rbTable9, dateTimePicker9, tbName9, textBox14);
        }

        private void BtnResForTable10_Click(object sender, EventArgs e)
        {
            RezDataTable(rbTable10, dateTimePicker10, tbName10, textBox13);
        }

        private void BtnResForTable11_Click(object sender, EventArgs e)
        {
            RezDataTable(rbTable11, dateTimePicker11, tbName11, textBox12);
        }

        private void BtnResForTable12_Click(object sender, EventArgs e)
        {
            RezDataTable(rbTable12, dateTimePicker12, tbName12, textBox11);
        }

     
    }
}
