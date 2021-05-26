using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace egk.netcore_boilerplate.api.Migrations
{
    public partial class Added_Seed_Datas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 21, 0, 28, 596, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 21, 0, 28, 596, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 21, 0, 28, 596, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 4, "EgK", new DateTime(2021, 3, 8, 21, 0, 28, 596, DateTimeKind.Utc).AddTicks(7657), null, null, null, "Scheduler" },
                    { 5, "EgK", new DateTime(2021, 3, 8, 21, 0, 28, 596, DateTimeKind.Utc).AddTicks(7850), null, null, null, "Human Resources" },
                    { 6, "EgK", new DateTime(2021, 3, 8, 21, 0, 28, 596, DateTimeKind.Utc).AddTicks(8035), null, null, null, "Personal Asistant" }
                });

            migrationBuilder.UpdateData(
                table: "TaskStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 21, 0, 28, 642, DateTimeKind.Utc).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "TaskStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 21, 0, 28, 642, DateTimeKind.Utc).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "TaskStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 21, 0, 28, 642, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "TaskStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 21, 0, 28, 642, DateTimeKind.Utc).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "TaskStatuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 21, 0, 28, 642, DateTimeKind.Utc).AddTicks(7912));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 20, 46, 20, 133, DateTimeKind.Utc).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 20, 46, 20, 133, DateTimeKind.Utc).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 20, 46, 20, 133, DateTimeKind.Utc).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "TaskStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 20, 46, 20, 133, DateTimeKind.Utc).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "TaskStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 20, 46, 20, 133, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "TaskStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 20, 46, 20, 133, DateTimeKind.Utc).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "TaskStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 20, 46, 20, 133, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "TaskStatuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 20, 46, 20, 133, DateTimeKind.Utc).AddTicks(6870));
        }
    }
}
