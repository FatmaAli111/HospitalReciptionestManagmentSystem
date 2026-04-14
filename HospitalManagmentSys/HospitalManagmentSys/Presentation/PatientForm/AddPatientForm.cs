using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HospitalManagmentSys.Data;
using HospitalManagmentSys.Data.Models;

namespace HospitalManagmentSys.Presentation.PatientForm
{
    public partial class AddPatientForm : Form
    {
        private readonly AppDbContext _context = new AppDbContext();

        public AddPatientForm()
        {
            InitializeComponent();
            LoadComboBoxData();
        }

        private void LoadComboBoxData()
        {
            genderCombo.DataSource = Enum.GetValues(typeof(Gender));
            urgencyCombo.DataSource = Enum.GetValues(typeof(MedicalUrgency));
            booldTypeCombo.DataSource = Enum.GetValues(typeof(BloodType));
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(FullNameTextBox.Text) || string.IsNullOrWhiteSpace(PhoneNumberTextBox.Text))
                {
                    MessageBox.Show("Name and Phone are required.");
                    return;
                }

                if (_context.Patients.Any(p => p.Phone == PhoneNumberTextBox.Text.Trim()))
                {
                    MessageBox.Show("Patient with this phone already exists.");
                    return;
                }

                var newPatient = new Patient
                {
                    FullName = FullNameTextBox.Text.Trim(),
                    Phone = PhoneNumberTextBox.Text.Trim(),
                    Email = EmailTextBox.Text.Trim(),
                    DateOfBirth = dobPicker.Value,
                    Gender = (Gender)genderCombo.SelectedItem,
                    MedicalUrgency = (MedicalUrgency)urgencyCombo.SelectedItem,
                    BloodType = (BloodType)booldTypeCombo.SelectedItem,
                    CreatedAt = DateTime.Now,
                    NoShowCount = 0,
                    AttendanceRate = 100.0
                };

                _context.Patients.Add(newPatient);
                _context.SaveChanges();

                MessageBox.Show("Patient Added Successfully");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show($"Error: {msg}");
            }
        }
    }
}