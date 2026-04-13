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
            Time = new Label();
            DctorN = new Label();
            Speciality = new Label();
            PatieName = new Label();
            bStatus = new Guna.UI2.WinForms.Guna2Button();
            Urgency = new Guna.UI2.WinForms.Guna2Button();
            btnAvatar = new Guna.UI2.WinForms.Guna2CircleButton();
            SuspendLayout();
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Time.Location = new Point(408, 12);
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
            DctorN.Location = new Point(73, 48);
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
            Speciality.Location = new Point(185, 48);
            Speciality.Name = "Speciality";
            Speciality.Size = new Size(84, 20);
            Speciality.TabIndex = 7;
            Speciality.Text = "Cardiology";
            // 
            // PatieName
            // 
            PatieName.AutoSize = true;
            PatieName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatieName.Location = new Point(73, 12);
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
            bStatus.Location = new Point(390, 43);
            bStatus.Name = "bStatus";
            bStatus.ShadowDecoration.CustomizableEdges = customizableEdges2;
            bStatus.Size = new Size(96, 22);
            bStatus.TabIndex = 11;
            bStatus.Text = "waiting";
            // 
            // Urgency
            // 
            Urgency.BorderRadius = 5;
            Urgency.CustomizableEdges = customizableEdges3;
            Urgency.DisabledState.BorderColor = Color.DarkGray;
            Urgency.DisabledState.CustomBorderColor = Color.DarkGray;
            Urgency.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Urgency.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Urgency.FillColor = Color.FromArgb(220, 38, 38);
            Urgency.Font = new Font("Segoe UI", 9F);
            Urgency.ForeColor = Color.White;
            Urgency.Location = new Point(210, 12);
            Urgency.Name = "Urgency";
            Urgency.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Urgency.Size = new Size(89, 21);
            Urgency.TabIndex = 12;
            Urgency.Text = "high";
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
            btnAvatar.Location = new Point(3, 12);
            btnAvatar.Name = "btnAvatar";
            btnAvatar.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnAvatar.Size = new Size(44, 44);
            btnAvatar.TabIndex = 13;
            btnAvatar.Text = "JS";
            // 
            // PatientCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Time);
            Controls.Add(bStatus);
            Controls.Add(btnAvatar);
            Controls.Add(Urgency);
            Controls.Add(PatieName);
            Controls.Add(Speciality);
            Controls.Add(DctorN);
            Name = "PatientCardControl";
            Size = new Size(499, 92);
            Load += PatientCardControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Time;
        private Label DctorN;
        private Label Speciality;
        private Label PatieName;
        private Guna.UI2.WinForms.Guna2Button bStatus;
        private Guna.UI2.WinForms.Guna2Button Urgency;
        private Guna.UI2.WinForms.Guna2CircleButton btnAvatar;
        private Label Appointment;
        private Guna.UI2.WinForms.Guna2Button ViewAll;
    }
}
