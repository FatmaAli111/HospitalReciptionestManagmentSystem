namespace HospitalManagmentSys.Presentation.Controls.Sidebar
{
    partial class PatientControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            searchPanel = new Guna.UI2.WinForms.Guna2Panel();
            guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            filterCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            contentPanel = new Guna.UI2.WinForms.Guna2Panel();
            panel1 = new Panel();
            subLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            AddPatientBtn = new Guna.UI2.WinForms.Guna2Button();
            searchPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // searchPanel
            // 
            searchPanel.Controls.Add(guna2ComboBox1);
            searchPanel.Controls.Add(filterCombo);
            searchPanel.Controls.Add(searchBox);
            searchPanel.CustomizableEdges = customizableEdges7;
            searchPanel.FillColor = Color.White;
            searchPanel.Location = new Point(3, 102);
            searchPanel.Name = "searchPanel";
            searchPanel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            searchPanel.Size = new Size(1252, 70);
            searchPanel.TabIndex = 4;
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ComboBox1.BackColor = Color.Transparent;
            guna2ComboBox1.BorderColor = Color.FromArgb(229, 231, 235);
            guna2ComboBox1.BorderRadius = 8;
            guna2ComboBox1.CustomizableEdges = customizableEdges1;
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FocusedColor = Color.Empty;
            guna2ComboBox1.Font = new Font("Segoe UI", 10F);
            guna2ComboBox1.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Items.AddRange(new object[] { "All Patients", "High Risk", "Medium Risk", "Low Risk" });
            guna2ComboBox1.Location = new Point(1029, 18);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ComboBox1.Size = new Size(200, 36);
            guna2ComboBox1.TabIndex = 2;
            guna2ComboBox1.SelectedIndexChanged += guna2ComboBox1_SelectedIndexChanged;
            // 
            // filterCombo
            // 
            filterCombo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filterCombo.BackColor = Color.Transparent;
            filterCombo.BorderColor = Color.FromArgb(229, 231, 235);
            filterCombo.BorderRadius = 8;
            filterCombo.CustomizableEdges = customizableEdges3;
            filterCombo.DrawMode = DrawMode.OwnerDrawFixed;
            filterCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            filterCombo.FocusedColor = Color.Empty;
            filterCombo.Font = new Font("Segoe UI", 10F);
            filterCombo.ForeColor = Color.FromArgb(68, 88, 112);
            filterCombo.ItemHeight = 30;
            filterCombo.Items.AddRange(new object[] { "All Patients", "High Risk", "Medium Risk", "Low Risk" });
            filterCombo.Location = new Point(2066, 18);
            filterCombo.Name = "filterCombo";
            filterCombo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            filterCombo.Size = new Size(200, 36);
            filterCombo.TabIndex = 0;
            // 
            // searchBox
            // 
            searchBox.BorderColor = Color.FromArgb(229, 231, 235);
            searchBox.BorderRadius = 8;
            searchBox.CustomizableEdges = customizableEdges5;
            searchBox.DefaultText = "";
            searchBox.Font = new Font("Segoe UI", 10F);
            searchBox.Location = new Point(24, 18);
            searchBox.Margin = new Padding(3, 4, 3, 4);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search by name ...";
            searchBox.SelectedText = "";
            searchBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            searchBox.Size = new Size(400, 36);
            searchBox.TabIndex = 1;
            searchBox.TextChanged += searchBox_TextChanged_1;
            // 
            // contentPanel
            // 
            contentPanel.CustomizableEdges = customizableEdges9;
            contentPanel.FillColor = Color.FromArgb(243, 244, 246);
            contentPanel.Location = new Point(3, 241);
            contentPanel.Name = "contentPanel";
            contentPanel.ShadowDecoration.CustomizableEdges = customizableEdges10;
            contentPanel.Size = new Size(1488, 789);
            contentPanel.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(subLabel);
            panel1.Controls.Add(titleLabel);
            panel1.Controls.Add(AddPatientBtn);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1491, 88);
            panel1.TabIndex = 6;
            // 
            // subLabel
            // 
            subLabel.BackColor = Color.Transparent;
            subLabel.Font = new Font("Segoe UI", 9.5F);
            subLabel.ForeColor = Color.FromArgb(107, 114, 128);
            subLabel.Location = new Point(39, 52);
            subLabel.Name = "subLabel";
            subLabel.Size = new Size(281, 23);
            subLabel.TabIndex = 4;
            subLabel.Text = "Manage patient records and registration";
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(17, 24, 39);
            titleLabel.Location = new Point(39, 3);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(117, 43);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Patients";
            // 
            // AddPatientBtn
            // 
            AddPatientBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddPatientBtn.BorderRadius = 8;
            AddPatientBtn.Cursor = Cursors.Hand;
            AddPatientBtn.CustomizableEdges = customizableEdges11;
            AddPatientBtn.FillColor = Color.FromArgb(59, 130, 246);
            AddPatientBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            AddPatientBtn.ForeColor = Color.White;
            AddPatientBtn.Location = new Point(1314, 21);
            AddPatientBtn.Name = "AddPatientBtn";
            AddPatientBtn.ShadowDecoration.CustomizableEdges = customizableEdges12;
            AddPatientBtn.Size = new Size(150, 38);
            AddPatientBtn.TabIndex = 1;
            AddPatientBtn.Text = "+ New Patient";
            AddPatientBtn.Click += AddPatientBtn_Click;
            // 
            // PatientControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(contentPanel);
            Controls.Add(searchPanel);
            Name = "PatientControl";
            Size = new Size(1494, 1033);
            searchPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel searchPanel;
        private Guna.UI2.WinForms.Guna2ComboBox filterCombo;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2Panel contentPanel;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button AddPatientBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel subLabel;
    }
}
