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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardControl1));
            header = new Panel();
            label2 = new Label();
            label3 = new Label();
            ViewQueu = new Guna2Button();
            NewAppoint = new Guna2Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            TPatients = new Panel();
            panel8 = new Panel();
            TPtient = new Label();
            TotalPatients = new Label();
            TodayAppoin = new Panel();
            panel7 = new Panel();
            TAppoint = new Label();
            TodaysAppointments = new Label();
            NoShow = new Panel();
            guna2Panel1 = new Guna2Panel();
            NoSH = new Label();
            label1 = new Label();
            PatientsWating = new Panel();
            panel11 = new Panel();
            PatientWaiting = new Label();
            PatientsWatingNow = new Label();
            doctorAndAppointmentsRow = new TableLayoutPanel();
            todayAppointmentsContainer = new Panel();
            todayTitle = new Label();
            doctorAvailabilityContainer = new Panel();
            doctorTitle = new Label();
            progress = new Panel();
            prgUrgency = new Guna2ProgressBar();
            label11 = new Label();
            waiting = new Panel();
            label13 = new Label();
            label9 = new Label();
            panel15 = new Panel();
            nosho = new Panel();
            label14 = new Label();
            label10 = new Label();
            panel16 = new Panel();
            completed = new Panel();
            label12 = new Label();
            panel14 = new Panel();
            label8 = new Label();
            label7 = new Label();
            header.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            TPatients.SuspendLayout();
            TodayAppoin.SuspendLayout();
            NoShow.SuspendLayout();
            PatientsWating.SuspendLayout();
            doctorAndAppointmentsRow.SuspendLayout();
            todayAppointmentsContainer.SuspendLayout();
            doctorAvailabilityContainer.SuspendLayout();
            progress.SuspendLayout();
            waiting.SuspendLayout();
            nosho.SuspendLayout();
            completed.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.Controls.Add(label2);
            header.Controls.Add(label3);
            header.Controls.Add(ViewQueu);
            header.Controls.Add(NewAppoint);
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(200, 100);
            header.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 1;
            // 
            // ViewQueu
            // 
            ViewQueu.CustomizableEdges = customizableEdges1;
            ViewQueu.Font = new Font("Segoe UI", 9F);
            ViewQueu.ForeColor = Color.White;
            ViewQueu.Location = new Point(0, 0);
            ViewQueu.Name = "ViewQueu";
            ViewQueu.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ViewQueu.Size = new Size(180, 45);
            ViewQueu.TabIndex = 2;
            ViewQueu.Click += ViewQueu_Click_1;
            // 
            // NewAppoint
            // 
            NewAppoint.CustomizableEdges = customizableEdges3;
            NewAppoint.Font = new Font("Segoe UI", 9F);
            NewAppoint.ForeColor = Color.White;
            NewAppoint.Location = new Point(0, 0);
            NewAppoint.Name = "NewAppoint";
            NewAppoint.ShadowDecoration.CustomizableEdges = customizableEdges4;
            NewAppoint.Size = new Size(180, 45);
            NewAppoint.TabIndex = 3;
            NewAppoint.Click += NewAppoint_Click_2;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(TPatients);
            flowLayoutPanel4.Controls.Add(TodayAppoin);
            flowLayoutPanel4.Controls.Add(NoShow);
            flowLayoutPanel4.Controls.Add(PatientsWating);
            flowLayoutPanel4.Location = new Point(0, 0);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(200, 100);
            flowLayoutPanel4.TabIndex = 1;
            // 
            // TPatients
            // 
            TPatients.Controls.Add(panel8);
            TPatients.Controls.Add(TPtient);
            TPatients.Controls.Add(TotalPatients);
            TPatients.Location = new Point(3, 3);
            TPatients.Name = "TPatients";
            TPatients.Size = new Size(200, 100);
            TPatients.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 100);
            panel8.TabIndex = 0;
            // 
            // TPtient
            // 
            TPtient.Location = new Point(0, 0);
            TPtient.Name = "TPtient";
            TPtient.Size = new Size(100, 23);
            TPtient.TabIndex = 1;
            // 
            // TotalPatients
            // 
            TotalPatients.Location = new Point(0, 0);
            TotalPatients.Name = "TotalPatients";
            TotalPatients.Size = new Size(100, 23);
            TotalPatients.TabIndex = 2;
            // 
            // TodayAppoin
            // 
            TodayAppoin.Controls.Add(panel7);
            TodayAppoin.Controls.Add(TAppoint);
            TodayAppoin.Controls.Add(TodaysAppointments);
            TodayAppoin.Location = new Point(3, 109);
            TodayAppoin.Name = "TodayAppoin";
            TodayAppoin.Size = new Size(200, 100);
            TodayAppoin.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 100);
            panel7.TabIndex = 0;
            // 
            // TAppoint
            // 
            TAppoint.Location = new Point(0, 0);
            TAppoint.Name = "TAppoint";
            TAppoint.Size = new Size(100, 23);
            TAppoint.TabIndex = 1;
            // 
            // TodaysAppointments
            // 
            TodaysAppointments.Location = new Point(0, 0);
            TodaysAppointments.Name = "TodaysAppointments";
            TodaysAppointments.Size = new Size(100, 23);
            TodaysAppointments.TabIndex = 2;
            // 
            // NoShow
            // 
            NoShow.Controls.Add(guna2Panel1);
            NoShow.Controls.Add(NoSH);
            NoShow.Controls.Add(label1);
            NoShow.Location = new Point(3, 215);
            NoShow.Name = "NoShow";
            NoShow.Size = new Size(200, 100);
            NoShow.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(200, 100);
            guna2Panel1.TabIndex = 0;
            // 
            // NoSH
            // 
            NoSH.Location = new Point(0, 0);
            NoSH.Name = "NoSH";
            NoSH.Size = new Size(100, 23);
            NoSH.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 2;
            // 
            // PatientsWating
            // 
            PatientsWating.Controls.Add(panel11);
            PatientsWating.Controls.Add(PatientWaiting);
            PatientsWating.Controls.Add(PatientsWatingNow);
            PatientsWating.Location = new Point(3, 321);
            PatientsWating.Name = "PatientsWating";
            PatientsWating.Size = new Size(200, 100);
            PatientsWating.TabIndex = 3;
            // 
            // panel11
            // 
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(200, 100);
            panel11.TabIndex = 0;
            // 
            // PatientWaiting
            // 
            PatientWaiting.Location = new Point(0, 0);
            PatientWaiting.Name = "PatientWaiting";
            PatientWaiting.Size = new Size(100, 23);
            PatientWaiting.TabIndex = 1;
            // 
            // PatientsWatingNow
            // 
            PatientsWatingNow.Location = new Point(0, 0);
            PatientsWatingNow.Name = "PatientsWatingNow";
            PatientsWatingNow.Size = new Size(100, 23);
            PatientsWatingNow.TabIndex = 2;
            // 
            // doctorAndAppointmentsRow
            // 
            doctorAndAppointmentsRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            doctorAndAppointmentsRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            doctorAndAppointmentsRow.Controls.Add(todayAppointmentsContainer);
            doctorAndAppointmentsRow.Controls.Add(doctorAvailabilityContainer);
            doctorAndAppointmentsRow.Location = new Point(0, 0);
            doctorAndAppointmentsRow.Name = "doctorAndAppointmentsRow";
            doctorAndAppointmentsRow.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            doctorAndAppointmentsRow.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            doctorAndAppointmentsRow.Size = new Size(200, 100);
            doctorAndAppointmentsRow.TabIndex = 0;
            // 
            // todayAppointmentsContainer
            // 
            todayAppointmentsContainer.Controls.Add(todayTitle);
            todayAppointmentsContainer.Location = new Point(3, 3);
            todayAppointmentsContainer.Name = "todayAppointmentsContainer";
            todayAppointmentsContainer.Size = new Size(194, 14);
            todayAppointmentsContainer.TabIndex = 0;
            // 
            // todayTitle
            // 
            todayTitle.Location = new Point(0, 0);
            todayTitle.Name = "todayTitle";
            todayTitle.Size = new Size(100, 23);
            todayTitle.TabIndex = 0;
            // 
            // doctorAvailabilityContainer
            // 
            doctorAvailabilityContainer.Controls.Add(doctorTitle);
            doctorAvailabilityContainer.Location = new Point(3, 23);
            doctorAvailabilityContainer.Name = "doctorAvailabilityContainer";
            doctorAvailabilityContainer.Size = new Size(194, 74);
            doctorAvailabilityContainer.TabIndex = 1;
            // 
            // doctorTitle
            // 
            doctorTitle.Location = new Point(0, 0);
            doctorTitle.Name = "doctorTitle";
            doctorTitle.Size = new Size(100, 23);
            doctorTitle.TabIndex = 0;
            // 
            // progress
            // 
            progress.Anchor = AnchorStyles.None;
            progress.BackColor = Color.White;
            progress.Controls.Add(prgUrgency);
            progress.Controls.Add(label11);
            progress.Controls.Add(waiting);
            progress.Controls.Add(nosho);
            progress.Controls.Add(completed);
            progress.ForeColor = SystemColors.Control;
            progress.Location = new Point(753, 614);
            progress.Margin = new Padding(3, 4, 3, 4);
            progress.Name = "progress";
            progress.Size = new Size(530, 269);
            progress.TabIndex = 18;
            // 
            // prgUrgency
            // 
            prgUrgency.BorderRadius = 4;
            prgUrgency.CustomizableEdges = customizableEdges7;
            prgUrgency.FillColor = Color.FromArgb(229, 231, 235);
            prgUrgency.Location = new Point(43, 52);
            prgUrgency.Margin = new Padding(3, 4, 3, 4);
            prgUrgency.Name = "prgUrgency";
            prgUrgency.ProgressColor = Color.FromArgb(245, 158, 11);
            prgUrgency.ProgressColor2 = Color.FromArgb(245, 158, 11);
            prgUrgency.ShadowDecoration.CustomizableEdges = customizableEdges8;
            prgUrgency.Size = new Size(389, 11);
            prgUrgency.TabIndex = 8;
            prgUrgency.Text = "guna2ProgressBar1";
            prgUrgency.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            prgUrgency.Value = 50;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(32, 15);
            label11.Name = "label11";
            label11.Size = new Size(85, 20);
            label11.TabIndex = 3;
            label11.Text = "Completed";
            // 
            // waiting
            // 
            waiting.BackColor = SystemColors.GradientInactiveCaption;
            waiting.Controls.Add(label13);
            waiting.Controls.Add(label9);
            waiting.Controls.Add(panel15);
            waiting.ForeColor = SystemColors.GradientActiveCaption;
            waiting.Location = new Point(201, 89);
            waiting.Margin = new Padding(3, 4, 3, 4);
            waiting.Name = "waiting";
            waiting.Size = new Size(144, 165);
            waiting.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(54, 59);
            label13.Name = "label13";
            label13.Size = new Size(40, 46);
            label13.TabIndex = 3;
            label13.Text = "5";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(40, 112);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 0;
            label9.Text = "Waiting";
            // 
            // panel15
            // 
            panel15.BackgroundImage = (Image)resources.GetObject("panel15.BackgroundImage");
            panel15.Location = new Point(51, 19);
            panel15.Margin = new Padding(3, 4, 3, 4);
            panel15.Name = "panel15";
            panel15.Size = new Size(32, 37);
            panel15.TabIndex = 2;
            // 
            // nosho
            // 
            nosho.BackColor = SystemColors.InactiveCaption;
            nosho.Controls.Add(label14);
            nosho.Controls.Add(label10);
            nosho.Controls.Add(panel16);
            nosho.ForeColor = SystemColors.InactiveCaption;
            nosho.Location = new Point(355, 89);
            nosho.Margin = new Padding(3, 4, 3, 4);
            nosho.Name = "nosho";
            nosho.Size = new Size(144, 165);
            nosho.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(54, 59);
            label14.Name = "label14";
            label14.Size = new Size(40, 46);
            label14.TabIndex = 3;
            label14.Text = "5";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(46, 112);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 0;
            label10.Text = "No Show";
            // 
            // panel16
            // 
            panel16.BackgroundImage = (Image)resources.GetObject("panel16.BackgroundImage");
            panel16.Location = new Point(54, 19);
            panel16.Margin = new Padding(3, 4, 3, 4);
            panel16.Name = "panel16";
            panel16.Size = new Size(34, 40);
            panel16.TabIndex = 2;
            // 
            // completed
            // 
            completed.BackColor = SystemColors.InactiveBorder;
            completed.Controls.Add(label12);
            completed.Controls.Add(panel14);
            completed.Controls.Add(label8);
            completed.ForeColor = SystemColors.GradientInactiveCaption;
            completed.Location = new Point(46, 89);
            completed.Margin = new Padding(3, 4, 3, 4);
            completed.Name = "completed";
            completed.Size = new Size(144, 165);
            completed.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(54, 59);
            label12.Name = "label12";
            label12.Size = new Size(40, 46);
            label12.TabIndex = 3;
            label12.Text = "5";
            // 
            // panel14
            // 
            panel14.BackgroundImage = (Image)resources.GetObject("panel14.BackgroundImage");
            panel14.Location = new Point(48, 23);
            panel14.Margin = new Padding(3, 4, 3, 4);
            panel14.Name = "panel14";
            panel14.Size = new Size(38, 33);
            panel14.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(35, 112);
            label8.Name = "label8";
            label8.Size = new Size(83, 20);
            label8.TabIndex = 0;
            label8.Text = "Completed";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(690, 577);
            label7.Name = "label7";
            label7.Size = new Size(175, 28);
            label7.TabIndex = 17;
            label7.Text = "Today’s Progress :";
            // 
            // DashboardControl1
            // 
            BackColor = Color.White;
            Controls.Add(progress);
            Controls.Add(label7);
            Controls.Add(doctorAndAppointmentsRow);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(header);
            Name = "DashboardControl1";
            Size = new Size(1300, 900);
            header.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            TPatients.ResumeLayout(false);
            TodayAppoin.ResumeLayout(false);
            NoShow.ResumeLayout(false);
            PatientsWating.ResumeLayout(false);
            doctorAndAppointmentsRow.ResumeLayout(false);
            todayAppointmentsContainer.ResumeLayout(false);
            doctorAvailabilityContainer.ResumeLayout(false);
            progress.ResumeLayout(false);
            progress.PerformLayout();
            waiting.ResumeLayout(false);
            waiting.PerformLayout();
            nosho.ResumeLayout(false);
            nosho.PerformLayout();
            completed.ResumeLayout(false);
            completed.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label todayTitle;
        private Label doctorTitle;
        private Panel progress;
        private Guna2ProgressBar prgUrgency;
        private Label label11;
        private Panel waiting;
        private Label label13;
        private Label label9;
        private Panel panel15;
        private Panel nosho;
        private Label label14;
        private Label label10;
        private Panel panel16;
        private Panel completed;
        private Label label12;
        private Panel panel14;
        private Label label8;
        private Label label7;
    }
}
