# Hospital Receptionist Management System

A Windows Forms desktop application built with **.NET 8** that helps hospital receptionists manage patients, appointments, doctors, and queues efficiently.

---

## Table of Contents

- [Features](#features)
- [Tech Stack](#tech-stack)
- [Project Structure](#project-structure)
- [Data Models](#data-models)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Database Setup](#database-setup)
  - [Running the Application](#running-the-application)
- [User Roles](#user-roles)
- [License](#license)

---

## Features

- **Authentication** – Login and signup with role-based access control (Admin, Doctor, Receptionist)
- **Dashboard** – Overview cards showing key statistics (appointments, patients, doctors)
- **Patient Management** – Register patients, track medical urgency, blood type, attendance rate, and no-show count
- **Appointment Booking** – Book, confirm, complete, or cancel appointments with priority scoring
- **Queue Management** – Real-time priority queue display with visual status indicators
- **Doctor Management** – Manage doctors, their specialties, departments, and time slots
- **Reports** – Generate appointment and attendance reports
- **Admin Panel** – Manage user accounts and approve/reject account creation requests
- **Settings** – Application configuration

---

## Tech Stack

| Layer        | Technology                                   |
|--------------|----------------------------------------------|
| UI Framework | Windows Forms (.NET 8)                       |
| ORM          | Entity Framework Core 9                      |
| Database     | Microsoft SQL Server                         |
| UI Controls  | Guna.UI2.WinForms 2.0, LiveCharts.WinForms   |
| Config       | Microsoft.Extensions.Configuration.Json      |

---

## Project Structure

```
HospitalManagmentSys/
└── HospitalManagmentSys/
    ├── Program.cs                  # Application entry point
    ├── appsettings.json            # Database connection string
    ├── BiussnessLogic/             # Service / business logic layer
    │   ├── AppointmentService.cs
    │   ├── DashbordServices.cs
    │   ├── LoginService.cs
    │   ├── QueueService.cs
    │   ├── SessionManager.cs
    │   ├── SignupService.cs
    │   └── UserRequestService.cs
    ├── Data/
    │   ├── AppDbContext.cs         # EF Core database context
    │   ├── Configuration/          # Entity type configurations
    │   └── Models/                 # Domain models
    │       ├── Appointment.cs
    │       ├── Attendance.cs
    │       ├── Department.cs
    │       ├── Doctor.cs
    │       ├── Patient.cs
    │       ├── TimeSlot.cs
    │       ├── User.cs
    │       └── UserRequest.cs
    ├── Migrations/                 # EF Core migration files
    └── Presentation/               # Windows Forms UI
        ├── AccountForm/            # Login, Signup, Admin panel
        ├── AppointmentForm/        # Book & view appointments
        ├── Dashbord/               # Dashboard & card controls
        ├── PatientForm/            # Patient registration & management
        ├── ProfilePatient/         # Patient profile view
        ├── QueueForm/              # Priority queue display
        ├── ReportsForm/            # Appointment reports
        ├── Settings/               # App settings
        └── Controls/               # Shared UI controls (Sidebar, etc.)
```

---

## Data Models

| Model        | Key Fields                                                                 |
|--------------|----------------------------------------------------------------------------|
| `User`       | Name, Email, Phone, Role (Admin/Doctor/Receptionist), PasswordHash         |
| `Patient`    | FullName, Phone, Email, BloodType, DateOfBirth, Gender, MedicalUrgency     |
| `Doctor`     | UserId, DepartmentId, Specialty, TimeSlots                                 |
| `Department` | Name, Doctors                                                              |
| `Appointment`| PatientId, DoctorId, TimeSlotId, Date, Status, PriorityScore, QueueOrder  |
| `Attendance` | Tracks patient check-in/check-out for appointments                        |
| `TimeSlot`   | Available time slots for doctors                                           |
| `UserRequest`| Pending account creation requests for admin approval                       |

**Appointment statuses:** Pending → Confirmed → Completed / Cancelled

**Medical urgency levels:** Low · Medium · High · Emergency

---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (with Windows Forms workload)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (any edition, including LocalDB or Express)

### Database Setup

1. Open `appsettings.json` and update the connection string to point to your SQL Server instance:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "server=.;database=HospitalManagmentSystem;trust server certificate=true;integrated security=true;"
     }
   }
   ```

2. Apply the Entity Framework Core migrations to create the database schema. From the project directory, run:

   ```bash
   dotnet ef database update
   ```

### Running the Application

1. Clone the repository:

   ```bash
   git clone https://github.com/FatmaAli111/HospitalReciptionestManagmentSystem.git
   ```

2. Open `HospitalManagmentSys.sln` in Visual Studio 2022.

3. Restore NuGet packages (Visual Studio does this automatically on build).

4. Ensure the database connection string in `appsettings.json` is correct.

5. Press **F5** or click **Run** to build and launch the application.

---

## User Roles

| Role            | Capabilities                                                                 |
|-----------------|------------------------------------------------------------------------------|
| **Admin**       | Manage all users, approve/reject account requests, full system access        |
| **Doctor**      | View own appointments and patient queue, update attendance                   |
| **Receptionist**| Register patients, book appointments, manage queue, generate reports         |

---

## License

This project is open source. Feel free to fork and adapt it for your needs.