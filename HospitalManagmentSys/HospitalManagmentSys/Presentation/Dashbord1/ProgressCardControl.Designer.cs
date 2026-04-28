namespace HospitalManagmentSys.Presentation
{
    partial class ProgressCardControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTitle = new Label();
            lblValue = new Label();
            prgUrgency = new Guna.UI2.WinForms.Guna2ProgressBar();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(83, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(57, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValue.Location = new Point(91, 95);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(49, 15);
            lblValue.TabIndex = 1;
            lblValue.Text = "lblValue";
            // 
            // prgUrgency
            // 
            prgUrgency.BorderRadius = 4;
            prgUrgency.CustomizableEdges = customizableEdges3;
            prgUrgency.FillColor = Color.FromArgb(229, 231, 235);
            prgUrgency.Location = new Point(20, 140);
            prgUrgency.Name = "prgUrgency";
            prgUrgency.ProgressColor = Color.FromArgb(245, 158, 11);
            prgUrgency.ProgressColor2 = Color.FromArgb(245, 158, 11);
            prgUrgency.ShadowDecoration.CustomizableEdges = customizableEdges4;
            prgUrgency.Size = new Size(218, 10);
            prgUrgency.TabIndex = 8;
            prgUrgency.Text = "guna2ProgressBar1";
            prgUrgency.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            prgUrgency.Value = 50;
            // 
            // ProgressCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(prgUrgency);
            Controls.Add(lblValue);
            Controls.Add(lblTitle);
            Name = "ProgressCardControl";
            Size = new Size(245, 196);
            Load += ProgressCardControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblValue;
        private Guna.UI2.WinForms.Guna2ProgressBar prgUrgency;
    }
}
