
using HospitalManagmentSys.Data;
using HospitalManagmentSys.BiussnessLogic;
using HospitalManagmentSys.Presentation;
using HospitalManagmentSys.Presentation.ProfilePatient;
using WinFormsApp;
using HospitalManagmentSys.Presentation.Controls.Sidebar;

namespace HospitalManagmentSys
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var login = new Login_page();

            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainPage());
            }
        }
    }
}