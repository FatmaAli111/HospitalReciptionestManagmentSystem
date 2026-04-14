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
            cardEmergencies = new StatCardPanel();
            lblEmergenciesLabel = new Label();
            lblEmergenciesValue = new Label();
            pnlEmergenciesIconHost = new Panel();
            lblEmergenciesIcon = new Label();
            cardAvgWaitTime = new StatCardPanel();
            lblAvgWaitTimeLabel = new Label();
            lblAvgWaitTimeValue = new Label();
            pnlAvgWaitIconHost = new Panel();
            lblAvgWaitTimeIcon = new Label();
            cardCurrentTime = new StatCardPanel();
            lblCurrentTimeLabel = new Label();
            lblCurrentTimeValue = new Label();
            pnlCurrentTimeIconHost = new Panel();
            lblCurrentTimeIcon = new Label();
            pnlQueueSection = new Panel();
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
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(30, 27, 30, 21);
            pnlHeader.Size = new Size(1050, 96);
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
            btnEmergency.Location = new Point(828, 33);
            btnEmergency.Name = "btnEmergency";
            btnEmergency.Size = new Size(192, 36);
            btnEmergency.TabIndex = 0;
            btnEmergency.Text = "🚨  Emergency Patient";
            btnEmergency.UseVisualStyleBackColor = false;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 120, 120);
            lblSubtitle.Location = new Point(30, 58);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(239, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Priority-based dynamic patient queue";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(30, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(304, 41);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Queue Management";
            // 
            // pnlStats
            // 
            pnlStats.BackColor = Color.FromArgb(248, 249, 250);
            pnlStats.Controls.Add(tableStats);
            pnlStats.Dock = DockStyle.Top;
            pnlStats.Location = new Point(0, 96);
            pnlStats.Name = "pnlStats";
            pnlStats.Padding = new Padding(30, 15, 30, 15);
            pnlStats.Size = new Size(1050, 117);
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
            tableStats.Location = new Point(30, 15);
            tableStats.Margin = new Padding(0);
            tableStats.Name = "tableStats";
            tableStats.RowCount = 1;
            tableStats.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableStats.Size = new Size(990, 87);
            tableStats.TabIndex = 0;
            // 
            // cardPatientsWaiting
            // 
            cardPatientsWaiting.BackColor = Color.FromArgb(255, 255, 255);
            cardPatientsWaiting.Controls.Add(lblPatientsWaitingLabel);
            cardPatientsWaiting.Controls.Add(lblPatientsWaitingValue);
            cardPatientsWaiting.Controls.Add(pnlPatientsIconHost);
            cardPatientsWaiting.Dock = DockStyle.Fill;
            cardPatientsWaiting.Location = new Point(0, 0);
            cardPatientsWaiting.Margin = new Padding(0, 0, 9, 0);
            cardPatientsWaiting.Name = "cardPatientsWaiting";
            cardPatientsWaiting.Padding = new Padding(12, 9, 12, 9);
            cardPatientsWaiting.Size = new Size(238, 87);
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
            pnlPatientsIconHost.Location = new Point(12, 16);
            pnlPatientsIconHost.Margin = new Padding(3, 2, 3, 2);
            pnlPatientsIconHost.Name = "pnlPatientsIconHost";
            pnlPatientsIconHost.Size = new Size(42, 36);
            pnlPatientsIconHost.TabIndex = 0;
            // 
            // lblPatientsWaitingIcon
            // 
            lblPatientsWaitingIcon.Dock = DockStyle.Fill;
            lblPatientsWaitingIcon.Font = new Font("Segoe MDL2 Assets", 20F);
            lblPatientsWaitingIcon.ForeColor = Color.FromArgb(0, 86, 179);
            lblPatientsWaitingIcon.Location = new Point(0, 0);
            lblPatientsWaitingIcon.Name = "lblPatientsWaitingIcon";
            lblPatientsWaitingIcon.Size = new Size(42, 36);
            lblPatientsWaitingIcon.TabIndex = 0;
            lblPatientsWaitingIcon.Text = "";
            lblPatientsWaitingIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardEmergencies
            // 
            cardEmergencies.BackColor = Color.FromArgb(255, 255, 255);
            cardEmergencies.Controls.Add(lblEmergenciesLabel);
            cardEmergencies.Controls.Add(lblEmergenciesValue);
            cardEmergencies.Controls.Add(pnlEmergenciesIconHost);
            cardEmergencies.Dock = DockStyle.Fill;
            cardEmergencies.Location = new Point(247, 0);
            cardEmergencies.Margin = new Padding(0, 0, 9, 0);
            cardEmergencies.Name = "cardEmergencies";
            cardEmergencies.Padding = new Padding(12, 9, 12, 9);
            cardEmergencies.Size = new Size(238, 87);
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
            pnlEmergenciesIconHost.Location = new Point(12, 16);
            pnlEmergenciesIconHost.Margin = new Padding(3, 2, 3, 2);
            pnlEmergenciesIconHost.Name = "pnlEmergenciesIconHost";
            pnlEmergenciesIconHost.Size = new Size(42, 36);
            pnlEmergenciesIconHost.TabIndex = 0;
            // 
            // lblEmergenciesIcon
            // 
            lblEmergenciesIcon.Dock = DockStyle.Fill;
            lblEmergenciesIcon.Font = new Font("Segoe MDL2 Assets", 20F);
            lblEmergenciesIcon.ForeColor = Color.FromArgb(211, 47, 47);
            lblEmergenciesIcon.Location = new Point(0, 0);
            lblEmergenciesIcon.Name = "lblEmergenciesIcon";
            lblEmergenciesIcon.Size = new Size(42, 36);
            lblEmergenciesIcon.TabIndex = 0;
            lblEmergenciesIcon.Text = "";
            lblEmergenciesIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardAvgWaitTime
            // 
            cardAvgWaitTime.BackColor = Color.FromArgb(255, 255, 255);
            cardAvgWaitTime.Controls.Add(lblAvgWaitTimeLabel);
            cardAvgWaitTime.Controls.Add(lblAvgWaitTimeValue);
            cardAvgWaitTime.Controls.Add(pnlAvgWaitIconHost);
            cardAvgWaitTime.Dock = DockStyle.Fill;
            cardAvgWaitTime.Location = new Point(494, 0);
            cardAvgWaitTime.Margin = new Padding(0, 0, 9, 0);
            cardAvgWaitTime.Name = "cardAvgWaitTime";
            cardAvgWaitTime.Padding = new Padding(12, 9, 12, 9);
            cardAvgWaitTime.Size = new Size(238, 87);
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
            pnlAvgWaitIconHost.Location = new Point(12, 16);
            pnlAvgWaitIconHost.Margin = new Padding(3, 2, 3, 2);
            pnlAvgWaitIconHost.Name = "pnlAvgWaitIconHost";
            pnlAvgWaitIconHost.Size = new Size(42, 36);
            pnlAvgWaitIconHost.TabIndex = 0;
            // 
            // lblAvgWaitTimeIcon
            // 
            lblAvgWaitTimeIcon.Dock = DockStyle.Fill;
            lblAvgWaitTimeIcon.Font = new Font("Segoe MDL2 Assets", 20F);
            lblAvgWaitTimeIcon.ForeColor = Color.FromArgb(251, 192, 45);
            lblAvgWaitTimeIcon.Location = new Point(0, 0);
            lblAvgWaitTimeIcon.Name = "lblAvgWaitTimeIcon";
            lblAvgWaitTimeIcon.Size = new Size(42, 36);
            lblAvgWaitTimeIcon.TabIndex = 0;
            lblAvgWaitTimeIcon.Text = "";
            lblAvgWaitTimeIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardCurrentTime
            // 
            cardCurrentTime.BackColor = Color.FromArgb(255, 255, 255);
            cardCurrentTime.Controls.Add(lblCurrentTimeLabel);
            cardCurrentTime.Controls.Add(lblCurrentTimeValue);
            cardCurrentTime.Controls.Add(pnlCurrentTimeIconHost);
            cardCurrentTime.Dock = DockStyle.Fill;
            cardCurrentTime.Location = new Point(741, 0);
            cardCurrentTime.Margin = new Padding(0);
            cardCurrentTime.Name = "cardCurrentTime";
            cardCurrentTime.Padding = new Padding(12, 9, 12, 9);
            cardCurrentTime.Size = new Size(249, 87);
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
            pnlCurrentTimeIconHost.Location = new Point(12, 16);
            pnlCurrentTimeIconHost.Margin = new Padding(3, 2, 3, 2);
            pnlCurrentTimeIconHost.Name = "pnlCurrentTimeIconHost";
            pnlCurrentTimeIconHost.Size = new Size(42, 36);
            pnlCurrentTimeIconHost.TabIndex = 0;
            // 
            // lblCurrentTimeIcon
            // 
            lblCurrentTimeIcon.Dock = DockStyle.Fill;
            lblCurrentTimeIcon.Font = new Font("Segoe MDL2 Assets", 20F);
            lblCurrentTimeIcon.ForeColor = Color.FromArgb(0, 86, 179);
            lblCurrentTimeIcon.Location = new Point(0, 0);
            lblCurrentTimeIcon.Name = "lblCurrentTimeIcon";
            lblCurrentTimeIcon.Size = new Size(42, 36);
            lblCurrentTimeIcon.TabIndex = 0;
            lblCurrentTimeIcon.Text = "";
            lblCurrentTimeIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlQueueSection
            // 
            pnlQueueSection.BackColor = Color.White;
            pnlQueueSection.Controls.Add(pnlQueueContainer);
            pnlQueueSection.Controls.Add(pnlPriorityLegend);
            pnlQueueSection.Controls.Add(tblQueueHeader);
            pnlQueueSection.Dock = DockStyle.Fill;
            pnlQueueSection.Location = new Point(0, 213);
            pnlQueueSection.Name = "pnlQueueSection";
            pnlQueueSection.Padding = new Padding(30, 21, 30, 21);
            pnlQueueSection.Size = new Size(1050, 349);
            pnlQueueSection.TabIndex = 0;
            // 
            // pnlQueueContainer
            // 
            pnlQueueContainer.BackColor = Color.FromArgb(248, 249, 250);
            pnlQueueContainer.Controls.Add(flowPatients);
            pnlQueueContainer.Dock = DockStyle.Fill;
            pnlQueueContainer.Location = new Point(30, 67);
            pnlQueueContainer.Name = "pnlQueueContainer";
            pnlQueueContainer.Padding = new Padding(7, 6, 7, 6);
            pnlQueueContainer.Size = new Size(990, 159);
            pnlQueueContainer.TabIndex = 0;
            // 
            // flowPatients
            // 
            flowPatients.AutoScroll = true;
            flowPatients.BackColor = Color.FromArgb(248, 249, 250);
            flowPatients.Dock = DockStyle.Fill;
            flowPatients.FlowDirection = FlowDirection.TopDown;
            flowPatients.Location = new Point(7, 6);
            flowPatients.Name = "flowPatients";
            flowPatients.Size = new Size(976, 147);
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
            tblQueueHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tblQueueHeader.Controls.Add(lblQueueTitle, 0, 0);
            tblQueueHeader.Controls.Add(lblQueueSubtitle, 0, 1);
            tblQueueHeader.Controls.Add(chkAutoRefresh, 1, 0);
            tblQueueHeader.Dock = DockStyle.Top;
            tblQueueHeader.Location = new Point(30, 21);
            tblQueueHeader.Margin = new Padding(0, 0, 0, 9);
            tblQueueHeader.Name = "tblQueueHeader";
            tblQueueHeader.RowCount = 2;
            tblQueueHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tblQueueHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblQueueHeader.Size = new Size(990, 46);
            tblQueueHeader.TabIndex = 1;
            // 
            // lblQueueTitle
            // 
            lblQueueTitle.AutoSize = true;
            lblQueueTitle.Dock = DockStyle.Fill;
            lblQueueTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblQueueTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblQueueTitle.Location = new Point(0, 0);
            lblQueueTitle.Margin = new Padding(0, 0, 0, 3);
            lblQueueTitle.Name = "lblQueueTitle";
            lblQueueTitle.Size = new Size(815, 24);
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
            lblQueueSubtitle.Location = new Point(0, 27);
            lblQueueSubtitle.Margin = new Padding(0);
            lblQueueSubtitle.Name = "lblQueueSubtitle";
            lblQueueSubtitle.Size = new Size(815, 20);
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
            chkAutoRefresh.Font = new Font("Segoe UI", 9F);
            chkAutoRefresh.ForeColor = Color.FromArgb(100, 100, 100);
            chkAutoRefresh.Location = new Point(815, 0);
            chkAutoRefresh.Margin = new Padding(0);
            chkAutoRefresh.Name = "chkAutoRefresh";
            tblQueueHeader.SetRowSpan(chkAutoRefresh, 2);
            chkAutoRefresh.Size = new Size(175, 47);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 562);
            Controls.Add(pnlQueueSection);
            Controls.Add(pnlStats);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(842, 460);
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
