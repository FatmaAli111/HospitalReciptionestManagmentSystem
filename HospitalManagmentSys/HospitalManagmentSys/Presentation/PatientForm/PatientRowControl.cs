using Guna.UI2.WinForms;
using HospitalManagmentSys.Data.Models;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalManagmentSys.Presentation.UserControls
{
    public partial class PatientRowControl : UserControl
    {
        public event EventHandler<Patient> OnPatientSelected;
        private Patient _patient;
        public PatientRowControl()
        {
            InitializeComponent();

            this.Click += (s, e) => OnPatientSelected?.Invoke(this, _patient);
            foreach (Control ctrl in this.Controls)
                ctrl.Click += (s, e) => OnPatientSelected?.Invoke(this, _patient);
        }

        public void SetData(Patient patient, Color avatarColor)
        {
            _patient = patient;

            avatarLabel.Text = patient.Initials;
            avatarLabel.FillColor = avatarColor;

            nameLabel.Text = patient.FullName;
            ageLabel.Text = $"{patient.Age} years old";

            contactLabel.Text = $"{patient.Phone}\r\n{patient.Email}";

            bloodLabel.Text = patient.BloodType.ToString().Replace("_", " ");

            appointmentsLabel.Text = $"{patient.TotalAppointments} total";

            SetStatusBadge(patient);
        }

        private void SetStatusBadge(Patient patient)
        {
            Color badgeBg, badgeFg;
            string badgeText;

            switch (patient.MedicalUrgency)
            {
                case MedicalUrgency.Low:
                    badgeBg = Color.FromArgb(220, 252, 231);
                    badgeFg = Color.FromArgb(21, 128, 61);
                    badgeText = $"Good ({patient.NoShowCount})";
                    break;
                case MedicalUrgency.High:
                    badgeBg = Color.FromArgb(254, 226, 226);
                    badgeFg = Color.FromArgb(153, 27, 27);
                    badgeText = $"High Risk ({patient.NoShowCount})";
                    break;
                default:
                    badgeBg = Color.FromArgb(254, 243, 199);
                    badgeFg = Color.FromArgb(146, 64, 14);
                    badgeText = $"Warning ({patient.NoShowCount})";
                    break;
            }

            statusLabel.FillColor = badgeBg;
            statusLabel.ForeColor = badgeFg;
            statusLabel.Text = badgeText;
        }
    }
}