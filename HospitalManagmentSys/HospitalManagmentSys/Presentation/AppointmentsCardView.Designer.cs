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
            this.pCard = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpCard = new System.Windows.Forms.TableLayoutPanel();
            this.pTime = new System.Windows.Forms.Panel();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.lblTimeEnd = new System.Windows.Forms.Label();
            this.pDetails = new System.Windows.Forms.Panel();
            this.btnAvatar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblPatient = new System.Windows.Forms.Label();
            this.bUrgency = new Guna.UI2.WinForms.Guna2Button();
            this.bStatus = new Guna.UI2.WinForms.Guna2Button();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblComplaint = new System.Windows.Forms.Label();
            this.lblUrgency = new System.Windows.Forms.Label();
            this.prgUrgency = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.lblUrgencyValue = new System.Windows.Forms.Label();
            this.pActions = new System.Windows.Forms.Panel();
            this.btnNoShow = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckIn = new Guna.UI2.WinForms.Guna2Button();
            this.lnkCancel = new System.Windows.Forms.LinkLabel();
            this.pCard.SuspendLayout();
            this.tlpCard.SuspendLayout();
            this.pTime.SuspendLayout();
            this.pDetails.SuspendLayout();
            this.pActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pCard
            // 
            this.pCard.BackColor = System.Drawing.Color.Transparent;
            this.pCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(242)))));
            this.pCard.BorderRadius = 14;
            this.pCard.BorderThickness = 1;
            this.pCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCard.FillColor = System.Drawing.Color.White;
            this.pCard.Location = new System.Drawing.Point(0, 0);
            this.pCard.Name = "pCard";
            this.pCard.Padding = new System.Windows.Forms.Padding(16);
            this.pCard.ShadowDecoration.BorderRadius = 14;
            this.pCard.ShadowDecoration.Enabled = true;
            this.pCard.Size = new System.Drawing.Size(980, 150);
            this.pCard.TabIndex = 0;
            // 
            // tlpCard
            // 
            this.tlpCard.ColumnCount = 3;
            this.tlpCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tlpCard.Controls.Add(this.pTime, 0, 0);
            this.tlpCard.Controls.Add(this.pDetails, 1, 0);
            this.tlpCard.Controls.Add(this.pActions, 2, 0);
            this.tlpCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCard.Location = new System.Drawing.Point(16, 16);
            this.tlpCard.Name = "tlpCard";
            this.tlpCard.RowCount = 1;
            this.tlpCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCard.Size = new System.Drawing.Size(948, 118);
            this.tlpCard.TabIndex = 0;
            // 
            // pTime
            // 
            this.pTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.pTime.Controls.Add(this.lblTimeStart);
            this.pTime.Controls.Add(this.lblTimeEnd);
            this.pTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTime.Location = new System.Drawing.Point(0, 0);
            this.pTime.Margin = new System.Windows.Forms.Padding(0);
            this.pTime.Name = "pTime";
            this.pTime.Size = new System.Drawing.Size(120, 118);
            this.pTime.TabIndex = 0;
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.AutoSize = true;
            this.lblTimeStart.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimeStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblTimeStart.Location = new System.Drawing.Point(16, 34);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(77, 32);
            this.lblTimeStart.TabIndex = 0;
            this.lblTimeStart.Text = "09:30";
            // 
            // lblTimeEnd
            // 
            this.lblTimeEnd.AutoSize = true;
            this.lblTimeEnd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimeEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTimeEnd.Location = new System.Drawing.Point(20, 68);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.lblTimeEnd.Size = new System.Drawing.Size(55, 15);
            this.lblTimeEnd.TabIndex = 1;
            this.lblTimeEnd.Text = "to 10:00";
            // 
            // pDetails
            // 
            this.pDetails.BackColor = System.Drawing.Color.Transparent;
            this.pDetails.Controls.Add(this.btnAvatar);
            this.pDetails.Controls.Add(this.lblPatient);
            this.pDetails.Controls.Add(this.bUrgency);
            this.pDetails.Controls.Add(this.bStatus);
            this.pDetails.Controls.Add(this.lblDoctor);
            this.pDetails.Controls.Add(this.lblComplaint);
            this.pDetails.Controls.Add(this.lblUrgency);
            this.pDetails.Controls.Add(this.prgUrgency);
            this.pDetails.Controls.Add(this.lblUrgencyValue);
            this.pDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDetails.Location = new System.Drawing.Point(120, 0);
            this.pDetails.Margin = new System.Windows.Forms.Padding(0);
            this.pDetails.Name = "pDetails";
            this.pDetails.Size = new System.Drawing.Size(608, 118);
            this.pDetails.TabIndex = 1;
            // 
            // btnAvatar
            // 
            this.btnAvatar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAvatar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAvatar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btnAvatar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAvatar.Enabled = false;
            this.btnAvatar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btnAvatar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAvatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAvatar.Location = new System.Drawing.Point(16, 12);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAvatar.Size = new System.Drawing.Size(44, 44);
            this.btnAvatar.TabIndex = 0;
            this.btnAvatar.Text = "ED";
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblPatient.Location = new System.Drawing.Point(72, 14);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(86, 20);
            this.lblPatient.TabIndex = 1;
            this.lblPatient.Text = "Emma Davis";
            // 
            // bUrgency
            // 
            this.bUrgency.BorderRadius = 10;
            this.bUrgency.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bUrgency.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bUrgency.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.bUrgency.DisabledState.ForeColor = System.Drawing.Color.White;
            this.bUrgency.Enabled = false;
            this.bUrgency.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.bUrgency.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bUrgency.ForeColor = System.Drawing.Color.White;
            this.bUrgency.Location = new System.Drawing.Point(180, 12);
            this.bUrgency.Name = "bUrgency";
            this.bUrgency.Size = new System.Drawing.Size(70, 22);
            this.bUrgency.TabIndex = 2;
            this.bUrgency.Text = "medium";
            // 
            // bStatus
            // 
            this.bStatus.BorderRadius = 10;
            this.bStatus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.bStatus.DisabledState.ForeColor = System.Drawing.Color.White;
            this.bStatus.Enabled = false;
            this.bStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.bStatus.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bStatus.ForeColor = System.Drawing.Color.White;
            this.bStatus.Location = new System.Drawing.Point(258, 12);
            this.bStatus.Name = "bStatus";
            this.bStatus.Size = new System.Drawing.Size(70, 22);
            this.bStatus.TabIndex = 3;
            this.bStatus.Text = "waiting";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblDoctor.Location = new System.Drawing.Point(72, 38);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(245, 17);
            this.lblDoctor.TabIndex = 4;
            this.lblDoctor.Text = "Dr. Robert Martinez • General Medicine";
            // 
            // lblComplaint
            // 
            this.lblComplaint.AutoSize = true;
            this.lblComplaint.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComplaint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblComplaint.Location = new System.Drawing.Point(72, 58);
            this.lblComplaint.Name = "lblComplaint";
            this.lblComplaint.Size = new System.Drawing.Size(92, 17);
            this.lblComplaint.TabIndex = 5;
            this.lblComplaint.Text = "Annual checkup";
            // 
            // lblUrgency
            // 
            this.lblUrgency.AutoSize = true;
            this.lblUrgency.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUrgency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblUrgency.Location = new System.Drawing.Point(72, 87);
            this.lblUrgency.Name = "lblUrgency";
            this.lblUrgency.Size = new System.Drawing.Size(52, 15);
            this.lblUrgency.TabIndex = 6;
            this.lblUrgency.Text = "Urgency:";
            // 
            // prgUrgency
            // 
            this.prgUrgency.BorderRadius = 4;
            this.prgUrgency.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.prgUrgency.Location = new System.Drawing.Point(132, 90);
            this.prgUrgency.Name = "prgUrgency";
            this.prgUrgency.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.prgUrgency.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.prgUrgency.Size = new System.Drawing.Size(340, 8);
            this.prgUrgency.TabIndex = 7;
            this.prgUrgency.Text = "guna2ProgressBar1";
            this.prgUrgency.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.prgUrgency.Value = 50;
            // 
            // lblUrgencyValue
            // 
            this.lblUrgencyValue.AutoSize = true;
            this.lblUrgencyValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUrgencyValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblUrgencyValue.Location = new System.Drawing.Point(482, 86);
            this.lblUrgencyValue.Name = "lblUrgencyValue";
            this.lblUrgencyValue.Size = new System.Drawing.Size(19, 15);
            this.lblUrgencyValue.TabIndex = 8;
            this.lblUrgencyValue.Text = "50";
            // 
            // pActions
            // 
            this.pActions.BackColor = System.Drawing.Color.Transparent;
            this.pActions.Controls.Add(this.btnNoShow);
            this.pActions.Controls.Add(this.btnCheckIn);
            this.pActions.Controls.Add(this.lnkCancel);
            this.pActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pActions.Location = new System.Drawing.Point(728, 0);
            this.pActions.Margin = new System.Windows.Forms.Padding(0);
            this.pActions.Name = "pActions";
            this.pActions.Size = new System.Drawing.Size(220, 118);
            this.pActions.TabIndex = 2;
            // 
            // btnNoShow
            // 
            this.btnNoShow.BorderRadius = 10;
            this.btnNoShow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnNoShow.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNoShow.ForeColor = System.Drawing.Color.White;
            this.btnNoShow.Location = new System.Drawing.Point(52, 16);
            this.btnNoShow.Name = "btnNoShow";
            this.btnNoShow.Size = new System.Drawing.Size(150, 36);
            this.btnNoShow.TabIndex = 0;
            this.btnNoShow.Text = "Mark No-Show";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btnCheckIn.BorderRadius = 10;
            this.btnCheckIn.BorderThickness = 1;
            this.btnCheckIn.FillColor = System.Drawing.Color.White;
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnCheckIn.Location = new System.Drawing.Point(52, 16);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(100, 36);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.Visible = false;
            // 
            // lnkCancel
            // 
            this.lnkCancel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lnkCancel.AutoSize = true;
            this.lnkCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnkCancel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lnkCancel.Location = new System.Drawing.Point(162, 25);
            this.lnkCancel.Name = "lnkCancel";
            this.lnkCancel.Size = new System.Drawing.Size(44, 17);
            this.lnkCancel.TabIndex = 2;
            this.lnkCancel.TabStop = true;
            this.lnkCancel.Text = "Cancel";
            this.lnkCancel.Visible = false;
            // 
            // AppointmentsCardView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pCard);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.Name = "AppointmentsCardView";
            this.Size = new System.Drawing.Size(980, 150);
            this.pCard.Controls.Add(this.tlpCard);
            this.pCard.ResumeLayout(false);
            this.tlpCard.ResumeLayout(false);
            this.pTime.ResumeLayout(false);
            this.pTime.PerformLayout();
            this.pDetails.ResumeLayout(false);
            this.pDetails.PerformLayout();
            this.pActions.ResumeLayout(false);
            this.pActions.PerformLayout();
            this.ResumeLayout(false);

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