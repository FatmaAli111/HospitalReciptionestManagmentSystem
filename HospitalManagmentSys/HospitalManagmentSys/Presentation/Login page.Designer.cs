namespace WinFormsApp
{
    partial class Login_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_page));
            label1 = new Label();
            Signin_button = new Button();
            doctors_photo = new PictureBox();
            Password_textBox1 = new TextBox();
            Password = new Label();
            Emal_Address_textBox = new TextBox();
            Email_Address = new Label();
            Welcome_Header = new Label();
            footer = new Label();
            pargraph = new Label();
            Header1 = new Label();
            pictureBox1 = new PictureBox();
            Pargraph_signin = new Label();
            Active_Patients_num = new Label();
            Active_Patients_name = new Label();
            Today_Appointments_num = new Label();
            Today_Appointments_Name = new Label();
            Today_Appointments_panel = new Panel();
            left_panel1 = new Panel();
            Active_Patients_panel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            right_panel = new Panel();
            Signup_Link = new LinkLabel();
            sign_in_button = new Button();
            Password_textBox = new TextBox();
            Password_sign_in = new Label();
            EmailAddress_textBox = new TextBox();
            label3 = new Label();
            pargraph_sign_in = new Label();
            Welcome = new Label();
            ((System.ComponentModel.ISupportInitialize)doctors_photo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Today_Appointments_panel.SuspendLayout();
            left_panel1.SuspendLayout();
            Active_Patients_panel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            right_panel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(296, 583);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 10;
            label1.Text = "Don't have an account ?";
            // 
            // Signin_button
            // 
            Signin_button.BackColor = SystemColors.HotTrack;
            Signin_button.FlatStyle = FlatStyle.Popup;
            Signin_button.Location = new Point(3, 527);
            Signin_button.Name = "Signin_button";
            Signin_button.Size = new Size(930, 41);
            Signin_button.TabIndex = 9;
            Signin_button.Text = "Sign in";
            Signin_button.UseVisualStyleBackColor = false;
            Signin_button.Click += Signin_button_Click;
            // 
            // doctors_photo
            // 
            doctors_photo.Image = (Image)resources.GetObject("doctors_photo.Image");
            doctors_photo.Location = new Point(296, 645);
            doctors_photo.Name = "doctors_photo";
            doctors_photo.Size = new Size(294, 353);
            doctors_photo.TabIndex = 8;
            doctors_photo.TabStop = false;
            // 
            // Password_textBox1
            // 
            Password_textBox1.BorderStyle = BorderStyle.FixedSingle;
            Password_textBox1.Location = new Point(233, 434);
            Password_textBox1.Name = "Password_textBox1";
            Password_textBox1.Size = new Size(343, 27);
            Password_textBox1.TabIndex = 5;
            Password_textBox1.TextChanged += Password_textBox1_TextChanged;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.ForeColor = SystemColors.ActiveCaptionText;
            Password.Location = new Point(233, 406);
            Password.Name = "Password";
            Password.Size = new Size(97, 28);
            Password.TabIndex = 4;
            Password.Text = "Password";
            // 
            // Emal_Address_textBox
            // 
            Emal_Address_textBox.BorderStyle = BorderStyle.FixedSingle;
            Emal_Address_textBox.Location = new Point(233, 319);
            Emal_Address_textBox.Name = "Emal_Address_textBox";
            Emal_Address_textBox.Size = new Size(343, 27);
            Emal_Address_textBox.TabIndex = 3;
            Emal_Address_textBox.TextChanged += Emal_Address_textBox_TextChanged;
            // 
            // Email_Address
            // 
            Email_Address.AutoSize = true;
            Email_Address.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Email_Address.ForeColor = SystemColors.ActiveCaptionText;
            Email_Address.Location = new Point(233, 288);
            Email_Address.Name = "Email_Address";
            Email_Address.Size = new Size(139, 28);
            Email_Address.TabIndex = 2;
            Email_Address.Text = "Email Address";
            // 
            // Welcome_Header
            // 
            Welcome_Header.AutoSize = true;
            Welcome_Header.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Welcome_Header.ForeColor = SystemColors.ActiveCaptionText;
            Welcome_Header.Location = new Point(296, 126);
            Welcome_Header.Name = "Welcome_Header";
            Welcome_Header.Size = new Size(276, 50);
            Welcome_Header.TabIndex = 0;
            Welcome_Header.Text = "Welcome back";
            // 
            // footer
            // 
            footer.AutoSize = true;
            footer.ForeColor = SystemColors.ControlDarkDark;
            footer.Location = new Point(282, 952);
            footer.Name = "footer";
            footer.Size = new Size(372, 20);
            footer.TabIndex = 4;
            footer.Text = "© 2026 MediCare Hospital Systems. All rights reserved.";
            // 
            // pargraph
            // 
            pargraph.AutoSize = true;
            pargraph.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pargraph.ForeColor = SystemColors.ControlDarkDark;
            pargraph.Location = new Point(70, 406);
            pargraph.Name = "pargraph";
            pargraph.Size = new Size(375, 75);
            pargraph.TabIndex = 2;
            pargraph.Text = "Streamline patient registration, appointment\r\n scheduling, and queue management with our\r\n intelligent hospital reception platform.\r\n";
            // 
            // Header1
            // 
            Header1.AutoSize = true;
            Header1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Header1.ForeColor = Color.White;
            Header1.Location = new Point(70, 246);
            Header1.Name = "Header1";
            Header1.Size = new Size(330, 100);
            Header1.TabIndex = 1;
            Header1.Text = "Smart Hospital\r\nReception System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(48, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Pargraph_signin
            // 
            Pargraph_signin.AutoSize = true;
            Pargraph_signin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pargraph_signin.ForeColor = SystemColors.ControlDarkDark;
            Pargraph_signin.Location = new Point(296, 216);
            Pargraph_signin.Name = "Pargraph_signin";
            Pargraph_signin.Size = new Size(301, 23);
            Pargraph_signin.TabIndex = 1;
            Pargraph_signin.Text = "Sign in to access the reception system";
            // 
            // Active_Patients_num
            // 
            Active_Patients_num.AutoSize = true;
            Active_Patients_num.Font = new Font("Simplified Arabic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Active_Patients_num.ForeColor = Color.White;
            Active_Patients_num.Location = new Point(15, 14);
            Active_Patients_num.Name = "Active_Patients_num";
            Active_Patients_num.Size = new Size(146, 73);
            Active_Patients_num.TabIndex = 1;
            Active_Patients_num.Text = "1,455";
            // 
            // Active_Patients_name
            // 
            Active_Patients_name.AutoSize = true;
            Active_Patients_name.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Active_Patients_name.ForeColor = Color.Gray;
            Active_Patients_name.Location = new Point(3, 87);
            Active_Patients_name.Name = "Active_Patients_name";
            Active_Patients_name.Size = new Size(129, 23);
            Active_Patients_name.TabIndex = 0;
            Active_Patients_name.Text = "Active Patients";
            // 
            // Today_Appointments_num
            // 
            Today_Appointments_num.AutoSize = true;
            Today_Appointments_num.Font = new Font("Simplified Arabic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Today_Appointments_num.ForeColor = Color.White;
            Today_Appointments_num.Location = new Point(15, 14);
            Today_Appointments_num.Name = "Today_Appointments_num";
            Today_Appointments_num.Size = new Size(82, 73);
            Today_Appointments_num.TabIndex = 1;
            Today_Appointments_num.Text = "65";
            // 
            // Today_Appointments_Name
            // 
            Today_Appointments_Name.AutoSize = true;
            Today_Appointments_Name.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Today_Appointments_Name.ForeColor = Color.Gray;
            Today_Appointments_Name.Location = new Point(3, 87);
            Today_Appointments_Name.Name = "Today_Appointments_Name";
            Today_Appointments_Name.Size = new Size(184, 23);
            Today_Appointments_Name.TabIndex = 0;
            Today_Appointments_Name.Text = "Today`sAppointments";
            // 
            // Today_Appointments_panel
            // 
            Today_Appointments_panel.BackColor = Color.FromArgb(0, 0, 65);
            Today_Appointments_panel.Controls.Add(Today_Appointments_num);
            Today_Appointments_panel.Controls.Add(Today_Appointments_Name);
            Today_Appointments_panel.Location = new Point(539, 663);
            Today_Appointments_panel.Name = "Today_Appointments_panel";
            Today_Appointments_panel.Size = new Size(317, 129);
            Today_Appointments_panel.TabIndex = 5;
            // 
            // left_panel1
            // 
            left_panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            left_panel1.BackColor = Color.FromArgb(0, 0, 50);
            left_panel1.Controls.Add(Today_Appointments_panel);
            left_panel1.Controls.Add(Active_Patients_panel);
            left_panel1.Controls.Add(footer);
            left_panel1.Controls.Add(pargraph);
            left_panel1.Controls.Add(Header1);
            left_panel1.Controls.Add(pictureBox1);
            left_panel1.Location = new Point(3, 3);
            left_panel1.Name = "left_panel1";
            left_panel1.Size = new Size(975, 1105);
            left_panel1.TabIndex = 0;
            // 
            // Active_Patients_panel
            // 
            Active_Patients_panel.BackColor = Color.FromArgb(0, 0, 65);
            Active_Patients_panel.Controls.Add(Active_Patients_num);
            Active_Patients_panel.Controls.Add(Active_Patients_name);
            Active_Patients_panel.Location = new Point(83, 663);
            Active_Patients_panel.Name = "Active_Patients_panel";
            Active_Patients_panel.Size = new Size(317, 129);
            Active_Patients_panel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.3333321F));
            tableLayoutPanel1.Controls.Add(left_panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(right_panel, 1, 0);
            tableLayoutPanel1.Location = new Point(-7, -62);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 98.73817F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.26182961F));
            tableLayoutPanel1.Size = new Size(1938, 1111);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // right_panel
            // 
            right_panel.Controls.Add(Signup_Link);
            right_panel.Controls.Add(label1);
            right_panel.Controls.Add(Signin_button);
            right_panel.Controls.Add(doctors_photo);
            right_panel.Controls.Add(Password_textBox1);
            right_panel.Controls.Add(Password);
            right_panel.Controls.Add(Emal_Address_textBox);
            right_panel.Controls.Add(Email_Address);
            right_panel.Controls.Add(Pargraph_signin);
            right_panel.Controls.Add(Welcome_Header);
            right_panel.Dock = DockStyle.Fill;
            right_panel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            right_panel.ForeColor = SystemColors.ButtonHighlight;
            right_panel.Location = new Point(984, 3);
            right_panel.Name = "right_panel";
            right_panel.Size = new Size(951, 1105);
            right_panel.TabIndex = 1;
            // 
            // Signup_Link
            // 
            Signup_Link.ActiveLinkColor = Color.Blue;
            Signup_Link.AutoSize = true;
            Signup_Link.LinkColor = Color.FromArgb(0, 0, 50);
            Signup_Link.Location = new Point(467, 583);
            Signup_Link.Name = "Signup_Link";
            Signup_Link.Size = new Size(235, 20);
            Signup_Link.TabIndex = 11;
            Signup_Link.TabStop = true;
            Signup_Link.Text = "Submit a Ticket to Adminstrator";
            Signup_Link.LinkClicked += Signup_Link_LinkClicked;
            // 
            // sign_in_button
            // 
            sign_in_button.BackColor = SystemColors.MenuHighlight;
            sign_in_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sign_in_button.ForeColor = Color.White;
            sign_in_button.Location = new Point(679, 318);
            sign_in_button.Name = "sign_in_button";
            sign_in_button.Size = new Size(478, 38);
            sign_in_button.TabIndex = 15;
            sign_in_button.Text = "Sign in";
            sign_in_button.UseVisualStyleBackColor = false;
            // 
            // Password_textBox
            // 
            Password_textBox.BackColor = SystemColors.ButtonFace;
            Password_textBox.BorderStyle = BorderStyle.FixedSingle;
            Password_textBox.Cursor = Cursors.No;
            Password_textBox.ForeColor = SystemColors.Desktop;
            Password_textBox.Location = new Point(704, 234);
            Password_textBox.Name = "Password_textBox";
            Password_textBox.Size = new Size(234, 27);
            Password_textBox.TabIndex = 14;
            // 
            // Password_sign_in
            // 
            Password_sign_in.AutoSize = true;
            Password_sign_in.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password_sign_in.Location = new Point(704, 211);
            Password_sign_in.Name = "Password_sign_in";
            Password_sign_in.Size = new Size(73, 20);
            Password_sign_in.TabIndex = 13;
            Password_sign_in.Text = "Password";
            // 
            // EmailAddress_textBox
            // 
            EmailAddress_textBox.BackColor = SystemColors.ButtonFace;
            EmailAddress_textBox.BorderStyle = BorderStyle.FixedSingle;
            EmailAddress_textBox.Cursor = Cursors.No;
            EmailAddress_textBox.ForeColor = SystemColors.Desktop;
            EmailAddress_textBox.Location = new Point(704, 135);
            EmailAddress_textBox.Name = "EmailAddress_textBox";
            EmailAddress_textBox.Size = new Size(234, 27);
            EmailAddress_textBox.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(704, 112);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 11;
            label3.Text = "Email Address";
            // 
            // pargraph_sign_in
            // 
            pargraph_sign_in.AutoSize = true;
            pargraph_sign_in.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pargraph_sign_in.ForeColor = SystemColors.ControlDarkDark;
            pargraph_sign_in.Location = new Point(750, 46);
            pargraph_sign_in.Name = "pargraph_sign_in";
            pargraph_sign_in.Size = new Size(300, 23);
            pargraph_sign_in.TabIndex = 10;
            pargraph_sign_in.Text = "Sign in to access the reception system";
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Welcome.Location = new Point(750, -8);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(207, 38);
            Welcome.TabIndex = 9;
            Welcome.Text = "Welcome back";
            // 
            // Login_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 986);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(sign_in_button);
            Controls.Add(Password_textBox);
            Controls.Add(Password_sign_in);
            Controls.Add(EmailAddress_textBox);
            Controls.Add(label3);
            Controls.Add(pargraph_sign_in);
            Controls.Add(Welcome);
            Name = "Login_page";
            Text = "Login_page";
            ((System.ComponentModel.ISupportInitialize)doctors_photo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Today_Appointments_panel.ResumeLayout(false);
            Today_Appointments_panel.PerformLayout();
            left_panel1.ResumeLayout(false);
            left_panel1.PerformLayout();
            Active_Patients_panel.ResumeLayout(false);
            Active_Patients_panel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            right_panel.ResumeLayout(false);
            right_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button Signin_button;
        private PictureBox doctors_photo;
        private TextBox Password_textBox1;
        private Label Password;
        private TextBox Emal_Address_textBox;
        private Label Email_Address;
        private Label Welcome_Header;
        private Label footer;
        private Label pargraph;
        private Label Header1;
        private PictureBox pictureBox1;
        private Label Pargraph_signin;
        private Label Active_Patients_num;
        private Label Active_Patients_name;
        private Label Today_Appointments_num;
        private Label Today_Appointments_Name;
        private Panel Today_Appointments_panel;
        private Panel left_panel1;
        private Panel Active_Patients_panel;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel right_panel;
        private Button sign_in_button;
        private TextBox Password_textBox;
        private Label Password_sign_in;
        private TextBox EmailAddress_textBox;
        private Label label3;
        private Label pargraph_sign_in;
        private Label Welcome;
        private LinkLabel Signup_Link;
    }
}