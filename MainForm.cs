using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licenta_V1
{
    public partial class MainForm : Form
    {
        //Fields
        private Button CurrentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public MainForm()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            //--------------------------------------//
            this.Text = String.Empty; //remove the form boarder
            this.ControlBox = false;  // 
            //-------------------------------------//
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            LabelLogInMode.Text = DataBase.ControlUserType ?? (DataBase._username.Contains("admin") ? "admin" : "user");
            if (LabelLogInMode.Text.Contains("admin"))
                btnLogIn.Show();
            else
               btnLogIn.Hide();
        }
        //..Using System.Runtime.InteropServices;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color SelectThemeColor()
        {                //Will select a random color from class "ThemeColor"
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        //We hightlight the button that has been clicked(Active form)
        // 1: We select a random color for the theme
        // 2: We change the background color of the button
        // 3: We change the font color of the button
        // 4: We change the font size of the button 
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (CurrentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    CurrentButton = (Button)btnSender;
                    CurrentButton.BackColor = color;
                    CurrentButton.ForeColor = Color.White;
                    CurrentButton.Font = new System.Drawing.Font("Segoe UI", 12.5F, 
                        System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    panelTopBar.BackColor = color;
                    panelLogoBar.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3); //the value must be in decimals
                    //we  save the current theme color
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelNavBar.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 12.5F, 
                        System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }
        //method to open the forms in container panel
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender); //We highlight the button (activate)
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelHome.Text = childForm.Text;
        }
        private void panelLogoBar_Paint(object sender, PaintEventArgs e)
        {
            labelLogo.ForeColor = Color.Gainsboro;
        }
        private void buttonBookRes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.Reservation(), sender);
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //Forms.LogIn sucLog = new Forms.LogIn();
            ActivateButton(sender);
            OpenChildForm(new ResForms.Res1(), sender);
        }
        private void BtnAbout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.About(), sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.Settings(), sender);
        }
        private void Reset()
        {
            DisableButton();
            labelHome.Text = "HOME";
            panelTopBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogoBar.BackColor = Color.FromArgb(39, 39, 57);
            CurrentButton = null;
            btnCloseChildForm.Visible = false;
        }
        private void btnCloseChildForm_Click_1(object sender, EventArgs e) // Close Form Function 
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void btnClose_Click(object sender, EventArgs e) // Close Application Function
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e) // Maximize Function 
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e) // Minimize Function 
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panelTopBar_MouseDown(object sender, MouseEventArgs e) // Drag function
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LabelLogInMode_Click(object sender, EventArgs e)
        {
           
        }
       
       

     
    }
}
