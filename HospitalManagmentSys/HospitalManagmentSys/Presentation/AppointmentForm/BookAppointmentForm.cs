using HospitalManagmentSys.BiussnessLogic;
using HospitalManagmentSys.Data;
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
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace HospitalManagmentSys.Presentation
{
    public partial class BookAppointmentForm : Form
    {
        private readonly AppointmentService _Service;
        public BookAppointmentForm()
        {

            InitializeComponent();
            _Service = new();
        }

        private void cmbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void BookAppointmentForm_Load(object sender, EventArgs e)
        {
            IEnumerable<Patient> patients = _Service.GetPatients().ToList();
            cmbPatient.DataSource = patients;
            cmbPatient.DisplayMember = "FullName";
            cmbPatient.ValueMember = "Id";

            var doctors = _Service.GetDoctors().Select(d => new { FullName = d.User.Name, d.Id }).ToList();
            cmbDoctor.DataSource = doctors;
            cmbDoctor.DisplayMember = "FullName";
            cmbDoctor.ValueMember = "Id";
            cmbDoctor.Text = "Doctor";

            cmbPriority.DrawMode = DrawMode.Normal;
            cmbPriority.DataSource = Enum.GetValues(typeof(MedicalUrgency));

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dtpDate.Value.Date + dtpTime.Value.TimeOfDay;

            var appointment = new Appointment
            {
                PatientId = (int)cmbPatient.SelectedValue,
                DoctorId = (int)cmbDoctor.SelectedValue,
                PriorityScore = (double)(MedicalUrgency)cmbPriority.SelectedItem,
                Description = txtReason.Text
            };

            string result = _Service.AddAppointment(appointment, dateTime);
            MessageBox.Show(result);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
