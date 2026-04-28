using HospitalManagmentSys.BiussnessLogic;
using HospitalManagmentSys.Data;
using HospitalManagmentSys.Data.Models;
using HospitalManagmentSys.Presentation.Controls.Sidebar;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagmentSys.Presentation
{
    public partial class QueueForm : Form
    {
        private readonly AppDbContext _context;
        private readonly QueueService _queueService;
        private List<PatientData> _patients = new();
        private int _patientCount;
        private int? _selectedDoctorId;
        private UserRole? _currentUserRole;

        // Sidebar removed for QueueForm — this page uses the app's main sidebar instead of an embedded one

        public QueueForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _queueService = new QueueService(_context);
            btnEmergency.Click += BtnEmergency_Click;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // no embedded timers to dispose (sidebar removed)
            base.OnFormClosed(e);
        }

        private void QueueForm_Load(object sender, EventArgs e)
        {
            ApplyTheme();

            // Initialize based on user role
            if (!UserSession.IsLoggedIn)
            {
                MessageBox.Show("Please login first.", "Authentication Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            _currentUserRole = UserSession.CurrentRole;
            ConfigureUIForRole();
            LoadDataForRole();
        }

        // No embedded sidebar — use main application sidebar instead



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

        private void ConfigureUIForRole()
        {
            if (_currentUserRole == UserRole.Doctor)
            {
                // Hide doctor selection for doctors - they only see their own queue
                pnlDoctorSelection.Visible = false;
                lblSubtitle.Text = $"Your queue - {UserSession.CurrentUser?.Name}";
            }
            else if (_currentUserRole == UserRole.Admin || _currentUserRole == UserRole.Receptionist)
            {
                // Show doctor selection for Admin/Receptionist
                pnlDoctorSelection.Visible = true;
                lblSubtitle.Text = "Select a doctor to view their queue";
            }
            else
            {
                MessageBox.Show("Invalid user role.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadDataForRole()
        {
            if (_currentUserRole == UserRole.Doctor)
            {
                // Auto-identify the logged-in doctor
                var doctorId = UserSession.GetDoctorId();
                if (doctorId.HasValue)
                {
                    _selectedDoctorId = doctorId.Value;
                    LoadDoctorQueue(doctorId.Value);
                }
                else
                {
                    MessageBox.Show("Doctor profile not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (_currentUserRole == UserRole.Admin || _currentUserRole == UserRole.Receptionist)
            {
                // Load doctors for selection
                LoadDoctors();
            }
        }

        private void LoadDoctors()
        {
            try
            {
                var doctors = _queueService.GetActiveDoctors();

                cmbDoctors.DataSource = null;
                cmbDoctors.Items.Clear();

                if (doctors.Count == 0)
                {
                    cmbDoctors.Items.Add("No doctors available");
                    cmbDoctors.SelectedIndex = 0;
                    cmbDoctors.Enabled = false;
                    btnReorderQueue.Enabled = false;
                    return;
                }

                cmbDoctors.DisplayMember = "User.Name";
                cmbDoctors.ValueMember = "Id";
                cmbDoctors.DataSource = doctors;
                cmbDoctors.Enabled = true;
                btnReorderQueue.Enabled = true;

                if (doctors.Count > 0)
                {
                    cmbDoctors.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading doctors: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDoctorQueue(int doctorId)
        {
            try
            {
                _patients.Clear();

                // 1) هات الـ TimeSlot الحالي للدكتور
                var timeSlot = _queueService.GetCurrentTimeSlotForDoctor(doctorId);
                if (timeSlot == null)
                {
                    lblQueueTitle.Text = "Patient Queue";
                    lblQueueSubtitle.Text = "No active time slot";
                    return;
                }

                // 2) هات الـ Queue بالطريقة اللي فيها Include للـ Doctor.User
                var queue = _queueService.GetDoctorQueueByTimeSlot(doctorId, timeSlot.Id);

                if (queue.Count == 0)
                {
                    lblQueueTitle.Text = "Patient Queue";
                    lblQueueSubtitle.Text = "No patients in queue";
                    return;
                }

                // 3) الدكتور الحقيقي من الـ Queue (ومعمول له Include)
                var doctor = queue.First().Doctor;

                lblQueueTitle.Text = $"{doctor?.User?.Name}'s Queue";
                lblQueueSubtitle.Text = $"{queue.Count} patient(s) waiting";

                int position = 1;
                foreach (var appointment in queue)
                {
                    var patient = appointment.Patient;
                    bool isCurrentPatient = position == 1;

                    _patients.Add(new PatientData
                    {
                        Position = position,
                        Name = patient.FullName,
                        Initials = patient.Initials,
                        Doctor = doctor?.User?.Name ?? "Unknown",
                        Department = doctor?.Department?.Name ?? "Unknown",
                        ScheduledTime = appointment.AppointmentDate.ToString("HH:mm"),
                        WaitingDuration = appointment.AppointmentDate - DateTime.Now,
                        PriorityScore = (int)appointment.PriorityScore,
                        Priority = GetPriorityLabel(appointment.PriorityScore),
                        Symptom = appointment.Description ?? "No description",
                        IsEmergencyCase = patient.MedicalUrgency == MedicalUrgency.Emergency,
                        IsCurrentPatient = isCurrentPatient,
                        AppointmentId = appointment.Id
                    });

                    position++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Queue Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetPriorityLabel(double score)
        {
            if (score >= 7) return "EMERGENCY";
            if (score >= 5) return "HIGH";
            if (score >= 3) return "MEDIUM";
            return "LOW";
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

                // Store appointment ID for button actions
                item.AppointmentId = patient.AppointmentId;

                // Wire up button click events
                item.StartClicked += OnPatientStartClicked;
                item.NoShowClicked += OnPatientNoShowClicked;

                // Highlight current patient
                if (patient.IsCurrentPatient)
                {
                    item.BackColor = Color.FromArgb(255, 248, 220);
                }

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

            // "Average waiting time" = the mean projected wait across all patients
            // still waiting for a future slot (WaitingDuration = AppointmentDate - DateTime.Now).
            //   > 0  : patient is waiting for a future slot  — include
            //   <= 0 : overdue or currently being seen        — exclude (no longer "waiting")
            //   null : data was not populated                 — exclude

            var waitingPatients = _patients
                .Where(p => p.WaitingDuration.HasValue && p.WaitingDuration.Value > TimeSpan.Zero)
                .ToList();

            if (waitingPatients.Count == 0)
            {
                // Queue is empty, or every patient is already at the head / overdue.
                lblAvgWaitTimeValue.Text = _patientCount > 0 ? "Now" : "--";
                return;
            }

            double avgMinutes = waitingPatients.Average(p => p.WaitingDuration!.Value.TotalMinutes);

            if (double.IsNaN(avgMinutes) || double.IsInfinity(avgMinutes))
            {
                lblAvgWaitTimeValue.Text = "--";
                return;
            }

            // Show hours component only when the average reaches 60 min or more.
            int totalMinutes = (int)Math.Round(avgMinutes);
            lblAvgWaitTimeValue.Text = totalMinutes >= 60
                ? $"{totalMinutes / 60}h {totalMinutes % 60}m"
                : $"{totalMinutes} min";
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

        private void pnlPriorityLegend_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CmbDoctors_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbDoctors.SelectedValue is int doctorId)
            {
                _selectedDoctorId = doctorId;
                LoadDoctorQueue(doctorId);
            }
        }

        private void BtnReorderQueue_Click(object? sender, EventArgs e)
        {
            if (_selectedDoctorId.HasValue)
            {
                try
                {
                    var timeSlot = _queueService.GetCurrentTimeSlotForDoctor(_selectedDoctorId.Value);
                    if (timeSlot != null)
                    {
                        _queueService.ReorderQueue(timeSlot.Id);
                        LoadDoctorQueue(_selectedDoctorId.Value);
                        MessageBox.Show("Queue reordered by priority successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No active time slot found for this doctor.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reordering queue: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OnPatientStartClicked(object? sender, EventArgs e)
        {
            if (sender is PatientQueueItem item)
            {
                try
                {
                    var result = MessageBox.Show(
                        "Start consultation for this patient?",
                        "Confirm Start",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (_queueService.StartPatientConsultation(item.AppointmentId))
                        {
                            MessageBox.Show("Patient consultation started successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (_selectedDoctorId.HasValue)
                            {
                                LoadDoctorQueue(_selectedDoctorId.Value);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to start consultation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error starting consultation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OnPatientNoShowClicked(object? sender, EventArgs e)
        {
            if (sender is PatientQueueItem item)
            {
                try
                {
                    var result = MessageBox.Show(
                        "Mark this patient as no-show?\n\nThis will cancel their appointment and update their attendance record.",
                        "Confirm No-Show",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        if (_queueService.MarkPatientAsNoShow(item.AppointmentId))
                        {
                            MessageBox.Show("Patient marked as no-show. Queue has been updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (_selectedDoctorId.HasValue)
                            {
                                LoadDoctorQueue(_selectedDoctorId.Value);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to mark patient as no-show.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error marking no-show: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEmergency_Click(object? sender, EventArgs e)
        {
            if (!_selectedDoctorId.HasValue)
            {
                MessageBox.Show("Please select a doctor first.", "No Doctor Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var result = MessageBox.Show(
                    "Add emergency patient to the front of the queue?\n\nThis will add a patient with emergency priority immediately.",
                    "Emergency Admission",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var patients = _queueService.GetAllPatients();
                    if (patients.Count == 0)
                    {
                        MessageBox.Show("No patients available in the system.", "No Patients", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Simple dialog to select patient by name (in a real app, use a proper selection dialog)
                    using (var form = new Form())
                    {
                        form.Text = "Select Patient for Emergency";
                        form.Size = new Size(400, 300);
                        form.StartPosition = FormStartPosition.CenterParent;

                        var lbl = new Label { Text = "Select Patient:", Location = new Point(20, 20), AutoSize = true };
                        var cmb = new ComboBox { Location = new Point(20, 50), Size = new Size(340, 25), DropDownStyle = ComboBoxStyle.DropDownList };
                        var btnOk = new Button { Text = "OK", DialogResult = DialogResult.OK, Location = new Point(220, 220), Size = new Size(80, 30) };
                        var btnCancel = new Button { Text = "Cancel", DialogResult = DialogResult.Cancel, Location = new Point(310, 220), Size = new Size(80, 30) };

                        foreach (var patient in patients.OrderBy(p => p.FullName))
                        {
                            cmb.Items.Add(new { Id = patient.Id, Name = patient.FullName });
                        }
                        cmb.DisplayMember = "Name";
                        cmb.ValueMember = "Id";
                        if (cmb.Items.Count > 0) cmb.SelectedIndex = 0;

                        var lblDesc = new Label { Text = "Description (optional):", Location = new Point(20, 90), AutoSize = true };
                        var txtDesc = new TextBox { Location = new Point(20, 115), Size = new Size(340, 60), Multiline = true };

                        form.Controls.AddRange(new Control[] { lbl, cmb, btnOk, btnCancel, lblDesc, txtDesc });
                        form.AcceptButton = btnOk;
                        form.CancelButton = btnCancel;

                        if (form.ShowDialog() == DialogResult.OK && cmb.SelectedItem != null)
                        {
                            var selected = cmb.SelectedItem;
                            int patientId = (int)selected.GetType().GetProperty("Id").GetValue(selected);
                            string description = txtDesc.Text.Trim();

                            if (_queueService.AddEmergencyPatient(patientId, _selectedDoctorId.Value, description))
                            {
                                MessageBox.Show("Emergency patient added to front of queue successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDoctorQueue(_selectedDoctorId.Value);
                            }
                            else
                            {
                                MessageBox.Show("Failed to add emergency patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding emergency patient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        public bool IsCurrentPatient { get; set; }
        public int AppointmentId { get; set; }
    }
}