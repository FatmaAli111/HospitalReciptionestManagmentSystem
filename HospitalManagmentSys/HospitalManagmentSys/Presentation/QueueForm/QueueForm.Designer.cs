namespace HospitalManagmentSys.Presentation
{
    partial class QueueForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlHeader = new Panel();
            btnEmergency = new Button();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlStats = new Panel();
            tableStats = new TableLayoutPanel();
            lblPatientsWaitingLabel = new Label();
            lblPatientsWaitingValue = new Label();
            pnlPatientsIconHost = new Panel();
            lblPatientsWaitingIcon = new Label();
            lblEmergenciesLabel = new Label();
            lblEmergenciesValue = new Label();
            pnlEmergenciesIconHost = new Panel();
            lblEmergenciesIcon = new Label();
            lblAvgWaitTimeLabel = new Label();
            lblAvgWaitTimeValue = new Label();
            pnlAvgWaitIconHost = new Panel();
            lblAvgWaitTimeIcon = new Label();
            lblCurrentTimeLabel = new Label();
            lblCurrentTimeValue = new Label();
            pnlCurrentTimeIconHost = new Panel();
            lblCurrentTimeIcon = new Label();
            pnlQueueSection = new Panel();
            pnlQueueContainer = new Panel();
            tblQueueHeader = new TableLayoutPanel();
            lblQueueTitle = new Label();
            lblQueueSubtitle = new Label();
            chkAutoRefresh = new CheckBox();
            timerClock = new System.Windows.Forms.Timer(components);
            timerAutoRefresh = new System.Windows.Forms.Timer(components);
            pnlHeader.SuspendLayout();
            pnlStats.SuspendLayout();
            pnlPatientsIconHost.SuspendLayout();
            pnlEmergenciesIconHost.SuspendLayout();
            pnlAvgWaitIconHost.SuspendLayout();
            pnlCurrentTimeIconHost.SuspendLayout();
            pnlQueueSection.SuspendLayout();
            tblQueueHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(btnEmergency);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(34, 36, 34, 28);
            pnlHeader.Size = new Size(1113, 128);
            pnlHeader.TabIndex = 2;
            // 
            // btnEmergency
            // 
            btnEmergency.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEmergency.BackColor = Color.FromArgb(211, 47, 47);
            btnEmergency.Cursor = Cursors.Hand;
            btnEmergency.FlatAppearance.BorderSize = 0;
            btnEmergency.FlatStyle = FlatStyle.Flat;
            btnEmergency.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEmergency.ForeColor = Color.White;
            btnEmergency.Location = new Point(-87, 0);
            btnEmergency.Name = "btnEmergency";
            btnEmergency.Size = new Size(75, 23);
            btnEmergency.TabIndex = 0;
            btnEmergency.Text = "🚨  Emergency Patient";
            btnEmergency.UseVisualStyleBackColor = false;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 120, 120);
            lblSubtitle.Location = new Point(0, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(297, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Priority-based dynamic patient queue";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(374, 50);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Queue Management";
            // 
            // pnlStats
            // 
            pnlStats.BackColor = Color.FromArgb(248, 249, 250);
            pnlStats.Controls.Add(tableStats);
            pnlStats.Dock = DockStyle.Top;
            pnlStats.Location = new Point(0, 128);
            pnlStats.Name = "pnlStats";
            pnlStats.Size = new Size(1113, 100);
            pnlStats.TabIndex = 1;
            // 
            // tableStats
            // 
            tableStats.ColumnCount = 4;
            tableStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableStats.Dock = DockStyle.Fill;
            tableStats.Location = new Point(0, 0);
            tableStats.Margin = new Padding(0);
            tableStats.Name = "tableStats";
            tableStats.RowCount = 1;
            tableStats.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableStats.Size = new Size(1113, 100);
            tableStats.TabIndex = 0;
            // create stat cards and populate tableStats columns
            cardPatientsWaiting = new StatCardPanel();
            cardEmergencies = new StatCardPanel();
            cardAvgWaitTime = new StatCardPanel();
            cardCurrentTime = new StatCardPanel();

            // configure cards and add the prepared labels/panels into them
            cardPatientsWaiting.Dock = DockStyle.Fill;
            cardPatientsWaiting.Controls.Add(lblPatientsWaitingLabel);
            cardPatientsWaiting.Controls.Add(lblPatientsWaitingValue);
            cardPatientsWaiting.Controls.Add(pnlPatientsIconHost);

            cardEmergencies.Dock = DockStyle.Fill;
            cardEmergencies.Controls.Add(lblEmergenciesLabel);
            cardEmergencies.Controls.Add(lblEmergenciesValue);
            cardEmergencies.Controls.Add(pnlEmergenciesIconHost);

            cardAvgWaitTime.Dock = DockStyle.Fill;
            cardAvgWaitTime.Controls.Add(lblAvgWaitTimeLabel);
            cardAvgWaitTime.Controls.Add(lblAvgWaitTimeValue);
            cardAvgWaitTime.Controls.Add(pnlAvgWaitIconHost);

            cardCurrentTime.Dock = DockStyle.Fill;
            cardCurrentTime.Controls.Add(lblCurrentTimeLabel);
            cardCurrentTime.Controls.Add(lblCurrentTimeValue);
            cardCurrentTime.Controls.Add(pnlCurrentTimeIconHost);

            // clear any placeholder locations and add to table
            lblPatientsWaitingLabel.Location = new Point(16, 54);
            lblPatientsWaitingValue.Location = new Point(16, 10);
            pnlPatientsIconHost.Size = new Size(56, 56);
            pnlPatientsIconHost.Dock = DockStyle.Right;

            lblEmergenciesLabel.Location = new Point(16, 54);
            lblEmergenciesValue.Location = new Point(16, 10);
            pnlEmergenciesIconHost.Size = new Size(56, 56);
            pnlEmergenciesIconHost.Dock = DockStyle.Right;

            lblAvgWaitTimeLabel.Location = new Point(16, 54);
            lblAvgWaitTimeValue.Location = new Point(16, 10);
            pnlAvgWaitIconHost.Size = new Size(56, 56);
            pnlAvgWaitIconHost.Dock = DockStyle.Right;

            lblCurrentTimeLabel.Location = new Point(16, 54);
            lblCurrentTimeValue.Location = new Point(16, 10);
            pnlCurrentTimeIconHost.Size = new Size(56, 56);
            pnlCurrentTimeIconHost.Dock = DockStyle.Right;

            tableStats.Controls.Add(cardPatientsWaiting, 0, 0);
            tableStats.Controls.Add(cardEmergencies, 1, 0);
            tableStats.Controls.Add(cardAvgWaitTime, 2, 0);
            tableStats.Controls.Add(cardCurrentTime, 3, 0);
            // 
            // lblPatientsWaitingLabel
            // 
            lblPatientsWaitingLabel.AutoSize = true;
            lblPatientsWaitingLabel.Font = new Font("Segoe UI", 9.5F);
            lblPatientsWaitingLabel.ForeColor = Color.FromArgb(120, 120, 120);
            lblPatientsWaitingLabel.Location = new Point(72, 68);
            lblPatientsWaitingLabel.Name = "lblPatientsWaitingLabel";
            lblPatientsWaitingLabel.Size = new Size(121, 21);
            lblPatientsWaitingLabel.TabIndex = 2;
            lblPatientsWaitingLabel.Text = "Patients Waiting";
            // 
            // lblPatientsWaitingValue
            // 
            lblPatientsWaitingValue.AutoSize = true;
            lblPatientsWaitingValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblPatientsWaitingValue.ForeColor = Color.FromArgb(30, 30, 30);
            lblPatientsWaitingValue.Location = new Point(72, 18);
            lblPatientsWaitingValue.Name = "lblPatientsWaitingValue";
            lblPatientsWaitingValue.Size = new Size(43, 50);
            lblPatientsWaitingValue.TabIndex = 1;
            lblPatientsWaitingValue.Text = "2";
            // 
            // pnlPatientsIconHost
            // 
            pnlPatientsIconHost.BackColor = Color.FromArgb(240, 242, 245);
            pnlPatientsIconHost.Controls.Add(lblPatientsWaitingIcon);
            pnlPatientsIconHost.Location = new Point(0, 0);
            pnlPatientsIconHost.Name = "pnlPatientsIconHost";
            pnlPatientsIconHost.Size = new Size(200, 100);
            pnlPatientsIconHost.TabIndex = 0;
            // 
            // lblPatientsWaitingIcon
            // 
            lblPatientsWaitingIcon.Dock = DockStyle.Fill;
            lblPatientsWaitingIcon.Location = new Point(0, 0);
            lblPatientsWaitingIcon.Name = "lblPatientsWaitingIcon";
            lblPatientsWaitingIcon.Size = new Size(200, 100);
            lblPatientsWaitingIcon.TabIndex = 0;
            lblPatientsWaitingIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmergenciesLabel
            // 
            lblEmergenciesLabel.AutoSize = true;
            lblEmergenciesLabel.Font = new Font("Segoe UI", 9.5F);
            lblEmergenciesLabel.ForeColor = Color.FromArgb(120, 120, 120);
            lblEmergenciesLabel.Location = new Point(72, 68);
            lblEmergenciesLabel.Name = "lblEmergenciesLabel";
            lblEmergenciesLabel.Size = new Size(98, 21);
            lblEmergenciesLabel.TabIndex = 2;
            lblEmergenciesLabel.Text = "Emergencies";
            // 
            // lblEmergenciesValue
            // 
            lblEmergenciesValue.AutoSize = true;
            lblEmergenciesValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblEmergenciesValue.ForeColor = Color.FromArgb(211, 47, 47);
            lblEmergenciesValue.Location = new Point(72, 18);
            lblEmergenciesValue.Name = "lblEmergenciesValue";
            lblEmergenciesValue.Size = new Size(43, 50);
            lblEmergenciesValue.TabIndex = 1;
            lblEmergenciesValue.Text = "0";
            // 
            // pnlEmergenciesIconHost
            // 
            pnlEmergenciesIconHost.BackColor = Color.FromArgb(240, 242, 245);
            pnlEmergenciesIconHost.Controls.Add(lblEmergenciesIcon);
            pnlEmergenciesIconHost.Location = new Point(0, 0);
            pnlEmergenciesIconHost.Name = "pnlEmergenciesIconHost";
            pnlEmergenciesIconHost.Size = new Size(200, 100);
            pnlEmergenciesIconHost.TabIndex = 0;
            // 
            // lblEmergenciesIcon
            // 
            lblEmergenciesIcon.Dock = DockStyle.Fill;
            lblEmergenciesIcon.Location = new Point(0, 0);
            lblEmergenciesIcon.Name = "lblEmergenciesIcon";
            lblEmergenciesIcon.Size = new Size(200, 100);
            lblEmergenciesIcon.TabIndex = 0;
            lblEmergenciesIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAvgWaitTimeLabel
            // 
            lblAvgWaitTimeLabel.AutoSize = true;
            lblAvgWaitTimeLabel.Font = new Font("Segoe UI", 9.5F);
            lblAvgWaitTimeLabel.ForeColor = Color.FromArgb(120, 120, 120);
            lblAvgWaitTimeLabel.Location = new Point(72, 68);
            lblAvgWaitTimeLabel.Name = "lblAvgWaitTimeLabel";
            lblAvgWaitTimeLabel.Size = new Size(113, 21);
            lblAvgWaitTimeLabel.TabIndex = 2;
            lblAvgWaitTimeLabel.Text = "Avg. Wait Time";
            // 
            // lblAvgWaitTimeValue
            // 
            lblAvgWaitTimeValue.AutoSize = true;
            lblAvgWaitTimeValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblAvgWaitTimeValue.ForeColor = Color.FromArgb(30, 30, 30);
            lblAvgWaitTimeValue.Location = new Point(72, 18);
            lblAvgWaitTimeValue.Name = "lblAvgWaitTimeValue";
            lblAvgWaitTimeValue.Size = new Size(141, 50);
            lblAvgWaitTimeValue.TabIndex = 1;
            lblAvgWaitTimeValue.Text = "14 min";
            // 
            // pnlAvgWaitIconHost
            // 
            pnlAvgWaitIconHost.BackColor = Color.FromArgb(240, 242, 245);
            pnlAvgWaitIconHost.Controls.Add(lblAvgWaitTimeIcon);
            pnlAvgWaitIconHost.Location = new Point(0, 0);
            pnlAvgWaitIconHost.Name = "pnlAvgWaitIconHost";
            pnlAvgWaitIconHost.Size = new Size(200, 100);
            pnlAvgWaitIconHost.TabIndex = 0;
            // 
            // lblAvgWaitTimeIcon
            // 
            lblAvgWaitTimeIcon.Dock = DockStyle.Fill;
            lblAvgWaitTimeIcon.Location = new Point(0, 0);
            lblAvgWaitTimeIcon.Name = "lblAvgWaitTimeIcon";
            lblAvgWaitTimeIcon.Size = new Size(200, 100);
            lblAvgWaitTimeIcon.TabIndex = 0;
            lblAvgWaitTimeIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentTimeLabel
            // 
            lblCurrentTimeLabel.AutoSize = true;
            lblCurrentTimeLabel.Font = new Font("Segoe UI", 9.5F);
            lblCurrentTimeLabel.ForeColor = Color.FromArgb(120, 120, 120);
            lblCurrentTimeLabel.Location = new Point(72, 68);
            lblCurrentTimeLabel.Name = "lblCurrentTimeLabel";
            lblCurrentTimeLabel.Size = new Size(101, 21);
            lblCurrentTimeLabel.TabIndex = 2;
            lblCurrentTimeLabel.Text = "Current Time";
            // 
            // lblCurrentTimeValue
            // 
            lblCurrentTimeValue.AutoSize = true;
            lblCurrentTimeValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblCurrentTimeValue.ForeColor = Color.FromArgb(30, 30, 30);
            lblCurrentTimeValue.Location = new Point(72, 18);
            lblCurrentTimeValue.Name = "lblCurrentTimeValue";
            lblCurrentTimeValue.Size = new Size(187, 50);
            lblCurrentTimeValue.TabIndex = 1;
            lblCurrentTimeValue.Text = "08:12 AM";
            // 
            // pnlCurrentTimeIconHost
            // 
            pnlCurrentTimeIconHost.BackColor = Color.FromArgb(240, 242, 245);
            pnlCurrentTimeIconHost.Controls.Add(lblCurrentTimeIcon);
            pnlCurrentTimeIconHost.Location = new Point(0, 0);
            pnlCurrentTimeIconHost.Name = "pnlCurrentTimeIconHost";
            pnlCurrentTimeIconHost.Size = new Size(200, 100);
            pnlCurrentTimeIconHost.TabIndex = 0;
            // 
            // lblCurrentTimeIcon
            // 
            lblCurrentTimeIcon.Dock = DockStyle.Fill;
            lblCurrentTimeIcon.Location = new Point(0, 0);
            lblCurrentTimeIcon.Name = "lblCurrentTimeIcon";
            lblCurrentTimeIcon.Size = new Size(200, 100);
            lblCurrentTimeIcon.TabIndex = 0;
            lblCurrentTimeIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlQueueSection
            // 
            pnlQueueSection.BackColor = Color.White;
            // create flowPatients control and legend
            flowPatients = new DoubleBufferedFlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Padding = new Padding(12)
            };

            pnlQueueSection.Controls.Add(pnlQueueContainer);
            pnlQueueSection.Controls.Add(tblQueueHeader);
            pnlQueueSection.Controls.Add(new PriorityQueueLegendPanel { Dock = DockStyle.Bottom });
            pnlQueueSection.Dock = DockStyle.Fill;
            pnlQueueSection.Location = new Point(0, 228);
            pnlQueueSection.Name = "pnlQueueSection";
            pnlQueueSection.Size = new Size(1113, 25);
            pnlQueueSection.TabIndex = 0;
            // 
            // pnlQueueContainer
            // 
            pnlQueueContainer.BackColor = Color.FromArgb(248, 249, 250);
            pnlQueueContainer.Dock = DockStyle.Fill;
            pnlQueueContainer.Location = new Point(0, 100);
            pnlQueueContainer.Name = "pnlQueueContainer";
            pnlQueueContainer.Size = new Size(1113, 400);
            pnlQueueContainer.TabIndex = 0;
            // add flowPatients to container
            pnlQueueContainer.Controls.Add(flowPatients);
            // 
            // tblQueueHeader
            // 
            tblQueueHeader.ColumnCount = 2;
            tblQueueHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblQueueHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblQueueHeader.Controls.Add(lblQueueTitle, 0, 0);
            tblQueueHeader.Controls.Add(lblQueueSubtitle, 0, 1);
            tblQueueHeader.Controls.Add(chkAutoRefresh, 1, 0);
            tblQueueHeader.Dock = DockStyle.Top;
            tblQueueHeader.Location = new Point(0, 0);
            tblQueueHeader.Name = "tblQueueHeader";
            tblQueueHeader.RowCount = 2;
            tblQueueHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblQueueHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblQueueHeader.Size = new Size(1113, 100);
            tblQueueHeader.TabIndex = 1;
            // 
            // lblQueueTitle
            // 
            lblQueueTitle.AutoSize = true;
            lblQueueTitle.Dock = DockStyle.Fill;
            lblQueueTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblQueueTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblQueueTitle.Location = new Point(3, 0);
            lblQueueTitle.Name = "lblQueueTitle";
            lblQueueTitle.Size = new Size(1087, 20);
            lblQueueTitle.TabIndex = 0;
            lblQueueTitle.Text = "Patient Queue";
            lblQueueTitle.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblQueueSubtitle
            // 
            lblQueueSubtitle.AutoSize = true;
            lblQueueSubtitle.Dock = DockStyle.Fill;
            lblQueueSubtitle.Font = new Font("Segoe UI", 9F);
            lblQueueSubtitle.ForeColor = Color.FromArgb(120, 120, 120);
            lblQueueSubtitle.Location = new Point(0, 20);
            lblQueueSubtitle.Margin = new Padding(0);
            lblQueueSubtitle.Name = "lblQueueSubtitle";
            lblQueueSubtitle.Size = new Size(1093, 80);
            lblQueueSubtitle.TabIndex = 1;
            lblQueueSubtitle.Text = "Ordered by urgency score...";
            lblQueueSubtitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chkAutoRefresh
            // 
            chkAutoRefresh.AutoSize = true;
            chkAutoRefresh.CheckAlign = ContentAlignment.MiddleRight;
            chkAutoRefresh.Checked = true;
            chkAutoRefresh.CheckState = CheckState.Checked;
            chkAutoRefresh.Cursor = Cursors.Hand;
            chkAutoRefresh.Dock = DockStyle.Fill;
            chkAutoRefresh.FlatStyle = FlatStyle.Flat;
            chkAutoRefresh.ForeColor = Color.FromArgb(100, 100, 100);
            chkAutoRefresh.Location = new Point(1093, 0);
            chkAutoRefresh.Margin = new Padding(0);
            chkAutoRefresh.Name = "chkAutoRefresh";
            tblQueueHeader.SetRowSpan(chkAutoRefresh, 2);
            chkAutoRefresh.Size = new Size(20, 100);
            chkAutoRefresh.TabIndex = 2;
            chkAutoRefresh.Text = "Auto-refresh: ON";
            chkAutoRefresh.TextAlign = ContentAlignment.MiddleRight;
            chkAutoRefresh.UseVisualStyleBackColor = false;
            chkAutoRefresh.CheckedChanged += ChkAutoRefresh_CheckedChanged;
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += TimerClock_Tick;
            // 
            // timerAutoRefresh
            // 
            timerAutoRefresh.Enabled = true;
            timerAutoRefresh.Interval = 5000;
            timerAutoRefresh.Tick += TimerAutoRefresh_Tick;
            // 
            // QueueForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 253);
            Controls.Add(pnlQueueSection);
            Controls.Add(pnlStats);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            Name = "QueueForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Reception - Queue Management";
            WindowState = FormWindowState.Maximized;
            Load += QueueForm_Load;
            Resize += QueueForm_Resize;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlStats.ResumeLayout(false);
            pnlPatientsIconHost.ResumeLayout(false);
            pnlEmergenciesIconHost.ResumeLayout(false);
            pnlAvgWaitIconHost.ResumeLayout(false);
            pnlCurrentTimeIconHost.ResumeLayout(false);
            pnlQueueSection.ResumeLayout(false);
            tblQueueHeader.ResumeLayout(false);
            tblQueueHeader.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnEmergency;
        private Panel pnlStats;
        private TableLayoutPanel tableStats;
        private StatCardPanel cardPatientsWaiting;
        private Panel pnlPatientsIconHost;
        private Label lblPatientsWaitingIcon;
        private Label lblPatientsWaitingValue;
        private Label lblPatientsWaitingLabel;
        private StatCardPanel cardEmergencies;
        private Panel pnlEmergenciesIconHost;
        private Label lblEmergenciesIcon;
        private Label lblEmergenciesValue;
        private Label lblEmergenciesLabel;
        private StatCardPanel cardAvgWaitTime;
        private Panel pnlAvgWaitIconHost;
        private Label lblAvgWaitTimeIcon;
        private Label lblAvgWaitTimeValue;
        private Label lblAvgWaitTimeLabel;
        private StatCardPanel cardCurrentTime;
        private Panel pnlCurrentTimeIconHost;
        private Label lblCurrentTimeIcon;
        private Label lblCurrentTimeValue;
        private Label lblCurrentTimeLabel;
        private Panel pnlQueueSection;
        private PriorityQueueLegendPanel pnlPriorityLegend;
        private TableLayoutPanel tblQueueHeader;
        private Label lblQueueTitle;
        private Label lblQueueSubtitle;
        private CheckBox chkAutoRefresh;
        private Panel pnlQueueContainer;
        private DoubleBufferedFlowLayoutPanel flowPatients;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Timer timerAutoRefresh;
    }
}
