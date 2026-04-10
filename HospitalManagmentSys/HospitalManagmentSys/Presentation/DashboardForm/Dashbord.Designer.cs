namespace Dashboard
{
    partial class Dashbord
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashbord));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            PatientsWating = new Panel();
            PatientWaiting = new Label();
            PatientsWatingNow = new Label();
            panel10 = new Panel();
            panel3 = new Panel();
            ActiveDoc = new Label();
            ActiveDoctor = new Label();
            panel11 = new Panel();
            TPatients = new Panel();
            TPtient = new Label();
            TotalPatients = new Label();
            panel6 = new Panel();
            NoShow = new Panel();
            NoSH = new Label();
            label1 = new Label();
            panel8 = new Panel();
            TodayAppoin = new Panel();
            TAppoint = new Label();
            TodaysAppointments = new Label();
            panel7 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            DoctorName = new Label();
            panel4 = new Panel();
            ActualScore = new Label();
            UrgenctSeverity = new Label();
            Score = new Label();
            PatientName = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1 = new Panel();
            Time = new Label();
            Status = new Label();
            DctorN = new Label();
            Speciality = new Label();
            UrgencySeverity = new Label();
            PatieName = new Label();
            Appointment = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel2 = new Panel();
            Dr = new Label();
            specialty = new Label();
            DocName = new Label();
            Dctor = new Label();
            label6 = new Label();
            label7 = new Label();
            panel5 = new Panel();
            panel16 = new Panel();
            panel15 = new Panel();
            panel13 = new Panel();
            label9 = new Label();
            panel12 = new Panel();
            label10 = new Label();
            panel9 = new Panel();
            panel14 = new Panel();
            label8 = new Label();
            NewAppoint = new Guna.UI2.WinForms.Guna2Button();
            ViewQueu = new Guna.UI2.WinForms.Guna2Button();
            ViewAll = new Guna.UI2.WinForms.Guna2Button();
            PatientsWating.SuspendLayout();
            panel3.SuspendLayout();
            TPatients.SuspendLayout();
            NoShow.SuspendLayout();
            TodayAppoin.SuspendLayout();
            panel4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel13.SuspendLayout();
            panel12.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // PatientsWating
            // 
            PatientsWating.BackColor = Color.White;
            PatientsWating.Controls.Add(PatientWaiting);
            PatientsWating.Controls.Add(PatientsWatingNow);
            PatientsWating.Controls.Add(panel10);
            PatientsWating.Location = new Point(930, 87);
            PatientsWating.Name = "PatientsWating";
            PatientsWating.Size = new Size(200, 168);
            PatientsWating.TabIndex = 0;
            PatientsWating.Paint += panel9_Paint;
            // 
            // PatientWaiting
            // 
            PatientWaiting.AutoSize = true;
            PatientWaiting.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatientWaiting.ForeColor = Color.DarkGray;
            PatientWaiting.Location = new Point(90, 85);
            PatientWaiting.Name = "PatientWaiting";
            PatientWaiting.Size = new Size(33, 37);
            PatientWaiting.TabIndex = 2;
            PatientWaiting.Text = "5";
            PatientWaiting.Click += PatientWaiting_Click;
            // 
            // PatientsWatingNow
            // 
            PatientsWatingNow.AutoSize = true;
            PatientsWatingNow.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatientsWatingNow.ForeColor = Color.RoyalBlue;
            PatientsWatingNow.Location = new Point(80, 13);
            PatientsWatingNow.Name = "PatientsWatingNow";
            PatientsWatingNow.Size = new Size(124, 15);
            PatientsWatingNow.TabIndex = 1;
            PatientsWatingNow.Text = "Patients Wating Now";
            PatientsWatingNow.Click += PatientsWatingNow_Click;
            // 
            // panel10
            // 
            panel10.BackgroundImage = (Image)resources.GetObject("panel10.BackgroundImage");
            panel10.Location = new Point(3, 5);
            panel10.Name = "panel10";
            panel10.Size = new Size(71, 51);
            panel10.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(ActiveDoc);
            panel3.Controls.Add(ActiveDoctor);
            panel3.Controls.Add(panel11);
            panel3.Location = new Point(761, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(160, 168);
            panel3.TabIndex = 0;
            // 
            // ActiveDoc
            // 
            ActiveDoc.AutoSize = true;
            ActiveDoc.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ActiveDoc.ForeColor = Color.DarkGray;
            ActiveDoc.Location = new Point(73, 85);
            ActiveDoc.Name = "ActiveDoc";
            ActiveDoc.Size = new Size(33, 37);
            ActiveDoc.TabIndex = 2;
            ActiveDoc.Text = "5";
            // 
            // ActiveDoctor
            // 
            ActiveDoctor.AutoSize = true;
            ActiveDoctor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ActiveDoctor.ForeColor = Color.RoyalBlue;
            ActiveDoctor.Location = new Point(73, 13);
            ActiveDoctor.Name = "ActiveDoctor";
            ActiveDoctor.Size = new Size(90, 15);
            ActiveDoctor.TabIndex = 1;
            ActiveDoctor.Text = "Active Doctors";
            // 
            // panel11
            // 
            panel11.BackgroundImage = (Image)resources.GetObject("panel11.BackgroundImage");
            panel11.Location = new Point(3, 5);
            panel11.Name = "panel11";
            panel11.Size = new Size(64, 54);
            panel11.TabIndex = 0;
            // 
            // TPatients
            // 
            TPatients.BackColor = Color.White;
            TPatients.Controls.Add(TPtient);
            TPatients.Controls.Add(TotalPatients);
            TPatients.Controls.Add(panel6);
            TPatients.Location = new Point(219, 87);
            TPatients.Name = "TPatients";
            TPatients.Size = new Size(157, 168);
            TPatients.TabIndex = 0;
            // 
            // TPtient
            // 
            TPtient.AutoSize = true;
            TPtient.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TPtient.ForeColor = Color.DarkGray;
            TPtient.Location = new Point(62, 85);
            TPtient.Name = "TPtient";
            TPtient.Size = new Size(33, 37);
            TPtient.TabIndex = 2;
            TPtient.Text = "5";
            // 
            // TotalPatients
            // 
            TotalPatients.AutoSize = true;
            TotalPatients.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalPatients.ForeColor = Color.RoyalBlue;
            TotalPatients.Location = new Point(73, 13);
            TotalPatients.Name = "TotalPatients";
            TotalPatients.Size = new Size(82, 15);
            TotalPatients.TabIndex = 1;
            TotalPatients.Text = "Total Patients";
            // 
            // panel6
            // 
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(64, 55);
            panel6.TabIndex = 0;
            // 
            // NoShow
            // 
            NoShow.BackColor = Color.White;
            NoShow.Controls.Add(NoSH);
            NoShow.Controls.Add(label1);
            NoShow.Controls.Add(panel8);
            NoShow.Location = new Point(599, 87);
            NoShow.Name = "NoShow";
            NoShow.Size = new Size(154, 168);
            NoShow.TabIndex = 0;
            NoShow.Paint += panel4_Paint;
            // 
            // NoSH
            // 
            NoSH.AutoSize = true;
            NoSH.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NoSH.ForeColor = Color.DarkGray;
            NoSH.Location = new Point(70, 85);
            NoSH.Name = "NoSH";
            NoSH.Size = new Size(33, 37);
            NoSH.TabIndex = 2;
            NoSH.Text = "5";
            NoSH.Click += NoSH_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(70, 13);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 1;
            label1.Text = "No Show Rate";
            // 
            // panel8
            // 
            panel8.BackgroundImage = (Image)resources.GetObject("panel8.BackgroundImage");
            panel8.Location = new Point(3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(64, 52);
            panel8.TabIndex = 0;
            // 
            // TodayAppoin
            // 
            TodayAppoin.BackColor = Color.White;
            TodayAppoin.Controls.Add(TAppoint);
            TodayAppoin.Controls.Add(TodaysAppointments);
            TodayAppoin.Controls.Add(panel7);
            TodayAppoin.Location = new Point(382, 87);
            TodayAppoin.Name = "TodayAppoin";
            TodayAppoin.Size = new Size(211, 168);
            TodayAppoin.TabIndex = 0;
            // 
            // TAppoint
            // 
            TAppoint.AutoSize = true;
            TAppoint.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TAppoint.ForeColor = Color.DarkGray;
            TAppoint.Location = new Point(85, 85);
            TAppoint.Name = "TAppoint";
            TAppoint.Size = new Size(33, 37);
            TAppoint.TabIndex = 2;
            TAppoint.Text = "5";
            // 
            // TodaysAppointments
            // 
            TodaysAppointments.AutoSize = true;
            TodaysAppointments.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TodaysAppointments.ForeColor = Color.RoyalBlue;
            TodaysAppointments.Location = new Point(69, 13);
            TodaysAppointments.Name = "TodaysAppointments";
            TodaysAppointments.Size = new Size(129, 15);
            TodaysAppointments.TabIndex = 1;
            TodaysAppointments.Text = "Today’s Appointments";
            // 
            // panel7
            // 
            panel7.BackgroundImage = (Image)resources.GetObject("panel7.BackgroundImage");
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(66, 56);
            panel7.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(223, 7);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 1;
            label2.Text = "Dasboard";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(223, 46);
            label3.Name = "label3";
            label3.Size = new Size(324, 20);
            label3.TabIndex = 2;
            label3.Text = "Welcome back! Here’s your hospital overview.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(219, 270);
            label4.Name = "label4";
            label4.Size = new Size(229, 21);
            label4.TabIndex = 0;
            label4.Text = "Queue Overview For Doctor :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(259, 300);
            label5.Name = "label5";
            label5.Size = new Size(202, 15);
            label5.TabIndex = 1;
            label5.Text = "Current waiting patients by priority";
            // 
            // DoctorName
            // 
            DoctorName.AutoSize = true;
            DoctorName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DoctorName.ForeColor = Color.LightSlateGray;
            DoctorName.Location = new Point(451, 270);
            DoctorName.Name = "DoctorName";
            DoctorName.Size = new Size(90, 21);
            DoctorName.TabIndex = 2;
            DoctorName.Text = "Ahmed Ali";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(ActualScore);
            panel4.Controls.Add(UrgenctSeverity);
            panel4.Controls.Add(Score);
            panel4.Controls.Add(PatientName);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 62);
            panel4.TabIndex = 3;
            // 
            // ActualScore
            // 
            ActualScore.AutoSize = true;
            ActualScore.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ActualScore.ForeColor = Color.DarkGray;
            ActualScore.Location = new Point(52, 39);
            ActualScore.Name = "ActualScore";
            ActualScore.Size = new Size(22, 17);
            ActualScore.TabIndex = 3;
            ActualScore.Text = "50";
            ActualScore.Click += label6_Click_1;
            // 
            // UrgenctSeverity
            // 
            UrgenctSeverity.AutoSize = true;
            UrgenctSeverity.BackColor = Color.Red;
            UrgenctSeverity.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UrgenctSeverity.ForeColor = Color.White;
            UrgenctSeverity.Location = new Point(126, 11);
            UrgenctSeverity.Name = "UrgenctSeverity";
            UrgenctSeverity.Size = new Size(31, 15);
            UrgenctSeverity.TabIndex = 2;
            UrgenctSeverity.Text = "high";
            // 
            // Score
            // 
            Score.AutoSize = true;
            Score.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Score.ForeColor = Color.DarkGray;
            Score.Location = new Point(3, 39);
            Score.Name = "Score";
            Score.Size = new Size(45, 15);
            Score.TabIndex = 1;
            Score.Text = "Score :";
            Score.Click += label7_Click;
            // 
            // PatientName
            // 
            PatientName.AutoSize = true;
            PatientName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatientName.Location = new Point(0, 6);
            PatientName.Name = "PatientName";
            PatientName.Size = new Size(90, 21);
            PatientName.TabIndex = 0;
            PatientName.Text = "John Smith";
            PatientName.Click += label6_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Location = new Point(222, 337);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(327, 109);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.Controls.Add(panel1);
            flowLayoutPanel2.Location = new Point(686, 337);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(445, 109);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Time);
            panel1.Controls.Add(Status);
            panel1.Controls.Add(DctorN);
            panel1.Controls.Add(Speciality);
            panel1.Controls.Add(UrgencySeverity);
            panel1.Controls.Add(PatieName);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 62);
            panel1.TabIndex = 0;
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Time.Location = new Point(335, 6);
            Time.Name = "Time";
            Time.Size = new Size(49, 20);
            Time.TabIndex = 10;
            Time.Text = "09:00";
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Status.ForeColor = Color.DarkGray;
            Status.Location = new Point(335, 36);
            Status.Name = "Status";
            Status.Size = new Size(49, 15);
            Status.TabIndex = 9;
            Status.Text = "Waiting";
            // 
            // DctorN
            // 
            DctorN.AutoSize = true;
            DctorN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DctorN.ForeColor = SystemColors.ControlDark;
            DctorN.Location = new Point(38, 36);
            DctorN.Name = "DctorN";
            DctorN.Size = new Size(109, 17);
            DctorN.TabIndex = 8;
            DctorN.Text = "Dr. Michael Chen";
            // 
            // Speciality
            // 
            Speciality.AutoSize = true;
            Speciality.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Speciality.ForeColor = Color.DarkGray;
            Speciality.Location = new Point(153, 35);
            Speciality.Name = "Speciality";
            Speciality.Size = new Size(84, 20);
            Speciality.TabIndex = 7;
            Speciality.Text = "Cardiology";
            // 
            // UrgencySeverity
            // 
            UrgencySeverity.AutoSize = true;
            UrgencySeverity.BackColor = Color.Red;
            UrgencySeverity.ForeColor = Color.White;
            UrgencySeverity.Location = new Point(129, 12);
            UrgencySeverity.Name = "UrgencySeverity";
            UrgencySeverity.Size = new Size(31, 15);
            UrgencySeverity.TabIndex = 5;
            UrgencySeverity.Text = "high";
            // 
            // PatieName
            // 
            PatieName.AutoSize = true;
            PatieName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatieName.Location = new Point(16, 10);
            PatieName.Name = "PatieName";
            PatieName.Size = new Size(90, 21);
            PatieName.TabIndex = 4;
            PatieName.Text = "John Smith";
            // 
            // Appointment
            // 
            Appointment.AutoSize = true;
            Appointment.BackColor = SystemColors.Control;
            Appointment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Appointment.ForeColor = Color.Blue;
            Appointment.Location = new Point(718, 276);
            Appointment.Name = "Appointment";
            Appointment.Size = new Size(171, 21);
            Appointment.TabIndex = 9;
            Appointment.Text = "Today’Appointment :";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.White;
            flowLayoutPanel3.Controls.Add(panel2);
            flowLayoutPanel3.Location = new Point(223, 501);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(326, 236);
            flowLayoutPanel3.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(Dr);
            panel2.Controls.Add(specialty);
            panel2.Controls.Add(DocName);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(157, 60);
            panel2.TabIndex = 0;
            // 
            // Dr
            // 
            Dr.AutoSize = true;
            Dr.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dr.Location = new Point(7, 2);
            Dr.Name = "Dr";
            Dr.Size = new Size(29, 20);
            Dr.TabIndex = 2;
            Dr.Text = "Dr.";
            // 
            // specialty
            // 
            specialty.AutoSize = true;
            specialty.BackColor = Color.Transparent;
            specialty.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specialty.ForeColor = Color.Blue;
            specialty.Location = new Point(7, 35);
            specialty.Name = "specialty";
            specialty.Size = new Size(82, 20);
            specialty.TabIndex = 1;
            specialty.Text = "Cardiology";
            // 
            // DocName
            // 
            DocName.AutoSize = true;
            DocName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DocName.Location = new Point(36, 2);
            DocName.Name = "DocName";
            DocName.Size = new Size(80, 20);
            DocName.TabIndex = 0;
            DocName.Text = "Ahmed Ali";
            DocName.Click += DocName_Click;
            // 
            // Dctor
            // 
            Dctor.AutoSize = true;
            Dctor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dctor.ForeColor = Color.Blue;
            Dctor.Location = new Point(222, 449);
            Dctor.Name = "Dctor";
            Dctor.Size = new Size(162, 21);
            Dctor.TabIndex = 0;
            Dctor.Text = "Doctor Availabiltiy :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(259, 483);
            label6.Name = "label6";
            label6.Size = new Size(140, 15);
            label6.TabIndex = 13;
            label6.Text = "Current on-duty  Doctors";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(686, 458);
            label7.Name = "label7";
            label7.Size = new Size(140, 21);
            label7.TabIndex = 15;
            label7.Text = "Today’s Progress :";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(panel16);
            panel5.Controls.Add(panel15);
            panel5.Controls.Add(panel13);
            panel5.Controls.Add(panel12);
            panel5.Controls.Add(panel9);
            panel5.ForeColor = SystemColors.ControlLightLight;
            panel5.Location = new Point(667, 501);
            panel5.Name = "panel5";
            panel5.Size = new Size(464, 236);
            panel5.TabIndex = 16;
            // 
            // panel16
            // 
            panel16.BackgroundImage = (Image)resources.GetObject("panel16.BackgroundImage");
            panel16.Location = new Point(311, 67);
            panel16.Name = "panel16";
            panel16.Size = new Size(67, 53);
            panel16.TabIndex = 2;
            // 
            // panel15
            // 
            panel15.BackgroundImage = (Image)resources.GetObject("panel15.BackgroundImage");
            panel15.Location = new Point(164, 67);
            panel15.Name = "panel15";
            panel15.Size = new Size(60, 53);
            panel15.TabIndex = 2;
            // 
            // panel13
            // 
            panel13.BackColor = Color.LemonChiffon;
            panel13.Controls.Add(label9);
            panel13.Location = new Point(165, 67);
            panel13.Name = "panel13";
            panel13.Size = new Size(140, 108);
            panel13.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(79, 17);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 0;
            label9.Text = "Waiting";
            // 
            // panel12
            // 
            panel12.BackColor = Color.MistyRose;
            panel12.Controls.Add(label10);
            panel12.Location = new Point(311, 67);
            panel12.Name = "panel12";
            panel12.Size = new Size(140, 108);
            panel12.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(78, 17);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 0;
            label10.Text = "No Show";
            // 
            // panel9
            // 
            panel9.BackColor = Color.LightCyan;
            panel9.Controls.Add(panel14);
            panel9.Controls.Add(label8);
            panel9.Location = new Point(19, 67);
            panel9.Name = "panel9";
            panel9.Size = new Size(140, 108);
            panel9.TabIndex = 0;
            // 
            // panel14
            // 
            panel14.BackgroundImage = (Image)resources.GetObject("panel14.BackgroundImage");
            panel14.Location = new Point(0, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(67, 53);
            panel14.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(73, 17);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 0;
            label8.Text = "Completed";
            // 
            // NewAppoint
            // 
            NewAppoint.AutoRoundedCorners = true;
            NewAppoint.CustomizableEdges = customizableEdges13;
            NewAppoint.DisabledState.BorderColor = Color.DarkGray;
            NewAppoint.DisabledState.CustomBorderColor = Color.DarkGray;
            NewAppoint.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            NewAppoint.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            NewAppoint.FillColor = Color.FromArgb(0, 0, 192);
            NewAppoint.Font = new Font("Segoe UI", 9F);
            NewAppoint.ForeColor = Color.White;
            NewAppoint.Location = new Point(854, 21);
            NewAppoint.Name = "NewAppoint";
            NewAppoint.ShadowDecoration.CustomizableEdges = customizableEdges14;
            NewAppoint.Size = new Size(180, 45);
            NewAppoint.TabIndex = 17;
            NewAppoint.Text = "New Appointment";
            // 
            // ViewQueu
            // 
            ViewQueu.AutoRoundedCorners = true;
            ViewQueu.BackColor = SystemColors.Control;
            ViewQueu.CustomizableEdges = customizableEdges15;
            ViewQueu.DisabledState.BorderColor = Color.DarkGray;
            ViewQueu.DisabledState.CustomBorderColor = Color.DarkGray;
            ViewQueu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ViewQueu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ViewQueu.FillColor = Color.Silver;
            ViewQueu.Font = new Font("Segoe UI", 9F);
            ViewQueu.ForeColor = SystemColors.InactiveCaptionText;
            ViewQueu.Location = new Point(667, 21);
            ViewQueu.Name = "ViewQueu";
            ViewQueu.RightToLeft = RightToLeft.No;
            ViewQueu.ShadowDecoration.CustomizableEdges = customizableEdges16;
            ViewQueu.Size = new Size(180, 45);
            ViewQueu.TabIndex = 18;
            ViewQueu.Text = "View Queue";
            // 
            // ViewAll
            // 
            ViewAll.AutoRoundedCorners = true;
            ViewAll.BackColor = SystemColors.Control;
            ViewAll.CustomizableEdges = customizableEdges17;
            ViewAll.DisabledState.BorderColor = Color.DarkGray;
            ViewAll.DisabledState.CustomBorderColor = Color.DarkGray;
            ViewAll.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ViewAll.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ViewAll.FillColor = Color.Silver;
            ViewAll.Font = new Font("Segoe UI", 9F);
            ViewAll.ForeColor = SystemColors.InactiveCaptionText;
            ViewAll.Location = new Point(991, 276);
            ViewAll.Name = "ViewAll";
            ViewAll.RightToLeft = RightToLeft.No;
            ViewAll.ShadowDecoration.CustomizableEdges = customizableEdges18;
            ViewAll.Size = new Size(111, 45);
            ViewAll.TabIndex = 19;
            ViewAll.Text = "View all";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 749);
            Controls.Add(PatientsWating);
            Controls.Add(ViewAll);
            Controls.Add(panel3);
            Controls.Add(ViewQueu);
            Controls.Add(NoShow);
            Controls.Add(TPatients);
            Controls.Add(TodayAppoin);
            Controls.Add(NewAppoint);
            Controls.Add(panel5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Dctor);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(Appointment);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(DoctorName);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Dashbord";
            Load += Form1_Load;
            PatientsWating.ResumeLayout(false);
            PatientsWating.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            TPatients.ResumeLayout(false);
            TPatients.PerformLayout();
            NoShow.ResumeLayout(false);
            NoShow.PerformLayout();
            TodayAppoin.ResumeLayout(false);
            TodayAppoin.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel TPatients;
        private Panel TodayAppoin;
        private Panel panel3;
        private Panel NoShow;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel PatientsWating;
        private Panel panel10;
        private Panel panel11;
        private Label ActiveDoctor;
        private Label TotalPatients;
        private Label TodaysAppointments;
        private Label PatientsWatingNow;
        private Label PatientWaiting;
        private Label ActiveDoc;
        private Label TPtient;
        private Label NoSH;
        private Label label1;
        private Label TAppoint;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Label DoctorName;
        private Label label5;
        private Panel panel4;
        private Label Score;
        private Label PatientName;
        private Label UrgenctSeverity;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label ActualScore;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label Appointment;
        private Panel panel1;
        private Label Time;
        private Label Status;
        private Label DctorN;
        private Label Speciality;
        private Label UrgencySeverity;
        private Label PatieName;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label Dctor;
        private Label specialty;
        private Label DocName;
        private Label label6;
        private Label Dr;
        private Label label7;
        private Panel panel5;
        private Panel panel13;
        private Panel panel12;
        private Panel panel9;
        private Label label9;
        private Label label10;
        private Label label8;
        private Panel panel14;
        private Panel panel16;
        private Panel panel15;
        private Guna.UI2.WinForms.Guna2Button NewAppoint;
        private Guna.UI2.WinForms.Guna2Button ViewQueu;
        private Guna.UI2.WinForms.Guna2Button ViewAll;
    }
}
