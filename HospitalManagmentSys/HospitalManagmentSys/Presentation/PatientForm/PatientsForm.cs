using Guna.UI2.WinForms;
using HospitalManagmentSys.Data.Models;
using HospitalManagmentSys.Presentation.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace HospitalManagmentSys.Presentation
{
    public partial class PatientsForm : Form
    {
        private readonly Color[] avatarColors =
        {
            Color.FromArgb(59, 130, 246),
            Color.FromArgb(139, 92, 246),
            Color.FromArgb(236, 72, 153),
            Color.FromArgb(249, 115, 22),
            Color.FromArgb(20, 184, 166),
        };
        private List<Patient> allPatients = new List<Patient>();
        public PatientsForm()
        {
            InitializeComponent();
            
            
        }
        private void LoadPatients()
        {
            //Load Patients from DB هنعمله هنا
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
                contentPanel.Controls.Add(row);
            }

            var header = new PatientTableHeader { Dock = DockStyle.Top };
            contentPanel.Controls.Add(header);
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
    }
}