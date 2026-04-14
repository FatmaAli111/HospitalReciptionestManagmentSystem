namespace HospitalManagmentSys.Presentation
{
    partial class AccountCreationTicket
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            FullName = new Label();
            label1 = new Label();
            Password = new Label();
            Role = new Label();
            Email_Address = new Label();
            FullName_textBox1 = new TextBox();
            EmailAddress_textBox = new TextBox();
            Password_textBox = new TextBox();
            Receptionist_radioButton1 = new RadioButton();
            Doctor_radioButton2 = new RadioButton();
            Send_guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            Reset_guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            doctor_view_panel = new Panel();
            Phone_textBox = new TextBox();
            Speciality_textBox = new TextBox();
            Phone = new Label();
            Speciality = new Label();
            doctor_view_panel.SuspendLayout();
            SuspendLayout();
            // 
            // FullName
            // 
            FullName.AutoSize = true;
            FullName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FullName.Location = new Point(43, 98);
            FullName.Name = "FullName";
            FullName.Size = new Size(102, 23);
            FullName.TabIndex = 0;
            FullName.Text = "Full Name : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 18);
            label1.Name = "label1";
            label1.Size = new Size(331, 38);
            label1.TabIndex = 1;
            label1.Text = "Account Creation Ticket";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.Location = new Point(43, 359);
            Password.Name = "Password";
            Password.Size = new Size(91, 23);
            Password.TabIndex = 2;
            Password.Text = "Password :";
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Role.Location = new Point(43, 270);
            Role.Name = "Role";
            Role.Size = new Size(177, 23);
            Role.TabIndex = 3;
            Role.Text = "Choose who you are :";
            // 
            // Email_Address
            // 
            Email_Address.AutoSize = true;
            Email_Address.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Email_Address.Location = new Point(43, 189);
            Email_Address.Name = "Email_Address";
            Email_Address.Size = new Size(125, 23);
            Email_Address.TabIndex = 4;
            Email_Address.Text = "Email Address :";
            // 
            // FullName_textBox1
            // 
            FullName_textBox1.Location = new Point(151, 98);
            FullName_textBox1.Name = "FullName_textBox1";
            FullName_textBox1.Size = new Size(283, 27);
            FullName_textBox1.TabIndex = 5;
            // 
            // EmailAddress_textBox
            // 
            EmailAddress_textBox.Location = new Point(174, 189);
            EmailAddress_textBox.Name = "EmailAddress_textBox";
            EmailAddress_textBox.Size = new Size(283, 27);
            EmailAddress_textBox.TabIndex = 6;
            EmailAddress_textBox.TextChanged += EmailAddress_textBox_TextChanged;
            // 
            // Password_textBox
            // 
            Password_textBox.Location = new Point(140, 359);
            Password_textBox.Name = "Password_textBox";
            Password_textBox.Size = new Size(283, 27);
            Password_textBox.TabIndex = 7;
            Password_textBox.TextChanged += Password_textBox_TextChanged;
            // 
            // Receptionist_radioButton1
            // 
            Receptionist_radioButton1.AutoSize = true;
            Receptionist_radioButton1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Receptionist_radioButton1.Location = new Point(236, 270);
            Receptionist_radioButton1.Name = "Receptionist_radioButton1";
            Receptionist_radioButton1.Size = new Size(113, 24);
            Receptionist_radioButton1.TabIndex = 8;
            Receptionist_radioButton1.TabStop = true;
            Receptionist_radioButton1.Text = "Receptionist";
            Receptionist_radioButton1.UseVisualStyleBackColor = true;
            // 
            // Doctor_radioButton2
            // 
            Doctor_radioButton2.AutoSize = true;
            Doctor_radioButton2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Doctor_radioButton2.Location = new Point(407, 270);
            Doctor_radioButton2.Name = "Doctor_radioButton2";
            Doctor_radioButton2.Size = new Size(77, 24);
            Doctor_radioButton2.TabIndex = 9;
            Doctor_radioButton2.TabStop = true;
            Doctor_radioButton2.Text = "Doctor";
            Doctor_radioButton2.UseVisualStyleBackColor = true;
            Doctor_radioButton2.CheckedChanged += Doctor_radioButton2_CheckedChanged;
            // 
            // Send_guna2CircleButton1
            // 
            Send_guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            Send_guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            Send_guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Send_guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Send_guna2CircleButton1.FillColor = Color.ForestGreen;
            Send_guna2CircleButton1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Send_guna2CircleButton1.ForeColor = Color.White;
            Send_guna2CircleButton1.Location = new Point(99, 433);
            Send_guna2CircleButton1.Name = "Send_guna2CircleButton1";
            Send_guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            Send_guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            Send_guna2CircleButton1.Size = new Size(110, 109);
            Send_guna2CircleButton1.TabIndex = 10;
            Send_guna2CircleButton1.Text = "Send";
            Send_guna2CircleButton1.Click += Send_guna2CircleButton1_Click;
            // 
            // Reset_guna2CircleButton1
            // 
            Reset_guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            Reset_guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            Reset_guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Reset_guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Reset_guna2CircleButton1.FillColor = Color.Maroon;
            Reset_guna2CircleButton1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Reset_guna2CircleButton1.ForeColor = Color.White;
            Reset_guna2CircleButton1.Location = new Point(621, 433);
            Reset_guna2CircleButton1.Name = "Reset_guna2CircleButton1";
            Reset_guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Reset_guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            Reset_guna2CircleButton1.Size = new Size(110, 109);
            Reset_guna2CircleButton1.TabIndex = 11;
            Reset_guna2CircleButton1.Text = "Reset";
            Reset_guna2CircleButton1.Click += Reset_guna2CircleButton1_Click;
            // 
            // doctor_view_panel
            // 
            doctor_view_panel.Controls.Add(Phone_textBox);
            doctor_view_panel.Controls.Add(Speciality_textBox);
            doctor_view_panel.Controls.Add(Phone);
            doctor_view_panel.Controls.Add(Speciality);
            doctor_view_panel.Location = new Point(512, 98);
            doctor_view_panel.Name = "doctor_view_panel";
            doctor_view_panel.Size = new Size(319, 134);
            doctor_view_panel.TabIndex = 12;
            doctor_view_panel.Paint += doctor_view_panel_Paint;
            // 
            // Phone_textBox
            // 
            Phone_textBox.Location = new Point(71, 95);
            Phone_textBox.MaxLength = 11;
            Phone_textBox.Name = "Phone_textBox";
            Phone_textBox.Size = new Size(215, 27);
            Phone_textBox.TabIndex = 7;
            Phone_textBox.KeyPress += Phone_textBox_KeyPress;
            // 
            // Speciality_textBox
            // 
            Speciality_textBox.Location = new Point(93, -1);
            Speciality_textBox.Name = "Speciality_textBox";
            Speciality_textBox.Size = new Size(215, 27);
            Speciality_textBox.TabIndex = 6;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Phone.Location = new Point(3, 95);
            Phone.Name = "Phone";
            Phone.Size = new Size(73, 23);
            Phone.TabIndex = 2;
            Phone.Text = "Phone : ";
            // 
            // Speciality
            // 
            Speciality.AutoSize = true;
            Speciality.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Speciality.Location = new Point(3, 0);
            Speciality.Name = "Speciality";
            Speciality.Size = new Size(96, 23);
            Speciality.TabIndex = 1;
            Speciality.Text = "Speciality : ";
            // 
            // AccountCreationTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 563);
            Controls.Add(doctor_view_panel);
            Controls.Add(Reset_guna2CircleButton1);
            Controls.Add(Send_guna2CircleButton1);
            Controls.Add(Doctor_radioButton2);
            Controls.Add(Receptionist_radioButton1);
            Controls.Add(Password_textBox);
            Controls.Add(EmailAddress_textBox);
            Controls.Add(FullName_textBox1);
            Controls.Add(Email_Address);
            Controls.Add(Role);
            Controls.Add(Password);
            Controls.Add(label1);
            Controls.Add(FullName);
            Name = "AccountCreationTicket";
            Text = "AccountCreationTicket";
            Load += AccountCreationTicket_Load;
            doctor_view_panel.ResumeLayout(false);
            doctor_view_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FullName;
        private Label label1;
        private Label Password;
        private Label Role;
        private Label Email_Address;
        private TextBox FullName_textBox1;
        private TextBox EmailAddress_textBox;
        private TextBox Password_textBox;
        private RadioButton Receptionist_radioButton1;
        private RadioButton Doctor_radioButton2;
        private Guna.UI2.WinForms.Guna2CircleButton Send_guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleButton Reset_guna2CircleButton1;
        private Panel doctor_view_panel;
        private TextBox Phone_textBox;
        private TextBox Speciality_textBox;
        private Label Phone;
        private Label Speciality;
    }
}