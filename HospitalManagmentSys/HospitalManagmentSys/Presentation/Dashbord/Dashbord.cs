using HospitalManagmentSys.Presentation;
using HospitalManagmentSys.Presentation.Dashbord;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.IO;

namespace Dashboard
{
    //    public partial class Dashbord : Form
    //    {

    //        public Dashbord()
    //        {
    //            InitializeComponent();
    //            this.Padding = new Padding(200, 0, 0, 0);
    //            this.MinimumSize = new Size(1200,700);
    //            Panel mainContainer = new Panel();
    //            mainContainer.Dock = DockStyle.Fill;
    //            mainContainer.AutoScroll = true;
    //            mainContainer.Left = 1000;
    //            this.Controls.Clear();
    //            this.Controls.Add(mainContainer);

    //            TableLayoutPanel root = new TableLayoutPanel();
    //            root.Dock = DockStyle.Top;
    //            root.AutoSize = true;
    //            root.ColumnCount = 1;
    //            root.Padding = new Padding(10);

    //            mainContainer.Controls.Add(root);

    //            // HEADER
    //            Control header = CreateHeader();
    //            header.Margin = new Padding(0, 0, 0, 15);
    //            root.Controls.Add(header);

    //            // KPIs
    //            Control kpis = CreateKPIs();
    //            kpis.Margin = new Padding(0, 0, 0, 20);
    //            root.Controls.Add(kpis);
    //// --- ????? ?????: ???????? ---

    //// 1. ????? ???????? ???????
    //Label appointmentTitle = new Label();
    //appointmentTitle.Text = "?? ???????? ???????";
    //appointmentTitle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
    //appointmentTitle.ForeColor = Color.DarkBlue;
    //appointmentTitle.AutoSize = true; // ???? true ???? ???? ????? ???? ??
    //appointmentTitle.Margin = new Padding(20, 10, 0, 5); // ?????? ?????? ???????
    //root.Controls.Add(appointmentTitle);

    //// 2. ????? ???? ????????
    //FlowLayoutPanel cardsContainer = new FlowLayoutPanel();
    //cardsContainer.AutoSize = true;
    //cardsContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    //cardsContainer.FlowDirection = FlowDirection.LeftToRight;
    //cardsContainer.WrapContents = true; 
    //cardsContainer.Width = 900;
    //cardsContainer.Padding = new Padding(5);
    //cardsContainer.Margin = new Padding(0, 0, 0, 20);

    //var a1 = new AppointmentCardControl();
    //a1.Size = new Size(250, 120);
    //a1.Margin = new Padding(10);
    //var a3 = new DoctorCardControl();
    //a3.Margin = new Padding(10);

    //cardsContainer.Controls.Add(a1);
    //cardsContainer.Controls.Add(a3);

    //root.Controls.Add(cardsContainer); // ??? ??????? ??? ??????? ?????

    //// --- ????? ??????: ??????? ?? ?????? ---

    //// 3. ????? ????? ?????? (??? ??????? ??????)
    //Label patientTitle = new Label();
    //patientTitle.Text = "?? ????? ?????? ????????";
    //patientTitle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
    //patientTitle.ForeColor = Color.DarkBlue;
    //patientTitle.AutoSize = true;
    //patientTitle.Margin = new Padding(20, 10, 0, 5);
    //root.Controls.Add(patientTitle);

    //// 4. ????? ???? ??????
    //FlowLayoutPanel doctorContainer = new FlowLayoutPanel();
    //doctorContainer.AutoSize = true;
    //doctorContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    //doctorContainer.FlowDirection = FlowDirection.LeftToRight;
    //doctorContainer.WrapContents = true;
    //doctorContainer.Width = 900;
    //doctorContainer.Padding = new Padding(5);

    //var a2 = new PatientCardControl();
    //a2.Size = new Size(500, 120);
    //a2.Margin = new Padding(10);

    //doctorContainer.Controls.Add(a2);

    //root.Controls.Add(doctorContainer); 
    //            root.Controls.Add(doctorContainer);

    //            Control progress = CreateProgressSection();
    //            progress.Margin = new Padding(0, 0, 0, 30);

    //            root.Controls.Add(progress);


    //        }
    //        private Control CreateHeader()
    //        {
    //            Panel header = new Panel();
    //            header.Width = 900;
    //            header.Height = 100;

    //            Label title = new Label();
    //            title.Text = "Dashboard";
    //            title.Font = new Font("Segoe UI", 18, FontStyle.Bold);
    //            title.Location = new Point(10, 5);
    //            title.AutoSize = true;
    //            Label subtitle = new Label();
    //            subtitle.Text = "Welcome back! Here’s your hospital overview.";
    //            subtitle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
    //            subtitle.ForeColor = Color.Gray;
    //            subtitle.AutoSize = true;
    //            subtitle.Location = new Point(10, 40);

    //            header.Controls.Add(title);
    //            header.Controls.Add(subtitle);
    //            header.Controls.Add(ViewQueu);
    //            header.Controls.Add(NewAppoint);






    //            return header;
    //        }
    //        private Control CreateKPIs()
    //        {
    //            FlowLayoutPanel panel = new FlowLayoutPanel();
    //            panel.Width = 900;
    //            panel.Height = 200;

    //            panel.Controls.Add(TPatients);
    //            panel.Controls.Add(TodayAppoin);
    //            panel.Controls.Add(NoShow);
    //            panel.Controls.Add(PatientsWating);

    //            foreach (Control c in panel.Controls)
    //            {
    //                c.Margin = new Padding(10);
    //            }

    //            return panel;
    //        }
    //        private Control CreateProgressSection()
    //        {
    //            Panel container = new Panel();
    //            container.Width = 700;
    //            container.Height = 450;
    //            container.Margin = new Padding(10);

    //            Label title = new Label();
    //            title.Text = "Today’s Progress";
    //            title.Font = new Font("Segoe UI", 12, FontStyle.Bold);
    //            title.AutoSize = true;
    //            title.Location = new Point(0, 0);

    //            panel5.Location = new Point(0, 40);
    //            panel5.Width = 450;

    //            container.Controls.Add(title);
    //            container.Controls.Add(panel5);

    //            return container;
    //        }

    //    }
    public partial class Dashbord : Form
    {
        private TableLayoutPanel root;
        private Panel MainContainer;
        public Dashbord()
        {
            InitializeComponent();
            SetupFormLayout();
            BuildDashboardLayout();

        }
        private void SetupFormLayout()
        {
            this.Padding = new Padding(200, 0, 0, 0);
            this.MinimumSize = new Size(1100, 700);
            this.Controls.Clear();

            mainContainer = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };
            this.Controls.Add(mainContainer);

            root = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                ColumnCount = 1,
                Padding = new Padding(10)
            };
            mainContainer.Controls.Add(root);
        }

        private void BuildDashboardLayout()
        {
            root.Controls.Add( CreateHeader());
            root.Controls.Add( CreateKPIs());

            // 1. ??????? ???? ???????
            FlowLayoutPanel horizontalWrapper = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true
            };

            FlowLayoutPanel queueGroup = new FlowLayoutPanel { FlowDirection = FlowDirection.TopDown, AutoSize = true };
            queueGroup.Controls.Add(CreateSectionTitle("Queue Status:"));
            queueGroup.Controls.Add(new AppointmentsListSection()); 

            FlowLayoutPanel doctorsGroup = new FlowLayoutPanel { FlowDirection = FlowDirection.TopDown, AutoSize = true };
            doctorsGroup.Controls.Add(CreateSectionTitle("Doctors Availability:"));
            doctorsGroup.Controls.Add(new DoctorsListSection()); 

            
            horizontalWrapper.Controls.Add(queueGroup);
            horizontalWrapper.Controls.Add(doctorsGroup);


            root.Controls.Add(horizontalWrapper);

            root.Controls.Add(CreateSectionTitle("Upcoming Appointments:"));
            root.Controls.Add(new PatientListSection());

            root.Controls.Add(CreateProgressSection());

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

        private Label CreateSectionTitle(string text, Padding? margin = null)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                Margin = margin ?? new Padding(20, 10, 0, 5)
            };
        }
    }
    public class AppointmentsListSection : FlowLayoutPanel
    {
        public AppointmentsListSection()
        {
            this.AutoSize = true;
            this.FlowDirection = FlowDirection.TopDown; 
            this.WrapContents = false;
            this.Width = 400; 
            LoadData();
        }

        private void LoadData()
        {
            this.Controls.Add(new AppointmentCardControl { Size = new Size(250, 120) });
            this.Controls.Add(new AppointmentCardControl { Size = new Size(250, 120) });
            this.Controls.Add(new AppointmentCardControl { Size = new Size(250, 120) });
            this.Controls.Add(new AppointmentCardControl { Size = new Size(250, 120) });

        }
    }
    public class DoctorsListSection : FlowLayoutPanel
    {
        public DoctorsListSection()
        {
            this.AutoSize = true;
            this.FlowDirection = FlowDirection.TopDown; 
            this.WrapContents = false;
            this.Width = 400;
            LoadData();
        }

        private void LoadData()
        {
            this.Controls.Add(new DoctorCardControl());
            this.Controls.Add(new DoctorCardControl());
            this.Controls.Add(new DoctorCardControl());
            this.Controls.Add(new DoctorCardControl());

        }
    }

    public class  PatientListSection: FlowLayoutPanel
    {
        public PatientListSection()
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.FlowDirection = FlowDirection.LeftToRight;
            this.WrapContents = true;
            this.Width = 900;
            this.Padding = new Padding(5);
            LoadData();
        }
        private void LoadData()
        {
            // ?????? ????? ??????
            this.Controls.Add(new PatientCardControl { Size = new Size(500, 120), Margin = new Padding(10) });
        }


    }
}
