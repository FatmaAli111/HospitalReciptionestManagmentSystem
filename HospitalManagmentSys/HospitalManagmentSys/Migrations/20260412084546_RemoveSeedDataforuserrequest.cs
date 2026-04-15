using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentSys.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSeedDataforuserrequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserRequests_UserID",
                table: "UserRequests");

            migrationBuilder.DeleteData(
                table: "UserRequests",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserRequests",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserRequests",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserRequests",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserRequests",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.AddColumn<string>(
                name: "Speciality",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "UserRequests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "UserRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UserRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "UserRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "UserRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "UserRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Speciality",
                table: "UserRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Speciality",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Speciality",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Speciality",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Speciality",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Speciality",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Speciality",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Speciality",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_UserRequests_UserID",
                table: "UserRequests",
                column: "UserID",
                unique: true,
                filter: "[UserID] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserRequests_UserID",
                table: "UserRequests");

            migrationBuilder.DropColumn(
                name: "Speciality",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "UserRequests");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "UserRequests");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "UserRequests");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "UserRequests");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "UserRequests");

            migrationBuilder.DropColumn(
                name: "Speciality",
                table: "UserRequests");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "UserRequests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "UserRequests",
                columns: new[] { "ID", "IsAccountCreated", "RequestDate", "Status", "UserID" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 1 },
                    { 2, true, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 2 },
                    { 3, true, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 3 },
                    { 4, true, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 4 }
                });

            migrationBuilder.InsertData(
                table: "UserRequests",
                columns: new[] { "ID", "RequestDate", "Status", "UserID" },
                values: new object[] { 5, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", 5 });

            migrationBuilder.CreateIndex(
                name: "IX_UserRequests_UserID",
                table: "UserRequests",
                column: "UserID",
                unique: true);
        }
    }
}
