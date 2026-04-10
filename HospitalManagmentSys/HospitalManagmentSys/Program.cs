<<<<<<< HEAD
using Dashboard;
=======
>>>>>>> 09c13daad965d29f09a3c75dbeb023d345c881cd
using HospitalManagmentSys.Presentation;
using SmartHospitalSystem;

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
<<<<<<< HEAD
            Application.Run(new BookAppointmentForm());
=======
            Application.Run(new QueueForm());
>>>>>>> 09c13daad965d29f09a3c75dbeb023d345c881cd
        }
    }
}