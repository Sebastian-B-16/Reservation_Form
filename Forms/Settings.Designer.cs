
namespace Licenta_V1.Forms
{
    partial class Settings
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
            this.LblVer = new System.Windows.Forms.Label();
            this.CBNotifi = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblVer
            // 
            this.LblVer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblVer.AutoSize = true;
            this.LblVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblVer.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblVer.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblVer.Location = new System.Drawing.Point(12, 411);
            this.LblVer.Name = "LblVer";
            this.LblVer.Size = new System.Drawing.Size(173, 30);
            this.LblVer.TabIndex = 0;
            this.LblVer.Text = "Version : Alpha 1.0";
            // 
            // CBNotifi
            // 
            this.CBNotifi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBNotifi.AutoSize = true;
            this.CBNotifi.FlatAppearance.BorderSize = 0;
            this.CBNotifi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBNotifi.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.CBNotifi.ForeColor = System.Drawing.Color.Gainsboro;
            this.CBNotifi.Location = new System.Drawing.Point(282, 45);
            this.CBNotifi.Name = "CBNotifi";
            this.CBNotifi.Size = new System.Drawing.Size(215, 32);
            this.CBNotifi.TabIndex = 1;
            this.CBNotifi.Text = "Recieve Push Notifications";
            this.CBNotifi.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CBNotifi);
            this.panel1.Controls.Add(this.LblVer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblVer;
        private System.Windows.Forms.CheckBox CBNotifi;
        private System.Windows.Forms.Panel panel1;
    }
}