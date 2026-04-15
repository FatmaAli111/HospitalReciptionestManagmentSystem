using HospitalManagmentSys.Presentation;
using HospitalManagmentSys.Presentation.Controls.Sidebar;
using HospitalManagmentSys.Presentation.Dashbord;
using HospitalManagmentSys.Presentation.ReportsForm;
using HospitalManagmentSys.Presentation.Settings;
using HospitalManagmentSys.Presentation.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagmentSys.Presentation.Controls.Sidebar
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            sidebarControl1.NavigationChanged += Sidebar_NavigationChanged;
            LoadPage(new DashboardControl1());
        }

        private void Sidebar_NavigationChanged(object? sender, SidebarNavigationChangedEventArgs e)
        {

            switch (e.Item)
            {

                case SidebarNavigationItem.Dashboard:
                    LoadPage(new DashboardControl1());
                    break;

                case SidebarNavigationItem.Patients:
                    LoadPage(new PatientControl());


                    break;

                case SidebarNavigationItem.Appointments:
                    LoadPage(new AppointmentsView());
                    break;

                case SidebarNavigationItem.Queue:
                    //LoadPage(new QueueView());
                    break;

                case SidebarNavigationItem.Reports:
                    LoadPage(new ReportsControl());
                    break;

                case SidebarNavigationItem.Settings:
                    LoadPage(new SettingsUserControl());
                    break;

            }
        }


        private void LoadPage(UserControl page)
        {
            page.Dock = DockStyle.Fill;
            guna2Panel1.Controls.Clear();
            guna2Panel1.Controls.Add(page);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebarControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
