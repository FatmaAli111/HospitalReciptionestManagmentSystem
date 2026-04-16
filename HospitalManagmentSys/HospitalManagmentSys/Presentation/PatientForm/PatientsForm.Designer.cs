namespace HospitalManagmentSys.Presentation
{
    partial class PatientsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            AddPatientBtn = new Guna.UI2.WinForms.Guna2Button();
            subLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            searchPanel = new Guna.UI2.WinForms.Guna2Panel();
            filterCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            tableHeaderPanel = new Guna.UI2.WinForms.Guna2Panel();
            headerPatient = new Label();
            headerContact = new Label();
            headerBlood = new Label();
            headerAppointments = new Label();
            headerStatus = new Label();
            contentPanel = new Guna.UI2.WinForms.Guna2Panel();
            headerPanel.SuspendLayout();
            searchPanel.SuspendLayout();
            tableHeaderPanel.SuspendLayout();
            SuspendLayout();

            headerPanel.Controls.Add(AddPatientBtn);
            headerPanel.Controls.Add(subLabel);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.FillColor = Color.White;
            headerPanel.Size = new Size(962, 70);

            AddPatientBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddPatientBtn.BorderRadius = 8;
            AddPatientBtn.FillColor = Color.FromArgb(37, 99, 235);
            AddPatientBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AddPatientBtn.ForeColor = Color.White;
            AddPatientBtn.Location = new Point(810, 15);
            AddPatientBtn.Size = new Size(130, 40);
            AddPatientBtn.Text = "+ New Patient";
            AddPatientBtn.Click += AddPatientBtn_Click;

            subLabel.Font = new Font("Segoe UI", 9F);
            subLabel.ForeColor = Color.FromArgb(107, 114, 128);
            subLabel.Location = new Point(20, 40);
            subLabel.Text = "Manage patient records and registration";

            titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(17, 24, 39);
            titleLabel.Location = new Point(20, 10);
            titleLabel.Text = "Patients";

            searchPanel.Controls.Add(filterCombo);
            searchPanel.Controls.Add(searchBox);
            searchPanel.Dock = DockStyle.Top;
            searchPanel.FillColor = Color.FromArgb(243, 244, 246);
            searchPanel.Padding = new Padding(20, 10, 20, 10);
            searchPanel.Size = new Size(962, 60);

            filterCombo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filterCombo.BorderRadius = 8;
            filterCombo.Font = new Font("Segoe UI", 10F);
            filterCombo.Items.AddRange(new object[] { "All Patients", "High Urgency", "Medium Urgency", "Low Urgency" });
            filterCombo.Location = new Point(740, 12);
            filterCombo.Size = new Size(200, 36);
            filterCombo.SelectedIndex = 0;
            filterCombo.SelectedIndexChanged += filterCombo_SelectedIndexChanged;

            searchBox.BorderRadius = 8;
            searchBox.Font = new Font("Segoe UI", 9F);
            searchBox.Location = new Point(20, 12);
            searchBox.PlaceholderText = "Search by name ...";
            searchBox.Size = new Size(300, 36);
            searchBox.TextChanged += searchBox_TextChanged;

            tableHeaderPanel.Dock = DockStyle.Top;
            tableHeaderPanel.FillColor = Color.White;
            tableHeaderPanel.Height = 45;

            headerPatient.AutoSize = false;
            headerPatient.Location = new Point(12, 0);
            headerPatient.Size = new Size(200, 45);
            headerPatient.Text = "PATIENT";
            headerPatient.TextAlign = ContentAlignment.MiddleLeft;
            headerPatient.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            headerPatient.ForeColor = Color.FromArgb(107, 114, 128);
            headerPatient.BackColor = Color.Transparent;

            headerContact.AutoSize = false;
            headerContact.Location = new Point(280, 0);
            headerContact.Size = new Size(200, 45);
            headerContact.Text = "CONTACT";
            headerContact.TextAlign = ContentAlignment.MiddleLeft;
            headerContact.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            headerContact.ForeColor = Color.FromArgb(107, 114, 128);
            headerContact.BackColor = Color.Transparent;

            headerBlood.AutoSize = false;
            headerBlood.Location = new Point(530, 0);
            headerBlood.Size = new Size(100, 45);
            headerBlood.Text = "BLOOD TYPE";
            headerBlood.TextAlign = ContentAlignment.MiddleLeft;
            headerBlood.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            headerBlood.ForeColor = Color.FromArgb(107, 114, 128);
            headerBlood.BackColor = Color.Transparent;

            headerAppointments.AutoSize = false;
            headerAppointments.Location = new Point(640, 0);
            headerAppointments.Size = new Size(110, 45);
            headerAppointments.Text = "APPOINTMENTS";
            headerAppointments.TextAlign = ContentAlignment.MiddleLeft;
            headerAppointments.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            headerAppointments.ForeColor = Color.FromArgb(107, 114, 128);
            headerAppointments.BackColor = Color.Transparent;

            headerStatus.AutoSize = false;
            headerStatus.Location = new Point(750, 0);
            headerStatus.Size = new Size(180, 45);
            headerStatus.Text = "NO-SHOW STATUS";
            headerStatus.TextAlign = ContentAlignment.MiddleLeft;
            headerStatus.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            headerStatus.ForeColor = Color.FromArgb(107, 114, 128);
            headerStatus.BackColor = Color.Transparent;

            tableHeaderPanel.Controls.Add(headerStatus);
            tableHeaderPanel.Controls.Add(headerAppointments);
            tableHeaderPanel.Controls.Add(headerBlood);
            tableHeaderPanel.Controls.Add(headerContact);
            tableHeaderPanel.Controls.Add(headerPatient);

            contentPanel.AutoScroll = true;
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.FillColor = Color.FromArgb(243, 244, 246);
            contentPanel.BackColor = Color.FromArgb(243, 244, 246);

            Controls.Add(contentPanel);
            Controls.Add(tableHeaderPanel);
            Controls.Add(searchPanel);
            Controls.Add(headerPanel);

            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(962, 525);
            headerPanel.ResumeLayout(false);
            searchPanel.ResumeLayout(false);
            tableHeaderPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Panel contentPanel;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel subLabel;
        private Guna.UI2.WinForms.Guna2Button AddPatientBtn;
        private Guna.UI2.WinForms.Guna2Panel searchPanel;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private Guna.UI2.WinForms.Guna2ComboBox filterCombo;
        private Guna.UI2.WinForms.Guna2Panel tableHeaderPanel;
        private Label headerPatient;
        private Label headerContact;
        private Label headerBlood;
        private Label headerAppointments;
        private Label headerStatus;
    }
}