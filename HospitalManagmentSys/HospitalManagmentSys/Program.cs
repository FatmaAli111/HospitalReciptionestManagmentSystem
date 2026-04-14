using Dashboard;
using HospitalManagmentSys.Data;
using HospitalManagmentSys.Presentation;
using HospitalManagmentSys.Presentation.ProfilePatient;
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
            
            Application.Run(new PatientsForm());
        }
    }
}