namespace HospitalManagmentSys.Presentation.Settings
{
    partial class SettingsUserControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            tabControl = new Guna.UI2.WinForms.Guna2TabControl();
            tabProfile = new TabPage();
            ucProfile = new ProfileTabControl();
            tabQueue = new TabPage();
            ucQueue = new QueueTabControl();
            tabSystem = new TabPage();
            pnlHeader.SuspendLayout();
            tabControl.SuspendLayout();
            tabProfile.SuspendLayout();
            tabQueue.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(24, 10, 24, 10);
            pnlHeader.Size = new Size(900, 80);
            pnlHeader.TabIndex = 1;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 130, 150);
            lblSubtitle.Location = new Point(25, 45);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(324, 19);
            lblSubtitle.TabIndex = 0;
            lblSubtitle.Text = "Manage your preferences and system configuration";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(24, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(106, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Settings";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabProfile);
            tabControl.Controls.Add(tabQueue);
            tabControl.Controls.Add(tabSystem);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 10F);
            tabControl.ItemSize = new Size(120, 40);
            tabControl.Location = new Point(0, 80);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(900, 500);
            tabControl.TabButtonHoverState.BorderColor = Color.Empty;
            tabControl.TabButtonHoverState.FillColor = Color.FromArgb(240, 245, 255);
            tabControl.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            tabControl.TabButtonHoverState.ForeColor = Color.FromArgb(37, 99, 235);
            tabControl.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            tabControl.TabButtonIdleState.BorderColor = Color.Empty;
            tabControl.TabButtonIdleState.FillColor = Color.Transparent;
            tabControl.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            tabControl.TabButtonIdleState.ForeColor = Color.FromArgb(120, 130, 150);
            tabControl.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            tabControl.TabButtonSelectedState.BorderColor = Color.Empty;
            tabControl.TabButtonSelectedState.FillColor = Color.FromArgb(230, 240, 255);
            tabControl.TabButtonSelectedState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tabControl.TabButtonSelectedState.ForeColor = Color.FromArgb(37, 99, 235);
            tabControl.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            tabControl.TabButtonSize = new Size(120, 40);
            tabControl.TabIndex = 0;
            tabControl.TabMenuBackColor = Color.FromArgb(248, 250, 252);
            tabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabProfile
            // 
            tabProfile.BackColor = Color.FromArgb(248, 250, 252);
            tabProfile.Controls.Add(ucProfile);
            tabProfile.Location = new Point(4, 44);
            tabProfile.Name = "tabProfile";
            tabProfile.Size = new Size(892, 452);
            tabProfile.TabIndex = 0;
            tabProfile.Text = "Profile";
            // 
            // ucProfile
            // 
            ucProfile.BackColor = Color.FromArgb(248, 249, 250);
            ucProfile.Dock = DockStyle.Fill;
            ucProfile.Location = new Point(0, 0);
            ucProfile.Name = "ucProfile";
            ucProfile.Size = new Size(892, 452);
            ucProfile.TabIndex = 0;
            // 
            // tabQueue
            // 
            tabQueue.BackColor = Color.FromArgb(248, 250, 252);
            tabQueue.Controls.Add(ucQueue);
            tabQueue.Location = new Point(4, 44);
            tabQueue.Name = "tabQueue";
            tabQueue.Size = new Size(892, 452);
            tabQueue.TabIndex = 1;
            tabQueue.Text = "Queue";
            // 
            // ucQueue
            // 
            ucQueue.BackColor = Color.FromArgb(248, 249, 250);
            ucQueue.Dock = DockStyle.Fill;
            ucQueue.Location = new Point(0, 0);
            ucQueue.Name = "ucQueue";
            ucQueue.Size = new Size(892, 452);
            ucQueue.TabIndex = 0;
            // 
            // tabSystem
            // 
            tabSystem.BackColor = Color.FromArgb(248, 250, 252);
            tabSystem.Location = new Point(4, 44);
            tabSystem.Name = "tabSystem";
            tabSystem.Size = new Size(892, 452);
            tabSystem.TabIndex = 2;
            tabSystem.Text = "System";
            // 
            // SettingsUserControl
            // 
            BackColor = Color.FromArgb(248, 250, 252);
            Controls.Add(tabControl);
            Controls.Add(pnlHeader);
            Name = "SettingsUserControl";
            Size = new Size(900, 580);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tabControl.ResumeLayout(false);
            tabProfile.ResumeLayout(false);
            tabQueue.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private Guna.UI2.WinForms.Guna2TabControl tabControl;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabQueue;
        private System.Windows.Forms.TabPage tabSystem;
        private ProfileTabControl ucProfile;
        private QueueTabControl ucQueue;

    }
}