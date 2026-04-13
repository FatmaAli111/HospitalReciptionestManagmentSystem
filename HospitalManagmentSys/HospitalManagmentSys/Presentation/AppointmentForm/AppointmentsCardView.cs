using HospitalManagmentSys.Data.Models;
using System.Windows.Forms;

namespace HospitalManagmentSys.Presentation
{
    public partial class AppointmentsCardView : UserControl
    {
        public AppointmentsCardView(Appointment appointment)
        {
            InitializeComponent();
            lblTimeStart.Text = appointment.AppointmentDate.ToString("hh:mm tt");
            lblTimeEnd.Text = $"to {appointment.AppointmentDate.AddMinutes(30).ToString("hh:mm tt")}";
            lblPatient.Text = appointment.Patient.FullName;
            lblDoctor.Text = $"Dr. {appointment.Doctor.User.Name}";
            lblComplaint.Text = appointment.Description;
            bStatus.Text = appointment.Status.ToString();
            prgUrgency.Value = (int)appointment.PriorityScore;
            bUrgency.Text = ((MedicalUrgency)appointment.PriorityScore).ToString();

            string fullName = appointment.Patient.FullName;
            string[] parts = fullName.Split(' ');

            if (parts.Length >= 2)
                btnAvatar.Text = $"{parts[0][0]}{parts[1][0]}".ToUpper();
            else
                btnAvatar.Text = parts[0][0].ToString().ToUpper();
        }
        private void AppointmentsCardView_Load(object sender, EventArgs e)
        {
        }

        private void lblTimeEnd_Click(object sender, EventArgs e)
        {

        }
    }
}