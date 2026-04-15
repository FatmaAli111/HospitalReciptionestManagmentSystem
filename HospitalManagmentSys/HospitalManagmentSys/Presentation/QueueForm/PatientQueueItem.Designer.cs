namespace HospitalManagmentSys.Presentation
{
    partial class PatientQueueItem
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
            pnlUrgencyBar = new Panel();
            pnlBody = new Panel();
            lblSymptom = new Label();
            pnlProgressTrack = new Panel();
            pnlTopRow = new Panel();
            pnlActions = new Panel();
            btnNoShow = new Button();
            btnStart = new Button();
            lblPriorityBadge = new Label();
            pnlCenter = new Panel();
            pnlMeta = new FlowLayoutPanel();
            lblScheduled = new Label();
            lblWaiting = new Label();
            lblScore = new Label();
            lblDoctorDept = new Label();
            lblPatientName = new Label();
            pnlAvatar = new Panel();
            lblInitials = new Label();
            pnlRank = new Panel();
            lblRank = new Label();
            pnlBody.SuspendLayout();
            pnlTopRow.SuspendLayout();
            pnlActions.SuspendLayout();
            pnlCenter.SuspendLayout();
            pnlMeta.SuspendLayout();
            pnlAvatar.SuspendLayout();
            pnlRank.SuspendLayout();
            SuspendLayout();
            // 
            // pnlUrgencyBar
            // 
            pnlUrgencyBar.BackColor = Color.FromArgb(211, 47, 47);
            pnlUrgencyBar.Dock = DockStyle.Left;
            pnlUrgencyBar.Location = new Point(0, 0);
            pnlUrgencyBar.Margin = new Padding(0);
            pnlUrgencyBar.Name = "pnlUrgencyBar";
            pnlUrgencyBar.Size = new Size(4, 178);
            pnlUrgencyBar.TabIndex = 0;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.White;
            pnlBody.Controls.Add(lblSymptom);
            pnlBody.Controls.Add(pnlProgressTrack);
            pnlBody.Controls.Add(pnlTopRow);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(4, 0);
            pnlBody.Margin = new Padding(0);
            pnlBody.Name = "pnlBody";
            pnlBody.TabIndex = 1;
            // 
            // lblSymptom
            // 
            lblSymptom.AutoSize = true;
            lblSymptom.Dock = DockStyle.Top;
            lblSymptom.Font = new Font("Segoe UI", 9F);
            lblSymptom.ForeColor = Color.FromArgb(120, 120, 120);
            lblSymptom.Name = "lblSymptom";
            lblSymptom.TabIndex = 2;
            lblSymptom.Text = "Notes";
            // 
            // pnlProgressTrack
            // 
            pnlProgressTrack.BackColor = Color.FromArgb(236, 236, 236);
            pnlProgressTrack.Dock = DockStyle.Top;
            pnlProgressTrack.Name = "pnlProgressTrack";
            pnlProgressTrack.TabIndex = 1;
            // 
            // pnlTopRow
            // 
            pnlTopRow.Controls.Add(pnlActions);
            pnlTopRow.Controls.Add(pnlCenter);
            pnlTopRow.Controls.Add(pnlAvatar);
            pnlTopRow.Controls.Add(pnlRank);
            pnlTopRow.Dock = DockStyle.Top;
            pnlTopRow.Margin = new Padding(0);
            pnlTopRow.Name = "pnlTopRow";
            pnlTopRow.TabIndex = 0;
            // 
            // pnlActions
            // 
            pnlActions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlActions.Controls.Add(btnNoShow);
            pnlActions.Controls.Add(btnStart);
            pnlActions.Controls.Add(lblPriorityBadge);
            pnlActions.Margin = new Padding(0);
            pnlActions.Name = "pnlActions";
            pnlActions.TabIndex = 3;
            // 
            // btnNoShow
            // 
            btnNoShow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNoShow.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNoShow.Name = "btnNoShow";
            btnNoShow.TabIndex = 2;
            btnNoShow.Text = "⊘  No-Show";
            btnNoShow.Click += BtnNoShow_Click;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStart.Name = "btnStart";
            btnStart.TabIndex = 1;
            btnStart.Text = "▶  Start";
            btnStart.Click += BtnStart_Click;
            // 
            // lblPriorityBadge
            // 
            lblPriorityBadge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPriorityBadge.BackColor = Color.FromArgb(211, 47, 47);
            lblPriorityBadge.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblPriorityBadge.ForeColor = Color.White;
            lblPriorityBadge.Name = "lblPriorityBadge";
            lblPriorityBadge.TabIndex = 0;
            lblPriorityBadge.Text = "HIGH";
            lblPriorityBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCenter
            // 
            pnlCenter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCenter.Controls.Add(pnlMeta);
            pnlCenter.Controls.Add(lblDoctorDept);
            pnlCenter.Controls.Add(lblPatientName);
            pnlCenter.Margin = new Padding(0);
            pnlCenter.Name = "pnlCenter";
            pnlCenter.TabIndex = 2;
            // 
            // pnlMeta
            // 
            pnlMeta.AutoSize = true;
            pnlMeta.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlMeta.BackColor = Color.Transparent;
            pnlMeta.Controls.Add(lblScheduled);
            pnlMeta.Controls.Add(lblWaiting);
            pnlMeta.Controls.Add(lblScore);
            pnlMeta.Margin = new Padding(0);
            pnlMeta.Name = "pnlMeta";
            pnlMeta.TabIndex = 2;
            pnlMeta.WrapContents = false;
            // 
            // lblScheduled
            // 
            lblScheduled.AutoSize = true;
            lblScheduled.Font = new Font("Segoe UI", 9F);
            lblScheduled.ForeColor = Color.FromArgb(120, 120, 120);
            lblScheduled.Location = new Point(0, 0);
            lblScheduled.Name = "lblScheduled";
            lblScheduled.TabIndex = 0;
            lblScheduled.Text = "Scheduled: …";
            // 
            // lblWaiting
            // 
            lblWaiting.AutoSize = true;
            lblWaiting.Font = new Font("Segoe UI", 9F);
            lblWaiting.ForeColor = Color.FromArgb(120, 120, 120);
            lblWaiting.Name = "lblWaiting";
            lblWaiting.TabIndex = 1;
            lblWaiting.Text = "Waiting: …";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 9F);
            lblScore.ForeColor = Color.FromArgb(120, 120, 120);
            lblScore.Margin = new Padding(0);
            lblScore.Name = "lblScore";
            lblScore.TabIndex = 2;
            lblScore.Text = "Score: …";
            // 
            // lblDoctorDept
            // 
            lblDoctorDept.AutoSize = true;
            lblDoctorDept.Font = new Font("Segoe UI", 9F);
            lblDoctorDept.ForeColor = Color.FromArgb(120, 120, 120);
            lblDoctorDept.Name = "lblDoctorDept";
            lblDoctorDept.TabIndex = 1;
            lblDoctorDept.Text = "Dr. …";
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPatientName.ForeColor = Color.FromArgb(30, 30, 30);
            lblPatientName.Margin = new Padding(0, 0, 0, 2);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.TabIndex = 0;
            lblPatientName.Text = "John Smith";
            // 
            // pnlAvatar
            // 
            pnlAvatar.Controls.Add(lblInitials);
            pnlAvatar.Name = "pnlAvatar";
            pnlAvatar.TabIndex = 1;
            // 
            // lblInitials
            // 
            lblInitials.Dock = DockStyle.Fill;
            lblInitials.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInitials.ForeColor = Color.FromArgb(0, 86, 179);
            lblInitials.Location = new Point(0, 0);
            lblInitials.Name = "lblInitials";
            lblInitials.TabIndex = 0;
            lblInitials.Text = "JS";
            lblInitials.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRank
            // 
            pnlRank.Controls.Add(lblRank);
            pnlRank.Name = "pnlRank";
            pnlRank.TabIndex = 0;
            // 
            // lblRank
            // 
            lblRank.Dock = DockStyle.Fill;
            lblRank.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRank.ForeColor = Color.White;
            lblRank.Location = new Point(0, 0);
            lblRank.Name = "lblRank";
            lblRank.TabIndex = 0;
            lblRank.Text = "1";
            lblRank.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PatientQueueItem
            // 
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlBody);
            Controls.Add(pnlUrgencyBar);
            Name = "PatientQueueItem";
            pnlBody.ResumeLayout(false);
            pnlBody.PerformLayout();
            pnlTopRow.ResumeLayout(false);
            pnlActions.ResumeLayout(false);
            pnlCenter.ResumeLayout(false);
            pnlCenter.PerformLayout();
            pnlMeta.ResumeLayout(false);
            pnlMeta.PerformLayout();
            pnlAvatar.ResumeLayout(false);
            pnlRank.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel pnlUrgencyBar;
        private Panel pnlBody;
        private Panel pnlTopRow;
        private Panel pnlRank;
        private Label lblRank;
        private Panel pnlAvatar;
        private Label lblInitials;
        private Panel pnlCenter;
        private Label lblPatientName;
        private Label lblDoctorDept;
        private FlowLayoutPanel pnlMeta;
        private Label lblScheduled;
        private Label lblWaiting;
        private Label lblScore;
        private Panel pnlActions;
        private Label lblPriorityBadge;
        private Button btnStart;
        private Button btnNoShow;
        private Panel pnlProgressTrack;
        private Label lblSymptom;
    }
}
