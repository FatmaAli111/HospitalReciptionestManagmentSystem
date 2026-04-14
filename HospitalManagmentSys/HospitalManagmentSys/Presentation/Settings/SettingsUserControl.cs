using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagmentSys.Presentation.Settings
{
    public partial class SettingsUserControl : UserControl
    {
        public SettingsUserControl()
        {
            InitializeComponent();
            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
