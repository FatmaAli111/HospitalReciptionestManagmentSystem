using Guna.UI2.WinForms;

namespace HospitalManagmentSys.Presentation.ProfilePatient
{
    partial class PatientDetailsForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            nameLabel = new Guna2HtmlLabel();
            metaLabel = new Guna2HtmlLabel();
            cardsPanel = new Guna2Panel();
            ageCard = new Guna2Panel();
            ageTitleLabel = new Guna2HtmlLabel();
            ageValueLabel = new Guna2HtmlLabel();
            dobLabel = new Guna2HtmlLabel();
            bloodCard = new Guna2Panel();
            bloodTitleLabel = new Guna2HtmlLabel();
            bloodValueLabel = new Guna2HtmlLabel();
            appointmentsCard = new Guna2Panel();
            appointmentsTitleLabel = new Guna2HtmlLabel();
            appointmentsValueLabel = new Guna2HtmlLabel();
            noShowLabel = new Guna2HtmlLabel();
            contactPanel = new Guna2Panel();
            contactTitleLabel = new Guna2HtmlLabel();
            phoneLabel = new Guna2HtmlLabel();
            emailLabel = new Guna2HtmlLabel();
            footerPanel = new Guna2Panel();
            closeBtn = new Guna2Button();
            bookBtn = new Guna2Button();
            avatarLabel = new Guna2CircleButton();
            headerPanel = new Guna2Panel();
            cardsPanel.SuspendLayout();
            ageCard.SuspendLayout();
            bloodCard.SuspendLayout();
            appointmentsCard.SuspendLayout();
            contactPanel.SuspendLayout();
            footerPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            nameLabel.ForeColor = Color.FromArgb(17, 24, 39);
            nameLabel.Location = new Point(92, 18);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(149, 33);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Patient Name";
            // 
            // metaLabel
            // 
            metaLabel.BackColor = Color.Transparent;
            metaLabel.Font = new Font("Segoe UI", 9F);
            metaLabel.ForeColor = Color.FromArgb(107, 114, 128);
            metaLabel.Location = new Point(93, 52);
            metaLabel.Name = "metaLabel";
            metaLabel.Size = new Size(179, 22);
            metaLabel.TabIndex = 2;
            metaLabel.Text = "Patient ID: -  •  Registered: -";
            // 
            // cardsPanel
            // 
            cardsPanel.Controls.Add(ageCard);
            cardsPanel.Controls.Add(bloodCard);
            cardsPanel.Controls.Add(appointmentsCard);
            cardsPanel.CustomizableEdges = customizableEdges7;
            cardsPanel.Dock = DockStyle.Top;
            cardsPanel.FillColor = Color.FromArgb(243, 244, 246);
            cardsPanel.Location = new Point(0, 90);
            cardsPanel.Name = "cardsPanel";
            cardsPanel.Padding = new Padding(24, 16, 24, 16);
            cardsPanel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cardsPanel.Size = new Size(565, 142);
            cardsPanel.TabIndex = 1;
            // 
            // ageCard
            // 
            ageCard.BorderColor = Color.FromArgb(229, 231, 235);
            ageCard.BorderRadius = 12;
            ageCard.BorderThickness = 1;
            ageCard.Controls.Add(ageTitleLabel);
            ageCard.Controls.Add(ageValueLabel);
            ageCard.Controls.Add(dobLabel);
            ageCard.CustomizableEdges = customizableEdges1;
            ageCard.FillColor = Color.White;
            ageCard.Location = new Point(24, 16);
            ageCard.Name = "ageCard";
            ageCard.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ageCard.Size = new Size(162, 110);
            ageCard.TabIndex = 0;
            // 
            // ageTitleLabel
            // 
            ageTitleLabel.BackColor = Color.Transparent;
            ageTitleLabel.Font = new Font("Segoe UI", 9F);
            ageTitleLabel.ForeColor = Color.FromArgb(107, 114, 128);
            ageTitleLabel.Location = new Point(12, 12);
            ageTitleLabel.Name = "ageTitleLabel";
            ageTitleLabel.Size = new Size(30, 22);
            ageTitleLabel.TabIndex = 0;
            ageTitleLabel.Text = "Age";
            // 
            // ageValueLabel
            // 
            ageValueLabel.BackColor = Color.Transparent;
            ageValueLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            ageValueLabel.ForeColor = Color.FromArgb(17, 24, 39);
            ageValueLabel.Location = new Point(12, 34);
            ageValueLabel.Name = "ageValueLabel";
            ageValueLabel.Size = new Size(18, 52);
            ageValueLabel.TabIndex = 1;
            ageValueLabel.Text = "-";
            // 
            // dobLabel
            // 
            dobLabel.BackColor = Color.Transparent;
            dobLabel.Font = new Font("Segoe UI", 8.5F);
            dobLabel.ForeColor = Color.FromArgb(107, 114, 128);
            dobLabel.Location = new Point(12, 82);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(9, 21);
            dobLabel.TabIndex = 2;
            dobLabel.Text = "-";
            // 
            // bloodCard
            // 
            bloodCard.BorderColor = Color.FromArgb(229, 231, 235);
            bloodCard.BorderRadius = 12;
            bloodCard.BorderThickness = 1;
            bloodCard.Controls.Add(bloodTitleLabel);
            bloodCard.Controls.Add(bloodValueLabel);
            bloodCard.CustomizableEdges = customizableEdges3;
            bloodCard.FillColor = Color.White;
            bloodCard.Location = new Point(202, 16);
            bloodCard.Name = "bloodCard";
            bloodCard.ShadowDecoration.CustomizableEdges = customizableEdges4;
            bloodCard.Size = new Size(162, 110);
            bloodCard.TabIndex = 1;
            // 
            // bloodTitleLabel
            // 
            bloodTitleLabel.BackColor = Color.Transparent;
            bloodTitleLabel.Font = new Font("Segoe UI", 9F);
            bloodTitleLabel.ForeColor = Color.FromArgb(107, 114, 128);
            bloodTitleLabel.Location = new Point(12, 12);
            bloodTitleLabel.Name = "bloodTitleLabel";
            bloodTitleLabel.Size = new Size(79, 22);
            bloodTitleLabel.TabIndex = 0;
            bloodTitleLabel.Text = "Blood Type";
            // 
            // bloodValueLabel
            // 
            bloodValueLabel.BackColor = Color.Transparent;
            bloodValueLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bloodValueLabel.ForeColor = Color.FromArgb(17, 24, 39);
            bloodValueLabel.Location = new Point(12, 34);
            bloodValueLabel.Name = "bloodValueLabel";
            bloodValueLabel.Size = new Size(12, 33);
            bloodValueLabel.TabIndex = 1;
            bloodValueLabel.Text = "-";
            // 
            // appointmentsCard
            // 
            appointmentsCard.BorderColor = Color.FromArgb(229, 231, 235);
            appointmentsCard.BorderRadius = 12;
            appointmentsCard.BorderThickness = 1;
            appointmentsCard.Controls.Add(appointmentsTitleLabel);
            appointmentsCard.Controls.Add(appointmentsValueLabel);
            appointmentsCard.Controls.Add(noShowLabel);
            appointmentsCard.CustomizableEdges = customizableEdges5;
            appointmentsCard.FillColor = Color.White;
            appointmentsCard.Location = new Point(380, 16);
            appointmentsCard.Name = "appointmentsCard";
            appointmentsCard.ShadowDecoration.CustomizableEdges = customizableEdges6;
            appointmentsCard.Size = new Size(162, 110);
            appointmentsCard.TabIndex = 2;
            // 
            // appointmentsTitleLabel
            // 
            appointmentsTitleLabel.BackColor = Color.Transparent;
            appointmentsTitleLabel.Font = new Font("Segoe UI", 9F);
            appointmentsTitleLabel.ForeColor = Color.FromArgb(107, 114, 128);
            appointmentsTitleLabel.Location = new Point(12, 12);
            appointmentsTitleLabel.Name = "appointmentsTitleLabel";
            appointmentsTitleLabel.Size = new Size(97, 22);
            appointmentsTitleLabel.TabIndex = 0;
            appointmentsTitleLabel.Text = "Appointments";
            // 
            // appointmentsValueLabel
            // 
            appointmentsValueLabel.BackColor = Color.Transparent;
            appointmentsValueLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            appointmentsValueLabel.ForeColor = Color.FromArgb(17, 24, 39);
            appointmentsValueLabel.Location = new Point(12, 34);
            appointmentsValueLabel.Name = "appointmentsValueLabel";
            appointmentsValueLabel.Size = new Size(18, 52);
            appointmentsValueLabel.TabIndex = 1;
            appointmentsValueLabel.Text = "-";
            // 
            // noShowLabel
            // 
            noShowLabel.BackColor = Color.Transparent;
            noShowLabel.Font = new Font("Segoe UI", 8.5F);
            noShowLabel.ForeColor = Color.FromArgb(107, 114, 128);
            noShowLabel.Location = new Point(12, 82);
            noShowLabel.Name = "noShowLabel";
            noShowLabel.Size = new Size(73, 21);
            noShowLabel.TabIndex = 2;
            noShowLabel.Text = "- no-shows";
            // 
            // contactPanel
            // 
            contactPanel.Controls.Add(contactTitleLabel);
            contactPanel.Controls.Add(phoneLabel);
            contactPanel.Controls.Add(emailLabel);
            contactPanel.CustomizableEdges = customizableEdges9;
            contactPanel.Dock = DockStyle.Top;
            contactPanel.FillColor = Color.White;
            contactPanel.Location = new Point(0, 232);
            contactPanel.Name = "contactPanel";
            contactPanel.Padding = new Padding(24, 16, 24, 16);
            contactPanel.ShadowDecoration.CustomizableEdges = customizableEdges10;
            contactPanel.Size = new Size(565, 100);
            contactPanel.TabIndex = 2;
            // 
            // contactTitleLabel
            // 
            contactTitleLabel.BackColor = Color.Transparent;
            contactTitleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            contactTitleLabel.ForeColor = Color.FromArgb(17, 24, 39);
            contactTitleLabel.Location = new Point(24, 16);
            contactTitleLabel.Name = "contactTitleLabel";
            contactTitleLabel.Size = new Size(166, 25);
            contactTitleLabel.TabIndex = 0;
            contactTitleLabel.Text = "Contact Information";
            // 
            // phoneLabel
            // 
            phoneLabel.BackColor = Color.Transparent;
            phoneLabel.Font = new Font("Segoe UI", 9.5F);
            phoneLabel.ForeColor = Color.FromArgb(75, 85, 99);
            phoneLabel.Location = new Point(24, 52);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(33, 23);
            phoneLabel.TabIndex = 1;
            phoneLabel.Text = "📞  -";
            // 
            // emailLabel
            // 
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Segoe UI", 9.5F);
            emailLabel.ForeColor = Color.FromArgb(75, 85, 99);
            emailLabel.Location = new Point(300, 52);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(35, 23);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "✉  -";
            // 
            // footerPanel
            // 
            footerPanel.Controls.Add(closeBtn);
            footerPanel.Controls.Add(bookBtn);
            footerPanel.CustomizableEdges = customizableEdges15;
            footerPanel.Dock = DockStyle.Bottom;
            footerPanel.FillColor = Color.White;
            footerPanel.Location = new Point(0, 392);
            footerPanel.Name = "footerPanel";
            footerPanel.Padding = new Padding(24, 0, 24, 0);
            footerPanel.ShadowDecoration.CustomizableEdges = customizableEdges16;
            footerPanel.Size = new Size(565, 68);
            footerPanel.TabIndex = 3;
            // 
            // closeBtn
            // 
            closeBtn.BorderColor = Color.FromArgb(229, 231, 235);
            closeBtn.BorderRadius = 8;
            closeBtn.BorderThickness = 1;
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.CustomizableEdges = customizableEdges11;
            closeBtn.FillColor = Color.White;
            closeBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            closeBtn.ForeColor = Color.FromArgb(107, 114, 128);
            closeBtn.Location = new Point(24, 14);
            closeBtn.Name = "closeBtn";
            closeBtn.ShadowDecoration.CustomizableEdges = customizableEdges12;
            closeBtn.Size = new Size(120, 40);
            closeBtn.TabIndex = 0;
            closeBtn.Text = "Close";
            closeBtn.Click += closeBtn_Click;
            // 
            // bookBtn
            // 
            bookBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bookBtn.BorderRadius = 8;
            bookBtn.Cursor = Cursors.Hand;
            bookBtn.CustomizableEdges = customizableEdges13;
            bookBtn.FillColor = Color.FromArgb(59, 130, 246);
            bookBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bookBtn.ForeColor = Color.White;
            bookBtn.Location = new Point(355, 14);
            bookBtn.Name = "bookBtn";
            bookBtn.ShadowDecoration.CustomizableEdges = customizableEdges14;
            bookBtn.Size = new Size(186, 40);
            bookBtn.TabIndex = 1;
            bookBtn.Text = "Book Appointment";
            bookBtn.Click += bookBtn_Click;
            // 
            // avatarLabel
            // 
            avatarLabel.FillColor = Color.FromArgb(59, 130, 246);
            avatarLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            avatarLabel.ForeColor = Color.White;
            avatarLabel.Location = new Point(24, 17);
            avatarLabel.Name = "avatarLabel";
            avatarLabel.ShadowDecoration.CustomizableEdges = customizableEdges17;
            avatarLabel.Size = new Size(56, 56);
            avatarLabel.TabIndex = 0;
            avatarLabel.TabStop = false;
            avatarLabel.Click += avatarLabel_Click;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(avatarLabel);
            headerPanel.Controls.Add(nameLabel);
            headerPanel.Controls.Add(metaLabel);
            headerPanel.CustomizableEdges = customizableEdges18;
            headerPanel.Dock = DockStyle.Top;
            headerPanel.FillColor = Color.White;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(24, 0, 24, 0);
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges19;
            headerPanel.Size = new Size(565, 90);
            headerPanel.TabIndex = 0;
            headerPanel.Paint += headerPanel_Paint;
            // 
            // PatientDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(565, 460);
            Controls.Add(footerPanel);
            Controls.Add(contactPanel);
            Controls.Add(cardsPanel);
            Controls.Add(headerPanel);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PatientDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Patient Details";
            Load += PatientDetailsForm_Load;
            cardsPanel.ResumeLayout(false);
            ageCard.ResumeLayout(false);
            ageCard.PerformLayout();
            bloodCard.ResumeLayout(false);
            bloodCard.PerformLayout();
            appointmentsCard.ResumeLayout(false);
            appointmentsCard.PerformLayout();
            contactPanel.ResumeLayout(false);
            contactPanel.PerformLayout();
            footerPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna2HtmlLabel nameLabel;
        private Guna2HtmlLabel metaLabel;
        private Guna2Panel cardsPanel;
        private Guna2Panel ageCard;
        private Guna2HtmlLabel ageTitleLabel;
        private Guna2HtmlLabel ageValueLabel;
        private Guna2HtmlLabel dobLabel;
        private Guna2Panel bloodCard;
        private Guna2HtmlLabel bloodTitleLabel;
        private Guna2HtmlLabel bloodValueLabel;
        private Guna2Panel appointmentsCard;
        private Guna2HtmlLabel appointmentsTitleLabel;
        private Guna2HtmlLabel appointmentsValueLabel;
        private Guna2HtmlLabel noShowLabel;
        private Guna2Panel contactPanel;
        private Guna2HtmlLabel contactTitleLabel;
        private Guna2HtmlLabel phoneLabel;
        private Guna2HtmlLabel emailLabel;
        private Guna2Panel footerPanel;
        private Guna2Button closeBtn;
        private Guna2Button bookBtn;
        private Guna2CircleButton avatarLabel;
        private Guna2Panel headerPanel;
    }
}