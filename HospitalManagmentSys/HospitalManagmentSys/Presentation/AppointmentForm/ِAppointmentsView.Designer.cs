namespace HospitalManagmentSys.Presentation
{
    partial class AppointmentsView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tlpRoot = new TableLayoutPanel();
            cardHeader = new Guna.UI2.WinForms.Guna2Panel();
            tlpHeader = new TableLayoutPanel();
            pHeaderText = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            btnBook = new Guna.UI2.WinForms.Guna2Button();
            cardDate = new Guna.UI2.WinForms.Guna2Panel();
            tlpDate = new TableLayoutPanel();
            btnPrev = new Guna.UI2.WinForms.Guna2Button();
            pDateCenter = new Panel();
            lblDate = new Label();
            lblCount = new Label();
            btnNext = new Guna.UI2.WinForms.Guna2Button();
            cardFilters = new Guna.UI2.WinForms.Guna2Panel();
            tlpFilters = new TableLayoutPanel();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            flpList = new FlowLayoutPanel();
            card3 = new AppointmentsCardView();
            tlpRoot.SuspendLayout();
            cardHeader.SuspendLayout();
            tlpHeader.SuspendLayout();
            pHeaderText.SuspendLayout();
            cardDate.SuspendLayout();
            tlpDate.SuspendLayout();
            pDateCenter.SuspendLayout();
            cardFilters.SuspendLayout();
            tlpFilters.SuspendLayout();
            flpList.SuspendLayout();
            SuspendLayout();
            // 
            // tlpRoot
            // 
            tlpRoot.ColumnCount = 1;
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRoot.Controls.Add(cardHeader, 0, 0);
            tlpRoot.Controls.Add(cardDate, 0, 1);
            tlpRoot.Controls.Add(cardFilters, 0, 2);
            tlpRoot.Controls.Add(flpList, 0, 3);
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.Location = new Point(24, 24);
            tlpRoot.Name = "tlpRoot";
            tlpRoot.RowCount = 4;
            tlpRoot.RowStyles.Add(new RowStyle());
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRoot.Size = new Size(1100, 760);
            tlpRoot.TabIndex = 0;
            tlpRoot.Paint += tlpRoot_Paint;
            // 
            // cardHeader
            // 
            cardHeader.BackColor = Color.Transparent;
            cardHeader.BorderColor = Color.FromArgb(230, 234, 242);
            cardHeader.BorderRadius = 14;
            cardHeader.BorderThickness = 1;
            cardHeader.Controls.Add(tlpHeader);
            cardHeader.CustomizableEdges = customizableEdges3;
            cardHeader.Dock = DockStyle.Top;
            cardHeader.FillColor = Color.White;
            cardHeader.Location = new Point(3, 3);
            cardHeader.Name = "cardHeader";
            cardHeader.Padding = new Padding(16);
            cardHeader.ShadowDecoration.BorderRadius = 14;
            cardHeader.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cardHeader.ShadowDecoration.Enabled = true;
            cardHeader.Size = new Size(1094, 86);
            cardHeader.TabIndex = 0;
            // 
            // tlpHeader
            // 
            tlpHeader.ColumnCount = 2;
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle());
            tlpHeader.Controls.Add(pHeaderText, 0, 0);
            tlpHeader.Controls.Add(btnBook, 1, 0);
            tlpHeader.Dock = DockStyle.Fill;
            tlpHeader.Location = new Point(16, 16);
            tlpHeader.Name = "tlpHeader";
            tlpHeader.RowCount = 1;
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHeader.Size = new Size(1062, 54);
            tlpHeader.TabIndex = 0;
            // 
            // pHeaderText
            // 
            pHeaderText.Controls.Add(lblTitle);
            pHeaderText.Controls.Add(lblSubtitle);
            pHeaderText.Dock = DockStyle.Fill;
            pHeaderText.Location = new Point(3, 3);
            pHeaderText.Name = "pHeaderText";
            pHeaderText.Size = new Size(866, 48);
            pHeaderText.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(17, 24, 39);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(177, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Appointments";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblSubtitle.Location = new Point(0, 33);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(279, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Schedule and manage patient appointments";
            // 
            // btnBook
            // 
            btnBook.BorderRadius = 10;
            btnBook.CustomizableEdges = customizableEdges1;
            btnBook.FillColor = Color.FromArgb(26, 115, 232);
            btnBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(875, 8);
            btnBook.Margin = new Padding(3, 8, 3, 3);
            btnBook.Name = "btnBook";
            btnBook.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBook.Size = new Size(184, 40);
            btnBook.TabIndex = 1;
            btnBook.Text = "+  Book Appointment";
            btnBook.Click += btnBook_Click;
            // 
            // cardDate
            // 
            cardDate.BackColor = Color.Transparent;
            cardDate.BorderColor = Color.FromArgb(230, 234, 242);
            cardDate.BorderRadius = 14;
            cardDate.BorderThickness = 1;
            cardDate.Controls.Add(tlpDate);
            cardDate.CustomizableEdges = customizableEdges9;
            cardDate.Dock = DockStyle.Fill;
            cardDate.FillColor = Color.White;
            cardDate.Location = new Point(3, 95);
            cardDate.Name = "cardDate";
            cardDate.Padding = new Padding(16);
            cardDate.ShadowDecoration.BorderRadius = 14;
            cardDate.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cardDate.ShadowDecoration.Enabled = true;
            cardDate.Size = new Size(1094, 104);
            cardDate.TabIndex = 1;
            // 
            // tlpDate
            // 
            tlpDate.ColumnCount = 3;
            tlpDate.ColumnStyles.Add(new ColumnStyle());
            tlpDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDate.ColumnStyles.Add(new ColumnStyle());
            tlpDate.Controls.Add(btnPrev, 0, 0);
            tlpDate.Controls.Add(pDateCenter, 1, 0);
            tlpDate.Controls.Add(btnNext, 2, 0);
            tlpDate.Dock = DockStyle.Fill;
            tlpDate.Location = new Point(16, 16);
            tlpDate.Name = "tlpDate";
            tlpDate.RowCount = 1;
            tlpDate.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDate.Size = new Size(1062, 72);
            tlpDate.TabIndex = 0;
            // 
            // btnPrev
            // 
            btnPrev.BorderRadius = 10;
            btnPrev.CustomizableEdges = customizableEdges5;
            btnPrev.FillColor = Color.FromArgb(245, 247, 251);
            btnPrev.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPrev.ForeColor = Color.FromArgb(17, 24, 39);
            btnPrev.Location = new Point(3, 16);
            btnPrev.Margin = new Padding(3, 16, 3, 3);
            btnPrev.Name = "btnPrev";
            btnPrev.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnPrev.Size = new Size(40, 40);
            btnPrev.TabIndex = 0;
            btnPrev.Text = "‹";
            btnPrev.Click += btnPrev_Click;
            // 
            // pDateCenter
            // 
            pDateCenter.Controls.Add(lblDate);
            pDateCenter.Controls.Add(lblCount);
            pDateCenter.Dock = DockStyle.Fill;
            pDateCenter.Location = new Point(49, 3);
            pDateCenter.Name = "pDateCenter";
            pDateCenter.Size = new Size(964, 66);
            pDateCenter.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDate.ForeColor = Color.FromArgb(17, 24, 39);
            lblDate.Location = new Point(360, 16);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(169, 20);
            lblDate.TabIndex = 0;
            lblDate.Text = "Saturday, April 4, 2026";
            // 
            // lblCount
            // 
            lblCount.Anchor = AnchorStyles.Top;
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9.5F);
            lblCount.ForeColor = Color.FromArgb(107, 114, 128);
            lblCount.Location = new Point(410, 40);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(99, 17);
            lblCount.TabIndex = 1;
            lblCount.Text = "7 appointments";
            // 
            // btnNext
            // 
            btnNext.BorderRadius = 10;
            btnNext.CustomizableEdges = customizableEdges7;
            btnNext.FillColor = Color.FromArgb(245, 247, 251);
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNext.ForeColor = Color.FromArgb(17, 24, 39);
            btnNext.Location = new Point(1019, 16);
            btnNext.Margin = new Padding(3, 16, 3, 3);
            btnNext.Name = "btnNext";
            btnNext.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnNext.Size = new Size(40, 40);
            btnNext.TabIndex = 2;
            btnNext.Text = "›";
            // 
            // cardFilters
            // 
            cardFilters.BackColor = Color.Transparent;
            cardFilters.BorderColor = Color.FromArgb(230, 234, 242);
            cardFilters.BorderRadius = 14;
            cardFilters.BorderThickness = 1;
            cardFilters.Controls.Add(tlpFilters);
            cardFilters.CustomizableEdges = customizableEdges15;
            cardFilters.Dock = DockStyle.Fill;
            cardFilters.FillColor = Color.White;
            cardFilters.Location = new Point(3, 205);
            cardFilters.Name = "cardFilters";
            cardFilters.Padding = new Padding(16);
            cardFilters.ShadowDecoration.BorderRadius = 14;
            cardFilters.ShadowDecoration.CustomizableEdges = customizableEdges16;
            cardFilters.ShadowDecoration.Enabled = true;
            cardFilters.Size = new Size(1094, 84);
            cardFilters.TabIndex = 2;
            // 
            // tlpFilters
            // 
            tlpFilters.ColumnCount = 2;
            tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpFilters.Controls.Add(txtSearch, 0, 0);
            tlpFilters.Controls.Add(cbStatus, 1, 0);
            tlpFilters.Dock = DockStyle.Fill;
            tlpFilters.Location = new Point(16, 16);
            tlpFilters.Name = "tlpFilters";
            tlpFilters.RowCount = 1;
            tlpFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFilters.Size = new Size(1062, 52);
            tlpFilters.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.BorderColor = Color.FromArgb(230, 234, 242);
            txtSearch.BorderRadius = 12;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.CustomizableEdges = customizableEdges11;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(245, 247, 251);
            txtSearch.DisabledState.ForeColor = Color.Gray;
            txtSearch.FillColor = Color.FromArgb(245, 247, 251);
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(3, 3);
            txtSearch.Margin = new Padding(3, 3, 12, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by patient, doctor, or department...";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtSearch.Size = new Size(728, 46);
            txtSearch.TabIndex = 0;
            // 
            // cbStatus
            // 
            cbStatus.BackColor = Color.Transparent;
            cbStatus.BorderColor = Color.FromArgb(230, 234, 242);
            cbStatus.BorderRadius = 12;
            cbStatus.CustomizableEdges = customizableEdges13;
            cbStatus.DrawMode = DrawMode.OwnerDrawFixed;
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.FillColor = Color.FromArgb(245, 247, 251);
            cbStatus.FocusedColor = Color.Empty;
            cbStatus.Font = new Font("Segoe UI", 10F);
            cbStatus.ForeColor = Color.FromArgb(17, 24, 39);
            cbStatus.ItemHeight = 30;
            cbStatus.Items.AddRange(new object[] { "All Status", "Scheduled", "Waiting", "Attended", "No-Show", "Cancelled" });
            cbStatus.Location = new Point(746, 8);
            cbStatus.Margin = new Padding(3, 8, 3, 3);
            cbStatus.Name = "cbStatus";
            cbStatus.ShadowDecoration.CustomizableEdges = customizableEdges14;
            cbStatus.Size = new Size(313, 36);
            cbStatus.StartIndex = 0;
            cbStatus.TabIndex = 1;
            // 
            // flpList
            // 
            flpList.AutoScroll = true;
            flpList.BackColor = Color.Transparent;
            flpList.Controls.Add(card3);
            flpList.Dock = DockStyle.Fill;
            flpList.FlowDirection = FlowDirection.TopDown;
            flpList.Location = new Point(3, 295);
            flpList.Name = "flpList";
            flpList.Padding = new Padding(0, 8, 0, 0);
            flpList.Size = new Size(1094, 462);
            flpList.TabIndex = 3;
            flpList.WrapContents = false;
            // 
            // card3
            // 
            card3.BackColor = Color.Transparent;
            card3.Location = new Point(0, 8);
            card3.Margin = new Padding(0, 0, 0, 16);
            card3.Name = "card3";
            card3.Size = new Size(980, 150);
            card3.TabIndex = 2;
            // 
            // AppointmentsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            Controls.Add(tlpRoot);
            Name = "AppointmentsView";
            Padding = new Padding(24);
            Size = new Size(1148, 808);
            tlpRoot.ResumeLayout(false);
            cardHeader.ResumeLayout(false);
            tlpHeader.ResumeLayout(false);
            pHeaderText.ResumeLayout(false);
            pHeaderText.PerformLayout();
            cardDate.ResumeLayout(false);
            tlpDate.ResumeLayout(false);
            pDateCenter.ResumeLayout(false);
            pDateCenter.PerformLayout();
            cardFilters.ResumeLayout(false);
            tlpFilters.ResumeLayout(false);
            flpList.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private Guna.UI2.WinForms.Guna2Panel cardHeader;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.Panel pHeaderText;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private Guna.UI2.WinForms.Guna2Button btnBook;
        private Guna.UI2.WinForms.Guna2Panel cardDate;
        private System.Windows.Forms.TableLayoutPanel tlpDate;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private System.Windows.Forms.Panel pDateCenter;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCount;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Panel cardFilters;
        private System.Windows.Forms.TableLayoutPanel tlpFilters;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private System.Windows.Forms.FlowLayoutPanel flpList;
        private AppointmentsCardView card3;
    }
}