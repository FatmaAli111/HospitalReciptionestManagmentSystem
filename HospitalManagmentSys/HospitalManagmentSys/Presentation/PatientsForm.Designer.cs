using Guna.UI2.WinForms;

namespace HospitalManagmentSys.Presentation
{
    partial class PatientsForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            headerPanel = new Guna2Panel();
            AddPatientBtn = new Guna2Button();
            subLabel = new Guna2HtmlLabel();
            titleLabel = new Guna2HtmlLabel();
            searchPanel = new Guna2Panel();
            filterCombo = new Guna2ComboBox();
            searchBox = new Guna2TextBox();
            contentPanel = new Guna2Panel();
            headerPanel.SuspendLayout();
            searchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(AddPatientBtn);
            headerPanel.Controls.Add(subLabel);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.CustomizableEdges = customizableEdges3;
            headerPanel.Dock = DockStyle.Top;
            headerPanel.FillColor = Color.White;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(24, 0, 24, 0);
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            headerPanel.Size = new Size(1100, 80);
            headerPanel.TabIndex = 2;
            // 
            // AddPatientBtn
            // 
            AddPatientBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddPatientBtn.BorderRadius = 8;
            AddPatientBtn.Cursor = Cursors.Hand;
            AddPatientBtn.CustomizableEdges = customizableEdges1;
            AddPatientBtn.FillColor = Color.FromArgb(59, 130, 246);
            AddPatientBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            AddPatientBtn.ForeColor = Color.White;
            AddPatientBtn.Location = new Point(922, 21);
            AddPatientBtn.Name = "AddPatientBtn";
            AddPatientBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            AddPatientBtn.Size = new Size(150, 38);
            AddPatientBtn.TabIndex = 0;
            AddPatientBtn.Text = "+ New Patient";
            AddPatientBtn.Click += AddPatientBtn_Click;
            // 
            // subLabel
            // 
            subLabel.BackColor = Color.Transparent;
            subLabel.Font = new Font("Segoe UI", 9.5F);
            subLabel.ForeColor = Color.FromArgb(107, 114, 128);
            subLabel.Location = new Point(26, 51);
            subLabel.Name = "subLabel";
            subLabel.Size = new Size(281, 23);
            subLabel.TabIndex = 1;
            subLabel.Text = "Manage patient records and registration";
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(17, 24, 39);
            titleLabel.Location = new Point(24, 10);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(117, 43);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Patients";
            // 
            // searchPanel
            // 
            searchPanel.Controls.Add(filterCombo);
            searchPanel.Controls.Add(searchBox);
            searchPanel.CustomizableEdges = customizableEdges9;
            searchPanel.Dock = DockStyle.Top;
            searchPanel.FillColor = Color.White;
            searchPanel.Location = new Point(0, 80);
            searchPanel.Name = "searchPanel";
            searchPanel.ShadowDecoration.CustomizableEdges = customizableEdges10;
            searchPanel.Size = new Size(1100, 70);
            searchPanel.TabIndex = 1;
            // 
            // filterCombo
            // 
            filterCombo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filterCombo.BackColor = Color.Transparent;
            filterCombo.BorderColor = Color.FromArgb(229, 231, 235);
            filterCombo.BorderRadius = 8;
            filterCombo.CustomizableEdges = customizableEdges5;
            filterCombo.DrawMode = DrawMode.OwnerDrawFixed;
            filterCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            filterCombo.FocusedColor = Color.Empty;
            filterCombo.Font = new Font("Segoe UI", 10F);
            filterCombo.ForeColor = Color.FromArgb(68, 88, 112);
            filterCombo.ItemHeight = 30;
            filterCombo.Items.AddRange(new object[] { "All Patients", "High No-Show Risk", "Good Standing" });
            filterCombo.Location = new Point(862, 18);
            filterCombo.Name = "filterCombo";
            filterCombo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            filterCombo.Size = new Size(200, 36);
            filterCombo.TabIndex = 0;
            filterCombo.SelectedIndexChanged += filterCombo_SelectedIndexChanged;
            // 
            // searchBox
            // 
            searchBox.BorderColor = Color.FromArgb(229, 231, 235);
            searchBox.BorderRadius = 8;
            searchBox.CustomizableEdges = customizableEdges7;
            searchBox.DefaultText = "";
            searchBox.Font = new Font("Segoe UI", 10F);
            searchBox.Location = new Point(24, 18);
            searchBox.Margin = new Padding(3, 4, 3, 4);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search by name, email, or phone...";
            searchBox.SelectedText = "";
            searchBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            searchBox.Size = new Size(400, 36);
            searchBox.TabIndex = 1;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // contentPanel
            // 
            contentPanel.CustomizableEdges = customizableEdges11;
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.FillColor = Color.FromArgb(243, 244, 246);
            contentPanel.Location = new Point(0, 150);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(24);
            contentPanel.ShadowDecoration.CustomizableEdges = customizableEdges12;
            contentPanel.Size = new Size(1100, 550);
            contentPanel.TabIndex = 0;
            // 
            // PatientsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(1100, 700);
            Controls.Add(contentPanel);
            Controls.Add(searchPanel);
            Controls.Add(headerPanel);
            Font = new Font("Segoe UI", 9F);
            Name = "PatientsForm";
            Text = "Patients";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            searchPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna2Panel headerPanel;
        private Guna2HtmlLabel titleLabel;
        private Guna2HtmlLabel subLabel;
        private Guna2Button AddPatientBtn;
        private Guna2Panel searchPanel;
        private Guna2TextBox searchBox;
        private Guna2ComboBox filterCombo;
        private Guna2Panel contentPanel;
    }
}