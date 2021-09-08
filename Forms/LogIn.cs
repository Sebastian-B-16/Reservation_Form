using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Licenta_V1.Forms
{
    
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            LoadTheme();
            btnRegister.BackColor = Color.DarkGray;
            btnLogIn.BackColor = Color.DarkGray;
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
                btnLogIn.BackColor = ThemeColor.SecondaryColor;
                btnLogIn.BackColor = ThemeColor.PrimaryColor;
                /*----------------------------------------------------*/
                btnRegister.BackColor = ThemeColor.PrimaryColor;
                btnRegister.BackColor = ThemeColor.SecondaryColor;
                /*----------------------------------------------------*/
                tbUser.BackColor= ThemeColor.PrimaryColor;
                tbUser.BackColor= ThemeColor.SecondaryColor;
                /*----------------------------------------------------*/
                tbPass.BackColor = ThemeColor.PrimaryColor;
                tbPass.BackColor = ThemeColor.SecondaryColor;
                /*----------------------------------------------------*/
              
            }
        }
        private void panelLogInPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }

    
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            DataBase.AccountIsCorrect(tbUser.Text, tbPass.Text);
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
              
        }
        
        private void btnShowPas_Click(object sender, EventArgs e)
        {
            if (tbPass.PasswordChar == '\0')
            {
                btnShowPass.BringToFront();
                tbPass.PasswordChar = '*';
            }
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            if (tbPass.PasswordChar == '*')
            {
                btnShowPass.BringToFront();
                tbPass.PasswordChar = '\0';
            }

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {   
            Forms.Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
