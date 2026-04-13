namespace HospitalManagmentSys.Presentation.Dashbord
{
    partial class AppointmentCardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            QueuePatientPanel = new Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            btnAvatar = new Guna.UI2.WinForms.Guna2CircleButton();
            ActualScore = new Label();
            Score = new Label();
            PatientName = new Label();
            QueuePatientPanel.SuspendLayout();
            SuspendLayout();
            // 
            // QueuePatientPanel
            // 
            QueuePatientPanel.BackColor = Color.White;
            QueuePatientPanel.Controls.Add(guna2Button1);
            QueuePatientPanel.Controls.Add(btnAvatar);
            QueuePatientPanel.Controls.Add(ActualScore);
            QueuePatientPanel.Controls.Add(Score);
            QueuePatientPanel.Controls.Add(PatientName);
            QueuePatientPanel.ForeColor = SystemColors.ControlText;
            QueuePatientPanel.Location = new Point(3, 3);
            QueuePatientPanel.Name = "QueuePatientPanel";
            QueuePatientPanel.Size = new Size(250, 62);
            QueuePatientPanel.TabIndex = 4;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 5;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(220, 38, 38);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(162, 6);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(71, 21);
            guna2Button1.TabIndex = 15;
            guna2Button1.Text = "high";
            // 
            // btnAvatar
            // 
            btnAvatar.DisabledState.BorderColor = Color.DarkGray;
            btnAvatar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAvatar.DisabledState.FillColor = Color.FromArgb(239, 246, 255);
            btnAvatar.DisabledState.ForeColor = Color.FromArgb(37, 99, 235);
            btnAvatar.Enabled = false;
            btnAvatar.FillColor = Color.Blue;
            btnAvatar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAvatar.ForeColor = Color.White;
            btnAvatar.Location = new Point(3, 6);
            btnAvatar.Name = "btnAvatar";
            btnAvatar.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnAvatar.Size = new Size(44, 44);
            btnAvatar.TabIndex = 14;
            btnAvatar.Text = "1";
            // 
            // ActualScore
            // 
            ActualScore.AutoSize = true;
            ActualScore.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ActualScore.ForeColor = Color.DarkGray;
            ActualScore.Location = new Point(91, 34);
            ActualScore.Name = "ActualScore";
            ActualScore.Size = new Size(22, 17);
            ActualScore.TabIndex = 3;
            ActualScore.Text = "50";
            // 
            // Score
            // 
            Score.AutoSize = true;
            Score.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Score.ForeColor = Color.DarkGray;
            Score.Location = new Point(49, 36);
            Score.Name = "Score";
            Score.Size = new Size(45, 15);
            Score.TabIndex = 1;
            Score.Text = "Score :";
            // 
            // PatientName
            // 
            PatientName.AutoSize = true;
            PatientName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatientName.Location = new Point(49, 6);
            PatientName.Name = "PatientName";
            PatientName.Size = new Size(90, 21);
            PatientName.TabIndex = 0;
            PatientName.Text = "John Smith";
            PatientName.Click += PatientName_Click;
            // 
            // AppointmentCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(QueuePatientPanel);
            Name = "AppointmentCardControl";
            Size = new Size(256, 68);
            QueuePatientPanel.ResumeLayout(false);
            QueuePatientPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel QueuePatientPanel;
        private Label ActualScore;
        private Label Score;
        private Label PatientName;
        private Guna.UI2.WinForms.Guna2CircleButton btnAvatar;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label15;
        private Label DoctorName;
        private Label label5;
    }
}
