namespace SmartHospitalSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidebarControl1 = new HospitalManagmentSys.Presentation.Controls.Sidebar.SidebarControl();
            contentPanel = new Panel();
            contentHintLabel = new Label();
            pageTitleLabel = new Label();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarControl1
            // 
            sidebarControl1.BackColor = Color.FromArgb(2, 29, 58);
            sidebarControl1.Dock = DockStyle.Left;
            sidebarControl1.Font = new Font("Segoe UI", 9F);
            sidebarControl1.Location = new Point(0, 0);
            sidebarControl1.Margin = new Padding(3, 4, 3, 4);
            sidebarControl1.MinimumSize = new Size(320, 533);
            sidebarControl1.Name = "sidebarControl1";
            sidebarControl1.Size = new Size(320, 960);
            sidebarControl1.TabIndex = 0;
            sidebarControl1.UserName = "Admin User";
            sidebarControl1.UserRole = "Admin";
            sidebarControl1.Load += sidebarControl1_Load;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(246, 248, 252);
            contentPanel.Controls.Add(contentHintLabel);
            contentPanel.Controls.Add(pageTitleLabel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(320, 0);
            contentPanel.Margin = new Padding(3, 4, 3, 4);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(32, 37, 32, 37);
            contentPanel.Size = new Size(1051, 960);
            contentPanel.TabIndex = 1;
            // 
            // contentHintLabel
            // 
            contentHintLabel.AutoSize = true;
            contentHintLabel.Font = new Font("Segoe UI", 11F);
            contentHintLabel.ForeColor = Color.FromArgb(97, 113, 130);
            contentHintLabel.Location = new Point(35, 112);
            contentHintLabel.Name = "contentHintLabel";
            contentHintLabel.Size = new Size(444, 25);
            contentHintLabel.TabIndex = 1;
            contentHintLabel.Text = "Content area host. Replace with page/user controls.";
            // 
            // pageTitleLabel
            // 
            pageTitleLabel.AutoSize = true;
            pageTitleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            pageTitleLabel.ForeColor = Color.FromArgb(26, 38, 52);
            pageTitleLabel.Location = new Point(32, 37);
            pageTitleLabel.Name = "pageTitleLabel";
            pageTitleLabel.Size = new Size(229, 54);
            pageTitleLabel.TabIndex = 0;
            pageTitleLabel.Text = "Dashboard";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 960);
            Controls.Add(contentPanel);
            Controls.Add(sidebarControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MediCare Reception";
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private HospitalManagmentSys.Presentation.Controls.Sidebar.SidebarControl sidebarControl1;
        private Panel contentPanel;
        private Label pageTitleLabel;
        private Label contentHintLabel;
    }
}
