using HospitalManagmentSys.Presentation;
using HospitalManagmentSys.Presentation.Dashbord;
using System.Drawing.Drawing2D;
using System.IO;

namespace Dashboard
{
    public partial class Dashbord : Form
    {

        public Dashbord()
        {
            InitializeComponent();
            this.Padding = new Padding(200, 0, 0, 0);
            this.MinimumSize = new Size(1200,700);
            Panel mainContainer = new Panel();
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.AutoScroll = true;
            mainContainer.Left = 1000;
            this.Controls.Clear();
            this.Controls.Add(mainContainer);

            TableLayoutPanel root = new TableLayoutPanel();
            root.Dock = DockStyle.Top;
            root.AutoSize = true;
            root.ColumnCount = 1;
            root.Padding = new Padding(10);

            mainContainer.Controls.Add(root);

            // HEADER
            Control header = CreateHeader();
            header.Margin = new Padding(0, 0, 0, 15);
            root.Controls.Add(header);

            // KPIs
            Control kpis = CreateKPIs();
            kpis.Margin = new Padding(0, 0, 0, 20);
            root.Controls.Add(kpis);

            FlowLayoutPanel cardsContainer = new FlowLayoutPanel();
            cardsContainer.AutoSize = true;
            cardsContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            cardsContainer.Width = 900;

            cardsContainer.FlowDirection = FlowDirection.LeftToRight;
            cardsContainer.WrapContents = true; 
            cardsContainer.Margin = new Padding(0, 0, 0, 20);
            cardsContainer.Padding = new Padding(5);

            Label title = new Label();
            title.Text = "Appointment";
            title.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            title.Location = new Point(10, 0);


            var a1 = new AppointmentCardControl();
            a1.Size = new Size(250, 120);
            a1.Margin = new Padding(10);
            var a3 = new DoctorCardControl();
            a3.Margin = new Padding(10);


            cardsContainer.Controls.Add(a1);
            cardsContainer.Controls.Add(title);

            cardsContainer.Controls.Add(a3);

            root.Controls.Add(cardsContainer);

            FlowLayoutPanel doctorContainer = new FlowLayoutPanel();
            doctorContainer.AutoSize = true;
            doctorContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            doctorContainer.Width = 900;
            doctorContainer.FlowDirection = FlowDirection.LeftToRight;
            doctorContainer.WrapContents = true;
            doctorContainer.Margin = new Padding(0, 0, 0, 20);
            doctorContainer.Padding = new Padding(5);

            var a2 = new PatientCardControl();
            a2.Size = new Size(500, 120);
            a2.Margin = new Padding(10);

            doctorContainer.Controls.Add(a2);


            root.Controls.Add(doctorContainer);

            Control progress = CreateProgressSection();
            progress.Margin = new Padding(0, 0, 0, 30);

            root.Controls.Add(progress);

            
        }
        private Control CreateHeader()
        {
            Panel header = new Panel();
            header.Width = 900;
            header.Height = 100;

            Label title = new Label();
            title.Text = "Dashboard";
            title.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            title.Location = new Point(10, 5);
            title.AutoSize = true;
            Label subtitle = new Label();
            subtitle.Text = "Welcome back! Here’s your hospital overview.";
            subtitle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            subtitle.ForeColor = Color.Gray;
            subtitle.AutoSize = true;
            subtitle.Location = new Point(10, 40);
           
            header.Controls.Add(title);
            header.Controls.Add(subtitle);
            header.Controls.Add(ViewQueu);
            header.Controls.Add(NewAppoint);

            




            return header;
        }
        private Control CreateKPIs()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Width = 900;
            panel.Height = 200;

            panel.Controls.Add(TPatients);
            panel.Controls.Add(TodayAppoin);
            panel.Controls.Add(NoShow);
            panel.Controls.Add(PatientsWating);

            foreach (Control c in panel.Controls)
            {
                c.Margin = new Padding(10);
            }

            return panel;
        }
        private Control CreateProgressSection()
        {
            Panel container = new Panel();
            container.Width = 700;
            container.Height = 450;
            container.Margin = new Padding(10);

            Label title = new Label();
            title.Text = "Today’s Progress";
            title.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            title.AutoSize = true;
            title.Location = new Point(0, 0);

            panel5.Location = new Point(0, 40);
            panel5.Width = 450;

            container.Controls.Add(title);
            container.Controls.Add(panel5);

            return container;
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void doctorCardControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
