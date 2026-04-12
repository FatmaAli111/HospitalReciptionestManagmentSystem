using HospitalManagmentSys.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagmentSys.Data
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Cardiology" },
                new Department { Id = 2, Name = "Neurology" },
                new Department { Id = 3, Name = "Orthopedics" },
                new Department { Id = 4, Name = "Pediatrics" },
                new Department { Id = 5, Name = "Dermatology" }
            );

            builder.Entity<User>().HasData(
                new User { Id = 1, Role = UserRole.Doctor, Name = "Dr. Ahmed Hassan", Email = "ahmed.hassan@hospital.com", Phone = "01001234567", PasswordHash = "hashed_pw_1", IsActive = true, CreatedAt = new DateTime(2024, 1, 10) },
                new User { Id = 2, Role = UserRole.Doctor, Name = "Dr. Sara Mahmoud", Email = "sara.mahmoud@hospital.com", Phone = "01012345678", PasswordHash = "hashed_pw_2", IsActive = true, CreatedAt = new DateTime(2024, 1, 12) },
                new User { Id = 3, Role = UserRole.Doctor, Name = "Dr. Omar Youssef", Email = "omar.youssef@hospital.com", Phone = "01023456789", PasswordHash = "hashed_pw_3", IsActive = true, CreatedAt = new DateTime(2024, 2, 1) },
                new User { Id = 4, Role = UserRole.Doctor, Name = "Dr. Nour ElDin", Email = "nour.eldin@hospital.com", Phone = "01034567890", PasswordHash = "hashed_pw_4", IsActive = true, CreatedAt = new DateTime(2024, 2, 15) },
                new User { Id = 5, Role = UserRole.Doctor, Name = "Dr. Hana Fathy", Email = "hana.fathy@hospital.com", Phone = "01045678901", PasswordHash = "hashed_pw_5", IsActive = true, CreatedAt = new DateTime(2024, 3, 5) },
                new User { Id = 6, Role = UserRole.Admin, Name = "Admin User", Email = "admin@hospital.com", Phone = "01056789012", PasswordHash = "hashed_pw_6", IsActive = true, CreatedAt = new DateTime(2024, 1, 1) },
                new User { Id = 7, Role = UserRole.Receptionist, Name = "Mona Kamel", Email = "mona.kamel@hospital.com", Phone = "01067890123", PasswordHash = "hashed_pw_7", IsActive = true, CreatedAt = new DateTime(2024, 1, 5) }
            );

           

            builder.Entity<Doctor>().HasData(
                new { Id = 1, DepartmentId = 1, Specialty = "Interventional Cardiology", UserId = 1 },
                new { Id = 2, DepartmentId = 2, Specialty = "Clinical Neurology", UserId = 2 },
                new { Id = 3, DepartmentId = 3, Specialty = "Spine Surgery", UserId = 3 },
                new { Id = 4, DepartmentId = 4, Specialty = "Neonatology", UserId = 4 },
                new { Id = 5, DepartmentId = 5, Specialty = "Cosmetic Dermatology", UserId = 5 }
            );

            builder.Entity<Patient>().HasData(
                new Patient { Id = 1, FullName = "Mohamed Ali", Phone = "01111234567", Email = "mohamed.ali@gmail.com", BloodType = BloodType.A_Positive, DateOfBirth = new DateTime(1990, 5, 15), NoShowCount = 0, AttendanceRate = 100.0, Gender = Gender.Male, MedicalUrgency = MedicalUrgency.Medium, CreatedAt = new DateTime(2024, 3, 1) },
                new Patient { Id = 2, FullName = "Fatma Ibrahim", Phone = "01122345678", Email = "fatma.ibrahim@gmail.com", BloodType = BloodType.B_Negative, DateOfBirth = new DateTime(1985, 8, 22), NoShowCount = 1, AttendanceRate = 80.0, Gender = Gender.Female, MedicalUrgency = MedicalUrgency.High, CreatedAt = new DateTime(2024, 3, 5) },
                new Patient { Id = 3, FullName = "Khaled Mostafa", Phone = "01133456789", Email = "khaled.mostafa@gmail.com", BloodType = BloodType.O_Positive, DateOfBirth = new DateTime(1978, 12, 3), NoShowCount = 2, AttendanceRate = 65.0, Gender = Gender.Male, MedicalUrgency = MedicalUrgency.Low, CreatedAt = new DateTime(2024, 3, 10) },
                new Patient { Id = 4, FullName = "Amira Samir", Phone = "01144567890", Email = "amira.samir@gmail.com", BloodType = BloodType.AB_Positive, DateOfBirth = new DateTime(2000, 3, 18), NoShowCount = 0, AttendanceRate = 100.0, Gender = Gender.Female, MedicalUrgency = MedicalUrgency.Medium, CreatedAt = new DateTime(2024, 3, 12) },
                new Patient { Id = 5, FullName = "Youssef Nabil", Phone = "01155678901", Email = "youssef.nabil@gmail.com", BloodType = BloodType.O_Negative, DateOfBirth = new DateTime(1995, 7, 30), NoShowCount = 3, AttendanceRate = 50.0, Gender = Gender.Male, MedicalUrgency = MedicalUrgency.High, CreatedAt = new DateTime(2024, 3, 15) },
                new Patient { Id = 6, FullName = "Rania Hassan", Phone = "01166789012", Email = "rania.hassan@gmail.com", BloodType = BloodType.A_Negative, DateOfBirth = new DateTime(1992, 11, 10), NoShowCount = 1, AttendanceRate = 75.0, Gender = Gender.Female, MedicalUrgency = MedicalUrgency.Low, CreatedAt = new DateTime(2024, 3, 18) },
                new Patient { Id = 7, FullName = "Tarek Adel", Phone = "01177890123", Email = "tarek.adel@gmail.com", BloodType = BloodType.B_Positive, DateOfBirth = new DateTime(1970, 2, 25), NoShowCount = 0, AttendanceRate = 90.0, Gender = Gender.Male, MedicalUrgency = MedicalUrgency.Medium, CreatedAt = new DateTime(2024, 4, 1) },
                new Patient { Id = 8, FullName = "Dina Walid", Phone = "01188901234", Email = "dina.walid@gmail.com", BloodType = BloodType.AB_Negative, DateOfBirth = new DateTime(1988, 6, 14), NoShowCount = 0, AttendanceRate = 95.0, Gender = Gender.Female, MedicalUrgency = MedicalUrgency.High, CreatedAt = new DateTime(2024, 4, 3) }
            );

            builder.Entity<TimeSlot>().HasData(
                new TimeSlot { Id = 1, DoctorId = 1, SlotDate = new DateTime(2025, 6, 10), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(9, 30, 0), MaxCapacity = 5, BookedCount = 3, IsAvailable = true },
                new TimeSlot { Id = 2, DoctorId = 1, SlotDate = new DateTime(2025, 6, 10), StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(10, 30, 0), MaxCapacity = 5, BookedCount = 5, IsAvailable = false },
                new TimeSlot { Id = 3, DoctorId = 2, SlotDate = new DateTime(2025, 6, 10), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(9, 30, 0), MaxCapacity = 4, BookedCount = 2, IsAvailable = true },
                new TimeSlot { Id = 4, DoctorId = 2, SlotDate = new DateTime(2025, 6, 11), StartTime = new TimeSpan(11, 0, 0), EndTime = new TimeSpan(11, 30, 0), MaxCapacity = 4, BookedCount = 4, IsAvailable = false },
                new TimeSlot { Id = 5, DoctorId = 3, SlotDate = new DateTime(2025, 6, 11), StartTime = new TimeSpan(8, 0, 0), EndTime = new TimeSpan(8, 30, 0), MaxCapacity = 3, BookedCount = 1, IsAvailable = true },
                new TimeSlot { Id = 6, DoctorId = 3, SlotDate = new DateTime(2025, 6, 12), StartTime = new TimeSpan(14, 0, 0), EndTime = new TimeSpan(14, 30, 0), MaxCapacity = 3, BookedCount = 0, IsAvailable = true },
                new TimeSlot { Id = 7, DoctorId = 4, SlotDate = new DateTime(2025, 6, 12), StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(10, 30, 0), MaxCapacity = 6, BookedCount = 3, IsAvailable = true },
                new TimeSlot { Id = 8, DoctorId = 5, SlotDate = new DateTime(2025, 6, 13), StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(13, 30, 0), MaxCapacity = 5, BookedCount = 2, IsAvailable = true }
            );

            builder.Entity<Queue>().HasData(
                new Queue { Id = 1, DoctorId = 1, LastUpdated = new DateTime(2025, 6, 10, 9, 0, 0), Status = QueueStatus.InProgress },
                new Queue { Id = 2, DoctorId = 2, LastUpdated = new DateTime(2025, 6, 10, 9, 0, 0), Status = QueueStatus.Waiting },
                new Queue { Id = 3, DoctorId = 3, LastUpdated = new DateTime(2025, 6, 11, 8, 0, 0), Status = QueueStatus.Waiting },
                new Queue { Id = 4, DoctorId = 4, LastUpdated = new DateTime(2025, 6, 12, 10, 0, 0), Status = QueueStatus.Completed },
                new Queue { Id = 5, DoctorId = 5, LastUpdated = new DateTime(2025, 6, 13, 13, 0, 0), Status = QueueStatus.Cancelled }
            );

            builder.Entity<Appointment>().HasData(
                new Appointment { Id = 1, PatientId = 1, DoctorId = 1, TimeSlotId = 1, QueueId = 1, QueueOrder = 1, Status = AppointmentStatus.Confirmed, PriorityScore = 7.5 },
                new Appointment { Id = 2, PatientId = 2, DoctorId = 1, TimeSlotId = 1, QueueId = 1, QueueOrder = 2, Status = AppointmentStatus.Confirmed, PriorityScore = 9.0 },
                new Appointment { Id = 3, PatientId = 3, DoctorId = 1, TimeSlotId = 2, QueueId = 1, QueueOrder = 3, Status = AppointmentStatus.Completed, PriorityScore = 5.0 },
                new Appointment { Id = 4, PatientId = 4, DoctorId = 2, TimeSlotId = 3, QueueId = 2, QueueOrder = 1, Status = AppointmentStatus.Pending, PriorityScore = 6.5 },
                new Appointment { Id = 5, PatientId = 5, DoctorId = 2, TimeSlotId = 4, QueueId = 2, QueueOrder = 2, Status = AppointmentStatus.Cancelled, PriorityScore = 8.0 },
                new Appointment { Id = 6, PatientId = 6, DoctorId = 3, TimeSlotId = 5, QueueId = 3, QueueOrder = 1, Status = AppointmentStatus.Pending, PriorityScore = 4.5 },
                new Appointment { Id = 7, PatientId = 7, DoctorId = 4, TimeSlotId = 7, QueueId = 4, QueueOrder = 1, Status = AppointmentStatus.Completed, PriorityScore = 7.0 },
                new Appointment { Id = 8, PatientId = 8, DoctorId = 5, TimeSlotId = 8, QueueId = 5, QueueOrder = 1, Status = AppointmentStatus.Cancelled, PriorityScore = 8.5 }
            );

            builder.Entity<Attendance>().HasData(
                new Attendance { Id = 1, AppointmentID = 3, CheckInTime = new DateTime(2025, 6, 10, 9, 0, 0), CheckOutTime = new DateTime(2025, 6, 10, 9, 25, 0), ArriveTime = new DateTime(2025, 6, 10, 8, 55, 0), Status = AttendanceStatus.Present },
                new Attendance { Id = 2, AppointmentID = 7, CheckInTime = new DateTime(2025, 6, 12, 10, 0, 0), CheckOutTime = new DateTime(2025, 6, 12, 10, 28, 0), ArriveTime = new DateTime(2025, 6, 12, 9, 50, 0), Status = AttendanceStatus.Present },
                new Attendance { Id = 3, AppointmentID = 1, CheckInTime = new DateTime(2025, 6, 10, 9, 30, 0), CheckOutTime = new DateTime(2025, 6, 10, 9, 55, 0), ArriveTime = new DateTime(2025, 6, 10, 9, 40, 0), Status = AttendanceStatus.Late },
                new Attendance { Id = 4, AppointmentID = 5, CheckInTime = new DateTime(2025, 6, 10, 11, 0, 0), CheckOutTime = new DateTime(2025, 6, 10, 11, 0, 0), ArriveTime = new DateTime(2025, 6, 10, 11, 0, 0), Status = AttendanceStatus.Absent }
            );
        }
    }
}