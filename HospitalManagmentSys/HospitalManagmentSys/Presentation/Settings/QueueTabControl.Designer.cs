namespace HospitalManagmentSys.Presentation.Settings
{
   
        partial class QueueTabControl
        {
            private System.ComponentModel.IContainer components = null;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null)) components.Dispose();
                base.Dispose(disposing);
            }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlCard = new Guna.UI2.WinForms.Guna2Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlDivider = new Panel();
            pnlEmergency = new Guna.UI2.WinForms.Guna2Panel();
            lblDotE = new Label();
            lblNameE = new Label();
            lblScoreE = new Label();
            pnlHigh = new Guna.UI2.WinForms.Guna2Panel();
            lblDotH = new Label();
            lblNameH = new Label();
            lblScoreH = new Label();
            pnlMedium = new Guna.UI2.WinForms.Guna2Panel();
            lblDotM = new Label();
            lblNameM = new Label();
            lblScoreM = new Label();
            pnlLow = new Guna.UI2.WinForms.Guna2Panel();
            lblDotL = new Label();
            lblNameL = new Label();
            lblScoreL = new Label();
            lblModifiers = new Label();
            pnlCard.SuspendLayout();
            pnlEmergency.SuspendLayout();
            pnlHigh.SuspendLayout();
            pnlMedium.SuspendLayout();
            pnlLow.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BorderColor = Color.FromArgb(220, 220, 220);
            pnlCard.BorderRadius = 12;
            pnlCard.BorderThickness = 1;
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Controls.Add(lblSubtitle);
            pnlCard.Controls.Add(pnlDivider);
            pnlCard.Controls.Add(pnlEmergency);
            pnlCard.Controls.Add(pnlHigh);
            pnlCard.Controls.Add(pnlMedium);
            pnlCard.Controls.Add(pnlLow);
            pnlCard.Controls.Add(lblModifiers);
            pnlCard.CustomizableEdges = customizableEdges9;
            pnlCard.FillColor = Color.White;
            pnlCard.Location = new Point(24, 20);
            pnlCard.Name = "pnlCard";
            pnlCard.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pnlCard.Size = new Size(1461, 860);
            pnlCard.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(20, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(194, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Queue Priority Rules";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 8.5F);
            lblSubtitle.ForeColor = Color.FromArgb(140, 140, 140);
            lblSubtitle.Location = new Point(21, 40);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(238, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "How urgency scores are calculated";
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(230, 230, 230);
            pnlDivider.Location = new Point(20, 62);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(780, 1);
            pnlDivider.TabIndex = 2;
            // 
            // pnlEmergency
            // 
            pnlEmergency.BorderColor = Color.FromArgb(230, 230, 230);
            pnlEmergency.BorderRadius = 8;
            pnlEmergency.BorderThickness = 1;
            pnlEmergency.Controls.Add(lblDotE);
            pnlEmergency.Controls.Add(lblNameE);
            pnlEmergency.Controls.Add(lblScoreE);
            pnlEmergency.CustomizableEdges = customizableEdges1;
            pnlEmergency.FillColor = Color.Maroon;
            pnlEmergency.Location = new Point(20, 78);
            pnlEmergency.Name = "pnlEmergency";
            pnlEmergency.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlEmergency.Size = new Size(1400, 50);
            pnlEmergency.TabIndex = 3;
            // 
            // lblDotE
            // 
            lblDotE.BackColor = Color.DarkRed;
            lblDotE.Location = new Point(16, 19);
            lblDotE.Name = "lblDotE";
            lblDotE.Size = new Size(12, 12);
            lblDotE.TabIndex = 0;
            // 
            // lblNameE
            // 
            lblNameE.AutoSize = true;
            lblNameE.BackColor = Color.Transparent;
            lblNameE.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNameE.ForeColor = Color.FromArgb(30, 30, 30);
            lblNameE.Location = new Point(36, 14);
            lblNameE.Name = "lblNameE";
            lblNameE.Size = new Size(98, 23);
            lblNameE.TabIndex = 1;
            lblNameE.Text = "Emergency";
            // 
            // lblScoreE
            // 
            lblScoreE.AutoSize = true;
            lblScoreE.BackColor = Color.Transparent;
            lblScoreE.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScoreE.ForeColor = Color.Black;
            lblScoreE.Location = new Point(1254, 14);
            lblScoreE.Name = "lblScoreE";
            lblScoreE.Size = new Size(124, 23);
            lblScoreE.TabIndex = 2;
            lblScoreE.Text = "Base score: 100";
            // 
            // pnlHigh
            // 
            pnlHigh.BackColor = Color.Maroon;
            pnlHigh.BorderColor = Color.FromArgb(230, 230, 230);
            pnlHigh.BorderRadius = 8;
            pnlHigh.BorderThickness = 1;
            pnlHigh.Controls.Add(lblDotH);
            pnlHigh.Controls.Add(lblNameH);
            pnlHigh.Controls.Add(lblScoreH);
            pnlHigh.CustomizableEdges = customizableEdges3;
            pnlHigh.FillColor = Color.FromArgb(192, 0, 0);
            pnlHigh.Location = new Point(20, 138);
            pnlHigh.Name = "pnlHigh";
            pnlHigh.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnlHigh.Size = new Size(1211, 50);
            pnlHigh.TabIndex = 4;
            // 
            // lblDotH
            // 
            lblDotH.BackColor = Color.FromArgb(226, 75, 74);
            lblDotH.Location = new Point(16, 19);
            lblDotH.Name = "lblDotH";
            lblDotH.Size = new Size(12, 12);
            lblDotH.TabIndex = 0;
            // 
            // lblNameH
            // 
            lblNameH.AutoSize = true;
            lblNameH.BackColor = Color.Transparent;
            lblNameH.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNameH.ForeColor = Color.FromArgb(30, 30, 30);
            lblNameH.Location = new Point(36, 14);
            lblNameH.Name = "lblNameH";
            lblNameH.Size = new Size(114, 23);
            lblNameH.TabIndex = 1;
            lblNameH.Text = "High Priority";
            // 
            // lblScoreH
            // 
            lblScoreH.AutoSize = true;
            lblScoreH.BackColor = Color.Transparent;
            lblScoreH.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScoreH.ForeColor = Color.Black;
            lblScoreH.Location = new Point(1080, 16);
            lblScoreH.Name = "lblScoreH";
            lblScoreH.Size = new Size(117, 23);
            lblScoreH.TabIndex = 2;
            lblScoreH.Text = "Base score: 70";
            // 
            // pnlMedium
            // 
            pnlMedium.BorderColor = Color.FromArgb(230, 230, 230);
            pnlMedium.BorderRadius = 8;
            pnlMedium.BorderThickness = 1;
            pnlMedium.Controls.Add(lblDotM);
            pnlMedium.Controls.Add(lblNameM);
            pnlMedium.Controls.Add(lblScoreM);
            pnlMedium.CustomizableEdges = customizableEdges5;
            pnlMedium.FillColor = Color.FromArgb(192, 64, 0);
            pnlMedium.Location = new Point(20, 198);
            pnlMedium.Name = "pnlMedium";
            pnlMedium.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pnlMedium.Size = new Size(963, 50);
            pnlMedium.TabIndex = 5;
            // 
            // lblDotM
            // 
            lblDotM.BackColor = Color.FromArgb(239, 159, 39);
            lblDotM.Location = new Point(16, 19);
            lblDotM.Name = "lblDotM";
            lblDotM.Size = new Size(12, 12);
            lblDotM.TabIndex = 0;
            // 
            // lblNameM
            // 
            lblNameM.AutoSize = true;
            lblNameM.BackColor = Color.Transparent;
            lblNameM.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNameM.ForeColor = Color.FromArgb(30, 30, 30);
            lblNameM.Location = new Point(36, 14);
            lblNameM.Name = "lblNameM";
            lblNameM.Size = new Size(142, 23);
            lblNameM.TabIndex = 1;
            lblNameM.Text = "Medium Priority";
            // 
            // lblScoreM
            // 
            lblScoreM.AutoSize = true;
            lblScoreM.BackColor = Color.Transparent;
            lblScoreM.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScoreM.ForeColor = Color.Black;
            lblScoreM.Location = new Point(839, 19);
            lblScoreM.Name = "lblScoreM";
            lblScoreM.Size = new Size(118, 23);
            lblScoreM.TabIndex = 2;
            lblScoreM.Text = "Base score: 40";
            // 
            // pnlLow
            // 
            pnlLow.BorderColor = Color.FromArgb(230, 230, 230);
            pnlLow.BorderRadius = 8;
            pnlLow.BorderThickness = 1;
            pnlLow.Controls.Add(lblDotL);
            pnlLow.Controls.Add(lblNameL);
            pnlLow.Controls.Add(lblScoreL);
            pnlLow.CustomizableEdges = customizableEdges7;
            pnlLow.FillColor = Color.Green;
            pnlLow.Location = new Point(20, 258);
            pnlLow.Name = "pnlLow";
            pnlLow.ShadowDecoration.CustomizableEdges = customizableEdges8;
            pnlLow.Size = new Size(780, 50);
            pnlLow.TabIndex = 6;
            // 
            // lblDotL
            // 
            lblDotL.BackColor = Color.FromArgb(99, 153, 34);
            lblDotL.Location = new Point(16, 19);
            lblDotL.Name = "lblDotL";
            lblDotL.Size = new Size(12, 12);
            lblDotL.TabIndex = 0;
            // 
            // lblNameL
            // 
            lblNameL.AutoSize = true;
            lblNameL.BackColor = Color.Transparent;
            lblNameL.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNameL.ForeColor = Color.FromArgb(30, 30, 30);
            lblNameL.Location = new Point(36, 14);
            lblNameL.Name = "lblNameL";
            lblNameL.Size = new Size(108, 23);
            lblNameL.TabIndex = 1;
            lblNameL.Text = "Low Priority";
            // 
            // lblScoreL
            // 
            lblScoreL.AutoSize = true;
            lblScoreL.BackColor = Color.Transparent;
            lblScoreL.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScoreL.ForeColor = Color.Black;
            lblScoreL.Location = new Point(660, 15);
            lblScoreL.Name = "lblScoreL";
            lblScoreL.Size = new Size(117, 23);
            lblScoreL.TabIndex = 2;
            lblScoreL.Text = "Base score: 20";
            // 
            // lblModifiers
            // 
            lblModifiers.AutoSize = true;
            lblModifiers.Font = new Font("Segoe UI", 8.5F);
            lblModifiers.ForeColor = Color.FromArgb(140, 140, 140);
            lblModifiers.Location = new Point(20, 320);
            lblModifiers.Name = "lblModifiers";
            lblModifiers.Size = new Size(0, 20);
            lblModifiers.TabIndex = 7;
            lblModifiers.Click += lblModifiers_Click;
            // 
            // QueueTabControl
            // 
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(pnlCard);
            Name = "QueueTabControl";
            Size = new Size(1488, 883);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            pnlEmergency.ResumeLayout(false);
            pnlEmergency.PerformLayout();
            pnlHigh.ResumeLayout(false);
            pnlHigh.PerformLayout();
            pnlMedium.ResumeLayout(false);
            pnlMedium.PerformLayout();
            pnlLow.ResumeLayout(false);
            pnlLow.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Fields
        private Guna.UI2.WinForms.Guna2Panel pnlCard;
            private System.Windows.Forms.Label lblTitle;
            private System.Windows.Forms.Label lblSubtitle;
            private System.Windows.Forms.Panel pnlDivider;
            private Guna.UI2.WinForms.Guna2Panel pnlEmergency;
            private Guna.UI2.WinForms.Guna2Panel pnlHigh;
            private Guna.UI2.WinForms.Guna2Panel pnlMedium;
            private Guna.UI2.WinForms.Guna2Panel pnlLow;
            private System.Windows.Forms.Label lblDotE;
            private System.Windows.Forms.Label lblNameE;
            private System.Windows.Forms.Label lblScoreE;
            private System.Windows.Forms.Label lblDotH;
            private System.Windows.Forms.Label lblNameH;
            private System.Windows.Forms.Label lblScoreH;
            private System.Windows.Forms.Label lblDotM;
            private System.Windows.Forms.Label lblNameM;
            private System.Windows.Forms.Label lblScoreM;
            private System.Windows.Forms.Label lblDotL;
            private System.Windows.Forms.Label lblNameL;
            private System.Windows.Forms.Label lblScoreL;
            private System.Windows.Forms.Label lblModifiers;
        }
    }
