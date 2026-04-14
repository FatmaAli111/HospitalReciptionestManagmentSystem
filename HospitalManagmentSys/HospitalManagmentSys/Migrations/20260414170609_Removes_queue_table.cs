using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentSys.Migrations
{
    /// <inheritdoc />
    public partial class Removes_queue_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Queues_QueueId",
                table: "Appointments");

            migrationBuilder.DropTable(
                name: "Queues");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_QueueId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "QueueId",
                table: "Appointments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QueueId",
                table: "Appointments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Queues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Queues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Queues_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_QueueId",
                table: "Appointments",
                column: "QueueId");

            migrationBuilder.CreateIndex(
                name: "IX_Queues_DoctorId",
                table: "Queues",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Queues_QueueId",
                table: "Appointments",
                column: "QueueId",
                principalTable: "Queues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
