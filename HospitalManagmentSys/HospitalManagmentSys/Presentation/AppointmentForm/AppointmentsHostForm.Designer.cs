namespace HospitalManagmentSys.Presentation
{
    partial class AppointmentsHostForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            appointmentsView1 = new AppointmentsView();
            SuspendLayout();
            // 
            // appointmentsView1
            // 
            appointmentsView1.BackColor = Color.FromArgb(245, 247, 251);
            appointmentsView1.Dock = DockStyle.Fill;
            appointmentsView1.Location = new Point(0, 0);
            appointmentsView1.Name = "appointmentsView1";
            appointmentsView1.Padding = new Padding(24);
            appointmentsView1.Size = new Size(685, 402);
            appointmentsView1.TabIndex = 0;
            // 
            // AppointmentsHostForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 402);
            Controls.Add(appointmentsView1);
            Name = "AppointmentsHostForm";
            Text = "AppointmentsHostForm";
            ResumeLayout(false);
        }

        #endregion

        private AppointmentsView appointmentsView1;
    }
}