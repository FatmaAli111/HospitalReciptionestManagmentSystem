using HospitalManagmentSys.BiussnessLogic;
using HospitalManagmentSys.Data.Models;
using System;
using System.Windows.Forms;

namespace HospitalManagmentSys.Presentation
{
    public partial class AppointmentsCardView : UserControl
    {
        private readonly Appointment _appointment;
        private readonly AppointmentService _service;
        public event EventHandler StatusChanged;
        public AppointmentsCardView(Appointment appointment, AppointmentService service)
        {
            InitializeComponent();
            _service = service;
            _appointment = appointment;

            lblTimeStart.Text = appointment.AppointmentDate.ToString("hh:mm tt");
            lblTimeEnd.Text = $"to {appointment.AppointmentDate.AddMinutes(30).ToString("hh:mm tt")}";
            lblPatient.Text = appointment.Patient.FullName;
            lblDoctor.Text = $"Dr. {appointment.Doctor.User.Name}";
            lblComplaint.Text = appointment.Description;
            bStatus.Text = appointment.Status.ToString();
            bStatus.DisabledState.FillColor = appointment.Status switch
            {
                AppointmentStatus.Pending => Color.FromArgb(255, 171, 0),
                AppointmentStatus.Completed => Color.FromArgb(34, 197, 94),
                AppointmentStatus.Cancelled => Color.FromArgb(239, 68, 68),
                _ => Color.Gray
            };

            prgUrgency.Value = (MedicalUrgency)appointment.PriorityScore switch
            {
                MedicalUrgency.Low => 20,
                MedicalUrgency.Medium => 40,
                MedicalUrgency.High => 70,
                MedicalUrgency.Emergency=>100,
                _ => 0
            }; Color urgencyColor = (MedicalUrgency)appointment.PriorityScore switch
            {
                MedicalUrgency.Low => Color.FromArgb(34, 197, 94),
                MedicalUrgency.Medium => Color.FromArgb(255, 171, 0),
                MedicalUrgency.High => Color.FromArgb(239, 68, 68),
                MedicalUrgency.Emergency => Color.FromArgb(239, 68, 68),
                _ => Color.Gray
            };
            prgUrgency.ProgressColor = urgencyColor;
            prgUrgency.ProgressColor2 = urgencyColor;
            bUrgency.Text = ((MedicalUrgency)appointment.PriorityScore).ToString();
            bUrgency.DisabledState.FillColor=(MedicalUrgency) appointment.PriorityScore switch
            {
                MedicalUrgency.Medium => Color.FromArgb(255, 171, 0),
                MedicalUrgency.Low => Color.FromArgb(34, 197, 94),
                MedicalUrgency.High => Color.FromArgb(239, 68, 68),
                _ => Color.Gray
            };
            string fullName = appointment.Patient.FullName;
            string[] parts = fullName.Split(' ');

            if (parts.Length >= 2)
                btnAvatar.Text = $"{parts[0][0]}{parts[1][0]}".ToUpper();
            else
                btnAvatar.Text = parts[0][0].ToString().ToUpper();
            bool isPending = appointment.Status == AppointmentStatus.Pending;
            guna2Button1.Visible = isPending;
            btnNoShow.Visible = isPending;
        }

        private void AppointmentsCardView_Load(object sender, EventArgs e)
        {
        }

        private void lblTimeEnd_Click(object sender, EventArgs e)
        {

        }

        private void btnNoShow_Click(object sender, EventArgs e)
        {
            guna2Button1.Visible = false;
            _service.UpdateStatus(AppointmentStatus.Cancelled, _appointment.Id);
            StatusChanged?.Invoke(this, EventArgs.Empty);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {   
            guna2Button1.Visible = false;
            _service.UpdateStatus(AppointmentStatus.Completed, _appointment.Id);
            StatusChanged?.Invoke(this, EventArgs.Empty); 

        }
    }
}