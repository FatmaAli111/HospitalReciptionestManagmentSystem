using Dashboard;
using HospitalManagmentSys.BiussnessLogic;
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
           // DashbordServices dashbordServices = new DashbordServices();
           //Console.WriteLine($"{dashbordServices.todayAppointments()},{ dashbordServices.NoShowNumber()};{dashbordServices.WaitingNow()};{dashbordServices.totalPatients()};") ;



            ApplicationConfiguration.Initialize();
            Application.Run(new system());
        }
    }
}