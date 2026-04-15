namespace HospitalManagmentSys.Presentation
{
    partial class DepartmentItem
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
            this.pnlValue = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPercent = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDept = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlBackground = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // pnlValue
            // 
            this.pnlValue.BackColor = System.Drawing.Color.Tomato;
            this.pnlValue.BorderRadius = 10;
            this.pnlValue.Location = new System.Drawing.Point(19, 44);
            this.pnlValue.Name = "pnlValue";
            this.pnlValue.Size = new System.Drawing.Size(237, 8);
            this.pnlValue.TabIndex = 11;
            // 
            // lblPercent
            // 
            this.lblPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblPercent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPercent.Location = new System.Drawing.Point(241, 8);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(96, 17);
            this.lblPercent.TabIndex = 10;
            this.lblPercent.Text = "55.0% attendance";
            // 
            // lblDept
            // 
            this.lblDept.BackColor = System.Drawing.Color.Transparent;
            this.lblDept.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.Location = new System.Drawing.Point(19, 8);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(110, 19);
            this.lblDept.TabIndex = 9;
            this.lblDept.Text = "General Medicine";
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlBackground.BorderRadius = 15;
            this.pnlBackground.Location = new System.Drawing.Point(19, 44);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(318, 8);
            this.pnlBackground.TabIndex = 8;
            // 
            // DepartmentItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlValue);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.pnlBackground);
            this.Name = "DepartmentItem";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Size = new System.Drawing.Size(388, 90);
            this.Load += new System.EventHandler(this.DepartmentItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPercent;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDept;
        private Guna.UI2.WinForms.Guna2Panel pnlBackground;
    }
}
