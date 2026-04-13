using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
namespace HospitalManagmentSys.Presentation
{
    partial class BookAppointmentForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private Guna2Panel pnlCard;
        private Guna2HtmlLabel lblTitle;
        private Guna2HtmlLabel lblSubtitle;
        private Guna2Button btnClose;
        private Guna2HtmlLabel lblPatient;
        private Guna2ComboBox cmbPatient;
        private Guna2HtmlLabel lblDoctor;
        private Guna2ComboBox cmbDoctor;
        private Guna2HtmlLabel lblDate;
        private Guna2HtmlLabel lblTime;
        private Guna2HtmlLabel lblPriority;
        private Guna2DateTimePicker dtpDate;
        private Guna2DateTimePicker dtpTime;
        private Guna2Button btnMedium;
        private Guna2HtmlLabel lblStandard;
        private ComboBox cmbPriority;
        private Guna2HtmlLabel lblReason;
        private Guna2TextBox txtReason;
        private Guna2Button btnCancel;
        private Guna2Button btnBook;
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlCard = new Guna2Panel();
            lblTitle = new Guna2HtmlLabel();
            lblSubtitle = new Guna2HtmlLabel();
            btnClose = new Guna2Button();
            lblPatient = new Guna2HtmlLabel();
            cmbPatient = new Guna2ComboBox();
            lblDoctor = new Guna2HtmlLabel();
            cmbDoctor = new Guna2ComboBox();
            lblDate = new Guna2HtmlLabel();
            lblPriority = new Guna2HtmlLabel();
            dtpDate = new Guna2DateTimePicker();
            cmbPriority = new ComboBox();
            lblTime = new Guna2HtmlLabel();
            dtpTime = new Guna2DateTimePicker();
            lblReason = new Guna2HtmlLabel();
            txtReason = new Guna2TextBox();
            btnCancel = new Guna2Button();
            btnBook = new Guna2Button();
            btnMedium = new Guna2Button();
            lblStandard = new Guna2HtmlLabel();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.Transparent;
            pnlCard.BorderRadius = 18;
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Controls.Add(lblSubtitle);
            pnlCard.Controls.Add(btnClose);
            pnlCard.Controls.Add(lblPatient);
            pnlCard.Controls.Add(cmbPatient);
            pnlCard.Controls.Add(lblDoctor);
            pnlCard.Controls.Add(cmbDoctor);
            pnlCard.Controls.Add(lblDate);
            pnlCard.Controls.Add(lblPriority);
            pnlCard.Controls.Add(dtpDate);
            pnlCard.Controls.Add(cmbPriority);
            pnlCard.Controls.Add(lblTime);
            pnlCard.Controls.Add(dtpTime);
            pnlCard.Controls.Add(lblReason);
            pnlCard.Controls.Add(txtReason);
            pnlCard.Controls.Add(btnCancel);
            pnlCard.Controls.Add(btnBook);
            pnlCard.CustomizableEdges = customizableEdges17;
            pnlCard.FillColor = Color.White;
            pnlCard.Location = new Point(0, 0);
            pnlCard.Name = "pnlCard";
            pnlCard.ShadowDecoration.Color = Color.FromArgb(60, 0, 0, 0);
            pnlCard.ShadowDecoration.CustomizableEdges = customizableEdges18;
            pnlCard.ShadowDecoration.Depth = 20;
            pnlCard.ShadowDecoration.Enabled = true;
            pnlCard.Size = new Size(460, 560);
            pnlCard.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(25, 25, 25);
            lblTitle.Location = new Point(24, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(198, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "<b>Book New Appointment</b>";
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 8F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(24, 46);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(366, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Schedule an appointment with conflict detection and slot suggestions";
            // 
            // btnClose
            // 
            btnClose.BorderColor = Color.Transparent;
            btnClose.BorderRadius = 13;
            btnClose.CustomizableEdges = customizableEdges1;
            btnClose.FillColor = Color.Transparent;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.Gray;
            btnClose.Location = new Point(420, 12);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(26, 26);
            btnClose.TabIndex = 2;
            btnClose.Text = "✕";
            // 
            // lblPatient
            // 
            lblPatient.BackColor = Color.Transparent;
            lblPatient.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPatient.ForeColor = Color.FromArgb(40, 40, 40);
            lblPatient.Location = new Point(24, 75);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(51, 17);
            lblPatient.TabIndex = 3;
            lblPatient.Text = "<b>Patient *</b>";
            // 
            // cmbPatient
            // 
            cmbPatient.AllowDrop = true;
            cmbPatient.BackColor = Color.Transparent;
            cmbPatient.BorderColor = Color.FromArgb(200, 200, 200);
            cmbPatient.BorderRadius = 8;
            cmbPatient.CustomizableEdges = customizableEdges3;
            cmbPatient.DrawMode = DrawMode.OwnerDrawFixed;
            cmbPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatient.FocusedColor = Color.Empty;
            cmbPatient.Font = new Font("Segoe UI", 9.5F);
            cmbPatient.ForeColor = Color.FromArgb(50, 50, 50);
            cmbPatient.ItemHeight = 30;
            cmbPatient.Location = new Point(24, 93);
            cmbPatient.Name = "cmbPatient";
            cmbPatient.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cmbPatient.Size = new Size(412, 36);
            cmbPatient.TabIndex = 4;
            cmbPatient.SelectedIndexChanged += cmbPatient_SelectedIndexChanged;
            // 
            // lblDoctor
            // 
            lblDoctor.BackColor = Color.Transparent;
            lblDoctor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDoctor.ForeColor = Color.FromArgb(40, 40, 40);
            lblDoctor.Location = new Point(24, 140);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(50, 17);
            lblDoctor.TabIndex = 5;
            lblDoctor.Text = "<b>Doctor *</b>";
            // 
            // cmbDoctor
            // 
            cmbDoctor.BackColor = Color.Transparent;
            cmbDoctor.BorderColor = Color.FromArgb(200, 200, 200);
            cmbDoctor.BorderRadius = 8;
            cmbDoctor.CustomizableEdges = customizableEdges5;
            cmbDoctor.DrawMode = DrawMode.OwnerDrawFixed;
            cmbDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoctor.FocusedColor = Color.Empty;
            cmbDoctor.Font = new Font("Segoe UI", 9.5F);
            cmbDoctor.ForeColor = Color.FromArgb(50, 50, 50);
            cmbDoctor.ItemHeight = 30;
            cmbDoctor.Location = new Point(24, 158);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cmbDoctor.Size = new Size(412, 36);
            cmbDoctor.TabIndex = 6;
            // 
            // lblDate
            // 
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDate.ForeColor = Color.FromArgb(40, 40, 40);
            lblDate.Location = new Point(24, 207);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(38, 17);
            lblDate.TabIndex = 7;
            lblDate.Text = "<b>Date *</b>";
            // 
            // lblPriority
            // 
            lblPriority.BackColor = Color.Transparent;
            lblPriority.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPriority.ForeColor = Color.FromArgb(40, 40, 40);
            lblPriority.Location = new Point(220, 207);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(52, 17);
            lblPriority.TabIndex = 8;
            lblPriority.Text = "<b>Priority *</b>";
            // 
            // dtpDate
            // 
            dtpDate.BorderColor = Color.FromArgb(200, 200, 200);
            dtpDate.BorderRadius = 8;
            dtpDate.Checked = true;
            dtpDate.CustomFormat = "dd/MM/yyyy";
            dtpDate.CustomizableEdges = customizableEdges7;
            dtpDate.FillColor = Color.White;
            dtpDate.Font = new Font("Segoe UI", 9.5F);
            dtpDate.ForeColor = Color.FromArgb(50, 50, 50);
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(24, 225);
            dtpDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpDate.MinDate = new DateTime(2026, 4, 13, 0, 0, 0, 0);
            dtpDate.Name = "dtpDate";
            dtpDate.ShadowDecoration.CustomizableEdges = customizableEdges8;
            dtpDate.Size = new Size(190, 36);
            dtpDate.TabIndex = 9;
            dtpDate.Value = new DateTime(2026, 4, 13, 0, 0, 0, 0);
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.FlatStyle = FlatStyle.Flat;
            cmbPriority.Font = new Font("Segoe UI", 9.5F);
            cmbPriority.ItemHeight = 17;
            cmbPriority.Location = new Point(226, 225);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(210, 25);
            cmbPriority.TabIndex = 10;
            // 
            // lblTime
            // 
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTime.ForeColor = Color.FromArgb(40, 40, 40);
            lblTime.Location = new Point(24, 272);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(39, 17);
            lblTime.TabIndex = 15;
            lblTime.Text = "<b>Time *</b>";
            // 
            // dtpTime
            // 
            dtpTime.BorderColor = Color.FromArgb(200, 200, 200);
            dtpTime.BorderRadius = 8;
            dtpTime.Checked = true;
            dtpTime.CustomFormat = "hh:mm tt";
            dtpTime.CustomizableEdges = customizableEdges9;
            dtpTime.FillColor = Color.White;
            dtpTime.Font = new Font("Segoe UI", 9.5F);
            dtpTime.ForeColor = Color.FromArgb(50, 50, 50);
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.Location = new Point(24, 290);
            dtpTime.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpTime.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpTime.Name = "dtpTime";
            dtpTime.ShadowDecoration.CustomizableEdges = customizableEdges10;
            dtpTime.ShowUpDown = true;
            dtpTime.Size = new Size(412, 36);
            dtpTime.TabIndex = 16;
            dtpTime.Value = new DateTime(2026, 4, 13, 9, 0, 0, 0);
            // 
            // lblReason
            // 
            lblReason.BackColor = Color.Transparent;
            lblReason.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblReason.ForeColor = Color.FromArgb(40, 40, 40);
            lblReason.Location = new Point(24, 338);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(98, 17);
            lblReason.TabIndex = 11;
            lblReason.Text = "<b>Reason for Visit *</b>";
            // 
            // txtReason
            // 
            txtReason.BorderColor = Color.FromArgb(200, 200, 200);
            txtReason.BorderRadius = 8;
            txtReason.CustomizableEdges = customizableEdges11;
            txtReason.DefaultText = "";
            txtReason.Font = new Font("Segoe UI", 9.5F);
            txtReason.ForeColor = Color.FromArgb(50, 50, 50);
            txtReason.Location = new Point(24, 356);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.PlaceholderText = "Describe the reason for this appointment...";
            txtReason.ScrollBars = ScrollBars.Vertical;
            txtReason.SelectedText = "";
            txtReason.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtReason.Size = new Size(412, 80);
            txtReason.TabIndex = 12;
            // 
            // btnCancel
            // 
            btnCancel.BorderColor = Color.FromArgb(200, 200, 200);
            btnCancel.BorderRadius = 20;
            btnCancel.BorderThickness = 1;
            btnCancel.CustomizableEdges = customizableEdges13;
            btnCancel.FillColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 9.5F);
            btnCancel.ForeColor = Color.FromArgb(80, 80, 80);
            btnCancel.Location = new Point(24, 455);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnBook
            // 
            btnBook.BorderColor = Color.Transparent;
            btnBook.BorderRadius = 20;
            btnBook.CustomizableEdges = customizableEdges15;
            btnBook.FillColor = Color.FromArgb(59, 130, 246);
            btnBook.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(156, 455);
            btnBook.Name = "btnBook";
            btnBook.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnBook.Size = new Size(200, 40);
            btnBook.TabIndex = 14;
            btnBook.Text = "Book Appointment";
            btnBook.Click += btnBook_Click;
            // 
            // btnMedium
            // 
            btnMedium.CustomizableEdges = customizableEdges19;
            btnMedium.Font = new Font("Segoe UI", 9F);
            btnMedium.ForeColor = Color.White;
            btnMedium.Location = new Point(0, 0);
            btnMedium.Name = "btnMedium";
            btnMedium.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnMedium.Size = new Size(180, 45);
            btnMedium.TabIndex = 0;
            // 
            // lblStandard
            // 
            lblStandard.BackColor = Color.Transparent;
            lblStandard.Location = new Point(0, 0);
            lblStandard.Name = "lblStandard";
            lblStandard.Size = new Size(3, 2);
            lblStandard.TabIndex = 0;
            lblStandard.Text = null;
            // 
            // BookAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(460, 560);
            Controls.Add(pnlCard);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BookAppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Appointment";
            Load += BookAppointmentForm_Load;
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }
    }
}