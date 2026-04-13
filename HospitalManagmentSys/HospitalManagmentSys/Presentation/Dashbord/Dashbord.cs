using Guna.UI2.WinForms;
using HospitalManagmentSys.BiussnessLogic;
using HospitalManagmentSys.Data.Models;
using HospitalManagmentSys.Presentation;
using HospitalManagmentSys.Presentation.Dashbord;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Dashboard
{

    public partial class Dashbord : Form
    {
        private TableLayoutPanel root;
        private Panel MainContainer;
        private DashbordServices dashbordServices;

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
            root.Controls.Add(CreateHeader());
            root.Controls.Add(CreateKPIs());

            FlowLayoutPanel horizontalWrapper = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true
            };
         

        FlowLayoutPanel queueGroup = new FlowLayoutPanel { FlowDirection = FlowDirection.TopDown, AutoSize = true };
            queueGroup.Paint += QueueGroup_Paint;
            queueGroup.Controls.Add(CreateSectionTitle("Queue Status:"));
            queueGroup.Controls.Add(new AppointmentsListSection()); 

            FlowLayoutPanel doctorsGroup = new FlowLayoutPanel { FlowDirection = FlowDirection.TopDown, AutoSize = true };
            doctorsGroup.Paint += DoctorsGroup_Paint;

            doctorsGroup.Controls.Add(CreateSectionTitle("Doctors Availability:"));
            doctorsGroup.Controls.Add(new DoctorsListSection()); 

            
            horizontalWrapper.Controls.Add(queueGroup);
            horizontalWrapper.Controls.Add(doctorsGroup);


            root.Controls.Add(horizontalWrapper);

            root.Controls.Add(CreateSectionTitle("Today Appointments:"));
            PatientListSection patientGroup = new PatientListSection();
            patientGroup.Paint += PatientGroup_Paint;
            root.Controls.Add(patientGroup);

            root.Controls.Add(CreateProgressSection());

        }
        private Control CreateKPIs()
        {
            dashbordServices = new DashbordServices();
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Width = 900;
            panel.Height = 200;
            var TPatient = TPatients.Controls["TPtient"] as Label;
            TPatient.Text = dashbordServices.totalPatients().ToString();
            panel.Controls.Add(TPatients);

            var TAppoint = TodayAppoin.Controls["TAppoint"] as Label;
            TAppoint.Text = dashbordServices.todayAppointments().ToString();
            panel.Controls.Add(TodayAppoin);

            var NoSH = NoShow.Controls["NoSH"] as Label;
            NoSH.Text = dashbordServices.NoShowNumber().ToString();
            panel.Controls.Add(NoShow);

            var PatientWaiting = PatientsWating.Controls["PatientWaiting"] as Label;
            PatientWaiting.Text = dashbordServices.WaitingNow().ToString();
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
            DashbordServices dashbordServices = new DashbordServices();

            Panel container = new Panel();
            container.Width = 700;
            container.Height = 450;
            container.Margin = new Padding(10);

            Label title = new Label();
            title.Text = "Today’s Progress";
            title.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            title.AutoSize = true;
            title.Location = new Point(0, 0);

            progress.Location = new Point(0, 40);
            progress.Width = 450;

            

            UpdateDashboardProgress();
            var lblCompleted = progress.Controls["completed"]?.Controls["panel14"]?.Controls["label12"] as Label;
            if (lblCompleted != null)
                lblCompleted.Text = dashbordServices.TodayAppointmentsCompleted().ToString();

            var lblWaiting = progress.Controls["waiting"]?.Controls["panel14"]?.Controls["label13"] as Label;
            if (lblWaiting != null)
                lblWaiting.Text = dashbordServices.WaitingNow().ToString();

            var lblNoShow = progress.Controls["nosho"]?.Controls["panel14"]?.Controls["label14"] as Label;
            if (lblNoShow != null)
                lblNoShow.Text = "7";
            container.Controls.Add(title);
            container.Controls.Add(progress);


            return container;
        }
      
        private void UpdateDashboardProgress()
        {
            DashbordServices services = new DashbordServices();

            int completed = services.TodayAppointmentsCompleted();
            int total = services.todayAppointments();

            
            int progressPercentage = 0;
            if (total > 0)
            {
                progressPercentage = (completed * 100) / total;
            }

            if (progress.Controls["prgUrgency"] is Guna2ProgressBar prg)
            {
                prg.Value = progressPercentage;

                if (progressPercentage < 40)
                    prg.ProgressColor = Color.Red;
                else if (progressPercentage < 80)
                    prg.ProgressColor = Color.Orange;
                else
                    prg.ProgressColor = Color.FromArgb(34, 197, 94); 
            }
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

        private void Dashbord_Load(object sender, EventArgs e)
        {

        }
        private void QueueGroup_Paint(object sender, PaintEventArgs e)
        {
            FlowLayoutPanel panel = (FlowLayoutPanel)sender;

            Color borderColor = Color.DarkGray; 
            int borderWidth = 2;

            ControlPaint.DrawBorder3D(e.Graphics, panel.ClientRectangle, Border3DStyle.RaisedInner);
        }
        private void PatientGroup_Paint(object sender, PaintEventArgs e)
        {
            FlowLayoutPanel panel = (FlowLayoutPanel)sender;

            Color borderColor = Color.DarkGray;
            int borderWidth = 2;

            ControlPaint.DrawBorder3D(e.Graphics, panel.ClientRectangle, Border3DStyle.RaisedInner);
        }
        private void DoctorsGroup_Paint(object sender, PaintEventArgs e)
        {
            FlowLayoutPanel panel = (FlowLayoutPanel)sender;

            Color borderColor = Color.DarkGray;
            int borderWidth = 2;

            ControlPaint.DrawBorder3D(e.Graphics, panel.ClientRectangle, Border3DStyle.RaisedInner);
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
            this.Controls.Clear();

            DashbordServices dashbordServices = new DashbordServices();
            var doctors = dashbordServices.DoctorsAvailable();

            foreach (var n in doctors)
            {
                if (n.Doctor == null) continue;

                DoctorCardControl doc = new DoctorCardControl();

                if (doc.Controls["DocName"] is Label lblName)
                    lblName.Text = n.Name;

                if (doc.Controls["specialty"] is Label lblSpec)
                    lblSpec.Text = n.Doctor.Specialty;
               
                if (doc.Controls["btnAvatar"] is Guna.UI2.WinForms.Guna2CircleButton avar)
                    avar.Text = dashbordServices.FChar(n.Name);

                this.Controls.Add(doc);
            }
        }
    }

    public class  PatientListSection: FlowLayoutPanel
    {
        public PatientListSection()
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.FlowDirection = FlowDirection.TopDown;
            this.WrapContents = true;
            this.Width = 900;
            this.Padding = new Padding(5);
            LoadData();
        }

        private void LoadData()
        {
            this.Controls.Clear();

            DashbordServices dashbordServices = new DashbordServices();
            var Appoins = dashbordServices.Appoinments();

            foreach (var appt in Appoins)
            {
                if (appt.Doctor == null) continue;
                if (appt.Patient == null) continue;
                if (appt.TimeSlot == null) continue;

                PatientCardControl patien = new PatientCardControl();

                if (patien.Controls["DocName"] is Label lblName)
                    lblName.Text = appt.Doctor.User.Name;

                if (patien.Controls["PatieName"] is Label PaName)
                    PaName.Text = appt.Patient.FullName;

                if (patien.Controls["Urgency"] is Guna2Button UrgName)
                {
                    switch (appt.Patient.MedicalUrgency)
                    {
                        case MedicalUrgency.Low:
                            UrgName.Text = "Low";
                            UrgName.FillColor = Color.Green;
                            UrgName.ForeColor = Color.White;
                            break;

                        case MedicalUrgency.Medium:
                            UrgName.Text = "Medium";
                            UrgName.FillColor = Color.Orange;
                            UrgName.ForeColor = Color.White;
                            break;

                        case MedicalUrgency.High:
                            UrgName.Text = "High";
                            UrgName.FillColor = Color.FromArgb(220, 38, 38);
                            UrgName.ForeColor = Color.White;
                            break;

                        default:
                            UrgName.Text = "No Status";
                            UrgName.FillColor = Color.LightGray;
                            break;
                    }
                }
                   

                if (patien.Controls["Time"] is Label time)
                    time.Text = appt.TimeSlot.StartTime.ToString();


                if (patien.Controls["bStatus"] is Guna2Button StaName)
                {
                    switch (appt.Status)
                    {
                        case AppointmentStatus.Pending:
                            StaName.Text = "Pending";
                            StaName.FillColor = Color.FromArgb(34, 197, 94);
                            StaName.ForeColor = Color.White;
                            break;

                        case AppointmentStatus.Completed:
                            StaName.Text = "Completed";
                            StaName.FillColor = Color.FromArgb(239, 68, 68);
                            StaName.ForeColor = Color.White;
                            break;

                        case AppointmentStatus.Cancelled:
                            StaName.Text = "Cancelled";
                            StaName.FillColor = Color.FromArgb(107, 114, 128);
                            StaName.ForeColor = Color.White;
                            break;

                        default:
                            StaName.Text = "No Status";
                            StaName.FillColor = Color.LightGray;
                            break;
                    }
                }

                if (patien.Controls["Speciality"] is Label lblSpec)
                           lblSpec.Text = appt.Doctor.Specialty;

                if (patien.Controls["btnAvatar"] is Guna2CircleButton avar)
                    avar.Text = dashbordServices.FCharr(appt.Patient.FullName);

                this.Controls.Add(patien);
            }
           
        }


    }
}
