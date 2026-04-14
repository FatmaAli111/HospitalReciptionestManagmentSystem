namespace HospitalManagmentSys.Presentation.Settings
{
    partial class ProfileTabControl
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

            // ── Controls ──────────────────────────────────────────────
            this.pnlCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSectionTitle = new System.Windows.Forms.Label();
            this.lblSectionSub = new System.Windows.Forms.Label();
            this.pnlDivider = new System.Windows.Forms.Panel();

            // Avatar circle
            this.pnlAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblAvatarInitials = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblDoctorEmail = new System.Windows.Forms.Label();
            this.btnBadge = new Guna.UI2.WinForms.Guna2Button();

            // Form fields
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();

            // Permissions
            this.lblPermissions = new System.Windows.Forms.Label();
            this.pnlPatients = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPatTitle = new System.Windows.Forms.Label();
            this.lblPatValue = new System.Windows.Forms.Label();
            this.pnlAppointments = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblAppValue = new System.Windows.Forms.Label();
            this.pnlReports = new Guna.UI2.WinForms.Guna2Panel();
            this.lblRepTitle = new System.Windows.Forms.Label();
            this.lblRepValue = new System.Windows.Forms.Label();

            // ── pnlCard ───────────────────────────────────────────────
            this.pnlCard.FillColor = System.Drawing.Color.White;
            this.pnlCard.BorderRadius = 12;
            this.pnlCard.BorderColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.pnlCard.BorderThickness = 1;
            this.pnlCard.Size = new System.Drawing.Size(820, 380);
            this.pnlCard.Location = new System.Drawing.Point(24, 20);

            // lblSectionTitle
            this.lblSectionTitle.AutoSize = true;
            this.lblSectionTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSectionTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblSectionTitle.Location = new System.Drawing.Point(20, 18);
            this.lblSectionTitle.Text = "👤  Profile Information";

            // lblSectionSub
            this.lblSectionSub.AutoSize = true;
            this.lblSectionSub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSectionSub.ForeColor = System.Drawing.Color.FromArgb(140, 140, 140);
            this.lblSectionSub.Location = new System.Drawing.Point(21, 40);
            this.lblSectionSub.Text = "Your account details and role permissions";

            // pnlDivider
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.pnlDivider.Size = new System.Drawing.Size(780, 1);
            this.pnlDivider.Location = new System.Drawing.Point(20, 62);

            // ── Avatar ────────────────────────────────────────────────
            this.pnlAvatar.Size = new System.Drawing.Size(54, 54);
            this.pnlAvatar.Location = new System.Drawing.Point(20, 80);
            this.pnlAvatar.FillColor = System.Drawing.Color.FromArgb(221, 232, 248);

            this.lblAvatarInitials.Text = "DMC";
            this.lblAvatarInitials.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAvatarInitials.ForeColor = System.Drawing.Color.FromArgb(26, 86, 196);
            this.lblAvatarInitials.Size = new System.Drawing.Size(54, 54);
            this.lblAvatarInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAvatarInitials.Location = new System.Drawing.Point(0, 0);
            this.pnlAvatar.Controls.Add(this.lblAvatarInitials);

            // lblDoctorName
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDoctorName.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblDoctorName.Location = new System.Drawing.Point(86, 82);
            this.lblDoctorName.Text = "Dr. Michael Chen";

            // lblDoctorEmail
            this.lblDoctorEmail.AutoSize = true;
            this.lblDoctorEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDoctorEmail.ForeColor = System.Drawing.Color.FromArgb(130, 130, 130);
            this.lblDoctorEmail.Location = new System.Drawing.Point(87, 103);
            this.lblDoctorEmail.Text = "mchen@hospital.com";

            // btnBadge (Doctor badge — non-clickable style)
            this.btnBadge.FillColor = System.Drawing.Color.FromArgb(26, 124, 62);
            this.btnBadge.ForeColor = System.Drawing.Color.White;
            this.btnBadge.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnBadge.BorderRadius = 4;
            this.btnBadge.Size = new System.Drawing.Size(62, 22);
            this.btnBadge.Location = new System.Drawing.Point(87, 122);
            this.btnBadge.Text = "Doctor";
            this.btnBadge.ShadowDecoration.Enabled = false;
            this.btnBadge.Cursor = System.Windows.Forms.Cursors.Default;

            // ── Form fields ───────────────────────────────────────────
            // Full Name
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblFullName.Location = new System.Drawing.Point(20, 158);
            this.lblFullName.Text = "Full Name";

            this.txtFullName.DefaultText = "";
            this.txtFullName.Text = "Dr. Michael Chen";
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullName.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.txtFullName.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.txtFullName.BorderRadius = 8;
            this.txtFullName.FillColor = System.Drawing.Color.White;
            this.txtFullName.Size = new System.Drawing.Size(370, 38);
            this.txtFullName.Location = new System.Drawing.Point(20, 178);

            // Email
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblEmail.Location = new System.Drawing.Point(410, 158);
            this.lblEmail.Text = "Email Address";

            this.txtEmail.DefaultText = "";
            this.txtEmail.Text = "mchen@hospital.com";
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.txtEmail.BorderRadius = 8;
            this.txtEmail.FillColor = System.Drawing.Color.White;
            this.txtEmail.Size = new System.Drawing.Size(370, 38);
            this.txtEmail.Location = new System.Drawing.Point(410, 178);

            // ── Permissions label ─────────────────────────────────────
            this.lblPermissions.AutoSize = true;
            this.lblPermissions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPermissions.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblPermissions.Location = new System.Drawing.Point(20, 234);
            this.lblPermissions.Text = "Role Permissions";

            // ── Permission cards ──────────────────────────────────────
            int cardY = 256, cardW = 248, cardH = 68;

            // Patients card
            this.pnlPatients.FillColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.pnlPatients.BorderColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.pnlPatients.BorderThickness = 1;
            this.pnlPatients.BorderRadius = 8;
            this.pnlPatients.Size = new System.Drawing.Size(cardW, cardH);
            this.pnlPatients.Location = new System.Drawing.Point(20, cardY);

            this.lblPatTitle.AutoSize = true;
            this.lblPatTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPatTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblPatTitle.Location = new System.Drawing.Point(12, 14);
            this.lblPatTitle.Text = "👥  Patients";
            this.lblPatValue.AutoSize = true;
            this.lblPatValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPatValue.ForeColor = System.Drawing.Color.FromArgb(130, 130, 130);
            this.lblPatValue.Location = new System.Drawing.Point(13, 36);
            this.lblPatValue.Text = "View & Edit";
            this.pnlPatients.Controls.Add(this.lblPatTitle);
            this.pnlPatients.Controls.Add(this.lblPatValue);

            // Appointments card
            this.pnlAppointments.FillColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.pnlAppointments.BorderColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.pnlAppointments.BorderThickness = 1;
            this.pnlAppointments.BorderRadius = 8;
            this.pnlAppointments.Size = new System.Drawing.Size(cardW, cardH);
            this.pnlAppointments.Location = new System.Drawing.Point(278, cardY);

            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblAppTitle.Location = new System.Drawing.Point(12, 14);
            this.lblAppTitle.Text = "🕐  Appointments";
            this.lblAppValue.AutoSize = true;
            this.lblAppValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAppValue.ForeColor = System.Drawing.Color.FromArgb(130, 130, 130);
            this.lblAppValue.Location = new System.Drawing.Point(13, 36);
            this.lblAppValue.Text = "View only";
            this.pnlAppointments.Controls.Add(this.lblAppTitle);
            this.pnlAppointments.Controls.Add(this.lblAppValue);

            // Reports card
            this.pnlReports.FillColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.pnlReports.BorderColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.pnlReports.BorderThickness = 1;
            this.pnlReports.BorderRadius = 8;
            this.pnlReports.Size = new System.Drawing.Size(cardW, cardH);
            this.pnlReports.Location = new System.Drawing.Point(536, cardY);

            this.lblRepTitle.AutoSize = true;
            this.lblRepTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblRepTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblRepTitle.Location = new System.Drawing.Point(12, 14);
            this.lblRepTitle.Text = "📄  Reports";
            this.lblRepValue.AutoSize = true;
            this.lblRepValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRepValue.ForeColor = System.Drawing.Color.FromArgb(130, 130, 130);
            this.lblRepValue.Location = new System.Drawing.Point(13, 36);
            this.lblRepValue.Text = "Limited";
            this.pnlReports.Controls.Add(this.lblRepTitle);
            this.pnlReports.Controls.Add(this.lblRepValue);

            // ── Add everything to pnlCard ─────────────────────────────
            this.pnlCard.Controls.Add(this.lblSectionTitle);
            this.pnlCard.Controls.Add(this.lblSectionSub);
            this.pnlCard.Controls.Add(this.pnlDivider);
            this.pnlCard.Controls.Add(this.pnlAvatar);
            this.pnlCard.Controls.Add(this.lblDoctorName);
            this.pnlCard.Controls.Add(this.lblDoctorEmail);
            this.pnlCard.Controls.Add(this.btnBadge);
            this.pnlCard.Controls.Add(this.lblFullName);
            this.pnlCard.Controls.Add(this.txtFullName);
            this.pnlCard.Controls.Add(this.lblEmail);
            this.pnlCard.Controls.Add(this.txtEmail);
            this.pnlCard.Controls.Add(this.lblPermissions);
            this.pnlCard.Controls.Add(this.pnlPatients);
            this.pnlCard.Controls.Add(this.pnlAppointments);
            this.pnlCard.Controls.Add(this.pnlReports);

            // ── ProfileTabControl ─────────────────────────────────────
            this.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.Size = new System.Drawing.Size(870, 440);
            this.Controls.Add(this.pnlCard);
        }

        #endregion

        // Fields
        private Guna.UI2.WinForms.Guna2Panel pnlCard;
        private System.Windows.Forms.Label lblSectionTitle;
        private System.Windows.Forms.Label lblSectionSub;
        private System.Windows.Forms.Panel pnlDivider;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pnlAvatar;
        private System.Windows.Forms.Label lblAvatarInitials;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Label lblDoctorEmail;
        private Guna.UI2.WinForms.Guna2Button btnBadge;
        private System.Windows.Forms.Label lblFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label lblPermissions;
        private Guna.UI2.WinForms.Guna2Panel pnlPatients;
        private System.Windows.Forms.Label lblPatTitle;
        private System.Windows.Forms.Label lblPatValue;
        private Guna.UI2.WinForms.Guna2Panel pnlAppointments;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblAppValue;
        private Guna.UI2.WinForms.Guna2Panel pnlReports;
        private System.Windows.Forms.Label lblRepTitle;
        private System.Windows.Forms.Label lblRepValue;
    }
}