namespace HospitalManagmentSys.Presentation
{
    partial class AdminPanel
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
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            requestsPanel = new DoubleBufferedFlowLayoutPanel();
            AccountCreationRequest = new Guna.UI2.WinForms.Guna2HtmlLabel();
            sidebarControl1 = new HospitalManagmentSys.Presentation.Controls.Sidebar.SidebarControl();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = SystemColors.ControlLight;
            guna2Panel1.Controls.Add(requestsPanel);
            guna2Panel1.Controls.Add(AccountCreationRequest);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(358, -1);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(1566, 988);
            guna2Panel1.TabIndex = 0;
            // 
            // requestsPanel
            // 
            requestsPanel.Location = new Point(123, 145);
            requestsPanel.Name = "requestsPanel";
            requestsPanel.Size = new Size(1390, 840);
            requestsPanel.TabIndex = 1;
            // 
            // AccountCreationRequest
            // 
            AccountCreationRequest.BackColor = Color.Transparent;
            AccountCreationRequest.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AccountCreationRequest.Location = new Point(573, 26);
            AccountCreationRequest.Name = "AccountCreationRequest";
            AccountCreationRequest.Size = new Size(422, 47);
            AccountCreationRequest.TabIndex = 0;
            AccountCreationRequest.Text = "Account Creation Requests";
            // 
            // sidebarControl1
            // 
            sidebarControl1.BackColor = Color.FromArgb(2, 29, 58);
            sidebarControl1.Font = new Font("Segoe UI", 9F);
            sidebarControl1.Location = new Point(0, 2);
            sidebarControl1.MinimumSize = new Size(280, 400);
            sidebarControl1.Name = "sidebarControl1";
            sidebarControl1.Size = new Size(363, 985);
            sidebarControl1.TabIndex = 1;
            sidebarControl1.UserName = "Admin User";
            sidebarControl1.UserRole = "Admin";
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 986);
            Controls.Add(sidebarControl1);
            Controls.Add(guna2Panel1);
            Name = "AdminPanel";
            Text = "Form2";
            Load += AdminPanel_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel AccountCreationRequest;
        private DoubleBufferedFlowLayoutPanel requestsPanel;
        private Controls.Sidebar.SidebarControl sidebarControl1;
    }
}