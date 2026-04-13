using Dashboard;
using HospitalManagmentSys.Presentation;
using WinFormsApp;

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
            ApplicationConfiguration.Initialize();
            //Application.Run(new PatientsForm());
            //Application.Run(new AccountCreationTicket());
            Application.Run(new AppointmentsHostForm());

            //Application.Run(new AdminPanel());

        }
    }
}