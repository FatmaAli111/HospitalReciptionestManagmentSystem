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

        // ── Controls ──────────────────────────────────────────────────────────
        private Guna2Panel pnlCard;
        private Guna2HtmlLabel lblTitle;
        private Guna2HtmlLabel lblSubtitle;
        private Guna2Button btnClose;
        private Guna2HtmlLabel lblPatient;
        private Guna2ComboBox cmbPatient;
        private Guna2HtmlLabel lblDoctor;
        private Guna2ComboBox cmbDoctor;
        private Guna2HtmlLabel lblDate;
        private Guna2HtmlLabel lblPriority;
        private Guna2DateTimePicker dtpDate;
        private Guna2Button btnMedium;
        private Guna2HtmlLabel lblStandard;
        private ComboBox cmbPriority;
        private Guna2HtmlLabel lblReason;
        private Guna2TextBox txtReason;
        private Guna2Button btnCancel;
        private Guna2Button btnBook;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlCard = new Guna2Panel();
            this.lblTitle = new Guna2HtmlLabel();
            this.lblSubtitle = new Guna2HtmlLabel();
            this.btnClose = new Guna2Button();
            this.lblPatient = new Guna2HtmlLabel();
            this.cmbPatient = new Guna2ComboBox();
            this.lblDoctor = new Guna2HtmlLabel();
            this.cmbDoctor = new Guna2ComboBox();
            this.lblDate = new Guna2HtmlLabel();
            this.lblPriority = new Guna2HtmlLabel();
            this.dtpDate = new Guna2DateTimePicker();
            this.btnMedium = new Guna2Button();
            this.lblStandard = new Guna2HtmlLabel();
            this.cmbPriority = new ComboBox();
            this.lblReason = new Guna2HtmlLabel();
            this.txtReason = new Guna2TextBox();
            this.btnCancel = new Guna2Button();
            this.btnBook = new Guna2Button();

            this.pnlCard.SuspendLayout();
            this.SuspendLayout();

            // ── pnlCard ───────────────────────────────────────────────────────
            this.pnlCard.BorderRadius = 18;
            this.pnlCard.FillColor = Color.White;
            this.pnlCard.Location = new Point(0, 0);
            this.pnlCard.Size = new Size(460, 480);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.ShadowDecoration.Enabled = true;
            this.pnlCard.ShadowDecoration.Color = Color.FromArgb(60, 0, 0, 0);
            this.pnlCard.ShadowDecoration.Depth = 20;
            this.pnlCard.Controls.AddRange(new Control[]
            {
                this.lblTitle, this.lblSubtitle, this.btnClose,
                this.lblPatient, this.cmbPatient,
                this.lblDoctor,  this.cmbDoctor,
                this.lblDate,    this.lblPriority,
                this.dtpDate,    this.cmbPriority,
                this.lblReason,  this.txtReason,
                this.btnCancel,  this.btnBook
            });

            // ── btnClose ──────────────────────────────────────────────────────
            this.btnClose.Text = "✕";
            this.btnClose.Location = new Point(382, 12);
            this.btnClose.Size = new Size(26, 26);
            this.btnClose.BorderRadius = 13;
            this.btnClose.FillColor = Color.Transparent;
            this.btnClose.ForeColor = Color.Gray;
            this.btnClose.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            this.btnClose.BorderColor = Color.Transparent;
            this.btnClose.Name = "btnClose";

            // ── lblTitle ──────────────────────────────────────────────────────
            this.lblTitle.Text = "<b>Book New Appointment</b>";
            this.lblTitle.Font = new Font("Segoe UI", 13f, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(25, 25, 25);
            this.lblTitle.Location = new Point(24, 18);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Name = "lblTitle";

            // ── lblSubtitle ───────────────────────────────────────────────────
            this.lblSubtitle.Text = "Schedule an appointment with conflict detection and slot suggestions";
            this.lblSubtitle.Font = new Font("Segoe UI", 8f);
            this.lblSubtitle.ForeColor = Color.Gray;
            this.lblSubtitle.Location = new Point(24, 46);
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Name = "lblSubtitle";

            // ── lblPatient ────────────────────────────────────────────────────
            this.lblPatient.Text = "<b>Patient *</b>";
            this.lblPatient.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            this.lblPatient.ForeColor = Color.FromArgb(40, 40, 40);
            this.lblPatient.Location = new Point(24, 75);
            this.lblPatient.AutoSize = true;
            this.lblPatient.Name = "lblPatient";

            // ── cmbPatient ────────────────────────────────────────────────────
            this.cmbPatient.Location = new Point(24, 93);
            this.cmbPatient.Size = new Size(412, 36);
            this.cmbPatient.BorderRadius = 8;
            this.cmbPatient.BorderColor = Color.FromArgb(200, 200, 200);
            this.cmbPatient.FillColor = Color.White;
            this.cmbPatient.ForeColor = Color.FromArgb(50, 50, 50);
            this.cmbPatient.Font = new Font("Segoe UI", 9.5f);
            this.cmbPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Items.AddRange(new object[]
                { "Ahmed Mohamed", "Sara Ali", "Omar Hassan", "Nour Ibrahim" });

            // ── lblDoctor ─────────────────────────────────────────────────────
            this.lblDoctor.Text = "<b>Doctor *</b>";
            this.lblDoctor.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            this.lblDoctor.ForeColor = Color.FromArgb(40, 40, 40);
            this.lblDoctor.Location = new Point(24, 140);
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Name = "lblDoctor";

            // ── cmbDoctor ─────────────────────────────────────────────────────
            this.cmbDoctor.Location = new Point(24, 158);
            this.cmbDoctor.Size = new Size(412, 36);
            this.cmbDoctor.BorderRadius = 8;
            this.cmbDoctor.BorderColor = Color.FromArgb(200, 200, 200);
            this.cmbDoctor.FillColor = Color.White;
            this.cmbDoctor.ForeColor = Color.FromArgb(50, 50, 50);
            this.cmbDoctor.Font = new Font("Segoe UI", 9.5f);
            this.cmbDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Items.AddRange(new object[]
                { "Dr. Robert Martinez", "Dr. Layla Hassan", "Dr. Youssef Kamal" });

            // ── lblDate + lblPriority ─────────────────────────────────────────
            this.lblDate.Text = "<b>Date *</b>";
            this.lblDate.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            this.lblDate.ForeColor = Color.FromArgb(40, 40, 40);
            this.lblDate.Location = new Point(24, 207);
            this.lblDate.AutoSize = true;
            this.lblDate.Name = "lblDate";

            this.lblPriority.Text = "<b>Priority *</b>";
            this.lblPriority.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            this.lblPriority.ForeColor = Color.FromArgb(40, 40, 40);
            this.lblPriority.Location = new Point(220, 207);
            this.lblPriority.AutoSize = true;
            this.lblPriority.Name = "lblPriority";

            // ── dtpDate ───────────────────────────────────────────────────────
            this.dtpDate.Format = DateTimePickerFormat.Short;
            this.dtpDate.Value = new System.DateTime(2026, 9, 4);
            this.dtpDate.Location = new Point(24, 225);
            this.dtpDate.Size = new Size(200, 36);
            this.dtpDate.BorderRadius = 8;
            this.dtpDate.BorderColor = Color.FromArgb(200, 200, 200);
            this.dtpDate.FillColor = Color.White;
            this.dtpDate.ForeColor = Color.FromArgb(50, 50, 50);
            this.dtpDate.Font = new Font("Segoe UI", 9.5f);
            this.dtpDate.Name = "dtpDate";

            // ── cmbPriority (owner-draw for colored badges) ───────────────────
            this.cmbPriority.DrawMode = DrawMode.OwnerDrawFixed;
            this.cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbPriority.Location = new Point(236, 225);
            this.cmbPriority.Size = new Size(200, 26);
            this.cmbPriority.Font = new Font("Segoe UI", 9.5f);
            this.cmbPriority.ItemHeight = 26;
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.FlatStyle = FlatStyle.Flat;
            
            // ── lblReason ─────────────────────────────────────────────────────
            this.lblReason.Text = "<b>Reason for Visit *</b>";
            this.lblReason.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            this.lblReason.ForeColor = Color.FromArgb(40, 40, 40);
            this.lblReason.Location = new Point(24, 274);
            this.lblReason.AutoSize = true;
            this.lblReason.Name = "lblReason";

            // ── txtReason ─────────────────────────────────────────────────────
            this.txtReason.PlaceholderText = "Describe the reason for this appointment...";
            this.txtReason.Multiline = true;
            this.txtReason.ScrollBars = ScrollBars.Vertical;
            this.txtReason.Location = new Point(24, 292);
            this.txtReason.Size = new Size(412, 80);
            this.txtReason.BorderRadius = 8;
            this.txtReason.BorderColor = Color.FromArgb(200, 200, 200);
            this.txtReason.FillColor = Color.White;
            this.txtReason.ForeColor = Color.FromArgb(50, 50, 50);
            this.txtReason.Font = new Font("Segoe UI", 9.5f);
            this.txtReason.Name = "txtReason";

            // ── btnCancel ─────────────────────────────────────────────────────
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new Point(24, 392);
            this.btnCancel.Size = new Size(120, 40);
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.FillColor = Color.White;
            this.btnCancel.ForeColor = Color.FromArgb(80, 80, 80);
            this.btnCancel.Font = new Font("Segoe UI", 9.5f);
            this.btnCancel.BorderColor = Color.FromArgb(200, 200, 200);
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.Name = "btnCancel";

            // ── btnBook ───────────────────────────────────────────────────────
            this.btnBook.Text = "Book Appointment";
            this.btnBook.Location = new Point(156, 392);
            this.btnBook.Size = new Size(200, 40);
            this.btnBook.BorderRadius = 20;
            this.btnBook.FillColor = Color.FromArgb(59, 130, 246);
            this.btnBook.ForeColor = Color.White;
            this.btnBook.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            this.btnBook.BorderColor = Color.Transparent;
            this.btnBook.Name = "btnBook";

            // ── Form ──────────────────────────────────────────────────────────
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(460, 480);
            this.Controls.Add(this.pnlCard);
            this.Font = new Font("Segoe UI", 9.5f);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BookAppointmentForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Book Appointment";

            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}