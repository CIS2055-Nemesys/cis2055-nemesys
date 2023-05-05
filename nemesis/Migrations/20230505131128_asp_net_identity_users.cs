using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class asp_net_identity_users : Migration
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

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                table: "ReportViewModel",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                table: "Reports",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "InvestigatorId",
                table: "Investigations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", 0, "fb76fef5-62e2-4cf0-b908-74efd31349e3", "chalijgatt@sampleemail.com", false, false, null, null, null, null, "44236421", false, "cd4bc2a6-df80-4726-aa0c-2ecede784a64", false, "CharlesG" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", new DateTime(2023, 4, 17, 13, 11, 27, 792, DateTimeKind.Utc).AddTicks(1018), new DateTime(2023, 4, 15, 13, 11, 27, 792, DateTimeKind.Utc).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", new DateTime(2023, 4, 23, 15, 35, 27, 792, DateTimeKind.Utc).AddTicks(1030), new DateTime(2023, 4, 23, 13, 11, 27, 792, DateTimeKind.Utc).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", new DateTime(2023, 4, 24, 14, 23, 27, 792, DateTimeKind.Utc).AddTicks(1035), new DateTime(2023, 4, 24, 13, 11, 27, 792, DateTimeKind.Utc).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", new DateTime(2023, 4, 30, 15, 35, 27, 792, DateTimeKind.Utc).AddTicks(1039), new DateTime(2023, 4, 30, 13, 11, 27, 792, DateTimeKind.Utc).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", new DateTime(2023, 5, 3, 15, 35, 27, 792, DateTimeKind.Utc).AddTicks(1043), new DateTime(2023, 5, 3, 13, 11, 27, 792, DateTimeKind.Utc).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", new DateTime(2023, 5, 2, 13, 11, 27, 792, DateTimeKind.Utc).AddTicks(1046), new DateTime(2023, 5, 2, 1, 11, 27, 792, DateTimeKind.Utc).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", new DateTime(2023, 5, 3, 3, 35, 27, 792, DateTimeKind.Utc).AddTicks(1112), new DateTime(2023, 5, 3, 1, 11, 27, 792, DateTimeKind.Utc).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", new DateTime(2023, 5, 3, 15, 35, 27, 792, DateTimeKind.Utc).AddTicks(1117), new DateTime(2023, 5, 3, 13, 11, 27, 792, DateTimeKind.Utc).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", new DateTime(2023, 5, 4, 1, 11, 27, 792, DateTimeKind.Utc).AddTicks(1120), new DateTime(2023, 5, 3, 20, 23, 27, 792, DateTimeKind.Utc).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", new DateTime(2023, 5, 4, 17, 59, 27, 792, DateTimeKind.Utc).AddTicks(1124), new DateTime(2023, 5, 4, 13, 11, 27, 792, DateTimeKind.Utc).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", new DateTime(2023, 5, 5, 5, 59, 27, 792, DateTimeKind.Utc).AddTicks(1127), new DateTime(2023, 5, 5, 1, 11, 27, 792, DateTimeKind.Utc).AddTicks(1127) });

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_AspNetUsers_CreatedByUserId",
                table: "Reports",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReportViewModel_AspNetUsers_CreatedByUserId",
                table: "ReportViewModel",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_AspNetUsers_CreatedByUserId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportViewModel_AspNetUsers_CreatedByUserId",
                table: "ReportViewModel");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6");

            migrationBuilder.AlterColumn<int>(
                name: "CreatedByUserId",
                table: "ReportViewModel",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedByUserId",
                table: "Reports",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "InvestigatorId",
                table: "Investigations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsInvestigator = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNum = table.Column<int>(type: "int", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { 2, new DateTime(2023, 4, 15, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1416), new DateTime(2023, 4, 13, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1405) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { 3, new DateTime(2023, 4, 21, 12, 46, 36, 71, DateTimeKind.Utc).AddTicks(1531), new DateTime(2023, 4, 21, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { 5, new DateTime(2023, 4, 22, 11, 34, 36, 71, DateTimeKind.Utc).AddTicks(1538), new DateTime(2023, 4, 22, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { 1, new DateTime(2023, 4, 28, 12, 46, 36, 71, DateTimeKind.Utc).AddTicks(1542), new DateTime(2023, 4, 28, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { 4, new DateTime(2023, 5, 1, 12, 46, 36, 71, DateTimeKind.Utc).AddTicks(1545), new DateTime(2023, 5, 1, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { 4, new DateTime(2023, 4, 30, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1549), new DateTime(2023, 4, 29, 22, 22, 36, 71, DateTimeKind.Utc).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { 5, new DateTime(2023, 5, 1, 0, 46, 36, 71, DateTimeKind.Utc).AddTicks(1556), new DateTime(2023, 4, 30, 22, 22, 36, 71, DateTimeKind.Utc).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { 5, new DateTime(2023, 5, 1, 12, 46, 36, 71, DateTimeKind.Utc).AddTicks(1560), new DateTime(2023, 5, 1, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { 3, new DateTime(2023, 5, 1, 22, 22, 36, 71, DateTimeKind.Utc).AddTicks(1564), new DateTime(2023, 5, 1, 17, 34, 36, 71, DateTimeKind.Utc).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { 4, new DateTime(2023, 5, 2, 15, 10, 36, 71, DateTimeKind.Utc).AddTicks(1568), new DateTime(2023, 5, 2, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { 5, new DateTime(2023, 5, 3, 3, 10, 36, 71, DateTimeKind.Utc).AddTicks(1572), new DateTime(2023, 5, 2, 22, 22, 36, 71, DateTimeKind.Utc).AddTicks(1571) });

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
