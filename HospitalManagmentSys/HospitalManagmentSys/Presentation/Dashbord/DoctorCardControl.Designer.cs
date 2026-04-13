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
            DoctorPanel = new Panel();
            btnAvatar = new Guna.UI2.WinForms.Guna2CircleButton();
            Dr = new Label();
            specialty = new Label();
            DocName = new Label();
            DoctorPanel.SuspendLayout();
            SuspendLayout();
            // 
            // DoctorPanel
            // 
            DoctorPanel.BackColor = Color.White;
            DoctorPanel.Controls.Add(btnAvatar);
            DoctorPanel.Controls.Add(Dr);
            DoctorPanel.Controls.Add(specialty);
            DoctorPanel.Controls.Add(DocName);
            DoctorPanel.Location = new Point(3, 3);
            DoctorPanel.Name = "DoctorPanel";
            DoctorPanel.Size = new Size(187, 67);
            DoctorPanel.TabIndex = 1;
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
            btnAvatar.Location = new Point(10, 11);
            btnAvatar.Name = "btnAvatar";
            btnAvatar.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnAvatar.Size = new Size(44, 44);
            btnAvatar.TabIndex = 15;
            btnAvatar.Text = "M";
            // 
            // Dr
            // 
            Dr.AutoSize = true;
            Dr.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dr.Location = new Point(60, 15);
            Dr.Name = "Dr";
            Dr.Size = new Size(29, 20);
            Dr.TabIndex = 2;
            Dr.Text = "Dr.";
            // 
            // specialty
            // 
            specialty.AutoSize = true;
            specialty.BackColor = Color.Transparent;
            specialty.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specialty.ForeColor = Color.DarkGray;
            specialty.Location = new Point(60, 35);
            specialty.Name = "specialty";
            specialty.Size = new Size(82, 20);
            specialty.TabIndex = 1;
            specialty.Text = "Cardiology";
            // 
            // DocName
            // 
            DocName.AutoSize = true;
            DocName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DocName.Location = new Point(85, 15);
            DocName.Name = "DocName";
            DocName.Size = new Size(80, 20);
            DocName.TabIndex = 0;
            DocName.Text = "Ahmed Ali";
            // 
            // DoctorCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(DoctorPanel);
            Name = "DoctorCardControl";
            Size = new Size(192, 76);
            DoctorPanel.ResumeLayout(false);
            DoctorPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel DoctorPanel;
        private Label Dr;
        private Label specialty;
        private Label DocName;
        private Guna.UI2.WinForms.Guna2CircleButton btnAvatar;
        private Label label6;
        private Label label4;
    }
}
