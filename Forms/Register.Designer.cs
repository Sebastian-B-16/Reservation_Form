
namespace Licenta_V1.Forms
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelRegisterPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRegisterDone = new System.Windows.Forms.Button();
            this.LabelUser = new System.Windows.Forms.Label();
            this.LabelPass = new System.Windows.Forms.Label();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.PanelRegisterPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelRegisterPanel
            // 
            this.PanelRegisterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.PanelRegisterPanel.Controls.Add(this.panel1);
            this.PanelRegisterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRegisterPanel.Location = new System.Drawing.Point(0, 0);
            this.PanelRegisterPanel.Name = "PanelRegisterPanel";
            this.PanelRegisterPanel.Size = new System.Drawing.Size(552, 386);
            this.PanelRegisterPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnRegisterDone);
            this.panel1.Controls.Add(this.LabelUser);
            this.panel1.Controls.Add(this.LabelPass);
            this.panel1.Controls.Add(this.TbPassword);
            this.panel1.Controls.Add(this.TbUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 261);
            this.panel1.TabIndex = 5;
            // 
            // BtnRegisterDone
            // 
            this.BtnRegisterDone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegisterDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnRegisterDone.FlatAppearance.BorderSize = 0;
            this.BtnRegisterDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegisterDone.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BtnRegisterDone.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnRegisterDone.Location = new System.Drawing.Point(233, 209);
            this.BtnRegisterDone.Name = "BtnRegisterDone";
            this.BtnRegisterDone.Size = new System.Drawing.Size(129, 40);
            this.BtnRegisterDone.TabIndex = 4;
            this.BtnRegisterDone.Text = "Register";
            this.BtnRegisterDone.UseVisualStyleBackColor = false;
            this.BtnRegisterDone.Click += new System.EventHandler(this.BtnRegisterDone_Click);
            // 
            // LabelUser
            // 
            this.LabelUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelUser.AutoSize = true;
            this.LabelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelUser.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LabelUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelUser.Location = new System.Drawing.Point(158, 32);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(71, 23);
            this.LabelUser.TabIndex = 0;
            this.LabelUser.Text = "Username";
            // 
            // LabelPass
            // 
            this.LabelPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPass.AutoSize = true;
            this.LabelPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelPass.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LabelPass.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelPass.Location = new System.Drawing.Point(160, 89);
            this.LabelPass.Name = "LabelPass";
            this.LabelPass.Size = new System.Drawing.Size(69, 23);
            this.LabelPass.TabIndex = 3;
            this.LabelPass.Text = "Password";
            // 
            // TbPassword
            // 
            this.TbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbPassword.Location = new System.Drawing.Point(235, 89);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(129, 23);
            this.TbPassword.TabIndex = 2;
            // 
            // TbUsername
            // 
            this.TbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbUsername.Location = new System.Drawing.Point(233, 35);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(129, 23);
            this.TbUsername.TabIndex = 1;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 386);
            this.Controls.Add(this.PanelRegisterPanel);
            this.Name = "Register";
            this.Text = "Register";
            this.PanelRegisterPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelRegisterPanel;
        private System.Windows.Forms.Button BtnRegisterDone;
        private System.Windows.Forms.Label LabelPass;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Panel panel1;
    }
}