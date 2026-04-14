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
            this.components = new System.ComponentModel.Container();

            // ── Controls ─────────────────────────────
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();

            this.tabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.tabQueue = new System.Windows.Forms.TabPage();
            this.tabSystem = new System.Windows.Forms.TabPage();

            this.ucProfile = new ProfileTabControl();
            this.ucQueue = new QueueTabControl();

            // ── Header ─────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 80;
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(24, 10, 24, 10);

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTitle.Location = new System.Drawing.Point(24, 10);
            this.lblTitle.Text = "Settings";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(120, 130, 150);
            this.lblSubtitle.Location = new System.Drawing.Point(25, 45);
            this.lblSubtitle.Text = "Manage your preferences and system configuration";

            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);

            // ── TabControl (SOFT MODERN STYLE) ──────
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Top;
            this.tabControl.ItemSize = new System.Drawing.Size(120, 40);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;

            // 🎨 ألوان ناعمة
            this.tabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(248, 250, 252);

            this.tabControl.TabButtonIdleState.FillColor = System.Drawing.Color.Transparent;
            this.tabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(120, 130, 150);

            this.tabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(240, 245, 255);
            this.tabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);

            this.tabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(230, 240, 255);
            this.tabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);

            this.tabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            // ── Tabs ─────────────────────────────
            this.tabProfile.Text = "Profile";
            this.tabProfile.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);

            this.tabQueue.Text = "Queue";
            this.tabQueue.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);

            this.tabSystem.Text = "System";
            this.tabSystem.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);

            // ── Sub Controls ─────────────────────
            this.ucProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucQueue.Dock = System.Windows.Forms.DockStyle.Fill;

            this.tabProfile.Controls.Add(this.ucProfile);
            this.tabQueue.Controls.Add(this.ucQueue);

            // ── Add Tabs ─────────────────────────
            this.tabControl.Controls.Add(this.tabProfile);
            this.tabControl.Controls.Add(this.tabQueue);
            this.tabControl.Controls.Add(this.tabSystem);

            // ── UserControl ──────────────────────
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.Size = new System.Drawing.Size(900, 580);

            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlHeader);
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