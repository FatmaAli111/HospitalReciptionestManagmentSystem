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
            cardPatientsWaiting = new StatCardPanel();
            lblPatientsWaitingLabel = new Label();
            lblPatientsWaitingValue = new Label();
            pnlPatientsIconHost = new Panel();
            lblPatientsWaitingIcon = new Label();
            lblPatientsWaitingValue = new Label();
            lblPatientsWaitingLabel = new Label();
            cardEmergencies = new StatCardPanel();
            lblEmergenciesLabel = new Label();
            lblEmergenciesValue = new Label();
            pnlEmergenciesIconHost = new Panel();
            lblEmergenciesIcon = new Label();
            lblEmergenciesValue = new Label();
            lblEmergenciesLabel = new Label();
            cardAvgWaitTime = new StatCardPanel();
            lblAvgWaitTimeLabel = new Label();
            lblAvgWaitTimeValue = new Label();
            pnlAvgWaitIconHost = new Panel();
            lblAvgWaitTimeIcon = new Label();
            lblAvgWaitTimeValue = new Label();
            lblAvgWaitTimeLabel = new Label();
            cardCurrentTime = new StatCardPanel();
            lblCurrentTimeLabel = new Label();
            lblCurrentTimeValue = new Label();
            pnlCurrentTimeIconHost = new Panel();
            lblCurrentTimeIcon = new Label();
            lblCurrentTimeValue = new Label();
            lblCurrentTimeLabel = new Label();
            pnlQueueSection = new Panel();
            pnlPriorityLegend = new PriorityQueueLegendPanel();
            pnlQueueContainer = new Panel();
            flowPatients = new DoubleBufferedFlowLayoutPanel();
            pnlPriorityLegend = new PriorityQueueLegendPanel();
            tblQueueHeader = new TableLayoutPanel();
            lblQueueTitle = new Label();
            lblQueueSubtitle = new Label();
            chkAutoRefresh = new CheckBox();
            timerClock = new System.Windows.Forms.Timer(components);
            timerAutoRefresh = new System.Windows.Forms.Timer(components);
            pnlHeader.SuspendLayout();
            pnlStats.SuspendLayout();
            tableStats.SuspendLayout();
            cardPatientsWaiting.SuspendLayout();
            pnlPatientsIconHost.SuspendLayout();
            cardEmergencies.SuspendLayout();
            pnlEmergenciesIconHost.SuspendLayout();
            cardAvgWaitTime.SuspendLayout();
            pnlAvgWaitIconHost.SuspendLayout();
            cardCurrentTime.SuspendLayout();
            pnlCurrentTimeIconHost.SuspendLayout();
            pnlQueueSection.SuspendLayout();
            pnlPriorityLegend.SuspendLayout();
            pnlQueueContainer.SuspendLayout();
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
            pnlHeader.Size = new Size(1200, 128);
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
            btnEmergency.Name = "btnEmergency";
            btnEmergency.TabIndex = 0;
            btnEmergency.Text = "🚨  Emergency Patient";
            btnEmergency.UseVisualStyleBackColor = false;
            //
            // lblSubtitle
            //
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 120, 120);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Priority-based dynamic patient queue";
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Queue Management";
            //
            // pnlStats
            //
            pnlStats.BackColor = Color.FromArgb(248, 249, 250);
            pnlStats.Controls.Add(tableStats);
            pnlStats.Dock = DockStyle.Top;
            pnlStats.Name = "pnlStats";
            pnlStats.TabIndex = 1;
            //
            // tableStats
            //
            tableStats.ColumnCount = 4;
            tableStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableStats.Controls.Add(cardPatientsWaiting, 0, 0);
            tableStats.Controls.Add(cardEmergencies, 1, 0);
            tableStats.Controls.Add(cardAvgWaitTime, 2, 0);
            tableStats.Controls.Add(cardCurrentTime, 3, 0);
            tableStats.Dock = DockStyle.Fill;
            tableStats.Margin = new Padding(0);
            tableStats.Name = "tableStats";
            tableStats.RowCount = 1;
            tableStats.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableStats.TabIndex = 0;
            //
            // cardPatientsWaiting
            //
            cardPatientsWaiting.BackColor = Color.FromArgb(255, 255, 255);
            cardPatientsWaiting.Controls.Add(lblPatientsWaitingLabel);
            cardPatientsWaiting.Controls.Add(lblPatientsWaitingValue);
            cardPatientsWaiting.Controls.Add(pnlPatientsIconHost);
            cardPatientsWaiting.Dock = DockStyle.Fill;
            cardPatientsWaiting.Name = "cardPatientsWaiting";
            cardPatientsWaiting.TabIndex = 0;
            //
            // lblPatientsWaitingLabel
            // 
            lblPatientsWaitingLabel.AutoSize = true;
            lblPatientsWaitingLabel.Font = new Font("Segoe UI", 9.5F);
            lblPatientsWaitingLabel.ForeColor = Color.FromArgb(120, 120, 120);
            lblPatientsWaitingLabel.Location = new Point(63, 51);
            lblPatientsWaitingLabel.Name = "lblPatientsWaitingLabel";
            lblPatientsWaitingLabel.Size = new Size(100, 17);
            lblPatientsWaitingLabel.TabIndex = 2;
            lblPatientsWaitingLabel.Text = "Patients Waiting";
            // 
            // lblPatientsWaitingValue
            // 
            lblPatientsWaitingValue.AutoSize = true;
            lblPatientsWaitingValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblPatientsWaitingValue.ForeColor = Color.FromArgb(30, 30, 30);
            lblPatientsWaitingValue.Location = new Point(63, 14);
            lblPatientsWaitingValue.Name = "lblPatientsWaitingValue";
            lblPatientsWaitingValue.Size = new Size(35, 41);
            lblPatientsWaitingValue.TabIndex = 1;
            lblPatientsWaitingValue.Text = "2";
            // 
            // pnlPatientsIconHost
            //
            pnlPatientsIconHost.BackColor = Color.FromArgb(240, 242, 245);
            pnlPatientsIconHost.Controls.Add(lblPatientsWaitingIcon);
            pnlPatientsIconHost.Name = "pnlPatientsIconHost";
            pnlPatientsIconHost.TabIndex = 0;
            //
            // lblPatientsWaitingIcon
            //
            lblPatientsWaitingIcon.Dock = DockStyle.Fill;
            lblPatientsWaitingIcon.Location = new Point(0, 0);
            lblPatientsWaitingIcon.Name = "lblPatientsWaitingIcon";
            lblPatientsWaitingIcon.TabIndex = 0;
            lblPatientsWaitingIcon.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblPatientsWaitingValue
            //
            lblPatientsWaitingValue.AutoSize = true;
            lblPatientsWaitingValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblPatientsWaitingValue.ForeColor = Color.FromArgb(30, 30, 30);
            lblPatientsWaitingValue.Location = new Point(72, 18);
            lblPatientsWaitingValue.Name = "lblPatientsWaitingValue";
            lblPatientsWaitingValue.Size = new Size(42, 50);
            lblPatientsWaitingValue.TabIndex = 1;
            lblPatientsWaitingValue.Text = "2";
            //
            // lblPatientsWaitingLabel
            //
            lblPatientsWaitingLabel.AutoSize = true;
            lblPatientsWaitingLabel.Font = new Font("Segoe UI", 9.5F);
            lblPatientsWaitingLabel.ForeColor = Color.FromArgb(120, 120, 120);
            lblPatientsWaitingLabel.Location = new Point(72, 68);
            lblPatientsWaitingLabel.Name = "lblPatientsWaitingLabel";
            lblPatientsWaitingLabel.Size = new Size(120, 21);
            lblPatientsWaitingLabel.TabIndex = 2;
            lblPatientsWaitingLabel.Text = "Patients Waiting";
            //
            // cardEmergencies
            //
            cardEmergencies.BackColor = Color.FromArgb(255, 255, 255);
            cardEmergencies.Controls.Add(lblEmergenciesLabel);
            cardEmergencies.Controls.Add(lblEmergenciesValue);
            cardEmergencies.Controls.Add(pnlEmergenciesIconHost);
            cardEmergencies.Dock = DockStyle.Fill;
            cardEmergencies.Name = "cardEmergencies";
            cardEmergencies.TabIndex = 1;
            //
            // lblEmergenciesLabel
            // 
            lblEmergenciesLabel.AutoSize = true;
            lblEmergenciesLabel.Font = new Font("Segoe UI", 9.5F);
            lblEmergenciesLabel.ForeColor = Color.FromArgb(120, 120, 120);
            lblEmergenciesLabel.Location = new Point(63, 51);
            lblEmergenciesLabel.Name = "lblEmergenciesLabel";
            lblEmergenciesLabel.Size = new Size(82, 17);
            lblEmergenciesLabel.TabIndex = 2;
            lblEmergenciesLabel.Text = "Emergencies";
            // 
            // lblEmergenciesValue
            // 
            lblEmergenciesValue.AutoSize = true;
            lblEmergenciesValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblEmergenciesValue.ForeColor = Color.FromArgb(211, 47, 47);
            lblEmergenciesValue.Location = new Point(63, 14);
            lblEmergenciesValue.Name = "lblEmergenciesValue";
            lblEmergenciesValue.Size = new Size(35, 41);
            lblEmergenciesValue.TabIndex = 1;
            lblEmergenciesValue.Text = "0";
            // 
            // pnlEmergenciesIconHost
            //
            pnlEmergenciesIconHost.BackColor = Color.FromArgb(240, 242, 245);
            pnlEmergenciesIconHost.Controls.Add(lblEmergenciesIcon);
            pnlEmergenciesIconHost.Name = "pnlEmergenciesIconHost";
            pnlEmergenciesIconHost.TabIndex = 0;
            //
            // lblEmergenciesIcon
            //
            lblEmergenciesIcon.Dock = DockStyle.Fill;
            lblEmergenciesIcon.Location = new Point(0, 0);
            lblEmergenciesIcon.Name = "lblEmergenciesIcon";
            lblEmergenciesIcon.TabIndex = 0;
            lblEmergenciesIcon.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblEmergenciesValue
            //
            lblEmergenciesValue.AutoSize = true;
            lblEmergenciesValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblEmergenciesValue.ForeColor = QueueTheme.EmergencyRed;
            lblEmergenciesValue.Location = new Point(72, 18);
            lblEmergenciesValue.Name = "lblEmergenciesValue";
            lblEmergenciesValue.Size = new Size(42, 50);
            lblEmergenciesValue.TabIndex = 1;
            lblEmergenciesValue.Text = "0";
            //
            // lblEmergenciesLabel
            //
            lblEmergenciesLabel.AutoSize = true;
            lblEmergenciesLabel.Font = new Font("Segoe UI", 9.5F);
            lblEmergenciesLabel.ForeColor = Color.FromArgb(120, 120, 120);
            lblEmergenciesLabel.Location = new Point(72, 68);
            lblEmergenciesLabel.Name = "lblEmergenciesLabel";
            lblEmergenciesLabel.Size = new Size(95, 21);
            lblEmergenciesLabel.TabIndex = 2;
            lblEmergenciesLabel.Text = "Emergencies";
            //
            // cardAvgWaitTime
            //
            cardAvgWaitTime.BackColor = Color.FromArgb(255, 255, 255);
            cardAvgWaitTime.Controls.Add(lblAvgWaitTimeLabel);
            cardAvgWaitTime.Controls.Add(lblAvgWaitTimeValue);
            cardAvgWaitTime.Controls.Add(pnlAvgWaitIconHost);
            cardAvgWaitTime.Dock = DockStyle.Fill;
            cardAvgWaitTime.Name = "cardAvgWaitTime";
            cardAvgWaitTime.TabIndex = 2;
            //
            // lblAvgWaitTimeLabel
            // 
            lblAvgWaitTimeLabel.AutoSize = true;
            lblAvgWaitTimeLabel.Font = new Font("Segoe UI", 9.5F);
            lblAvgWaitTimeLabel.ForeColor = Color.FromArgb(120, 120, 120);
            lblAvgWaitTimeLabel.Location = new Point(63, 51);
            lblAvgWaitTimeLabel.Name = "lblAvgWaitTimeLabel";
            lblAvgWaitTimeLabel.Size = new Size(94, 17);
            lblAvgWaitTimeLabel.TabIndex = 2;
            lblAvgWaitTimeLabel.Text = "Avg. Wait Time";
            // 
            // lblAvgWaitTimeValue
            // 
            lblAvgWaitTimeValue.AutoSize = true;
            lblAvgWaitTimeValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblAvgWaitTimeValue.ForeColor = Color.FromArgb(30, 30, 30);
            lblAvgWaitTimeValue.Location = new Point(63, 14);
            lblAvgWaitTimeValue.Name = "lblAvgWaitTimeValue";
            lblAvgWaitTimeValue.Size = new Size(114, 41);
            lblAvgWaitTimeValue.TabIndex = 1;
            lblAvgWaitTimeValue.Text = "14 min";
            // 
            // pnlAvgWaitIconHost
            //
            pnlAvgWaitIconHost.BackColor = Color.FromArgb(240, 242, 245);
            pnlAvgWaitIconHost.Controls.Add(lblAvgWaitTimeIcon);
            pnlAvgWaitIconHost.Name = "pnlAvgWaitIconHost";
            pnlAvgWaitIconHost.TabIndex = 0;
            //
            // lblAvgWaitTimeIcon
            //
            lblAvgWaitTimeIcon.Dock = DockStyle.Fill;
            lblAvgWaitTimeIcon.Location = new Point(0, 0);
            lblAvgWaitTimeIcon.Name = "lblAvgWaitTimeIcon";
            lblAvgWaitTimeIcon.TabIndex = 0;
            lblAvgWaitTimeIcon.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblAvgWaitTimeValue
            //
            lblAvgWaitTimeValue.AutoSize = true;
            lblAvgWaitTimeValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblAvgWaitTimeValue.ForeColor = Color.FromArgb(30, 30, 30);
            lblAvgWaitTimeValue.Location = new Point(72, 18);
            lblAvgWaitTimeValue.Name = "lblAvgWaitTimeValue";
            lblAvgWaitTimeValue.Size = new Size(80, 50);
            lblAvgWaitTimeValue.TabIndex = 1;
            lblAvgWaitTimeValue.Text = "14 min";
            //
            // lblAvgWaitTimeLabel
            //
            lblAvgWaitTimeLabel.AutoSize = true;
            lblAvgWaitTimeLabel.Font = new Font("Segoe UI", 9.5F);
            lblAvgWaitTimeLabel.ForeColor = Color.FromArgb(120, 120, 120);
            lblAvgWaitTimeLabel.Location = new Point(72, 68);
            lblAvgWaitTimeLabel.Name = "lblAvgWaitTimeLabel";
            lblAvgWaitTimeLabel.Size = new Size(118, 21);
            lblAvgWaitTimeLabel.TabIndex = 2;
            lblAvgWaitTimeLabel.Text = "Avg. Wait Time";
            //
            // cardCurrentTime
            //
            cardCurrentTime.BackColor = Color.FromArgb(255, 255, 255);
            cardCurrentTime.Controls.Add(lblCurrentTimeLabel);
            cardCurrentTime.Controls.Add(lblCurrentTimeValue);
            cardCurrentTime.Controls.Add(pnlCurrentTimeIconHost);
            cardCurrentTime.Dock = DockStyle.Fill;
            cardCurrentTime.Margin = new Padding(0);
            cardCurrentTime.Name = "cardCurrentTime";
            cardCurrentTime.TabIndex = 3;
            //
            // lblCurrentTimeLabel
            // 
            lblCurrentTimeLabel.AutoSize = true;
            lblCurrentTimeLabel.Font = new Font("Segoe UI", 9.5F);
            lblCurrentTimeLabel.ForeColor = Color.FromArgb(120, 120, 120);
            lblCurrentTimeLabel.Location = new Point(63, 51);
            lblCurrentTimeLabel.Name = "lblCurrentTimeLabel";
            lblCurrentTimeLabel.Size = new Size(83, 17);
            lblCurrentTimeLabel.TabIndex = 2;
            lblCurrentTimeLabel.Text = "Current Time";
            // 
            // lblCurrentTimeValue
            // 
            lblCurrentTimeValue.AutoSize = true;
            lblCurrentTimeValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblCurrentTimeValue.ForeColor = Color.FromArgb(30, 30, 30);
            lblCurrentTimeValue.Location = new Point(63, 14);
            lblCurrentTimeValue.Name = "lblCurrentTimeValue";
            lblCurrentTimeValue.Size = new Size(152, 41);
            lblCurrentTimeValue.TabIndex = 1;
            lblCurrentTimeValue.Text = "08:12 AM";
            // 
            // pnlCurrentTimeIconHost
            //
            pnlCurrentTimeIconHost.BackColor = Color.FromArgb(240, 242, 245);
            pnlCurrentTimeIconHost.Controls.Add(lblCurrentTimeIcon);
            pnlCurrentTimeIconHost.Name = "pnlCurrentTimeIconHost";
            pnlCurrentTimeIconHost.TabIndex = 0;
            //
            // lblCurrentTimeIcon
            //
            lblCurrentTimeIcon.Dock = DockStyle.Fill;
            lblCurrentTimeIcon.Location = new Point(0, 0);
            lblCurrentTimeIcon.Name = "lblCurrentTimeIcon";
            lblCurrentTimeIcon.TabIndex = 0;
            lblCurrentTimeIcon.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblCurrentTimeValue
            //
            lblCurrentTimeValue.AutoSize = true;
            lblCurrentTimeValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblCurrentTimeValue.ForeColor = Color.FromArgb(30, 30, 30);
            lblCurrentTimeValue.Location = new Point(72, 18);
            lblCurrentTimeValue.Name = "lblCurrentTimeValue";
            lblCurrentTimeValue.Size = new Size(180, 50);
            lblCurrentTimeValue.TabIndex = 1;
            lblCurrentTimeValue.Text = "08:12 AM";
            //
            // lblCurrentTimeLabel
            //
            lblCurrentTimeLabel.AutoSize = true;
            lblCurrentTimeLabel.Font = new Font("Segoe UI", 9.5F);
            lblCurrentTimeLabel.ForeColor = Color.FromArgb(120, 120, 120);
            lblCurrentTimeLabel.Location = new Point(72, 68);
            lblCurrentTimeLabel.Name = "lblCurrentTimeLabel";
            lblCurrentTimeLabel.Size = new Size(99, 21);
            lblCurrentTimeLabel.TabIndex = 2;
            lblCurrentTimeLabel.Text = "Current Time";
            //
            // pnlQueueSection
            //
            pnlQueueSection.BackColor = Color.White;
            pnlQueueSection.Controls.Add(pnlQueueContainer);
            pnlQueueSection.Controls.Add(pnlPriorityLegend);
            pnlQueueSection.Controls.Add(tblQueueHeader);
            pnlQueueSection.Dock = DockStyle.Fill;
            pnlQueueSection.Name = "pnlQueueSection";
            pnlQueueSection.TabIndex = 0;
            //
            // pnlPriorityLegend
            //
            pnlPriorityLegend.Dock = DockStyle.Bottom;
            pnlPriorityLegend.Location = new Point(34, 348);
            pnlPriorityLegend.Margin = new Padding(0, 12, 0, 0);
            pnlPriorityLegend.Name = "pnlPriorityLegend";
            pnlPriorityLegend.Size = new Size(1132, 136);
            pnlPriorityLegend.TabIndex = 2;
            //
            // pnlQueueContainer
            //
            pnlQueueContainer.BackColor = Color.FromArgb(248, 249, 250);
            pnlQueueContainer.Controls.Add(flowPatients);
            pnlQueueContainer.Dock = DockStyle.Fill;
            pnlQueueContainer.Name = "pnlQueueContainer";
            pnlQueueContainer.TabIndex = 0;
            //
            // flowPatients
            //
            flowPatients.AutoScroll = true;
            flowPatients.BackColor = Color.FromArgb(248, 249, 250);
            flowPatients.Dock = DockStyle.Fill;
            flowPatients.FlowDirection = FlowDirection.TopDown;
            flowPatients.Name = "flowPatients";
            flowPatients.TabIndex = 0;
            flowPatients.WrapContents = false;
            flowPatients.SizeChanged += FlowPatients_SizeChanged;
            //
            // pnlPriorityLegend
            // 
            pnlPriorityLegend.BackColor = Color.FromArgb(255, 255, 255);
            pnlPriorityLegend.Dock = DockStyle.Bottom;
            pnlPriorityLegend.Location = new Point(30, 226);
            pnlPriorityLegend.Margin = new Padding(0, 9, 0, 0);
            pnlPriorityLegend.Name = "pnlPriorityLegend";
            pnlPriorityLegend.Padding = new Padding(16, 9, 16, 10);
            pnlPriorityLegend.Size = new Size(990, 102);
            pnlPriorityLegend.TabIndex = 2;
            // 
            // tblQueueHeader
            //
            tblQueueHeader.ColumnCount = 2;
            tblQueueHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblQueueHeader.Controls.Add(lblQueueTitle, 0, 0);
            tblQueueHeader.Controls.Add(lblQueueSubtitle, 0, 1);
            tblQueueHeader.Controls.Add(chkAutoRefresh, 1, 0);
            tblQueueHeader.SetRowSpan(chkAutoRefresh, 2);
            tblQueueHeader.Dock = DockStyle.Top;
            tblQueueHeader.Name = "tblQueueHeader";
            tblQueueHeader.RowCount = 2;
            tblQueueHeader.TabIndex = 1;
            //
            // lblQueueTitle
            //
            lblQueueTitle.AutoSize = true;
            lblQueueTitle.Dock = DockStyle.Fill;
            lblQueueTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblQueueTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblQueueTitle.Location = new Point(0, 0);
            lblQueueTitle.Name = "lblQueueTitle";
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
            lblQueueSubtitle.Margin = new Padding(0);
            lblQueueSubtitle.Name = "lblQueueSubtitle";
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
            chkAutoRefresh.Location = new Point(815, 0);
            chkAutoRefresh.Margin = new Padding(0);
            chkAutoRefresh.Name = "chkAutoRefresh";
            chkAutoRefresh.TabIndex = 2;
            chkAutoRefresh.Text = "Auto-refresh: ON";
            chkAutoRefresh.TextAlign = ContentAlignment.MiddleRight;
            chkAutoRefresh.CheckAlign = ContentAlignment.MiddleRight;
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
            AutoScaleMode = AutoScaleMode.Font;
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
            tableStats.ResumeLayout(false);
            cardPatientsWaiting.ResumeLayout(false);
            cardPatientsWaiting.PerformLayout();
            pnlPatientsIconHost.ResumeLayout(false);
            cardEmergencies.ResumeLayout(false);
            cardEmergencies.PerformLayout();
            pnlEmergenciesIconHost.ResumeLayout(false);
            cardAvgWaitTime.ResumeLayout(false);
            cardAvgWaitTime.PerformLayout();
            pnlAvgWaitIconHost.ResumeLayout(false);
            cardCurrentTime.ResumeLayout(false);
            cardCurrentTime.PerformLayout();
            pnlCurrentTimeIconHost.ResumeLayout(false);
            pnlQueueSection.ResumeLayout(false);
            pnlPriorityLegend.ResumeLayout(false);
            pnlQueueContainer.ResumeLayout(false);
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
