namespace HospitalManagmentSys.Presentation.Dashbord
{
    partial class DoctorCardControl
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
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            btnAvatar = new Guna.UI2.WinForms.Guna2CircleButton();
            specialty = new Label();
            DocName = new Label();
            SuspendLayout();
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 5;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Green;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(238, 22);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(86, 30);
            guna2Button1.TabIndex = 16;
            guna2Button1.Text = " Available";
            // 
            // btnAvatar
            // 
            btnAvatar.DisabledState.BorderColor = Color.DarkGray;
            btnAvatar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAvatar.DisabledState.FillColor = Color.FromArgb(239, 246, 255);
            btnAvatar.DisabledState.ForeColor = Color.FromArgb(37, 99, 235);
            btnAvatar.Enabled = false;
            btnAvatar.FillColor = Color.LightCyan;
            btnAvatar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAvatar.ForeColor = Color.Lime;
            btnAvatar.Location = new Point(13, 22);
            btnAvatar.Name = "btnAvatar";
            btnAvatar.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnAvatar.Size = new Size(44, 44);
            btnAvatar.TabIndex = 15;
            btnAvatar.Text = "M";
            // 
            // specialty
            // 
            specialty.AutoSize = true;
            specialty.BackColor = Color.Transparent;
            specialty.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specialty.ForeColor = Color.DarkGray;
            specialty.Location = new Point(63, 42);
            specialty.Name = "specialty";
            specialty.Size = new Size(82, 20);
            specialty.TabIndex = 1;
            specialty.Text = "Cardiology";
            // 
            // DocName
            // 
            DocName.AutoSize = true;
            DocName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DocName.Location = new Point(63, 22);
            DocName.Name = "DocName";
            DocName.Size = new Size(105, 20);
            DocName.TabIndex = 0;
            DocName.Text = "Dr .Ahmed Ali";
            DocName.Click += DocName_Click;
            // 
            // DoctorCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2Button1);
            Controls.Add(specialty);
            Controls.Add(btnAvatar);
            Controls.Add(DocName);
            Name = "DoctorCardControl";
            Size = new Size(337, 74);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label specialty;
        private Label DocName;
        private Guna.UI2.WinForms.Guna2CircleButton btnAvatar;
        private Label label6;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
