using System.Windows.Forms;

namespace HospitalManagmentSys.Presentation
{
    public partial class AppointmentsView : UserControl
    {
        public AppointmentsView()
        {
            InitializeComponent();
        }

        private void tlpRoot_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            BookAppointmentForm form = new();
            form.Show();
        }
    }
}