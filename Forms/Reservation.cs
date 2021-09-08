using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Licenta_V1.Forms
{
    public partial class Reservation : Form
    {
        private Form activeForm;
        public Reservation()
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
                btnres1.BackColor = ThemeColor.SecondaryColor;
                btnres1.BackColor = ThemeColor.PrimaryColor;
                /*----------------------------------------------------*/
                btnres2.BackColor = ThemeColor.SecondaryColor;
                btnres2.BackColor = ThemeColor.PrimaryColor;
                /*----------------------------------------------------*/
                btnres3.BackColor = ThemeColor.SecondaryColor;
                btnres3.BackColor = ThemeColor.PrimaryColor;
                /*----------------------------------------------------*/
                btnres4.BackColor = ThemeColor.SecondaryColor;
                btnres4.BackColor = ThemeColor.PrimaryColor;
                /*----------------------------------------------------*/
                btnres5.BackColor = ThemeColor.SecondaryColor;
                btnres5.BackColor = ThemeColor.PrimaryColor;
                /*----------------------------------------------------*/
                btnres6.BackColor = ThemeColor.SecondaryColor;
                btnres6.BackColor = ThemeColor.PrimaryColor;
                /*----------------------------------------------------*/
                btnres7.BackColor = ThemeColor.SecondaryColor;
                btnres7.BackColor = ThemeColor.PrimaryColor;
                /*----------------------------------------------------*/
                btnres8.BackColor = ThemeColor.SecondaryColor;
                btnres8.BackColor = ThemeColor.PrimaryColor;
                /*----------------------------------------------------*/
                btnres9.BackColor = ThemeColor.SecondaryColor;
                btnres9.BackColor = ThemeColor.PrimaryColor;
                /*----------------------------------------------------*/


            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
           
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelresMain.Controls.Add(childForm);
            this.panelresMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

          

        }
        private void panelresMain_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void btnres1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ResForms.Res1(), sender);
        }

        private void btnres2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ResForms.Res1(), sender);
        }

        private void btnres3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ResForms.Res1(), sender);
        }

        private void btnres4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ResForms.Res1(), sender);
        }

        private void btnres5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ResForms.Res1(), sender);
        }

        private void btnres6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ResForms.Res1(), sender);
        }

        private void btnres7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ResForms.Res1(), sender);
        }

        private void btnres8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ResForms.Res1(), sender);
        }

        private void btnres9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ResForms.Res1(), sender);
        }
    }
}
