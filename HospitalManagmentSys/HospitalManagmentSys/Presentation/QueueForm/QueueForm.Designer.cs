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
            pnlDoctorSelection = new Panel();
            btnReorderQueue = new Button();
            cmbDoctors = new ComboBox();
            lblDoctorLabel = new Label();
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
            // pnlDoctorSelection
            // 
            pnlDoctorSelection.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlDoctorSelection.BackColor = Color.FromArgb(248, 249, 250);
            pnlDoctorSelection.Controls.Add(btnReorderQueue);
            pnlDoctorSelection.Controls.Add(cmbDoctors);
            pnlDoctorSelection.Controls.Add(lblDoctorLabel);
            pnlDoctorSelection.Location = new Point(1256, 100);
            pnlDoctorSelection.Name = "pnlDoctorSelection";
            pnlDoctorSelection.Size = new Size(634, 56);
            pnlDoctorSelection.TabIndex = 3;
            // 
            // btnReorderQueue
            // 
            btnReorderQueue.BackColor = Color.FromArgb(0, 86, 179);
            btnReorderQueue.Cursor = Cursors.Hand;
            btnReorderQueue.FlatAppearance.BorderSize = 0;
            btnReorderQueue.FlatStyle = FlatStyle.Flat;
            btnReorderQueue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReorderQueue.ForeColor = Color.White;
            btnReorderQueue.Location = new Point(460, 9);
            btnReorderQueue.Name = "btnReorderQueue";
            btnReorderQueue.Size = new Size(150, 28);
            btnReorderQueue.TabIndex = 2;
            btnReorderQueue.Text = "🔄 Reorder by Priority";
            btnReorderQueue.UseVisualStyleBackColor = false;
            btnReorderQueue.Click += BtnReorderQueue_Click;
            // 
            // cmbDoctors
            // 
            cmbDoctors.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoctors.Font = new Font("Segoe UI", 9F);
            cmbDoctors.FormattingEnabled = true;
            cmbDoctors.Location = new Point(74, 8);
            cmbDoctors.Name = "cmbDoctors";
            cmbDoctors.Size = new Size(380, 28);
            cmbDoctors.TabIndex = 1;
            cmbDoctors.SelectedIndexChanged += CmbDoctors_SelectedIndexChanged;
            // 
            // lblDoctorLabel
            // 
            lblDoctorLabel.AutoSize = true;
            lblDoctorLabel.Font = new Font("Segoe UI", 9F);
            lblDoctorLabel.ForeColor = Color.FromArgb(100, 100, 100);
            lblDoctorLabel.Location = new Point(12, 10);
            lblDoctorLabel.Name = "lblDoctorLabel";
            lblDoctorLabel.Size = new Size(58, 20);
            lblDoctorLabel.TabIndex = 0;
            lblDoctorLabel.Text = "Doctor:";
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
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(34, 36, 34, 28);
            pnlHeader.Size = new Size(1924, 180);
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
            btnEmergency.Location = new Point(1662, 36);
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
            lblSubtitle.Location = new Point(66, 86);
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
            lblTitle.Location = new Point(34, 36);
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
            pnlStats.Location = new Point(0, 180);
            pnlStats.Margin = new Padding(3, 4, 3, 4);
            pnlStats.Name = "pnlStats";
            pnlStats.Padding = new Padding(34, 20, 34, 20);
            pnlStats.Size = new Size(1924, 156);
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
            tableStats.Size = new Size(1856, 116);
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
            cardPatientsWaiting.Margin = new Padding(0, 0, 10, 0);
            cardPatientsWaiting.Name = "cardPatientsWaiting";
            cardPatientsWaiting.Padding = new Padding(14, 12, 14, 12);
            cardPatientsWaiting.Size = new Size(454, 116);
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
            lblPatientsWaitingIcon.Font = new Font("Segoe MDL2 Assets", 20F);
            lblPatientsWaitingIcon.ForeColor = Color.FromArgb(0, 86, 179);
            lblPatientsWaitingIcon.Location = new Point(0, 0);
            lblPatientsWaitingIcon.Name = "lblPatientsWaitingIcon";
            lblPatientsWaitingIcon.Size = new Size(48, 48);
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
            cardEmergencies.Location = new Point(464, 0);
            cardEmergencies.Margin = new Padding(0, 0, 10, 0);
            cardEmergencies.Name = "cardEmergencies";
            cardEmergencies.Padding = new Padding(14, 12, 14, 12);
            cardEmergencies.Size = new Size(454, 116);
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
            lblEmergenciesIcon.Font = new Font("Segoe MDL2 Assets", 20F);
            lblEmergenciesIcon.ForeColor = Color.FromArgb(211, 47, 47);
            lblEmergenciesIcon.Location = new Point(0, 0);
            lblEmergenciesIcon.Name = "lblEmergenciesIcon";
            lblEmergenciesIcon.Size = new Size(48, 48);
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
            cardAvgWaitTime.Location = new Point(928, 0);
            cardAvgWaitTime.Margin = new Padding(0, 0, 10, 0);
            cardAvgWaitTime.Name = "cardAvgWaitTime";
            cardAvgWaitTime.Padding = new Padding(14, 12, 14, 12);
            cardAvgWaitTime.Size = new Size(454, 116);
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
            lblAvgWaitTimeIcon.Font = new Font("Segoe MDL2 Assets", 20F);
            lblAvgWaitTimeIcon.ForeColor = Color.FromArgb(251, 192, 45);
            lblAvgWaitTimeIcon.Location = new Point(0, 0);
            lblAvgWaitTimeIcon.Name = "lblAvgWaitTimeIcon";
            lblAvgWaitTimeIcon.Size = new Size(48, 48);
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
            cardCurrentTime.Location = new Point(1392, 0);
            cardCurrentTime.Margin = new Padding(0);
            cardCurrentTime.Name = "cardCurrentTime";
            cardCurrentTime.Padding = new Padding(14, 12, 14, 12);
            cardCurrentTime.Size = new Size(464, 116);
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
            lblCurrentTimeIcon.Font = new Font("Segoe MDL2 Assets", 20F);
            lblCurrentTimeIcon.ForeColor = Color.FromArgb(0, 86, 179);
            lblCurrentTimeIcon.Location = new Point(0, 0);
            lblCurrentTimeIcon.Name = "lblCurrentTimeIcon";
            lblCurrentTimeIcon.Size = new Size(48, 48);
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
            pnlQueueSection.Location = new Point(0, 336);
            pnlQueueSection.Margin = new Padding(3, 4, 3, 4);
            pnlQueueSection.Name = "pnlQueueSection";
            pnlQueueSection.Padding = new Padding(34, 28, 34, 28);
            pnlQueueSection.Size = new Size(1924, 650);
            pnlQueueSection.TabIndex = 0;
            // 
            // pnlQueueContainer
            // 
            pnlQueueContainer.BackColor = Color.FromArgb(248, 249, 250);
            pnlQueueContainer.Controls.Add(flowPatients);
            pnlQueueContainer.Dock = DockStyle.Fill;
            pnlQueueContainer.Location = new Point(34, 90);
            pnlQueueContainer.Margin = new Padding(3, 4, 3, 4);
            pnlQueueContainer.Name = "pnlQueueContainer";
            pnlQueueContainer.Padding = new Padding(8);
            pnlQueueContainer.Size = new Size(1856, 396);
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
            flowPatients.Size = new Size(1840, 380);
            flowPatients.TabIndex = 0;
            flowPatients.WrapContents = false;
            flowPatients.SizeChanged += FlowPatients_SizeChanged;
            // 
            // pnlPriorityLegend
            // 
            pnlPriorityLegend.BackColor = Color.FromArgb(255, 255, 255);
            pnlPriorityLegend.Dock = DockStyle.Bottom;
            pnlPriorityLegend.Location = new Point(34, 486);
            pnlPriorityLegend.Margin = new Padding(0, 12, 0, 0);
            pnlPriorityLegend.Name = "pnlPriorityLegend";
            pnlPriorityLegend.Padding = new Padding(18, 12, 18, 14);
            pnlPriorityLegend.Size = new Size(1856, 136);
            pnlPriorityLegend.TabIndex = 2;
            pnlPriorityLegend.Paint += pnlPriorityLegend_Paint;
            // 
            // tblQueueHeader
            // 
            tblQueueHeader.ColumnCount = 2;
            tblQueueHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblQueueHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tblQueueHeader.Controls.Add(lblQueueTitle, 0, 0);
            tblQueueHeader.Controls.Add(lblQueueSubtitle, 0, 1);
            tblQueueHeader.Controls.Add(chkAutoRefresh, 1, 0);
            tblQueueHeader.Dock = DockStyle.Top;
            tblQueueHeader.Location = new Point(34, 28);
            tblQueueHeader.Margin = new Padding(0, 0, 0, 12);
            tblQueueHeader.Name = "tblQueueHeader";
            tblQueueHeader.RowCount = 2;
            tblQueueHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tblQueueHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tblQueueHeader.Size = new Size(1856, 62);
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
            lblQueueTitle.Size = new Size(1656, 32);
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
            lblQueueSubtitle.Size = new Size(1656, 26);
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
            chkAutoRefresh.Location = new Point(1656, 0);
            chkAutoRefresh.Margin = new Padding(0);
            chkAutoRefresh.Name = "chkAutoRefresh";
            tblQueueHeader.SetRowSpan(chkAutoRefresh, 2);
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
            ClientSize = new Size(1924, 986);
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
            pnlDoctorSelection.ResumeLayout(false);
            pnlDoctorSelection.PerformLayout();
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

