using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace HospitalManagmentSys.Presentation.Dashbord
{
    partial class DashboardControl1
    {
        private System.ComponentModel.IContainer components = null;

        // HEADER
        private Panel header;
        private Label label2;
        private Label label3;
        private Guna2Button ViewQueu;
        private Guna2Button NewAppoint;

        // KPI CARDS
        private FlowLayoutPanel flowLayoutPanel4;
        private Panel TPatients;
        private Panel TodayAppoin;
        private Panel NoShow;
        private Panel PatientsWating;

        private Label TPtient;
        private Label TotalPatients;
        private Panel panel8;

        private Label TAppoint;
        private Label TodaysAppointments;
        private Panel panel7;

        private Label NoSH;
        private Label label1;
        private Guna2Panel guna2Panel1;

        private Label PatientWaiting;
        private Label PatientsWatingNow;
        private Panel panel11;

        // TODAY APPOINTMENTS + DOCTOR AVAILABILITY
        private TableLayoutPanel doctorAndAppointmentsRow;
        private Panel todayAppointmentsContainer;
        private Panel doctorAvailabilityContainer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            // ============================
            // HEADER
            // ============================
            header = new Panel
            {
                Dock = DockStyle.Top,
                Height = 90,
                BackColor = Color.WhiteSmoke
            };

            label2 = new Label
            {
                Text = "Dashboard",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                Location = new Point(20, 10),
                AutoSize = true
            };

            label3 = new Label
            {
                Text = "Welcome back! Here’s your hospital overview.",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.Gray,
                Location = new Point(22, 50),
                AutoSize = true
            };

            ViewQueu = new Guna2Button
            {
                Name = "ViewQueu",
                Text = "View Queue",
                Size = new Size(150, 40),
                Location = new Point(900, 20),
                FillColor = Color.Gainsboro,
                ForeColor = Color.Black
            };
            ViewQueu.Click += ViewQueu_Click_1;

            NewAppoint = new Guna2Button
            {
                Name = "NewAppoint",
                Text = "New Appointment",
                Size = new Size(180, 40),
                Location = new Point(1060, 20),
                FillColor = Color.FromArgb(0, 0, 128),
                ForeColor = Color.White
            };
            NewAppoint.Click += NewAppoint_Click_2;

            header.Controls.Add(label2);
            header.Controls.Add(label3);
            header.Controls.Add(ViewQueu);
            header.Controls.Add(NewAppoint);

            // ============================
            // KPI CARDS
            // ============================
            flowLayoutPanel4 = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 230,
                Padding = new Padding(20),
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false
            };

            Size cardSize = new Size(350, 200);

            // ===== Total Patients =====
            TPatients = new Panel
            {
                Name = "TPatients",
                Size = cardSize,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10)
            };

            panel8 = new Panel
            {
                Name = "panel8",
                Size = new Size(55, 55),
                Location = new Point((350 - 55) / 2, 15),
                BackgroundImageLayout = ImageLayout.Stretch,
                BackgroundImage = SystemIcons.Information.ToBitmap()
            };

            TPtient = new Label
            {
                Name = "TPtient",
                Font = new Font("Segoe UI", 28, FontStyle.Bold),
                ForeColor = Color.FromArgb(60, 60, 60),
                AutoSize = true,
                Location = new Point((350 / 2) - 20, 85),
                Text = "0"
            };

            TotalPatients = new Label
            {
                Name = "TotalPatients",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point((350 / 2) - 60, 145),
                Text = "Total Patients"
            };

            TPatients.Controls.Add(panel8);
            TPatients.Controls.Add(TPtient);
            TPatients.Controls.Add(TotalPatients);

            // ===== Today Appointments =====
            TodayAppoin = new Panel
            {
                Name = "TodayAppoin",
                Size = cardSize,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10)
            };

            panel7 = new Panel
            {
                Name = "panel7",
                Size = new Size(55, 55),
                Location = new Point((350 - 55) / 2, 15),
                BackgroundImageLayout = ImageLayout.Stretch,
                BackgroundImage = SystemIcons.Application.ToBitmap()
            };

            TAppoint = new Label
            {
                Name = "TAppoint",
                Font = new Font("Segoe UI", 28, FontStyle.Bold),
                ForeColor = Color.FromArgb(60, 60, 60),
                AutoSize = true,
                Location = new Point((350 / 2) - 20, 85),
                Text = "0"
            };

            TodaysAppointments = new Label
            {
                Name = "TodaysAppointments",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point((350 / 2) - 90, 145),
                Text = "Today’s Appointments"
            };

            TodayAppoin.Controls.Add(panel7);
            TodayAppoin.Controls.Add(TAppoint);
            TodayAppoin.Controls.Add(TodaysAppointments);

            // ===== No Show =====
            NoShow = new Panel
            {
                Name = "NoShow",
                Size = cardSize,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10)
            };

            guna2Panel1 = new Guna2Panel
            {
                Name = "guna2Panel1",
                Size = new Size(55, 55),
                Location = new Point((350 - 55) / 2, 15),
                BackgroundImageLayout = ImageLayout.Stretch,
                BackgroundImage = SystemIcons.Warning.ToBitmap()
            };

            NoSH = new Label
            {
                Name = "NoSH",
                Font = new Font("Segoe UI", 28, FontStyle.Bold),
                ForeColor = Color.FromArgb(60, 60, 60),
                AutoSize = true,
                Location = new Point((350 / 2) - 20, 85),
                Text = "0"
            };

            label1 = new Label
            {
                Name = "label1",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point((350 / 2) - 60, 145),
                Text = "No Show Rate"
            };

            NoShow.Controls.Add(guna2Panel1);
            NoShow.Controls.Add(NoSH);
            NoShow.Controls.Add(label1);

            // ===== Patients Waiting =====
            PatientsWating = new Panel
            {
                Name = "PatientsWating",
                Size = cardSize,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10)
            };

            panel11 = new Panel
            {
                Name = "panel11",
                Size = new Size(55, 55),
                Location = new Point((350 - 55) / 2, 15),
                BackgroundImageLayout = ImageLayout.Stretch,
                BackgroundImage = SystemIcons.Shield.ToBitmap()
            };

            PatientWaiting = new Label
            {
                Name = "PatientWaiting",
                Font = new Font("Segoe UI", 28, FontStyle.Bold),
                ForeColor = Color.FromArgb(60, 60, 60),
                AutoSize = true,
                Location = new Point((350 / 2) - 20, 85),
                Text = "0"
            };

            PatientsWatingNow = new Label
            {
                Name = "PatientsWatingNow",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point((350 / 2) - 100, 145),
                Text = "Patients Waiting Now"
            };

            PatientsWating.Controls.Add(panel11);
            PatientsWating.Controls.Add(PatientWaiting);
            PatientsWating.Controls.Add(PatientsWatingNow);

            // Add KPI cards
            flowLayoutPanel4.Controls.Add(TPatients);
            flowLayoutPanel4.Controls.Add(TodayAppoin);
            flowLayoutPanel4.Controls.Add(NoShow);
            flowLayoutPanel4.Controls.Add(PatientsWating);

            // ============================
            // TODAY APPOINTMENTS + DOCTOR AVAILABILITY
            // ============================
            doctorAndAppointmentsRow = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 450,
                BackColor = Color.White,
                ColumnCount = 2,
                RowCount = 1,
                Padding = new Padding(20),
            };

            doctorAndAppointmentsRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
             doctorAndAppointmentsRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            // LEFT SIDE — TODAY APPOINTMENTS
            todayAppointmentsContainer = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            Label todayTitle = new Label
            {
                Text = "Today Appointments",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(10, 10)
            };
            todayAppointmentsContainer.Controls.Add(todayTitle);

            PatientListSection patientList = new PatientListSection
            {
                Location = new Point(10, 50),
                Width = todayAppointmentsContainer.Width - 20,
                Height = 360,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            todayAppointmentsContainer.Controls.Add(patientList);

            // RIGHT SIDE — DOCTOR AVAILABILITY
            doctorAvailabilityContainer = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            Label doctorTitle = new Label
            {
                Text = "Doctor Availability",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(10, 10)
            };
            doctorAvailabilityContainer.Controls.Add(doctorTitle);

            DoctorsListSection doctorsList = new DoctorsListSection
            {
                Location = new Point(10, 50),
                Width = doctorAvailabilityContainer.Width - 20,
                Height = 360,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            doctorAvailabilityContainer.Controls.Add(doctorsList);

            doctorAndAppointmentsRow.Controls.Add(todayAppointmentsContainer);
            doctorAndAppointmentsRow.Controls.Add(doctorAvailabilityContainer);
            //doctorAndAppointmentsRow.Controls.Add(todayAppointmentsContainer, 0, 0);
            //doctorAndAppointmentsRow.Controls.Add(doctorAvailabilityContainer, 1, 0);

            // ============================
            // ADD TO CONTROL
            // ============================
            this.Controls.Add(doctorAndAppointmentsRow);
            this.Controls.Add(flowLayoutPanel4);
            this.Controls.Add(header);

            this.BackColor = Color.White;
            this.Size = new Size(1300, 900);
        }
    }
}
