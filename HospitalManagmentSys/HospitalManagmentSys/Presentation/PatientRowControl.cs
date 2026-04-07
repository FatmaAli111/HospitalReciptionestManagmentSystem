using Guna.UI2.WinForms;
using HospitalManagmentSys.Data.Models;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace HospitalManagmentSys.Presentation.UserControls
{
    public partial class PatientRowControl : UserControl
    {
        public PatientRowControl()
        {
            InitializeComponent();
        }
        public void SetData(Patient patient, Color avatarColor)
        {
            avatarLabel.Text = patient.Initials;
            avatarLabel.FillColor = avatarColor;

            nameLabel.Text = patient.FullName;
            ageLabel.Text = $"{patient.Age} years old";

            contactLabel.Text = $"{patient.Phone}\r\n{patient.Email}";

            bloodLabel.Text = patient.BloodType;

            appointmentsLabel.Text = $"{patient.TotalAppointments} total";

            SetStatusBadge(patient);
        }

        private void SetStatusBadge(Patient patient)
        {
            Color badgeBg, badgeFg;
            string badgeText;

            switch (patient.NoShowStatus)
            {
                case NoShowStatus.Good:
                    badgeBg = Color.FromArgb(220, 252, 231);
                    badgeFg = Color.FromArgb(21, 128, 61);
                    badgeText = $"Good ({patient.NoShowCount})";
                    break;
                case NoShowStatus.HighRisk:
                    badgeBg = Color.FromArgb(254, 226, 226);
                    badgeFg = Color.FromArgb(153, 27, 27);
                    badgeText = $"High Risk ({patient.NoShowCount})";
                    break;
                default: // Warning
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