using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class switched_to_asp_users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Users_CreatedByUserId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportViewModel_Users_CreatedByUserId",
                table: "ReportViewModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 17, 9, 56, 38, 702, DateTimeKind.Utc).AddTicks(2527), new DateTime(2023, 4, 15, 9, 56, 38, 702, DateTimeKind.Utc).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 23, 12, 20, 38, 702, DateTimeKind.Utc).AddTicks(2530), new DateTime(2023, 4, 23, 9, 56, 38, 702, DateTimeKind.Utc).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 24, 11, 8, 38, 702, DateTimeKind.Utc).AddTicks(2533), new DateTime(2023, 4, 24, 9, 56, 38, 702, DateTimeKind.Utc).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 30, 12, 20, 38, 702, DateTimeKind.Utc).AddTicks(2534), new DateTime(2023, 4, 30, 9, 56, 38, 702, DateTimeKind.Utc).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 12, 20, 38, 702, DateTimeKind.Utc).AddTicks(2536), new DateTime(2023, 5, 3, 9, 56, 38, 702, DateTimeKind.Utc).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 2, 9, 56, 38, 702, DateTimeKind.Utc).AddTicks(2538), new DateTime(2023, 5, 1, 21, 56, 38, 702, DateTimeKind.Utc).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 0, 20, 38, 702, DateTimeKind.Utc).AddTicks(2540), new DateTime(2023, 5, 2, 21, 56, 38, 702, DateTimeKind.Utc).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 12, 20, 38, 702, DateTimeKind.Utc).AddTicks(2542), new DateTime(2023, 5, 3, 9, 56, 38, 702, DateTimeKind.Utc).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 56, 38, 702, DateTimeKind.Utc).AddTicks(2544), new DateTime(2023, 5, 3, 17, 8, 38, 702, DateTimeKind.Utc).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 4, 14, 44, 38, 702, DateTimeKind.Utc).AddTicks(2546), new DateTime(2023, 5, 4, 9, 56, 38, 702, DateTimeKind.Utc).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 5, 2, 44, 38, 702, DateTimeKind.Utc).AddTicks(2548), new DateTime(2023, 5, 4, 21, 56, 38, 702, DateTimeKind.Utc).AddTicks(2547) });

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_User_CreatedByUserId",
                table: "Reports",
                column: "CreatedByUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReportViewModel_User_CreatedByUserId",
                table: "ReportViewModel",
                column: "CreatedByUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_User_CreatedByUserId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportViewModel_User_CreatedByUserId",
                table: "ReportViewModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 15, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1416), new DateTime(2023, 4, 13, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1405) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 46, 36, 71, DateTimeKind.Utc).AddTicks(1531), new DateTime(2023, 4, 21, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 22, 11, 34, 36, 71, DateTimeKind.Utc).AddTicks(1538), new DateTime(2023, 4, 22, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 46, 36, 71, DateTimeKind.Utc).AddTicks(1542), new DateTime(2023, 4, 28, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 46, 36, 71, DateTimeKind.Utc).AddTicks(1545), new DateTime(2023, 5, 1, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 30, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1549), new DateTime(2023, 4, 29, 22, 22, 36, 71, DateTimeKind.Utc).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 1, 0, 46, 36, 71, DateTimeKind.Utc).AddTicks(1556), new DateTime(2023, 4, 30, 22, 22, 36, 71, DateTimeKind.Utc).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 46, 36, 71, DateTimeKind.Utc).AddTicks(1560), new DateTime(2023, 5, 1, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 1, 22, 22, 36, 71, DateTimeKind.Utc).AddTicks(1564), new DateTime(2023, 5, 1, 17, 34, 36, 71, DateTimeKind.Utc).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 2, 15, 10, 36, 71, DateTimeKind.Utc).AddTicks(1568), new DateTime(2023, 5, 2, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 3, 10, 36, 71, DateTimeKind.Utc).AddTicks(1572), new DateTime(2023, 5, 2, 22, 22, 36, 71, DateTimeKind.Utc).AddTicks(1571) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsInvestigator", "Name", "PhoneNum", "Surname" },
                values: new object[,]
                {
                    { 1, "chalijgatt@sampleemail.com", false, "Charles", 44236421, "Gatt" },
                    { 2, "dimpeter@sampleemail.com", false, "Peter", 12345668, "Dimech" },
                    { 3, "valbutt@sampleemail.com", true, "Valentina", 36435173, "Buttigieg" },
                    { 4, "david_d_best@sampleemail.com", false, "David", 77777777, "Briffa" },
                    { 5, "borgwayne420@sampleemail.com", false, "Wayne", 94215242, "Borg" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Users_CreatedByUserId",
                table: "Reports",
                column: "CreatedByUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReportViewModel_Users_CreatedByUserId",
                table: "ReportViewModel",
                column: "CreatedByUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
