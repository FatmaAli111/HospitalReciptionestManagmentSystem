using HospitalManagmentSys.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HospitalManagmentSys.Presentation.ProfilePatient
{
    public partial class PatientDetailsForm : Form
    {
        private readonly Patient _patient;

        public PatientDetailsForm(Patient patient)
        {
            InitializeComponent();
            _patient = patient;
            PopulateData();
        }

        private void PopulateData()
        {

            avatarLabel.Text = _patient.Initials;

            nameLabel.Text = _patient.FullName;
            metaLabel.Text = $"Patient ID: {_patient.Id}  •  Registered: {_patient.CreatedAt:yyyy-MM-dd}";

            ageValueLabel.Text = _patient.Age.ToString();
            dobLabel.Text = _patient.DateOfBirth.ToString("yyyy-MM-dd");

            bloodValueLabel.Text = _patient.BloodType.ToString().Replace("_", " ");

            appointmentsValueLabel.Text = _patient.TotalAppointments.ToString();
            noShowLabel.Text = $"{_patient.NoShowCount} no-shows";

            phoneLabel.Text = _patient.Phone;
            emailLabel.Text = _patient.Email;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
