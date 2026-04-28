namespace HospitalManagmentSys.Presentation.Dashbord1
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
            Label PatientName;
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Urgency = new Guna.UI2.WinForms.Guna2Button();
            btnAvatar = new Guna.UI2.WinForms.Guna2CircleButton();
            ActualScore = new Label();
            Score = new Label();
            PatientName = new Label();
            SuspendLayout();
            // 
            // PatientName
            // 
            PatientName.AutoSize = true;
            PatientName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatientName.Location = new Point(50, 3);
            PatientName.Name = "PatientName";
            PatientName.Size = new Size(90, 21);
            PatientName.TabIndex = 0;
            PatientName.Text = "John Smith";
            PatientName.Click += PatientName_Click;
            // 
            // Urgency
            // 
            Urgency.BorderRadius = 5;
            Urgency.CustomizableEdges = customizableEdges1;
            Urgency.DisabledState.BorderColor = Color.DarkGray;
            Urgency.DisabledState.CustomBorderColor = Color.DarkGray;
            Urgency.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Urgency.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Urgency.FillColor = Color.FromArgb(220, 38, 38);
            Urgency.Font = new Font("Segoe UI", 9F);
            Urgency.ForeColor = Color.White;
            Urgency.Location = new Point(159, 26);
            Urgency.Name = "Urgency";
            Urgency.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Urgency.Size = new Size(86, 21);
            Urgency.TabIndex = 15;
            Urgency.Text = "high";
            Urgency.Click += Urgency_Click;
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
            btnAvatar.Location = new Point(0, 3);
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
            ActualScore.Location = new Point(90, 32);
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
            Score.Location = new Point(50, 32);
            Score.Name = "Score";
            Score.Size = new Size(45, 15);
            Score.TabIndex = 1;
            Score.Text = "Score :";
            // 
            // AppointmentCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(Urgency);
            Controls.Add(PatientName);
            Controls.Add(ActualScore);
            Controls.Add(btnAvatar);
            Controls.Add(Score);
            Name = "AppointmentCardControl";
            Size = new Size(265, 62);
            ResumeLayout(false);
            PerformLayout();
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
        private Guna.UI2.WinForms.Guna2Button Urgency;
    }
}
