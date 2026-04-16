namespace HospitalManagmentSys.Presentation
{
    partial class QueueForm : Form
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
            pnlDoctorSelection = new Panel();
            lblDoctorLabel = new Label();
            cmbDoctors = new ComboBox();
            btnReorderQueue = new Button();
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
            pnlDoctorSelection.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlStats.SuspendLayout();
            pnlPatientsIconHost.SuspendLayout();
            pnlEmergenciesIconHost.SuspendLayout();
            pnlAvgWaitIconHost.SuspendLayout();
            pnlCurrentTimeIconHost.SuspendLayout();
            pnlQueueSection.SuspendLayout();
            pnlQueueContainer.SuspendLayout();
            pnlQueueContainer.SuspendLayout();
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
            pnlHeader.Controls.Add(pnlDoctorSelection);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Size = new Size(1200, 180);
            pnlHeader.Size = new Size(1200, 128);
            // 
            // pnlDoctorSelection
            // 
            pnlDoctorSelection.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlDoctorSelection.BackColor = Color.FromArgb(248, 249, 250);
            pnlDoctorSelection.Controls.Add(btnReorderQueue);
            pnlDoctorSelection.Controls.Add(cmbDoctors);
            pnlDoctorSelection.Controls.Add(lblDoctorLabel);
            pnlDoctorSelection.Location = new Point(740, 100);
            pnlDoctorSelection.Name = "pnlDoctorSelection";
            pnlDoctorSelection.Size = new Size(426, 56);
            pnlDoctorSelection.TabIndex = 3;
            // 
            // lblDoctorLabel
            // 
            lblDoctorLabel.AutoSize = true;
            lblDoctorLabel.Font = new Font("Segoe UI", 9F);
            lblDoctorLabel.ForeColor = Color.FromArgb(100, 100, 100);
            lblDoctorLabel.Location = new Point(12, 10);
            lblDoctorLabel.Name = "lblDoctorLabel";
            lblDoctorLabel.Size = new Size(45, 19);
            lblDoctorLabel.TabIndex = 0;
            lblDoctorLabel.Text = "Doctor:";
            // 
            // cmbDoctors
            // 
            cmbDoctors.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoctors.Font = new Font("Segoe UI", 9F);
            cmbDoctors.FormattingEnabled = true;
            cmbDoctors.Location = new Point(63, 7);
            cmbDoctors.Name = "cmbDoctors";
            cmbDoctors.Size = new Size(180, 25);
            cmbDoctors.TabIndex = 1;
            cmbDoctors.SelectedIndexChanged += CmbDoctors_SelectedIndexChanged;
            // 
            // btnReorderQueue
            // 
            btnReorderQueue.BackColor = Color.FromArgb(0, 86, 179);
            btnReorderQueue.Cursor = Cursors.Hand;
            btnReorderQueue.FlatAppearance.BorderSize = 0;
            btnReorderQueue.FlatStyle = FlatStyle.Flat;
            btnReorderQueue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReorderQueue.ForeColor = Color.White;
            btnReorderQueue.Location = new Point(254, 6);
            btnReorderQueue.Name = "btnReorderQueue";
            btnReorderQueue.Size = new Size(150, 28);
            btnReorderQueue.TabIndex = 2;
            btnReorderQueue.Text = "🔄 Reorder by Priority";
            btnReorderQueue.UseVisualStyleBackColor = false;
            btnReorderQueue.Click += BtnReorderQueue_Click;
            // 
            //
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
            lblSubtitle.Location = new Point(66, 86);
            lblSubtitle.Location = new Point(34, 78);
            lblSubtitle.Location = new Point(34, 78);
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
            // 
            // cardPatientsWaiting
            // 
            cardPatientsWaiting.BackColor = Color.FromArgb(255, 255, 255);
            cardPatientsWaiting.Controls.Add(lblPatientsWaitingLabel);
            cardPatientsWaiting.Controls.Add(lblPatientsWaitingValue);
            cardPatientsWaiting.Controls.Add(pnlPatientsIconHost);
            cardPatientsWaiting.Dock = DockStyle.Fill;
            cardPatientsWaiting.Location = new Point(0, 0);
            cardPatientsWaiting.Margin = new Padding(0, 0, 10, 0);
            cardPatientsWaiting.Name = "cardPatientsWaiting";
            cardPatientsWaiting.Padding = new Padding(14, 12, 14, 12);
            cardPatientsWaiting.Size = new Size(273, 116);
            cardPatientsWaiting.TabIndex = 0;
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
            //
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
            lblPatientsWaitingIcon.Font = new Font("Segoe MDL2 Assets", 20F);
            lblPatientsWaitingIcon.ForeColor = Color.FromArgb(0, 86, 179);
            lblPatientsWaitingIcon.ForeColor = QueueTheme.PrimaryBlue;
            lblPatientsWaitingIcon.ForeColor = QueueTheme.PrimaryBlue;
            lblPatientsWaitingIcon.Location = new Point(0, 0);
            lblPatientsWaitingIcon.Name = "lblPatientsWaitingIcon";
            lblPatientsWaitingIcon.Text = "";
            lblPatientsWaitingIcon.Text = "\uE716";
            // 
            // cardEmergencies
            // 
            cardEmergencies.BackColor = Color.FromArgb(255, 255, 255);
            cardEmergencies.Controls.Add(lblEmergenciesLabel);
            cardEmergencies.Controls.Add(lblEmergenciesValue);
            cardEmergencies.Controls.Add(pnlEmergenciesIconHost);
            cardEmergencies.Dock = DockStyle.Fill;
            cardEmergencies.Location = new Point(283, 0);
            cardEmergencies.Margin = new Padding(0, 0, 10, 0);
            cardEmergencies.Name = "cardEmergencies";
            cardEmergencies.Padding = new Padding(14, 12, 14, 12);
            cardEmergencies.Size = new Size(273, 116);
            cardEmergencies.TabIndex = 1;
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
            //
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
            lblEmergenciesIcon.Font = new Font("Segoe MDL2 Assets", 20F);
            lblEmergenciesIcon.ForeColor = Color.FromArgb(211, 47, 47);
            lblEmergenciesIcon.ForeColor = QueueTheme.EmergencyRed;
            lblEmergenciesIcon.ForeColor = QueueTheme.EmergencyRed;
            lblEmergenciesIcon.Location = new Point(0, 0);
            lblEmergenciesIcon.Name = "lblEmergenciesIcon";
            lblEmergenciesIcon.Text = "";
            lblEmergenciesIcon.Text = "\uE7BA";
            // 
            // cardAvgWaitTime
            // 
            cardAvgWaitTime.BackColor = Color.FromArgb(255, 255, 255);
            cardAvgWaitTime.Controls.Add(lblAvgWaitTimeLabel);
            cardAvgWaitTime.Controls.Add(lblAvgWaitTimeValue);
            cardAvgWaitTime.Controls.Add(pnlAvgWaitIconHost);
            cardAvgWaitTime.Dock = DockStyle.Fill;
            cardAvgWaitTime.Location = new Point(566, 0);
            cardAvgWaitTime.Margin = new Padding(0, 0, 10, 0);
            cardAvgWaitTime.Name = "cardAvgWaitTime";
            cardAvgWaitTime.Padding = new Padding(14, 12, 14, 12);
            cardAvgWaitTime.Size = new Size(273, 116);
            cardAvgWaitTime.TabIndex = 2;
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
            //
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
            lblAvgWaitTimeIcon.Font = new Font("Segoe MDL2 Assets", 20F);
            lblAvgWaitTimeIcon.ForeColor = Color.FromArgb(251, 192, 45);
            lblAvgWaitTimeIcon.ForeColor = QueueTheme.AccentGold;
            lblAvgWaitTimeIcon.ForeColor = QueueTheme.AccentGold;
            lblAvgWaitTimeIcon.Location = new Point(0, 0);
            lblAvgWaitTimeIcon.Name = "lblAvgWaitTimeIcon";
            lblAvgWaitTimeIcon.Text = "";
            lblAvgWaitTimeIcon.Text = "\uE916";
            // 
            // cardCurrentTime
            // 
            cardCurrentTime.BackColor = Color.FromArgb(255, 255, 255);
            cardCurrentTime.Controls.Add(lblCurrentTimeLabel);
            cardCurrentTime.Controls.Add(lblCurrentTimeValue);
            cardCurrentTime.Controls.Add(pnlCurrentTimeIconHost);
            cardCurrentTime.Dock = DockStyle.Fill;
            cardCurrentTime.Location = new Point(849, 0);
            cardCurrentTime.Margin = new Padding(0);
            cardCurrentTime.Name = "cardCurrentTime";
            cardCurrentTime.Padding = new Padding(14, 12, 14, 12);
            cardCurrentTime.Size = new Size(283, 116);
            cardCurrentTime.TabIndex = 3;
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
            //
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
            lblCurrentTimeIcon.Font = new Font("Segoe MDL2 Assets", 20F);
            lblCurrentTimeIcon.ForeColor = Color.FromArgb(0, 86, 179);
            lblCurrentTimeIcon.ForeColor = QueueTheme.PrimaryBlue;
            lblCurrentTimeIcon.ForeColor = QueueTheme.PrimaryBlue;
            lblCurrentTimeIcon.Location = new Point(0, 0);
            lblCurrentTimeIcon.Name = "lblCurrentTimeIcon";
            lblCurrentTimeIcon.Text = "";
            lblCurrentTimeIcon.Text = "\uE823";
            lblCurrentTimeIcon.Text = "\uE823";
            lblCurrentTimeIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlQueueSection
            // 
            pnlQueueSection.BackColor = Color.White;
            pnlQueueSection.Controls.Add(pnlQueueContainer);
            pnlQueueSection.Controls.Add(tblQueueHeader);
            pnlQueueSection.Dock = DockStyle.Fill;
            pnlQueueSection.Location = new Point(0, 228);
            pnlQueueSection.Name = "pnlQueueSection";
            pnlQueueSection.Size = new Size(1113, 25);
            pnlQueueSection.TabIndex = 0;
            // 
            // pnlQueueContainer
            // 
            pnlQueueContainer.Location = new Point(34, 90);
            pnlQueueContainer.Margin = new Padding(3, 4, 3, 4);
            pnlQueueContainer.Margin = new Padding(3, 4, 3, 4);
            pnlQueueContainer.Padding = new Padding(8);
            pnlQueueContainer.Size = new Size(1132, 262);
            pnlQueueContainer.Size = new Size(1132, 374);
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
            flowPatients.Size = new Size(1116, 246);
            flowPatients.TabIndex = 0;
            flowPatients.WrapContents = false;
            flowPatients.SizeChanged += FlowPatients_SizeChanged;
            // 
            // pnlPriorityLegend
            // 
            pnlPriorityLegend.BackColor = Color.FromArgb(255, 255, 255);
            pnlPriorityLegend.Dock = DockStyle.Bottom;
            pnlPriorityLegend.Location = new Point(34, 352);
            pnlPriorityLegend.Margin = new Padding(0, 12, 0, 0);
            pnlPriorityLegend.Name = "pnlPriorityLegend";
            pnlPriorityLegend.Padding = new Padding(18, 12, 18, 14);
            pnlPriorityLegend.Size = new Size(1132, 136);
            pnlPriorityLegend.TabIndex = 2;
            pnlPriorityLegend.Paint += pnlPriorityLegend_Paint;
            // 
            //
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
            lblQueueTitle.Size = new Size(932, 32);
            lblQueueTitle.Size = new Size(932, 36);
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
            chkAutoRefresh.Font = new Font("Segoe UI", 9F);
            chkAutoRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            chkAutoRefresh.Location = new Point(932, 0);
            chkAutoRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            chkAutoRefresh.ForeColor = Color.FromArgb(100, 100, 100);
            tblQueueHeader.SetRowSpan(chkAutoRefresh, 2);
            chkAutoRefresh.Size = new Size(200, 62);
            chkAutoRefresh.Size = new Size(200, 62);
            chkAutoRefresh.Size = new Size(200, 62);
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
            pnlDoctorSelection.ResumeLayout(false);
            pnlDoctorSelection.PerformLayout();
            pnlStats.ResumeLayout(false);
            pnlPatientsIconHost.ResumeLayout(false);
            pnlEmergenciesIconHost.ResumeLayout(false);
            pnlAvgWaitIconHost.ResumeLayout(false);
            pnlQueueContainer.ResumeLayout(false);
            pnlPriorityLegend.ResumeLayout(false);
            pnlQueueContainer.ResumeLayout(false);
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
        private Panel pnlDoctorSelection;
        private Label lblDoctorLabel;
        private ComboBox cmbDoctors;
        private Button btnReorderQueue;
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

