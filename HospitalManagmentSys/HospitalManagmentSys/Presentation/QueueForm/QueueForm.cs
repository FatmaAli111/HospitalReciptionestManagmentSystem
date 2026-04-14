namespace HospitalManagmentSys.Presentation
{
    public partial class QueueForm : Form
    {
        private List<PatientData> _patients = new();
        private int _patientCount;

        public QueueForm()
        {
            InitializeComponent();
        }

        private void QueueForm_Load(object sender, EventArgs e)
        {
            ApplyTheme();
            InitializePatients();
            LoadPatients();
        }

        private void ApplyTheme()
        {
            BackColor = QueueTheme.Background;
            pnlHeader.BackColor = QueueTheme.Background;
            pnlStats.BackColor = QueueTheme.SurfaceMuted;
            pnlQueueSection.BackColor = QueueTheme.Background;
            pnlQueueContainer.BackColor = QueueTheme.SurfaceMuted;
            flowPatients.BackColor = QueueTheme.SurfaceMuted;

            lblTitle.Font = QueueTheme.TitleFont;
            lblTitle.ForeColor = QueueTheme.TextPrimary;
            lblSubtitle.Font = QueueTheme.HeaderSubtitleFont;
            lblSubtitle.ForeColor = QueueTheme.TextSecondary;

            lblQueueTitle.Font = QueueTheme.SectionTitleFont;
            lblQueueTitle.ForeColor = QueueTheme.TextPrimary;
            lblQueueSubtitle.Font = QueueTheme.SectionSubtitleFont;
            lblQueueSubtitle.ForeColor = QueueTheme.TextSecondary;

            QueueTheme.ApplyFlatButton(btnEmergency, QueueTheme.EmergencyRed, Color.White);
            btnEmergency.Font = new Font("Segoe UI", 11f, FontStyle.Bold, GraphicsUnit.Point);

            chkAutoRefresh.BackColor = QueueTheme.Background;
            chkAutoRefresh.FlatAppearance.BorderColor = QueueTheme.BorderSubtle;
            chkAutoRefresh.FlatAppearance.BorderSize = 1;
            chkAutoRefresh.Padding = new Padding(10, 4, 10, 4);

            PositionEmergencyButton();
        }

        private void PositionEmergencyButton()
        {
            const int pad = 34;
            btnEmergency.Location = new Point(
                Math.Max(pad, pnlHeader.ClientSize.Width - btnEmergency.Width - pad),
                48);
        }

        private void QueueForm_Resize(object sender, EventArgs e)
        {
            PositionEmergencyButton();
        }

        private void InitializePatients()
        {
            _patients = new List<PatientData>
            {
                new()
                {
                    Position = 1,
                    Name = "John Smith",
                    Initials = "JS",
                    Doctor = "Michael Chen",
                    Department = "Cardiology",
                    ScheduledTime = "09:00",
                    WaitingDuration = TimeSpan.FromMinutes(15) + TimeSpan.FromSeconds(30),
                    PriorityScore = 85,
                    Priority = "HIGH",
                    Symptom = "Chest pain and shortness of breath",
                    IsEmergencyCase = false
                },
                new()
                {
                    Position = 2,
                    Name = "Emma Davis",
                    Initials = "ED",
                    Doctor = "Robert Martinez",
                    Department = "General Medicine",
                    ScheduledTime = "09:30",
                    WaitingDuration = TimeSpan.FromMinutes(12) + TimeSpan.FromSeconds(45),
                    PriorityScore = 50,
                    Priority = "MEDIUM",
                    Symptom = "Annual checkup",
                    IsEmergencyCase = false
                }
            };
        }

        private void LoadPatients()
        {
            flowPatients.SuspendLayout();
            flowPatients.Controls.Clear();
            _patientCount = _patients.Count;

            foreach (var patient in _patients)
            {
                var item = new PatientQueueItem();
                item.SetPatientData(
                    patient.Position,
                    patient.Name,
                    patient.Initials,
                    patient.Doctor,
                    patient.Department,
                    patient.ScheduledTime,
                    patient.WaitingDuration,
                    patient.PriorityScore,
                    patient.Priority,
                    patient.Symptom);
                item.Width = Math.Max(400, flowPatients.ClientSize.Width - 24);
                item.Margin = new Padding(6, 0, 6, 10);
                flowPatients.Controls.Add(item);
            }

            flowPatients.ResumeLayout();
            UpdateStats();
        }

        private void FlowPatients_SizeChanged(object? sender, EventArgs e)
        {
            foreach (Control c in flowPatients.Controls)
            {
                if (c is PatientQueueItem)
                    c.Width = Math.Max(400, flowPatients.ClientSize.Width - 24);
            }
        }

        private void UpdateStats()
        {
            lblPatientsWaitingValue.Text = _patientCount.ToString();

            int emergencies = _patients.Count(p => p.IsEmergencyCase);
            lblEmergenciesValue.Text = emergencies.ToString();

            var withWait = _patients.Where(p => p.WaitingDuration.HasValue).ToList();
            if (withWait.Count == 0)
            {
                lblAvgWaitTimeValue.Text = "--";
            }
            else
            {
                double avgMinutes = withWait.Average(p => p.WaitingDuration!.Value.TotalMinutes);
                if (double.IsNaN(avgMinutes) || double.IsInfinity(avgMinutes))
                    lblAvgWaitTimeValue.Text = "--";
                else
                    lblAvgWaitTimeValue.Text = $"{Math.Round(avgMinutes)} min";
            }
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            lblCurrentTimeValue.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void TimerAutoRefresh_Tick(object sender, EventArgs e)
        {
            if (!chkAutoRefresh.Checked)
                return;

            LoadPatients();
        }

        private void ChkAutoRefresh_CheckedChanged(object? sender, EventArgs e)
        {
            chkAutoRefresh.Text = chkAutoRefresh.Checked ? "Auto-refresh: ON" : "Auto-refresh: OFF";
            timerAutoRefresh.Enabled = chkAutoRefresh.Checked;
        }
    }

    public sealed class PatientData
    {
        public int Position { get; set; }
        public string Name { get; set; } = "";
        public string Initials { get; set; } = "";
        public string Doctor { get; set; } = "";
        public string Department { get; set; } = "";
        public string ScheduledTime { get; set; } = "";
        public TimeSpan? WaitingDuration { get; set; }
        public int PriorityScore { get; set; }
        public string Priority { get; set; } = "";
        public string Symptom { get; set; } = "";
        public bool IsEmergencyCase { get; set; }
    }
}
