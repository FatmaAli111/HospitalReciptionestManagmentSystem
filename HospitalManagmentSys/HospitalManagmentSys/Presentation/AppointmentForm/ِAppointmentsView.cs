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
            RenderCards(_allAppointments);
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
                var card = new AppointmentsCardView(appointment);
                card.Width = flpList.ClientSize.Width - 20;
                card.Margin = new Padding(0, 0, 0, 16);
                flpList.Controls.Add(card);
            }
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

        }
    }
}