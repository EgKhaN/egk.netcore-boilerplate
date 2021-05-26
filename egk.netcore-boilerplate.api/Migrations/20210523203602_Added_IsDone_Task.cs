using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace egk.netcore_boilerplate.api.Migrations
{
    public partial class Added_IsDone_Task : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tasks_StatusId",
                table: "Tasks");

            migrationBuilder.AddColumn<bool>(
                name: "IsDone",
                table: "Tasks",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 23, 20, 36, 1, 979, DateTimeKind.Utc).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 23, 20, 36, 1, 979, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 23, 20, 36, 1, 979, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 23, 20, 36, 1, 979, DateTimeKind.Utc).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 23, 20, 36, 1, 979, DateTimeKind.Utc).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 23, 20, 36, 1, 979, DateTimeKind.Utc).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "TaskStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 23, 20, 36, 2, 19, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "TaskStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 23, 20, 36, 2, 19, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "TaskStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 23, 20, 36, 2, 19, DateTimeKind.Utc).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "TaskStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 23, 20, 36, 2, 19, DateTimeKind.Utc).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "TaskStatuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 23, 20, 36, 2, 19, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_StatusId",
                table: "Tasks",
                column: "StatusId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tasks_StatusId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "IsDone",
                table: "Tasks");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 21, 0, 28, 847, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 21, 0, 28, 847, DateTimeKind.Utc).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 21, 0, 28, 847, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 21, 0, 28, 847, DateTimeKind.Utc).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 21, 0, 28, 847, DateTimeKind.Utc).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 21, 0, 28, 847, DateTimeKind.Utc).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "TaskStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 21, 0, 28, 847, DateTimeKind.Utc).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "TaskStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 21, 0, 28, 847, DateTimeKind.Utc).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "TaskStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 21, 0, 28, 847, DateTimeKind.Utc).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "TaskStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 21, 0, 28, 847, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "TaskStatuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 21, 0, 28, 847, DateTimeKind.Utc).AddTicks(6349));

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_StatusId",
                table: "Tasks",
                column: "StatusId");
        }
    }
}
