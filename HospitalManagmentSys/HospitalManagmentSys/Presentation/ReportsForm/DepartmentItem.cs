using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagmentSys.Presentation
{
    public partial class DepartmentItem : UserControl
    {
        private System.Windows.Forms.Timer animationTimer;
        private int targetWidth;
        private int currentWidth;
        private float _percentage;

        public DepartmentItem()
        {
            InitializeComponent();
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 10;
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void DepartmentItem_Load(object sender, EventArgs e)
        {

        }

        public void SetData(string name, float percentage)
        {
            _percentage = percentage;

            lblDept.Text = name;
            lblPercent.Text = percentage + "% attendance";

            UpdateBar();
        }

        private void UpdateBar()
        {
            int fullWidth = pnlBackground.Width;
            targetWidth = (int)(fullWidth * (_percentage / 100));
            currentWidth = 0;

            if (animationTimer != null)
            {
                animationTimer.Stop();
                animationTimer.Start();
            }
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (currentWidth < targetWidth)
            {
                currentWidth += Math.Max(1, (targetWidth - currentWidth) / 10);
                if (currentWidth > targetWidth)
                    currentWidth = targetWidth;

                pnlValue.Width = currentWidth;
            }
            else
            {
                animationTimer.Stop();
            }
        }
    }
}
