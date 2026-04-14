using HospitalManagmentSys.BiussnessLogic;
using HospitalManagmentSys.Data.Models;
using System;
using System.Windows.Forms;
namespace HospitalManagmentSys.Presentation
{
    public partial class AppointmentsView : UserControl
    {
        private readonly AppointmentService _service;
        private DateTime _currentDate = DateTime.Today;
        private IEnumerable<Appointment> _allAppointments;

        public AppointmentsView()
        {
            InitializeComponent();
            _service = new AppointmentService();
        }
        private void AppointmentsView_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }
        private void LoadAppointments()
        {
            _allAppointments = _service.GetAppointmentsByDate(_currentDate).ToList();
            lblDate.Text = _currentDate.ToString("dddd, MMMM d, yyyy");
            ApplyFilters();
        }

        private void RenderCards(IEnumerable<Appointment> appointments)
        {
            flpList.Controls.Clear();
            var list = appointments;
            lblCount.Text = list.Count() == 0
                ? "No appointments"
                : $"{list.Count()} appointments";

            foreach (Appointment appointment in list)
            {
                var card = new AppointmentsCardView(appointment,_service);
                card.Width = flpList.ClientSize.Width - 20;
                card.Margin = new Padding(0, 0, 0, 16);
                card.StatusChanged += (s, e) => LoadAppointments(); 

                flpList.Controls.Add(card);
            }

        }
        private void ApplyFilters()
        {
            IEnumerable<Appointment> filtered = _allAppointments;

            string search = txtSearch.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(search))
            {
                filtered = filtered.Where(a =>
                    a.Patient.FullName.ToLower().Contains(search) ||
                    a.Doctor.User.Name.ToLower().Contains(search));
            }

            if (cbStatus.SelectedIndex > 0) 
            {
                string selected = cbStatus.SelectedItem.ToString();
                if (Enum.TryParse<AppointmentStatus>(selected, out var status))
                    filtered = filtered.Where(a => a.Status == status);
            }

            RenderCards(filtered);
        }
        private void btnPrev_Click_1(object sender, EventArgs e)
        {
            _currentDate = _currentDate.AddDays(-1);
            LoadAppointments();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            _currentDate = _currentDate.AddDays(1);
            LoadAppointments();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            BookAppointmentForm form = new();
            form.ShowDialog();
            LoadAppointments();
        }

        private void flpList_Paint(object sender, PaintEventArgs e)
        {
            foreach (Control card in flpList.Controls)
            {
                card.Width = flpList.ClientSize.Width - 20;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
    }
}