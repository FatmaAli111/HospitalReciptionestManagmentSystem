using HospitalManagmentSys.BiussnessLogic;
using HospitalManagmentSys.Presentation;
using HospitalManagmentSys.Presentation.Controls.Sidebar;
using HospitalManagmentSys.Presentation.Dashbord;
using HospitalManagmentSys.Presentation.ReportsForm;
using HospitalManagmentSys.Presentation.Settings;
using HospitalManagmentSys.Presentation.UserControls;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp;

namespace HospitalManagmentSys.Presentation.Controls.Sidebar
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            sidebarControl1.ProfileActionTriggered += Sidebar_ProfileActionTriggered;
            sidebarControl1.NavigationChanged += Sidebar_NavigationChanged;
            SwitchView(new HospitalManagmentSys.Presentation.Dashbord1.Dashbord());


        }

        private Control _previousView;
        private Control? _currentView;


        public void SwitchView(Form newForm)
        {

            if (_currentView != null)
            {
                _previousView = _currentView;
                _currentView.Hide();
            }
           

            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;

            if (!guna2Panel1.Controls.Contains(newForm))
                guna2Panel1.Controls.Add(newForm);

            _currentView = newForm;

         
            newForm.Show();
            newForm.BringToFront();
        }
        private void Sidebar_ProfileActionTriggered(object? sender, SidebarProfileActionEventArgs e)
        {
            switch (e.Action)
            {
                case SidebarProfileAction.Settings:
                    LoadPage(new SettingsUserControl());
                    break;

                case SidebarProfileAction.SignOut:

                    this.Hide();        
                    var loginPage = new Login_page();
                    loginPage.ShowDialog();   
                    this.Close();      
                    break;
            }
        }

        private void Sidebar_NavigationChanged(object? sender, SidebarNavigationChangedEventArgs e)
        {

            switch (e.Item)
            {

                case SidebarNavigationItem.Dashboard:
                    SwitchView(new HospitalManagmentSys.Presentation.Dashbord1.Dashbord());
                    break;

                case SidebarNavigationItem.Patients:
                    LoadPage(new PatientControl());


                    break;

                case SidebarNavigationItem.Appointments:
                    LoadPage(new AppointmentsView());
                    break;

                case SidebarNavigationItem.Queue:

                    SwitchView(new QueueForm());
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
            _currentView = page;
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
