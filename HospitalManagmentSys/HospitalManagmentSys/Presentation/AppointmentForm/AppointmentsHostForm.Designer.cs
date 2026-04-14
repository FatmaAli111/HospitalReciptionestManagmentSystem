namespace HospitalManagmentSys.Presentation
{
    partial class AppointmentsHostForm
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
            appointmentsView1 = new AppointmentsView();
            sidebarControl1 = new HospitalManagmentSys.Presentation.Controls.Sidebar.SidebarControl();
            SuspendLayout();
            // 
            // appointmentsView1
            // 
            appointmentsView1.BackColor = Color.FromArgb(245, 247, 251);
            appointmentsView1.Dock = DockStyle.Fill;
            appointmentsView1.Location = new Point(315, 0);
            appointmentsView1.Name = "appointmentsView1";
            appointmentsView1.Padding = new Padding(24);
            appointmentsView1.Size = new Size(885, 700);
            appointmentsView1.TabIndex = 0;
            appointmentsView1.Load += appointmentsView1_Load;
            // 
            // sidebarControl1
            // 
            sidebarControl1.BackColor = Color.FromArgb(2, 29, 58);
            sidebarControl1.Dock = DockStyle.Left;
            sidebarControl1.Font = new Font("Segoe UI", 9F);
            sidebarControl1.Location = new Point(0, 0);
            sidebarControl1.MinimumSize = new Size(280, 400);
            sidebarControl1.Name = "sidebarControl1";
            sidebarControl1.Size = new Size(315, 700);
            sidebarControl1.TabIndex = 1;
            sidebarControl1.UserName = "Admin User";
            sidebarControl1.UserRole = "Admin";
            // 
            // AppointmentsHostForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(appointmentsView1);
            Controls.Add(sidebarControl1);
            Name = "AppointmentsHostForm";
            Text = "Appointments";
            ResumeLayout(false);
        }

        private AppointmentsView appointmentsView1;
        private Controls.Sidebar.SidebarControl sidebarControl1;
        #endregion

    }
}