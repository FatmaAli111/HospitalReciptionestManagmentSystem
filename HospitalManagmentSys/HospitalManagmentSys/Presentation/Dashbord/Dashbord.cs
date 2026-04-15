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
        private Panel cardsPanel;
        private AppointmentsListSection appointmentsList;

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

            MainContainer = new Panel  
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };
            this.Controls.Add(MainContainer);

            root = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                ColumnCount = 1,
                Padding = new Padding(10)
            };
            MainContainer.Controls.Add(root);
        }

        private void BuildDashboardLayout()
        {
            cardsPanel = new Panel();
            cardsPanel.Dock = DockStyle.Fill;
            this.Controls.Add(cardsPanel);

            dashbordServices = new DashbordServices();
            root.Controls.Add(CreateHeader());
            root.Controls.Add(CreateKPIs());

            FlowLayoutPanel horizontalWrapper = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true
            };

            FlowLayoutPanel queueGroup = new FlowLayoutPanel { FlowDirection = FlowDirection.TopDown, AutoSize = true };
            queueGroup.Paint += QueueGroup_Paint;
            queueGroup.Controls.Add(CreateSectionTitle("Select doctor Queue:"));

            Guna2ComboBox co1 = new Guna2ComboBox();
            co1.Size = new Size(200, 35);
            co1.DisplayMember = "Name";
            co1.ValueMember = "Id";

            var doctors = dashbordServices.DoctorsAvailable();
            foreach (var item in doctors)
            {
                co1.Items.Add(item);
            }

            queueGroup.Controls.Add(co1);
            queueGroup.Controls.Add(CreateSectionTitle(" "));

            appointmentsList = new AppointmentsListSection(co1);
            queueGroup.Controls.Add(appointmentsList);

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
            if (TPatient != null) TPatient.Text = dashbordServices.totalPatients().ToString();
            panel.Controls.Add(TPatients);

            var TAppoint = TodayAppoin.Controls["TAppoint"] as Label;
            if (TAppoint != null) TAppoint.Text = dashbordServices.todayAppointments().ToString();
            panel.Controls.Add(TodayAppoin);

            var NoSH = NoShow.Controls["NoSH"] as Label;
            if (NoSH != null) NoSH.Text = dashbordServices.NoShowNumber().ToString();
            panel.Controls.Add(NoShow);

            var PatientWaiting = PatientsWating.Controls["PatientWaiting"] as Label;
            if (PatientWaiting != null) PatientWaiting.Text = dashbordServices.WaitingNow().ToString();
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
            subtitle.Text = "Welcome back! Here's your hospital overview.";
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
            var services = dashbordServices;

            FlowLayoutPanel container = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                Padding = new Padding(10)
            };

            var completed = new ProgressCardControl();
            completed.SetTitle("Completed");
            completed.SetValue(services.TodayAppointmentsCompleted());
            completed.SetProgress(services.TodayAppointmentsCompleted(), services.todayAppointments());

            var noShow = new ProgressCardControl();
            noShow.SetTitle("No Show");
            noShow.SetValue(services.NoShowNumber());
            noShow.SetProgress(services.NoShowNumber(), services.todayAppointments());

            var waiting = new ProgressCardControl();
            waiting.SetTitle("Waiting");
            waiting.SetValue(services.WaitingNow());
            waiting.SetProgress(services.WaitingNow(), services.todayAppointments());

            container.Controls.Add(completed);
            container.Controls.Add(noShow);
            container.Controls.Add(waiting);

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

        private void QueueGroup_Paint(object sender, PaintEventArgs e)
        {
            FlowLayoutPanel panel = (FlowLayoutPanel)sender;
            ControlPaint.DrawBorder3D(e.Graphics, panel.ClientRectangle, Border3DStyle.RaisedInner);
        }

        private void PatientGroup_Paint(object sender, PaintEventArgs e)
        {
            FlowLayoutPanel panel = (FlowLayoutPanel)sender;
            ControlPaint.DrawBorder3D(e.Graphics, panel.ClientRectangle, Border3DStyle.RaisedInner);
        }

        private void DoctorsGroup_Paint(object sender, PaintEventArgs e)
        {
            FlowLayoutPanel panel = (FlowLayoutPanel)sender;
            ControlPaint.DrawBorder3D(e.Graphics, panel.ClientRectangle, Border3DStyle.RaisedInner);
        }

        private void NewAppoint_Click(object sender, EventArgs e)
        {
            LoadControl(new AppointmentsView());
        }

        private void LoadControl(UserControl control)
        {
            if (MainContainer != null)
            {
                MainContainer.Controls.Clear();
                control.Dock = DockStyle.Fill;
                MainContainer.Controls.Add(control);
            }
        }

        private void ViewQueu_Click(object sender, EventArgs e)
        {
            QueueForm queueForm = new QueueForm();
            queueForm.ShowDialog();
        }
    }

    public class AppointmentsListSection : FlowLayoutPanel
    {
        private int selectedD = 1;
        private Panel appointmentsContainer;
        private Guna2ComboBox doctorComboBox;

        public AppointmentsListSection(Guna2ComboBox comboBox)
        {
            this.AutoSize = true;
            this.FlowDirection = FlowDirection.TopDown;
            this.WrapContents = false;
            this.Width = 400;

            doctorComboBox = comboBox;

            appointmentsContainer = new Panel
            {
                Dock = DockStyle.Top,
                AutoScroll = true,
                Height = 500,
                Width = this.Width - 20
            };

            this.Controls.Add(appointmentsContainer);

            if (doctorComboBox != null)
            {
                doctorComboBox.SelectedIndexChanged += co1_SelectedIndexChanged;
                if (doctorComboBox.Items.Count > 0)
                {
                    doctorComboBox.SelectedIndex = 0;
                }
            }

            LoadData();
        }

        private void co1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (doctorComboBox.SelectedItem != null)
            {
                dynamic selectedDoctor = doctorComboBox.SelectedItem;
                if (selectedDoctor != null)
                {
                    int doctorId = 1;
                    try
                    {
                        var propertyInfo = selectedDoctor.GetType().GetProperty("Id");
                        if (propertyInfo != null)
                        {
                            doctorId = (int)propertyInfo.GetValue(selectedDoctor);
                        }
                        else
                        {
                            doctorId = doctorComboBox.SelectedIndex + 1;
                        }
                    }
                    catch
                    {
                        doctorId = doctorComboBox.SelectedIndex + 1;
                    }

                    selectedD = doctorId;
                    LoadData();
                }
            }
        }

        private void LoadData()
        {
            int num = 0;
            appointmentsContainer.Controls.Clear();

            DashbordServices dashbordServices = new DashbordServices();
            var Appoins = dashbordServices.AppoinmentQueue(selectedD);

            foreach (var appt in Appoins)
            {
                if (appt.Doctor == null || appt.Patient == null || appt.TimeSlot == null)
                    continue;

                AppointmentCardControl appoint = new AppointmentCardControl();

                if (appoint.Controls["ActualScore"] is Label lblName)
                    lblName.Text = appt.PriorityScore.ToString();

                if (appoint.Controls["PatientName"] is Label PaName)
                    PaName.Text = appt.Patient.FullName;

                if (appoint.Controls["Urgency"] is Guna2Button UrgName)
                {
                    switch (appt.Patient.MedicalUrgency)
                    {
                        case MedicalUrgency.Low:
                            UrgName.Text = "Low";
                            UrgName.FillColor = Color.Green;
                            break;
                        case MedicalUrgency.Medium:
                            UrgName.Text = "Medium";
                            UrgName.FillColor = Color.Orange;
                            break;
                        case MedicalUrgency.High:
                            UrgName.Text = "High";
                            UrgName.FillColor = Color.Red;
                            break;
                    }
                }

                if (appoint.Controls["btnAvatar"] is Guna2CircleButton avar)
                {
                    num++;
                    avar.Text = num.ToString();
                }

                appointmentsContainer.Controls.Add(appoint);
            }
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

                if (doc.Controls["btnAvatar"] is Guna2CircleButton avar)
                    avar.Text = dashbordServices.FChar(n.Name);

                this.Controls.Add(doc);
            }
        }
    }

    public class PatientListSection : FlowLayoutPanel
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

                if (patien.Controls["DctorN"] is Label lblName)
                    lblName.Text = appt.Doctor.User?.Name ?? "Unknown";

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