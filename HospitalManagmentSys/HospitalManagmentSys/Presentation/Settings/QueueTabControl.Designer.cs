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
                this.components = new System.ComponentModel.Container();

                this.pnlCard = new Guna.UI2.WinForms.Guna2Panel();
                this.lblTitle = new System.Windows.Forms.Label();
                this.lblSubtitle = new System.Windows.Forms.Label();
                this.pnlDivider = new System.Windows.Forms.Panel();

                // Priority rows (Emergency, High, Medium, Low)
                this.pnlEmergency = new Guna.UI2.WinForms.Guna2Panel();
                this.pnlHigh = new Guna.UI2.WinForms.Guna2Panel();
                this.pnlMedium = new Guna.UI2.WinForms.Guna2Panel();
                this.pnlLow = new Guna.UI2.WinForms.Guna2Panel();

                // Labels inside each row
                this.lblDotE = new System.Windows.Forms.Label();
                this.lblNameE = new System.Windows.Forms.Label();
                this.lblScoreE = new System.Windows.Forms.Label();

                this.lblDotH = new System.Windows.Forms.Label();
                this.lblNameH = new System.Windows.Forms.Label();
                this.lblScoreH = new System.Windows.Forms.Label();

                this.lblDotM = new System.Windows.Forms.Label();
                this.lblNameM = new System.Windows.Forms.Label();
                this.lblScoreM = new System.Windows.Forms.Label();

                this.lblDotL = new System.Windows.Forms.Label();
                this.lblNameL = new System.Windows.Forms.Label();
                this.lblScoreL = new System.Windows.Forms.Label();

                this.lblModifiers = new System.Windows.Forms.Label();

                // ── pnlCard ───────────────────────────────────────────────
                this.pnlCard.FillColor = System.Drawing.Color.White;
                this.pnlCard.BorderRadius = 12;
                this.pnlCard.BorderColor = System.Drawing.Color.FromArgb(220, 220, 220);
                this.pnlCard.BorderThickness = 1;
                this.pnlCard.Size = new System.Drawing.Size(820, 360);
                this.pnlCard.Location = new System.Drawing.Point(24, 20);

                // lblTitle
                this.lblTitle.AutoSize = true;
                this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
                this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
                this.lblTitle.Location = new System.Drawing.Point(20, 18);
                this.lblTitle.Text = "Queue Priority Rules";

                // lblSubtitle
                this.lblSubtitle.AutoSize = true;
                this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
                this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(140, 140, 140);
                this.lblSubtitle.Location = new System.Drawing.Point(21, 40);
                this.lblSubtitle.Text = "How urgency scores are calculated";

                // pnlDivider
                this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
                this.pnlDivider.Size = new System.Drawing.Size(780, 1);
                this.pnlDivider.Location = new System.Drawing.Point(20, 62);

                // ── Helper: Build a priority row ──────────────────────────
                // Row dimensions
                int rowX = 20, rowW = 780, rowH = 50;
                int dotSize = 12;
                System.Drawing.Color rowBorder = System.Drawing.Color.FromArgb(230, 230, 230);

                // ── Emergency ─────────────────────────────────────────────
                this.pnlEmergency.FillColor = System.Drawing.Color.FromArgb(252, 252, 252);
                this.pnlEmergency.BorderColor = rowBorder;
                this.pnlEmergency.BorderThickness = 1;
                this.pnlEmergency.BorderRadius = 8;
                this.pnlEmergency.Size = new System.Drawing.Size(rowW, rowH);
                this.pnlEmergency.Location = new System.Drawing.Point(rowX, 78);

                this.lblDotE.BackColor = System.Drawing.Color.FromArgb(226, 75, 74);
                this.lblDotE.Size = new System.Drawing.Size(dotSize, dotSize);
                this.lblDotE.Location = new System.Drawing.Point(16, 19);
                this.lblDotE.Text = "";

                this.lblNameE.AutoSize = true;
                this.lblNameE.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                this.lblNameE.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
                this.lblNameE.Location = new System.Drawing.Point(36, 14);
                this.lblNameE.Text = "Emergency";

                this.lblScoreE.AutoSize = true;
                this.lblScoreE.Font = new System.Drawing.Font("Segoe UI", 9.5F);
                this.lblScoreE.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
                this.lblScoreE.Location = new System.Drawing.Point(660, 15);
                this.lblScoreE.Text = "Base score: 100";

                this.pnlEmergency.Controls.Add(this.lblDotE);
                this.pnlEmergency.Controls.Add(this.lblNameE);
                this.pnlEmergency.Controls.Add(this.lblScoreE);

                // ── High Priority ─────────────────────────────────────────
                this.pnlHigh.FillColor = System.Drawing.Color.FromArgb(252, 252, 252);
                this.pnlHigh.BorderColor = rowBorder;
                this.pnlHigh.BorderThickness = 1;
                this.pnlHigh.BorderRadius = 8;
                this.pnlHigh.Size = new System.Drawing.Size(rowW, rowH);
                this.pnlHigh.Location = new System.Drawing.Point(rowX, 138);

                this.lblDotH.BackColor = System.Drawing.Color.FromArgb(226, 75, 74);
                this.lblDotH.Size = new System.Drawing.Size(dotSize, dotSize);
                this.lblDotH.Location = new System.Drawing.Point(16, 19);
                this.lblDotH.Text = "";

                this.lblNameH.AutoSize = true;
                this.lblNameH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                this.lblNameH.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
                this.lblNameH.Location = new System.Drawing.Point(36, 14);
                this.lblNameH.Text = "High Priority";

                this.lblScoreH.AutoSize = true;
                this.lblScoreH.Font = new System.Drawing.Font("Segoe UI", 9.5F);
                this.lblScoreH.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
                this.lblScoreH.Location = new System.Drawing.Point(660, 15);
                this.lblScoreH.Text = "Base score: 70";

                this.pnlHigh.Controls.Add(this.lblDotH);
                this.pnlHigh.Controls.Add(this.lblNameH);
                this.pnlHigh.Controls.Add(this.lblScoreH);

                // ── Medium Priority ───────────────────────────────────────
                this.pnlMedium.FillColor = System.Drawing.Color.FromArgb(252, 252, 252);
                this.pnlMedium.BorderColor = rowBorder;
                this.pnlMedium.BorderThickness = 1;
                this.pnlMedium.BorderRadius = 8;
                this.pnlMedium.Size = new System.Drawing.Size(rowW, rowH);
                this.pnlMedium.Location = new System.Drawing.Point(rowX, 198);

                this.lblDotM.BackColor = System.Drawing.Color.FromArgb(239, 159, 39);
                this.lblDotM.Size = new System.Drawing.Size(dotSize, dotSize);
                this.lblDotM.Location = new System.Drawing.Point(16, 19);
                this.lblDotM.Text = "";

                this.lblNameM.AutoSize = true;
                this.lblNameM.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                this.lblNameM.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
                this.lblNameM.Location = new System.Drawing.Point(36, 14);
                this.lblNameM.Text = "Medium Priority";

                this.lblScoreM.AutoSize = true;
                this.lblScoreM.Font = new System.Drawing.Font("Segoe UI", 9.5F);
                this.lblScoreM.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
                this.lblScoreM.Location = new System.Drawing.Point(660, 15);
                this.lblScoreM.Text = "Base score: 40";

                this.pnlMedium.Controls.Add(this.lblDotM);
                this.pnlMedium.Controls.Add(this.lblNameM);
                this.pnlMedium.Controls.Add(this.lblScoreM);

                // ── Low Priority ──────────────────────────────────────────
                this.pnlLow.FillColor = System.Drawing.Color.FromArgb(252, 252, 252);
                this.pnlLow.BorderColor = rowBorder;
                this.pnlLow.BorderThickness = 1;
                this.pnlLow.BorderRadius = 8;
                this.pnlLow.Size = new System.Drawing.Size(rowW, rowH);
                this.pnlLow.Location = new System.Drawing.Point(rowX, 258);

                this.lblDotL.BackColor = System.Drawing.Color.FromArgb(99, 153, 34);
                this.lblDotL.Size = new System.Drawing.Size(dotSize, dotSize);
                this.lblDotL.Location = new System.Drawing.Point(16, 19);
                this.lblDotL.Text = "";

                this.lblNameL.AutoSize = true;
                this.lblNameL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                this.lblNameL.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
                this.lblNameL.Location = new System.Drawing.Point(36, 14);
                this.lblNameL.Text = "Low Priority";

                this.lblScoreL.AutoSize = true;
                this.lblScoreL.Font = new System.Drawing.Font("Segoe UI", 9.5F);
                this.lblScoreL.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
                this.lblScoreL.Location = new System.Drawing.Point(660, 15);
                this.lblScoreL.Text = "Base score: 20";

                this.pnlLow.Controls.Add(this.lblDotL);
                this.pnlLow.Controls.Add(this.lblNameL);
                this.pnlLow.Controls.Add(this.lblScoreL);

                // ── lblModifiers ──────────────────────────────────────────
                this.lblModifiers.AutoSize = true;
                this.lblModifiers.Font = new System.Drawing.Font("Segoe UI", 8.5F);
                this.lblModifiers.ForeColor = System.Drawing.Color.FromArgb(140, 140, 140);
                this.lblModifiers.Location = new System.Drawing.Point(20, 320);
                this.lblModifiers.Text = "Additional modifiers: Age <5 or >70 (+15), Age <12 or >60 (+10)";

                // ── Add to pnlCard ────────────────────────────────────────
                this.pnlCard.Controls.Add(this.lblTitle);
                this.pnlCard.Controls.Add(this.lblSubtitle);
                this.pnlCard.Controls.Add(this.pnlDivider);
                this.pnlCard.Controls.Add(this.pnlEmergency);
                this.pnlCard.Controls.Add(this.pnlHigh);
                this.pnlCard.Controls.Add(this.pnlMedium);
                this.pnlCard.Controls.Add(this.pnlLow);
                this.pnlCard.Controls.Add(this.lblModifiers);

                // ── QueueTabControl ───────────────────────────────────────
                this.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
                this.Size = new System.Drawing.Size(870, 420);
                this.Controls.Add(this.pnlCard);
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
