using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentSys.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Cardiology" },
                    { 2, "Neurology" },
                    { 3, "Orthopedics" },
                    { 4, "Pediatrics" },
                    { 5, "Dermatology" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "AttendanceRate", "BloodType", "CreatedAt", "DateOfBirth", "Email", "FullName", "Gender", "MedicalUrgency", "Phone" },
                values: new object[] { 1, 100.0, "A_Positive", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "mohamed.ali@gmail.com", "Mohamed Ali", "Male", "Medium", "01111234567" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "AttendanceRate", "BloodType", "CreatedAt", "DateOfBirth", "Email", "FullName", "Gender", "MedicalUrgency", "NoShowCount", "Phone" },
                values: new object[,]
                {
                    { 2, 80.0, "B_Negative", new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatma.ibrahim@gmail.com", "Fatma Ibrahim", "Female", "High", 1, "01122345678" },
                    { 3, 65.0, "O_Positive", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "khaled.mostafa@gmail.com", "Khaled Mostafa", "Male", "Low", 2, "01133456789" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "AttendanceRate", "BloodType", "CreatedAt", "DateOfBirth", "Email", "FullName", "Gender", "MedicalUrgency", "Phone" },
                values: new object[] { 4, 100.0, "AB_Positive", new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "amira.samir@gmail.com", "Amira Samir", "Female", "Medium", "01144567890" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "AttendanceRate", "BloodType", "CreatedAt", "DateOfBirth", "Email", "FullName", "Gender", "MedicalUrgency", "NoShowCount", "Phone" },
                values: new object[,]
                {
                    { 5, 50.0, "O_Negative", new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "youssef.nabil@gmail.com", "Youssef Nabil", "Male", "High", 3, "01155678901" },
                    { 6, 75.0, "A_Negative", new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "rania.hassan@gmail.com", "Rania Hassan", "Female", "Low", 1, "01166789012" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "AttendanceRate", "BloodType", "CreatedAt", "DateOfBirth", "Email", "FullName", "Gender", "MedicalUrgency", "Phone" },
                values: new object[,]
                {
                    { 7, 90.0, "B_Positive", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "tarek.adel@gmail.com", "Tarek Adel", "Male", "Medium", "01177890123" },
                    { 8, 95.0, "AB_Negative", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "dina.walid@gmail.com", "Dina Walid", "Female", "High", "01188901234" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "IsActive", "Name", "PasswordHash", "Phone", "Role", "Speciality" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahmed.hassan@hospital.com", true, "Dr. Ahmed Hassan", "hashed_pw_1", "01001234567", 2, null },
                    { 2, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "sara.mahmoud@hospital.com", true, "Dr. Sara Mahmoud", "hashed_pw_2", "01012345678", 2, null },
                    { 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "omar.youssef@hospital.com", true, "Dr. Omar Youssef", "hashed_pw_3", "01023456789", 2, null },
                    { 4, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "nour.eldin@hospital.com", true, "Dr. Nour ElDin", "hashed_pw_4", "01034567890", 2, null },
                    { 5, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "hana.fathy@hospital.com", true, "Dr. Hana Fathy", "hashed_pw_5", "01045678901", 2, null },
                    { 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@hospital.com", true, "Admin User", "hashed_pw_6", "01056789012", 1, null },
                    { 7, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "mona.kamel@hospital.com", true, "Mona Kamel", "hashed_pw_7", "01067890123", 3, null }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "DepartmentId", "Specialty", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Interventional Cardiology", 1 },
                    { 2, 2, "Clinical Neurology", 2 },
                    { 3, 3, "Spine Surgery", 3 },
                    { 4, 4, "Neonatology", 4 },
                    { 5, 5, "Cosmetic Dermatology", 5 }
                });

            migrationBuilder.InsertData(
                table: "Queues",
                columns: new[] { "Id", "DoctorId", "LastUpdated", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), "InProgress" },
                    { 2, 2, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), "Waiting" },
                    { 3, 3, new DateTime(2025, 6, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "Waiting" },
                    { 4, 4, new DateTime(2025, 6, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 5, 5, new DateTime(2025, 6, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "Cancelled" }
                });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "BookedCount", "DoctorId", "EndTime", "IsAvailable", "MaxCapacity", "SlotDate", "StartTime" },
                values: new object[] { 1, 3, 1, new TimeSpan(0, 9, 30, 0, 0), true, 5, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "BookedCount", "DoctorId", "EndTime", "MaxCapacity", "SlotDate", "StartTime" },
                values: new object[] { 2, 5, 1, new TimeSpan(0, 10, 30, 0, 0), 5, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "BookedCount", "DoctorId", "EndTime", "IsAvailable", "MaxCapacity", "SlotDate", "StartTime" },
                values: new object[] { 3, 2, 2, new TimeSpan(0, 9, 30, 0, 0), true, 4, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "BookedCount", "DoctorId", "EndTime", "MaxCapacity", "SlotDate", "StartTime" },
                values: new object[] { 4, 4, 2, new TimeSpan(0, 11, 30, 0, 0), 4, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "BookedCount", "DoctorId", "EndTime", "IsAvailable", "MaxCapacity", "SlotDate", "StartTime" },
                values: new object[] { 5, 1, 3, new TimeSpan(0, 8, 30, 0, 0), true, 3, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "DoctorId", "EndTime", "IsAvailable", "MaxCapacity", "SlotDate", "StartTime" },
                values: new object[] { 6, 3, new TimeSpan(0, 14, 30, 0, 0), true, 3, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "BookedCount", "DoctorId", "EndTime", "IsAvailable", "MaxCapacity", "SlotDate", "StartTime" },
                values: new object[,]
                {
                    { 7, 3, 4, new TimeSpan(0, 10, 30, 0, 0), true, 6, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 8, 2, 5, new TimeSpan(0, 13, 30, 0, 0), true, 5, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "DoctorId", "PatientId", "PriorityScore", "QueueId", "QueueOrder", "Status", "TimeSlotId" },
                values: new object[,]
                {
                    { 1, 1, 1, 7.5, 1, 1, "Confirmed", 1 },
                    { 2, 1, 2, 9.0, 1, 2, "Confirmed", 1 },
                    { 3, 1, 3, 5.0, 1, 3, "Completed", 2 },
                    { 4, 2, 4, 6.5, 2, 1, "Pending", 3 },
                    { 5, 2, 5, 8.0, 2, 2, "Cancelled", 4 },
                    { 6, 3, 6, 4.5, 3, 1, "Pending", 5 },
                    { 7, 4, 7, 7.0, 4, 1, "Completed", 7 },
                    { 8, 5, 8, 8.5, 5, 1, "Cancelled", 8 }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "Id", "AppointmentID", "ArriveTime", "CheckInTime", "CheckOutTime", "Status" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2025, 6, 10, 8, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 10, 9, 25, 0, 0, DateTimeKind.Unspecified), "Present" },
                    { 2, 7, new DateTime(2025, 6, 12, 9, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 12, 10, 28, 0, 0, DateTimeKind.Unspecified), "Present" },
                    { 3, 1, new DateTime(2025, 6, 10, 9, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 10, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 10, 9, 55, 0, 0, DateTimeKind.Unspecified), "Late" },
                    { 4, 5, new DateTime(2025, 6, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), "Absent" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Queues",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Queues",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Queues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Queues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Queues",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
