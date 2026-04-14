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
    public partial class ProgressCardControl : UserControl
    {
        public ProgressCardControl()
        {
            InitializeComponent();
        }

        public void SetTitle(string title)
        {
            lblTitle.Text = title;
        }

        public void SetValue(int value)
        {
            lblValue.Text = value.ToString();
        }

        public void SetProgress(int completed, int total)
        {
            int percent = total == 0 ? 0 : (completed * 100) / total;

            prgUrgency.Value = percent;

            if (percent < 40)
                prgUrgency.ProgressColor = Color.Red;
            else if (percent < 80)
                prgUrgency.ProgressColor = Color.Orange;
            else
                prgUrgency.ProgressColor = Color.FromArgb(34, 197, 94);
        }

        private void ProgressCardControl_Load(object sender, EventArgs e)
        {

        }
    }
}
