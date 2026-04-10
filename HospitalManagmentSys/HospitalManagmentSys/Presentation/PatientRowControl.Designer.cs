using Guna.UI2.WinForms;

namespace HospitalManagmentSys.Presentation.UserControls
{
    partial class PatientRowControl
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
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            avatarLabel = new Guna2CircleButton();
            nameLabel = new Guna2HtmlLabel();
            ageLabel = new Guna2HtmlLabel();
            contactLabel = new Guna2HtmlLabel();
            bloodLabel = new Guna2Button();
            appointmentsLabel = new Guna2HtmlLabel();
            statusLabel = new Guna2Button();
            SuspendLayout();
            // 
            // avatarLabel
            // 
            avatarLabel.FillColor = Color.FromArgb(59, 130, 246);
            avatarLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            avatarLabel.ForeColor = Color.White;
            avatarLabel.Location = new Point(12, 10);
            avatarLabel.Name = "avatarLabel";
            avatarLabel.ShadowDecoration.CustomizableEdges = customizableEdges1;
            avatarLabel.Size = new Size(40, 40);
            avatarLabel.TabIndex = 0;
            avatarLabel.TabStop = false;
            // 
            // nameLabel
            // 
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            nameLabel.ForeColor = Color.FromArgb(17, 24, 39);
            nameLabel.Location = new Point(62, 8);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(3, 2);
            nameLabel.TabIndex = 1;
            nameLabel.Text = null;
            // 
            // ageLabel
            // 
            ageLabel.BackColor = Color.Transparent;
            ageLabel.Font = new Font("Segoe UI", 8.5F);
            ageLabel.ForeColor = Color.FromArgb(107, 114, 128);
            ageLabel.Location = new Point(63, 30);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(3, 2);
            ageLabel.TabIndex = 2;
            ageLabel.Text = null;
            // 
            // contactLabel
            // 
            contactLabel.BackColor = Color.Transparent;
            contactLabel.Font = new Font("Segoe UI", 8.5F);
            contactLabel.ForeColor = Color.FromArgb(107, 114, 128);
            contactLabel.Location = new Point(280, 10);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(3, 2);
            contactLabel.TabIndex = 3;
            contactLabel.Text = null;
            // 
            // bloodLabel
            // 
            bloodLabel.BorderColor = Color.FromArgb(239, 246, 255);
            bloodLabel.BorderRadius = 6;
            bloodLabel.CustomizableEdges = customizableEdges2;
            bloodLabel.FillColor = Color.FromArgb(239, 246, 255);
            bloodLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bloodLabel.ForeColor = Color.FromArgb(37, 99, 235);
            bloodLabel.Location = new Point(530, 18);
            bloodLabel.Name = "bloodLabel";
            bloodLabel.ShadowDecoration.CustomizableEdges = customizableEdges3;
            bloodLabel.Size = new Size(45, 24);
            bloodLabel.TabIndex = 4;
            bloodLabel.TabStop = false;
            // 
            // appointmentsLabel
            // 
            appointmentsLabel.BackColor = Color.Transparent;
            appointmentsLabel.Font = new Font("Segoe UI", 9F);
            appointmentsLabel.ForeColor = Color.FromArgb(107, 114, 128);
            appointmentsLabel.Location = new Point(640, 20);
            appointmentsLabel.Name = "appointmentsLabel";
            appointmentsLabel.Size = new Size(3, 2);
            appointmentsLabel.TabIndex = 5;
            appointmentsLabel.Text = null;
            // 
            // statusLabel
            // 
            statusLabel.BorderRadius = 12;
            statusLabel.CustomizableEdges = customizableEdges4;
            statusLabel.DefaultAutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            statusLabel.ForeColor = Color.White;
            statusLabel.Location = new Point(750, 18);
            statusLabel.Name = "statusLabel";
            statusLabel.ShadowDecoration.CustomizableEdges = customizableEdges5;
            statusLabel.Size = new Size(26, 10);
            statusLabel.TabIndex = 6;
            statusLabel.TabStop = false;
            // 
            // PatientRowControl
            // 
            BackColor = Color.White;
            Controls.Add(avatarLabel);
            Controls.Add(nameLabel);
            Controls.Add(ageLabel);
            Controls.Add(contactLabel);
            Controls.Add(bloodLabel);
            Controls.Add(appointmentsLabel);
            Controls.Add(statusLabel);
            Cursor = Cursors.Hand;
            Name = "PatientRowControl";
            Size = new Size(1052, 62);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna2CircleButton avatarLabel;
        private Guna2HtmlLabel nameLabel;
        private Guna2HtmlLabel ageLabel;
        private Guna2HtmlLabel contactLabel;
        private Guna2Button bloodLabel;
        private Guna2HtmlLabel appointmentsLabel;
        private Guna2Button statusLabel;
    }
}