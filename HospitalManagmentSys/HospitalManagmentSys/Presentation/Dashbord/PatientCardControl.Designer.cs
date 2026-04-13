namespace HospitalManagmentSys.Presentation.Dashbord
{
    partial class PatientCardControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Time = new Label();
            DctorN = new Label();
            Speciality = new Label();
            PatieName = new Label();
            bStatus = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            btnAvatar = new Guna.UI2.WinForms.Guna2CircleButton();
            AppointmentPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            AppointmentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Time.Location = new Point(423, 11);
            Time.Name = "Time";
            Time.Size = new Size(49, 20);
            Time.TabIndex = 10;
            Time.Text = "09:00";
            // 
            // DctorN
            // 
            DctorN.AutoSize = true;
            DctorN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DctorN.ForeColor = SystemColors.ControlDark;
            DctorN.Location = new Point(92, 47);
            DctorN.Name = "DctorN";
            DctorN.Size = new Size(116, 17);
            DctorN.TabIndex = 8;
            DctorN.Text = "Dr. Michael Chen .";
            // 
            // Speciality
            // 
            Speciality.AutoSize = true;
            Speciality.BackColor = Color.White;
            Speciality.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Speciality.ForeColor = Color.DarkGray;
            Speciality.Location = new Point(214, 47);
            Speciality.Name = "Speciality";
            Speciality.Size = new Size(84, 20);
            Speciality.TabIndex = 7;
            Speciality.Text = "Cardiology";
            // 
            // PatieName
            // 
            PatieName.AutoSize = true;
            PatieName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatieName.Location = new Point(80, 11);
            PatieName.Name = "PatieName";
            PatieName.Size = new Size(90, 21);
            PatieName.TabIndex = 4;
            PatieName.Text = "John Smith";
            PatieName.Click += PatieName_Click;
            // 
            // bStatus
            // 
            bStatus.BorderRadius = 5;
            bStatus.CustomizableEdges = customizableEdges1;
            bStatus.DisabledState.BorderColor = Color.DarkGray;
            bStatus.DisabledState.CustomBorderColor = Color.DarkGray;
            bStatus.DisabledState.FillColor = Color.FromArgb(245, 158, 11);
            bStatus.DisabledState.ForeColor = Color.White;
            bStatus.Enabled = false;
            bStatus.FillColor = Color.Coral;
            bStatus.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            bStatus.ForeColor = Color.White;
            bStatus.Location = new Point(411, 47);
            bStatus.Name = "bStatus";
            bStatus.ShadowDecoration.CustomizableEdges = customizableEdges2;
            bStatus.Size = new Size(70, 22);
            bStatus.TabIndex = 11;
            bStatus.Text = "waiting";
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 5;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(220, 38, 38);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(190, 11);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(71, 21);
            guna2Button1.TabIndex = 12;
            guna2Button1.Text = "high";
            // 
            // btnAvatar
            // 
            btnAvatar.DisabledState.BorderColor = Color.DarkGray;
            btnAvatar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAvatar.DisabledState.FillColor = Color.FromArgb(239, 246, 255);
            btnAvatar.DisabledState.ForeColor = Color.FromArgb(37, 99, 235);
            btnAvatar.Enabled = false;
            btnAvatar.FillColor = Color.FromArgb(239, 246, 255);
            btnAvatar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAvatar.ForeColor = Color.FromArgb(37, 99, 235);
            btnAvatar.Location = new Point(3, 20);
            btnAvatar.Name = "btnAvatar";
            btnAvatar.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnAvatar.Size = new Size(44, 44);
            btnAvatar.TabIndex = 13;
            btnAvatar.Text = "JS";
            // 
            // AppointmentPanel
            // 
            AppointmentPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            AppointmentPanel.Controls.Add(btnAvatar);
            AppointmentPanel.Controls.Add(bStatus);
            AppointmentPanel.Controls.Add(guna2Button1);
            AppointmentPanel.Controls.Add(Time);
            AppointmentPanel.Controls.Add(PatieName);
            AppointmentPanel.Controls.Add(Speciality);
            AppointmentPanel.Controls.Add(DctorN);
            AppointmentPanel.CustomBorderColor = Color.White;
            AppointmentPanel.CustomizableEdges = customizableEdges6;
            AppointmentPanel.Location = new Point(3, 3);
            AppointmentPanel.Name = "AppointmentPanel";
            AppointmentPanel.ShadowDecoration.CustomizableEdges = customizableEdges7;
            AppointmentPanel.Size = new Size(499, 92);
            AppointmentPanel.TabIndex = 14;
            // 
            // PatientCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(AppointmentPanel);
            Name = "PatientCardControl";
            Size = new Size(499, 96);
            Load += PatientCardControl_Load;
            AppointmentPanel.ResumeLayout(false);
            AppointmentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label Time;
        private Label DctorN;
        private Label Speciality;
        private Label PatieName;
        private Guna.UI2.WinForms.Guna2Button bStatus;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CircleButton btnAvatar;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel AppointmentPanel;
        private Label Appointment;
        private Guna.UI2.WinForms.Guna2Button ViewAll;
    }
}
