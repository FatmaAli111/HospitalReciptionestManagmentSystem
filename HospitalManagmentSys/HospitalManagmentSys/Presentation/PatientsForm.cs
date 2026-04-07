using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using HospitalManagmentSys.Data.Models;
using HospitalManagmentSys.Presentation.UserControls;

namespace HospitalManagmentSys.Presentation
{
    public partial class PatientsForm : Form
    {
        private readonly Color[] avatarColors =
        {
            Color.FromArgb(59,  130, 246),
            Color.FromArgb(139,  92, 246),
            Color.FromArgb(236,  72, 153),
            Color.FromArgb(249, 115,  22),
            Color.FromArgb( 20, 184, 166),
        };

        private readonly List<Patient> patients = new List<Patient>
        {
            new Patient { Id = "001", FullName = "Remonda Nady",
                Phone = "1234567890",  Email = "Remonda@email.com",
                BloodType = "A+",  Age = 23,
                TotalAppointments = 4, NoShowCount = 2 },

            new Patient { Id = "002", FullName = "Sara Ahmed",
                Phone = "123456778",  Email = "sara@email.com",
                BloodType = "O-",  Age = 22,
                TotalAppointments = 8, NoShowCount = 0 },

            new Patient { Id = "003", FullName = "John Smith",
                Phone = "2345678987", Email = "john@email.com",
                BloodType = "B+", Age = 41,
                TotalAppointments = 20, NoShowCount = 5 },
        };

        public PatientsForm()
        {
            InitializeComponent();
            SetPlaceholder();
            LoadPatients(patients);
        }

        private void SetPlaceholder()
        {
            searchBox.PlaceholderText = "Search by name...";
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void filterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            var result = patients.AsEnumerable();

            switch (filterCombo.SelectedIndex)
            {
                case 1:
                    result = result.Where(p => p.NoShowStatus.HasFlag(NoShowStatus.HighRisk));
                    break;
                case 2:
                    result = result.Where(p => p.NoShowStatus.HasFlag(NoShowStatus.Good));
                    break;
                case 4:
                    result = result.Where(p => p.NoShowStatus.HasFlag(NoShowStatus.Warning));
                    break;

            }

            var searchText = searchBox.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                result = result.Where(p =>
                    p.FullName.ToLower().Contains(searchText));
            }

            LoadPatients(result.ToList());
        }

        private void LoadPatients(List<Patient> patients)
        {
            contentPanel.Controls.Clear();

            contentPanel.Controls.Add(new PatientTableHeader());

            int colorIndex = 0;
            foreach (var patient in patients)
            {
                var row = new PatientRowControl { Dock = DockStyle.Top };
                row.SetData(patient, avatarColors[colorIndex % avatarColors.Length]);
                contentPanel.Controls.Add(row);
                colorIndex++;
            }

            contentPanel.Controls
                .Cast<Control>()
                .ToList()
                .ForEach(c => c.BringToFront());
        }

        private void AddPatientBtn_Click(object sender, EventArgs e)
        {
            var form = new AddPatientForm();
            form.ShowDialog(); 
        }
    }
}