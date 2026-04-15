using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagmentSys.Migrations
{
    /// <inheritdoc />
    public partial class Update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 1,
                column: "SlotDate",
                value: new DateTime(2026, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 2,
                column: "SlotDate",
                value: new DateTime(2026, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 3,
                column: "SlotDate",
                value: new DateTime(2026, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 4,
                column: "SlotDate",
                value: new DateTime(2026, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 5,
                column: "SlotDate",
                value: new DateTime(2026, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 6,
                column: "SlotDate",
                value: new DateTime(2026, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 7,
                column: "SlotDate",
                value: new DateTime(2026, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 8,
                column: "SlotDate",
                value: new DateTime(2026, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 1,
                column: "SlotDate",
                value: new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 2,
                column: "SlotDate",
                value: new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 3,
                column: "SlotDate",
                value: new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 4,
                column: "SlotDate",
                value: new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 5,
                column: "SlotDate",
                value: new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 6,
                column: "SlotDate",
                value: new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 7,
                column: "SlotDate",
                value: new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 8,
                column: "SlotDate",
                value: new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
