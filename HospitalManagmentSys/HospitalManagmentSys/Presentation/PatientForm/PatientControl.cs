using HospitalManagmentSys.Data.Models;
using HospitalManagmentSys.Presentation.ProfilePatient;
using HospitalManagmentSys.Presentation.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagmentSys.Presentation.Controls.Sidebar
{
    public partial class PatientControl : UserControl
    {
        public PatientControl()
        {
            InitializeComponent();
            LoadPatients();
        }

        private readonly Color[] avatarColors =
        {
            Color.FromArgb(59, 130, 246),
            Color.FromArgb(139, 92, 246),
            Color.FromArgb(236, 72, 153),
            Color.FromArgb(249, 115, 22),
            Color.FromArgb(20, 184, 166),
        };
        private List<Patient> allPatients = new List<Patient>();

        private void LoadPatients()
        {
            //Load Patients from DB هنعمله هنا
            allPatients = new List<Patient>
    {
        new Patient
        {
            Id = 1,
            FullName = "Remonda Nady",
            Phone = "2345678",
            Email = "remonda@email.com",
            BloodType = BloodType.O_Positive,
            DateOfBirth = new DateTime(2026, 11, 25),
            NoShowCount = 0,
            AttendanceRate = 100.0,
            Gender = Gender.Female,
            MedicalUrgency = MedicalUrgency.Medium,
            CreatedAt = new DateTime(2024, 1, 15),
            Appointments = new List<Appointment>()
        },
        new Patient
        {
            Id = 2,
            FullName = "Sara Ali",
            Phone = "123456789",
            Email = "Sara@email.com",
            BloodType = BloodType.A_Positive,
            DateOfBirth = new DateTime(2026, 11, 25),
            NoShowCount = 0,
            AttendanceRate = 100.0,
            Gender = Gender.Female,
            MedicalUrgency = MedicalUrgency.High,
            CreatedAt = new DateTime(2024, 1, 15),
            Appointments = new List<Appointment>()
        },

        new Patient
        {
            Id = 5,
            FullName = "Nour Ali",
            Phone = "1234567890",
            Email = "nour@email.com",
            BloodType = BloodType.O_Negative,
            DateOfBirth = new DateTime(2026, 11, 25),
            NoShowCount = 0,
            AttendanceRate = 100.0,
            Gender = Gender.Female,
            MedicalUrgency = MedicalUrgency.Low,
            CreatedAt = new DateTime(2024, 1, 15),
            Appointments = new List<Appointment>()  }
    };
            RenderPatients(allPatients);
        }

        private void RenderPatients(List<Patient> patients)
        {
            contentPanel.Controls.Clear();

            var reversedPatients = patients.AsEnumerable().Reverse().ToList();
            foreach (var patient in reversedPatients)
            {
                int colorIndex = patients.IndexOf(patient);
                var row = new PatientRowControl { Dock = DockStyle.Top };
                row.SetData(patient, avatarColors[colorIndex % avatarColors.Length]);
                row.OnPatientSelected += (s, selectedPatient) =>
                {
                    var details = new PatientDetailsForm(selectedPatient);
                    details.ShowDialog(this);
                };
                contentPanel.Controls.Add(row);
            }

            var header = new PatientTableHeader { Dock = DockStyle.Top };
            contentPanel.Controls.Add(header);
        }



      

        private void ApplyFilters()
        {
            var result = allPatients.AsEnumerable();

            // Filter by urgency
            switch (filterCombo.SelectedIndex)
            {
                case 1:
                    result = result.Where(p => p.MedicalUrgency == MedicalUrgency.High);
                    break;
                case 2:
                    result = result.Where(p => p.MedicalUrgency == MedicalUrgency.Medium);
                    break;
                case 3:
                    result = result.Where(p => p.MedicalUrgency == MedicalUrgency.Low);
                    break;
            }
            var searchText = searchBox.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                result = result.Where(p =>
                    p.FullName.ToLower().Contains(searchText));
            }

            RenderPatients(result.ToList());
        }







        private void AddPatientBtn_Click(object sender, EventArgs e)
        {
            var form = new AddPatientForm();
            form.ShowDialog();
        }

        private void searchBox_TextChanged_1(object sender, EventArgs e)
        {
            ApplyFilters();

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();

        }
    }
}
