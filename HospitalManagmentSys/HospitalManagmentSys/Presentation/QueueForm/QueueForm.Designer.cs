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
            pnlPatientsIconHost = new Panel();
            lblPatientsWaitingIcon = new Label();
            lblPatientsWaitingValue = new Label();
            lblPatientsWaitingLabel = new Label();
            cardEmergencies = new StatCardPanel();
            pnlEmergenciesIconHost = new Panel();
            lblEmergenciesIcon = new Label();
            lblEmergenciesValue = new Label();
            lblEmergenciesLabel = new Label();
            cardAvgWaitTime = new StatCardPanel();
            pnlAvgWaitIconHost = new Panel();
            lblAvgWaitTimeIcon = new Label();
            lblAvgWaitTimeValue = new Label();
            lblAvgWaitTimeLabel = new Label();
            cardCurrentTime = new StatCardPanel();
            pnlCurrentTimeIconHost = new Panel();
            lblCurrentTimeIcon = new Label();
            lblCurrentTimeValue = new Label();
            lblCurrentTimeLabel = new Label();
            pnlQueueSection = new Panel();
            pnlPriorityLegend = new PriorityQueueLegendPanel();
            pnlQueueContainer = new Panel();
            flowPatients = new DoubleBufferedFlowLayoutPanel();
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
            btnEmergency.Location = new Point(946, 44);
            btnEmergency.Margin = new Padding(3, 4, 3, 4);
            btnEmergency.Name = "btnEmergency";
            btnEmergency.Size = new Size(220, 48);
            btnEmergency.TabIndex = 0;
            btnEmergency.Text = "🚨  Emergency Patient";
            btnEmergency.UseVisualStyleBackColor = false;
            //
            // lblSubtitle
            //
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 120, 120);
            lblSubtitle.Location = new Point(34, 78);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(280, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Priority-based dynamic patient queue";
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(34, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(320, 50);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Queue Management";
            //
            // pnlStats
            //
            pnlStats.BackColor = Color.FromArgb(248, 249, 250);
            pnlStats.Controls.Add(tableStats);
            pnlStats.Dock = DockStyle.Top;
            pnlStats.Location = new Point(0, 128);
            pnlStats.Margin = new Padding(3, 4, 3, 4);
            pnlStats.Name = "pnlStats";
            pnlStats.Padding = new Padding(34, 20, 34, 20);
            pnlStats.Size = new Size(1200, 156);
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
            tableStats.Location = new Point(34, 20);
            tableStats.Margin = new Padding(0);
            tableStats.Name = "tableStats";
            tableStats.RowCount = 1;
            tableStats.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableStats.Size = new Size(1132, 116);
            tableStats.TabIndex = 0;
            //
            // cardPatientsWaiting
            //
            cardPatientsWaiting.Controls.Add(lblPatientsWaitingLabel);
            cardPatientsWaiting.Controls.Add(lblPatientsWaitingValue);
            cardPatientsWaiting.Controls.Add(pnlPatientsIconHost);
            cardPatientsWaiting.Dock = DockStyle.Fill;
            cardPatientsWaiting.Location = new Point(3, 3);
            cardPatientsWaiting.Margin = new Padding(0, 0, 10, 0);
            cardPatientsWaiting.Name = "cardPatientsWaiting";
            cardPatientsWaiting.Padding = new Padding(14, 12, 14, 12);
            cardPatientsWaiting.Size = new Size(273, 116);
            cardPatientsWaiting.TabIndex = 0;
            //
            // pnlPatientsIconHost
            //
            pnlPatientsIconHost.BackColor = Color.FromArgb(240, 242, 245);
            pnlPatientsIconHost.Controls.Add(lblPatientsWaitingIcon);
            pnlPatientsIconHost.Location = new Point(14, 22);
            pnlPatientsIconHost.Name = "pnlPatientsIconHost";
            pnlPatientsIconHost.Size = new Size(48, 48);
            pnlPatientsIconHost.TabIndex = 0;
            //
            // lblPatientsWaitingIcon
            //
            lblPatientsWaitingIcon.Dock = DockStyle.Fill;
            lblPatientsWaitingIcon.Font = QueueTheme.Mdl2Font(20f);
            lblPatientsWaitingIcon.ForeColor = QueueTheme.PrimaryBlue;
            lblPatientsWaitingIcon.Location = new Point(0, 0);
            lblPatientsWaitingIcon.Name = "lblPatientsWaitingIcon";
            lblPatientsWaitingIcon.Size = new Size(48, 48);
            lblPatientsWaitingIcon.TabIndex = 0;
            lblPatientsWaitingIcon.Text = "\uE716";
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
            cardEmergencies.Controls.Add(lblEmergenciesLabel);
            cardEmergencies.Controls.Add(lblEmergenciesValue);
            cardEmergencies.Controls.Add(pnlEmergenciesIconHost);
            cardEmergencies.Dock = DockStyle.Fill;
            cardEmergencies.Location = new Point(286, 3);
            cardEmergencies.Margin = new Padding(0, 0, 10, 0);
            cardEmergencies.Name = "cardEmergencies";
            cardEmergencies.Padding = new Padding(14, 12, 14, 12);
            cardEmergencies.Size = new Size(273, 116);
            cardEmergencies.TabIndex = 1;
            //
            // pnlEmergenciesIconHost
            //
            pnlEmergenciesIconHost.BackColor = Color.FromArgb(240, 242, 245);
            pnlEmergenciesIconHost.Controls.Add(lblEmergenciesIcon);
            pnlEmergenciesIconHost.Location = new Point(14, 22);
            pnlEmergenciesIconHost.Name = "pnlEmergenciesIconHost";
            pnlEmergenciesIconHost.Size = new Size(48, 48);
            pnlEmergenciesIconHost.TabIndex = 0;
            //
            // lblEmergenciesIcon
            //
            lblEmergenciesIcon.Dock = DockStyle.Fill;
            lblEmergenciesIcon.Font = QueueTheme.Mdl2Font(20f);
            lblEmergenciesIcon.ForeColor = QueueTheme.EmergencyRed;
            lblEmergenciesIcon.Location = new Point(0, 0);
            lblEmergenciesIcon.Name = "lblEmergenciesIcon";
            lblEmergenciesIcon.Size = new Size(48, 48);
            lblEmergenciesIcon.TabIndex = 0;
            lblEmergenciesIcon.Text = "\uE7BA";
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
            cardAvgWaitTime.Controls.Add(lblAvgWaitTimeLabel);
            cardAvgWaitTime.Controls.Add(lblAvgWaitTimeValue);
            cardAvgWaitTime.Controls.Add(pnlAvgWaitIconHost);
            cardAvgWaitTime.Dock = DockStyle.Fill;
            cardAvgWaitTime.Location = new Point(569, 3);
            cardAvgWaitTime.Margin = new Padding(0, 0, 10, 0);
            cardAvgWaitTime.Name = "cardAvgWaitTime";
            cardAvgWaitTime.Padding = new Padding(14, 12, 14, 12);
            cardAvgWaitTime.Size = new Size(273, 116);
            cardAvgWaitTime.TabIndex = 2;
            //
            // pnlAvgWaitIconHost
            //
            pnlAvgWaitIconHost.BackColor = Color.FromArgb(240, 242, 245);
            pnlAvgWaitIconHost.Controls.Add(lblAvgWaitTimeIcon);
            pnlAvgWaitIconHost.Location = new Point(14, 22);
            pnlAvgWaitIconHost.Name = "pnlAvgWaitIconHost";
            pnlAvgWaitIconHost.Size = new Size(48, 48);
            pnlAvgWaitIconHost.TabIndex = 0;
            //
            // lblAvgWaitTimeIcon
            //
            lblAvgWaitTimeIcon.Dock = DockStyle.Fill;
            lblAvgWaitTimeIcon.Font = QueueTheme.Mdl2Font(20f);
            lblAvgWaitTimeIcon.ForeColor = QueueTheme.AccentGold;
            lblAvgWaitTimeIcon.Location = new Point(0, 0);
            lblAvgWaitTimeIcon.Name = "lblAvgWaitTimeIcon";
            lblAvgWaitTimeIcon.Size = new Size(48, 48);
            lblAvgWaitTimeIcon.TabIndex = 0;
            lblAvgWaitTimeIcon.Text = "\uE916";
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
            cardCurrentTime.Controls.Add(lblCurrentTimeLabel);
            cardCurrentTime.Controls.Add(lblCurrentTimeValue);
            cardCurrentTime.Controls.Add(pnlCurrentTimeIconHost);
            cardCurrentTime.Dock = DockStyle.Fill;
            cardCurrentTime.Location = new Point(852, 3);
            cardCurrentTime.Margin = new Padding(0);
            cardCurrentTime.Name = "cardCurrentTime";
            cardCurrentTime.Padding = new Padding(14, 12, 14, 12);
            cardCurrentTime.Size = new Size(277, 116);
            cardCurrentTime.TabIndex = 3;
            //
            // pnlCurrentTimeIconHost
            //
            pnlCurrentTimeIconHost.BackColor = Color.FromArgb(240, 242, 245);
            pnlCurrentTimeIconHost.Controls.Add(lblCurrentTimeIcon);
            pnlCurrentTimeIconHost.Location = new Point(14, 22);
            pnlCurrentTimeIconHost.Name = "pnlCurrentTimeIconHost";
            pnlCurrentTimeIconHost.Size = new Size(48, 48);
            pnlCurrentTimeIconHost.TabIndex = 0;
            //
            // lblCurrentTimeIcon
            //
            lblCurrentTimeIcon.Dock = DockStyle.Fill;
            lblCurrentTimeIcon.Font = QueueTheme.Mdl2Font(20f);
            lblCurrentTimeIcon.ForeColor = QueueTheme.PrimaryBlue;
            lblCurrentTimeIcon.Location = new Point(0, 0);
            lblCurrentTimeIcon.Name = "lblCurrentTimeIcon";
            lblCurrentTimeIcon.Size = new Size(48, 48);
            lblCurrentTimeIcon.TabIndex = 0;
            lblCurrentTimeIcon.Text = "\uE823";
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
            pnlQueueSection.Location = new Point(0, 284);
            pnlQueueSection.Margin = new Padding(3, 4, 3, 4);
            pnlQueueSection.Name = "pnlQueueSection";
            pnlQueueSection.Padding = new Padding(34, 28, 34, 28);
            pnlQueueSection.Size = new Size(1200, 516);
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
            pnlQueueContainer.Location = new Point(34, 114);
            pnlQueueContainer.Margin = new Padding(3, 4, 3, 4);
            pnlQueueContainer.Name = "pnlQueueContainer";
            pnlQueueContainer.Padding = new Padding(8);
            pnlQueueContainer.Size = new Size(1132, 374);
            pnlQueueContainer.TabIndex = 0;
            //
            // flowPatients
            //
            flowPatients.AutoScroll = true;
            flowPatients.BackColor = Color.FromArgb(248, 249, 250);
            flowPatients.Dock = DockStyle.Fill;
            flowPatients.FlowDirection = FlowDirection.TopDown;
            flowPatients.Location = new Point(8, 8);
            flowPatients.Margin = new Padding(3, 4, 3, 4);
            flowPatients.Name = "flowPatients";
            flowPatients.Size = new Size(1116, 358);
            flowPatients.TabIndex = 0;
            flowPatients.WrapContents = false;
            flowPatients.SizeChanged += FlowPatients_SizeChanged;
            //
            // tblQueueHeader
            //
            tblQueueHeader.ColumnCount = 2;
            tblQueueHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblQueueHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tblQueueHeader.Controls.Add(lblQueueTitle, 0, 0);
            tblQueueHeader.Controls.Add(lblQueueSubtitle, 0, 1);
            tblQueueHeader.Controls.Add(chkAutoRefresh, 1, 0);
            tblQueueHeader.SetRowSpan(chkAutoRefresh, 2);
            tblQueueHeader.Dock = DockStyle.Top;
            tblQueueHeader.Location = new Point(34, 28);
            tblQueueHeader.Margin = new Padding(0, 0, 0, 12);
            tblQueueHeader.Name = "tblQueueHeader";
            tblQueueHeader.RowCount = 2;
            tblQueueHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tblQueueHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tblQueueHeader.Size = new Size(1132, 62);
            tblQueueHeader.TabIndex = 1;
            //
            // lblQueueTitle
            //
            lblQueueTitle.AutoSize = true;
            lblQueueTitle.Dock = DockStyle.Fill;
            lblQueueTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblQueueTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblQueueTitle.Location = new Point(0, 0);
            lblQueueTitle.Margin = new Padding(0, 0, 0, 4);
            lblQueueTitle.Name = "lblQueueTitle";
            lblQueueTitle.Size = new Size(932, 36);
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
            lblQueueSubtitle.Location = new Point(0, 36);
            lblQueueSubtitle.Margin = new Padding(0);
            lblQueueSubtitle.Name = "lblQueueSubtitle";
            lblQueueSubtitle.Size = new Size(932, 26);
            lblQueueSubtitle.TabIndex = 1;
            lblQueueSubtitle.Text = "Ordered by urgency score...";
            lblQueueSubtitle.TextAlign = ContentAlignment.MiddleLeft;
            //
            // chkAutoRefresh
            //
            chkAutoRefresh.AutoSize = true;
            chkAutoRefresh.Checked = true;
            chkAutoRefresh.CheckState = CheckState.Checked;
            chkAutoRefresh.Cursor = Cursors.Hand;
            chkAutoRefresh.Dock = DockStyle.Fill;
            chkAutoRefresh.FlatStyle = FlatStyle.Flat;
            chkAutoRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            chkAutoRefresh.ForeColor = Color.FromArgb(100, 100, 100);
            chkAutoRefresh.Margin = new Padding(0);
            chkAutoRefresh.Name = "chkAutoRefresh";
            chkAutoRefresh.Size = new Size(200, 62);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            Controls.Add(pnlQueueSection);
            Controls.Add(pnlStats);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(960, 600);
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
