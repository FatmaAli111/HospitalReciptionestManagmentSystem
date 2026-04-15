using HospitalManagmentSys.Presentation.Controls.Sidebar;
using HospitalManagmentSys.Presentation;

namespace Dashboard
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
            SetupSidebar();
        }

        private void SetupSidebar()
        {
            sidebarControl1.NavigationChanged += (s, e) =>
            {
                switch (e.Item)
                {
                    case SidebarNavigationItem.Queue:
                        var queueForm = new HospitalManagmentSys.Presentation.QueueForm();
                        OpenForm(queueForm);
                        break;

                    case SidebarNavigationItem.Patients:
                        var patientsForm = new HospitalManagmentSys.Presentation.PatientsForm();
                        OpenForm(patientsForm);
                        break;

                    case SidebarNavigationItem.Appointments:
                        var appointmentsForm = new HospitalManagmentSys.Presentation.AppointmentsHostForm();
                        OpenForm(appointmentsForm);
                        break;

                    case SidebarNavigationItem.Dashboard:
                        // Already on dashboard
                        break;

                    case SidebarNavigationItem.Reports:
                        var reportsForm = new HospitalManagmentSys.Presentation.Form1();
                        OpenForm(reportsForm);
                        break;
                }
            };
        }

        private void OpenForm(Form form)
        {
            form.Show();
            this.Hide();
            form.FormClosed += (s, e) => this.Show();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PatientsWatingNow_Click(object sender, EventArgs e)
        {

        }

        private void PatientWaiting_Click(object sender, EventArgs e)
        {

        }

        private void NoSH_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void DocName_Click(object sender, EventArgs e)
        {

        }
    }
}
