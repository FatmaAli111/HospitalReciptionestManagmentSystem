namespace HospitalManagmentSys.Presentation
{
    partial class AppointmentsCardView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pCard = new Guna.UI2.WinForms.Guna2Panel();
            tlpCard = new TableLayoutPanel();
            pTime = new Panel();
            lblTimeStart = new Label();
            lblTimeEnd = new Label();
            pDetails = new Panel();
            btnAvatar = new Guna.UI2.WinForms.Guna2CircleButton();
            lblPatient = new Label();
            bUrgency = new Guna.UI2.WinForms.Guna2Button();
            bStatus = new Guna.UI2.WinForms.Guna2Button();
            lblDoctor = new Label();
            lblComplaint = new Label();
            lblUrgency = new Label();
            prgUrgency = new Guna.UI2.WinForms.Guna2ProgressBar();
            lblUrgencyValue = new Label();
            pActions = new Panel();
            btnNoShow = new Guna.UI2.WinForms.Guna2Button();
            btnCheckIn = new Guna.UI2.WinForms.Guna2Button();
            lnkCancel = new LinkLabel();
            pCard.SuspendLayout();
            tlpCard.SuspendLayout();
            pTime.SuspendLayout();
            pDetails.SuspendLayout();
            pActions.SuspendLayout();
            SuspendLayout();
            // 
            // pCard
            // 
            pCard.BackColor = Color.Transparent;
            pCard.BorderColor = Color.FromArgb(230, 234, 242);
            pCard.BorderRadius = 14;
            pCard.BorderThickness = 1;
            pCard.Controls.Add(tlpCard);
            pCard.CustomizableEdges = customizableEdges12;
            pCard.Dock = DockStyle.Fill;
            pCard.FillColor = Color.White;
            pCard.Location = new Point(0, 0);
            pCard.Name = "pCard";
            pCard.Padding = new Padding(16);
            pCard.ShadowDecoration.BorderRadius = 14;
            pCard.ShadowDecoration.CustomizableEdges = customizableEdges13;
            pCard.ShadowDecoration.Enabled = true;
            pCard.Size = new Size(980, 150);
            pCard.TabIndex = 0;
            // 
            // tlpCard
            // 
            tlpCard.ColumnCount = 3;
            tlpCard.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCard.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tlpCard.Controls.Add(pTime, 0, 0);
            tlpCard.Controls.Add(pDetails, 1, 0);
            tlpCard.Controls.Add(pActions, 2, 0);
            tlpCard.Dock = DockStyle.Fill;
            tlpCard.Location = new Point(16, 16);
            tlpCard.Name = "tlpCard";
            tlpCard.RowCount = 1;
            tlpCard.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCard.Size = new Size(948, 118);
            tlpCard.TabIndex = 0;
            // 
            // pTime
            // 
            pTime.BackColor = Color.FromArgb(245, 247, 251);
            pTime.Controls.Add(lblTimeStart);
            pTime.Controls.Add(lblTimeEnd);
            pTime.Dock = DockStyle.Fill;
            pTime.Location = new Point(0, 0);
            pTime.Margin = new Padding(0);
            pTime.Name = "pTime";
            pTime.Size = new Size(120, 118);
            pTime.TabIndex = 0;
            // 
            // lblTimeStart
            // 
            lblTimeStart.AutoSize = true;
            lblTimeStart.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTimeStart.ForeColor = Color.FromArgb(17, 24, 39);
            lblTimeStart.Location = new Point(3, 26);
            lblTimeStart.Name = "lblTimeStart";
            lblTimeStart.Size = new Size(77, 32);
            lblTimeStart.TabIndex = 0;
            lblTimeStart.Text = "09:30";
            // 
            // lblTimeEnd
            // 
            lblTimeEnd.AutoSize = true;
            lblTimeEnd.Font = new Font("Segoe UI", 9F);
            lblTimeEnd.ForeColor = Color.FromArgb(107, 114, 128);
            lblTimeEnd.Location = new Point(17, 58);
            lblTimeEnd.Name = "lblTimeEnd";
            lblTimeEnd.Size = new Size(48, 15);
            lblTimeEnd.TabIndex = 1;
            lblTimeEnd.Text = "to 10:00";
            lblTimeEnd.Click += lblTimeEnd_Click;
            // 
            // pDetails
            // 
            pDetails.BackColor = Color.Transparent;
            pDetails.Controls.Add(btnAvatar);
            pDetails.Controls.Add(lblPatient);
            pDetails.Controls.Add(bUrgency);
            pDetails.Controls.Add(bStatus);
            pDetails.Controls.Add(lblDoctor);
            pDetails.Controls.Add(lblComplaint);
            pDetails.Controls.Add(lblUrgency);
            pDetails.Controls.Add(prgUrgency);
            pDetails.Controls.Add(lblUrgencyValue);
            pDetails.Dock = DockStyle.Fill;
            pDetails.Location = new Point(120, 0);
            pDetails.Margin = new Padding(0);
            pDetails.Name = "pDetails";
            pDetails.Size = new Size(608, 118);
            pDetails.TabIndex = 1;
            // 
            // btnAvatar
            // 
            btnAvatar.DisabledState.BorderColor = Color.DarkGray;
            btnAvatar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAvatar.DisabledState.FillColor = Color.FromArgb(239, 246, 255);
            btnAvatar.DisabledState.ForeColor = Color.FromArgb(37, 99, 235);
            btnAvatar.Enabled = false;
            btnAvatar.FillColor = Color.FromArgb(239, 246, 255);
            btnAvatar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAvatar.ForeColor = Color.FromArgb(37, 99, 235);
            btnAvatar.Location = new Point(16, 12);
            btnAvatar.Name = "btnAvatar";
            btnAvatar.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnAvatar.Size = new Size(44, 44);
            btnAvatar.TabIndex = 0;
            btnAvatar.Text = "ED";
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPatient.ForeColor = Color.FromArgb(17, 24, 39);
            lblPatient.Location = new Point(72, 14);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(95, 20);
            lblPatient.TabIndex = 1;
            lblPatient.Text = "Emma Davis";
            // 
            // bUrgency
            // 
            bUrgency.BorderRadius = 10;
            bUrgency.CustomizableEdges = customizableEdges2;
            bUrgency.DisabledState.BorderColor = Color.DarkGray;
            bUrgency.DisabledState.CustomBorderColor = Color.DarkGray;
            bUrgency.DisabledState.FillColor = Color.FromArgb(245, 158, 11);
            bUrgency.DisabledState.ForeColor = Color.White;
            bUrgency.Enabled = false;
            bUrgency.FillColor = Color.FromArgb(245, 158, 11);
            bUrgency.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            bUrgency.ForeColor = Color.White;
            bUrgency.Location = new Point(180, 12);
            bUrgency.Name = "bUrgency";
            bUrgency.ShadowDecoration.CustomizableEdges = customizableEdges3;
            bUrgency.Size = new Size(85, 22);
            bUrgency.TabIndex = 2;
            bUrgency.Text = "medium";
            // 
            // bStatus
            // 
            bStatus.BorderRadius = 10;
            bStatus.CustomizableEdges = customizableEdges4;
            bStatus.DisabledState.BorderColor = Color.DarkGray;
            bStatus.DisabledState.CustomBorderColor = Color.DarkGray;
            bStatus.DisabledState.FillColor = Color.FromArgb(245, 158, 11);
            bStatus.DisabledState.ForeColor = Color.White;
            bStatus.Enabled = false;
            bStatus.FillColor = Color.FromArgb(245, 158, 11);
            bStatus.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            bStatus.ForeColor = Color.White;
            bStatus.Location = new Point(271, 13);
            bStatus.Name = "bStatus";
            bStatus.ShadowDecoration.CustomizableEdges = customizableEdges5;
            bStatus.Size = new Size(80, 22);
            bStatus.TabIndex = 3;
            bStatus.Text = "waiting";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Segoe UI", 9.5F);
            lblDoctor.ForeColor = Color.FromArgb(107, 114, 128);
            lblDoctor.Location = new Point(72, 38);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(239, 17);
            lblDoctor.TabIndex = 4;
            lblDoctor.Text = "Dr. Robert Martinez • General Medicine";
            // 
            // lblComplaint
            // 
            lblComplaint.AutoSize = true;
            lblComplaint.Font = new Font("Segoe UI", 9.5F);
            lblComplaint.ForeColor = Color.FromArgb(17, 24, 39);
            lblComplaint.Location = new Point(72, 58);
            lblComplaint.Name = "lblComplaint";
            lblComplaint.Size = new Size(98, 17);
            lblComplaint.TabIndex = 5;
            lblComplaint.Text = "Annual checkup";
            // 
            // lblUrgency
            // 
            lblUrgency.AutoSize = true;
            lblUrgency.Font = new Font("Segoe UI", 9F);
            lblUrgency.ForeColor = Color.FromArgb(107, 114, 128);
            lblUrgency.Location = new Point(72, 87);
            lblUrgency.Name = "lblUrgency";
            lblUrgency.Size = new Size(54, 15);
            lblUrgency.TabIndex = 6;
            lblUrgency.Text = "Urgency:";
            // 
            // prgUrgency
            // 
            prgUrgency.BorderRadius = 4;
            prgUrgency.CustomizableEdges = customizableEdges6;
            prgUrgency.FillColor = Color.FromArgb(229, 231, 235);
            prgUrgency.Location = new Point(132, 90);
            prgUrgency.Name = "prgUrgency";
            prgUrgency.ProgressColor = Color.FromArgb(245, 158, 11);
            prgUrgency.ProgressColor2 = Color.FromArgb(245, 158, 11);
            prgUrgency.ShadowDecoration.CustomizableEdges = customizableEdges7;
            prgUrgency.Size = new Size(340, 8);
            prgUrgency.TabIndex = 7;
            prgUrgency.Text = "guna2ProgressBar1";
            prgUrgency.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            prgUrgency.Value = 50;
            // 
            // lblUrgencyValue
            // 
            lblUrgencyValue.AutoSize = true;
            lblUrgencyValue.Font = new Font("Segoe UI", 9F);
            lblUrgencyValue.ForeColor = Color.FromArgb(17, 24, 39);
            lblUrgencyValue.Location = new Point(482, 86);
            lblUrgencyValue.Name = "lblUrgencyValue";
            lblUrgencyValue.Size = new Size(19, 15);
            lblUrgencyValue.TabIndex = 8;
            lblUrgencyValue.Text = "50";
            // 
            // pActions
            // 
            pActions.BackColor = Color.Transparent;
            pActions.Controls.Add(btnNoShow);
            pActions.Controls.Add(btnCheckIn);
            pActions.Controls.Add(lnkCancel);
            pActions.Dock = DockStyle.Fill;
            pActions.Location = new Point(728, 0);
            pActions.Margin = new Padding(0);
            pActions.Name = "pActions";
            pActions.Size = new Size(220, 118);
            pActions.TabIndex = 2;
            // 
            // btnNoShow
            // 
            btnNoShow.BorderRadius = 10;
            btnNoShow.CustomizableEdges = customizableEdges8;
            btnNoShow.FillColor = Color.FromArgb(220, 38, 38);
            btnNoShow.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNoShow.ForeColor = Color.White;
            btnNoShow.Location = new Point(52, 16);
            btnNoShow.Name = "btnNoShow";
            btnNoShow.ShadowDecoration.CustomizableEdges = customizableEdges9;
            btnNoShow.Size = new Size(150, 36);
            btnNoShow.TabIndex = 0;
            btnNoShow.Text = "Mark No-Show";
            // 
            // btnCheckIn
            // 
            btnCheckIn.BorderColor = Color.FromArgb(229, 231, 235);
            btnCheckIn.BorderRadius = 10;
            btnCheckIn.BorderThickness = 1;
            btnCheckIn.CustomizableEdges = customizableEdges10;
            btnCheckIn.FillColor = Color.White;
            btnCheckIn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCheckIn.ForeColor = Color.FromArgb(17, 24, 39);
            btnCheckIn.Location = new Point(52, 16);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.ShadowDecoration.CustomizableEdges = customizableEdges11;
            btnCheckIn.Size = new Size(100, 36);
            btnCheckIn.TabIndex = 1;
            btnCheckIn.Text = "Check In";
            btnCheckIn.Visible = false;
            // 
            // lnkCancel
            // 
            lnkCancel.ActiveLinkColor = Color.FromArgb(220, 38, 38);
            lnkCancel.AutoSize = true;
            lnkCancel.Font = new Font("Segoe UI", 9.5F);
            lnkCancel.LinkColor = Color.FromArgb(220, 38, 38);
            lnkCancel.Location = new Point(162, 25);
            lnkCancel.Name = "lnkCancel";
            lnkCancel.Size = new Size(46, 17);
            lnkCancel.TabIndex = 2;
            lnkCancel.TabStop = true;
            lnkCancel.Text = "Cancel";
            lnkCancel.Visible = false;
            // 
            // AppointmentsCardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pCard);
            Margin = new Padding(0, 0, 0, 16);
            Name = "AppointmentsCardView";
            Size = new Size(980, 150);
            pCard.ResumeLayout(false);
            tlpCard.ResumeLayout(false);
            pTime.ResumeLayout(false);
            pTime.PerformLayout();
            pDetails.ResumeLayout(false);
            pDetails.PerformLayout();
            pActions.ResumeLayout(false);
            pActions.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pCard;
        private System.Windows.Forms.TableLayoutPanel tlpCard;
        private System.Windows.Forms.Panel pTime;
        private System.Windows.Forms.Label lblTimeStart;
        private System.Windows.Forms.Label lblTimeEnd;
        private System.Windows.Forms.Panel pDetails;
        private Guna.UI2.WinForms.Guna2CircleButton btnAvatar;
        private System.Windows.Forms.Label lblPatient;
        private Guna.UI2.WinForms.Guna2Button bUrgency;
        private Guna.UI2.WinForms.Guna2Button bStatus;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblComplaint;
        private System.Windows.Forms.Label lblUrgency;
        private Guna.UI2.WinForms.Guna2ProgressBar prgUrgency;
        private System.Windows.Forms.Label lblUrgencyValue;
        private System.Windows.Forms.Panel pActions;
        private Guna.UI2.WinForms.Guna2Button btnNoShow;
        private Guna.UI2.WinForms.Guna2Button btnCheckIn;
        private System.Windows.Forms.LinkLabel lnkCancel;
    }
}