using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagmentSys.Migrations
{
    /// <inheritdoc />
    public partial class AppointWithQueue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Queues_TimeSlots_TimeSlotId",
                table: "Queues");

            migrationBuilder.DropIndex(
                name: "IX_Queues_TimeSlotId",
                table: "Queues");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "UserRequests");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "UserRequests");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "UserRequests");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "UserRequests");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Doctors");

            migrationBuilder.RenameColumn(
                name: "TimeSlotId",
                table: "Queues",
                newName: "DoctorId");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Users",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "QueueId",
                table: "TimeSlots",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TimeSlots_QueueId",
                table: "TimeSlots",
                column: "QueueId");

            migrationBuilder.CreateIndex(
                name: "IX_Queues_DoctorId",
                table: "Queues",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Queues_Doctors_DoctorId",
                table: "Queues",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSlots_Queues_QueueId",
                table: "TimeSlots",
                column: "QueueId",
                principalTable: "Queues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Queues_Doctors_DoctorId",
                table: "Queues");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeSlots_Queues_QueueId",
                table: "TimeSlots");

            migrationBuilder.DropIndex(
                name: "IX_TimeSlots_QueueId",
                table: "TimeSlots");

            migrationBuilder.DropIndex(
                name: "IX_Queues_DoctorId",
                table: "Queues");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "QueueId",
                table: "TimeSlots");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "Queues",
                newName: "TimeSlotId");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "UserRequests",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "UserRequests",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "UserRequests",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "UserRequests",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Doctors",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Doctors",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Queues_TimeSlotId",
                table: "Queues",
                column: "TimeSlotId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Queues_TimeSlots_TimeSlotId",
                table: "Queues",
                column: "TimeSlotId",
                principalTable: "TimeSlots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
