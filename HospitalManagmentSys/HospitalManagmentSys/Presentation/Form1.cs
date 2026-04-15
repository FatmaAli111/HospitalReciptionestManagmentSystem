using HospitalManagmentSys.Presentation.Controls.Sidebar;

namespace SmartHospitalSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WireSidebarEvents();
            ConfigureSidebarDemoData();
        }

        private void WireSidebarEvents()
        {
            sidebarControl1.NavigationChanged += SidebarControlNavigationChanged;
            sidebarControl1.NewPatientClicked += SidebarControlNewPatientClicked;
            sidebarControl1.EmergencyClicked += SidebarControlEmergencyClicked;
            sidebarControl1.ProfileActionTriggered += SidebarControlProfileActionTriggered;
        }

        private void ConfigureSidebarDemoData()
        {
            sidebarControl1.UserName = "Admin User";
            sidebarControl1.UserRole = "Admin";
            sidebarControl1.SetQueueBadgeCount(2);
            sidebarControl1.SetSelectedNavigation(SidebarNavigationItem.Dashboard);
        }

        private void SidebarControlNavigationChanged(object? sender, SidebarNavigationChangedEventArgs e)
        {
            pageTitleLabel.Text = e.PageName;
            contentHintLabel.Text = $"Load {e.PageName} content by injecting a page control into the host panel.";
        }

        private void SidebarControlNewPatientClicked(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "New Patient action triggered.\nOpen AddPatient form or page host here.",
                "Quick Action",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void SidebarControlEmergencyClicked(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "Emergency action triggered.\nRoute to emergency workflow handler.",
                "Emergency",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void SidebarControlProfileActionTriggered(object? sender, SidebarProfileActionEventArgs e)
        {
            switch (e.Action)
            {
                case SidebarProfileAction.Settings:
                    MessageBox.Show("Profile settings requested.", "Profile");
                    break;
                case SidebarProfileAction.SignOut:
                    MessageBox.Show("Sign out requested.", "Profile");
                    break;
            }
        }

        private void sidebarControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
