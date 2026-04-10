using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagmentSys.Migrations
{
    /// <inheritdoc />
    public partial class rmSlotWithQueue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeSlots_Queues_QueueId",
                table: "TimeSlots");

            migrationBuilder.DropIndex(
                name: "IX_TimeSlots_QueueId",
                table: "TimeSlots");

            migrationBuilder.DropColumn(
                name: "QueueId",
                table: "TimeSlots");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSlots_Queues_QueueId",
                table: "TimeSlots",
                column: "QueueId",
                principalTable: "Queues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
