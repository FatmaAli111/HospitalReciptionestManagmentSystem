namespace HospitalManagmentSys.Presentation.Controls.Sidebar
{
    partial class MainPage
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            sidebarControl1 = new SidebarControl();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            SuspendLayout();
            // 
            // sidebarControl1
            // 
            sidebarControl1.BackColor = Color.FromArgb(2, 29, 58);
            sidebarControl1.Dock = DockStyle.Left;
            sidebarControl1.Font = new Font("Segoe UI", 9F);
            sidebarControl1.Location = new Point(0, 0);
            sidebarControl1.MinimumSize = new Size(280, 400);
            sidebarControl1.Name = "sidebarControl1";
            sidebarControl1.Size = new Size(408, 1033);
            sidebarControl1.TabIndex = 0;
            sidebarControl1.UserName = "Admin User";
            sidebarControl1.UserRole = "Admin";
            // 
            // guna2Panel1
            // 
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.Location = new Point(408, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(1494, 1033);
            guna2Panel1.TabIndex = 1;
            guna2Panel1.Paint += guna2Panel1_Paint;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(guna2Panel1);
            Controls.Add(sidebarControl1);
            Name = "MainPage";
            Text = "MainPage";
            ResumeLayout(false);
        }

        #endregion

        private SidebarControl sidebarControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}