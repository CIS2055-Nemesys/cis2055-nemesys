using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class deleting_old_user_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_User_CreatedByUserId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportViewModel_User_CreatedByUserId",
                table: "ReportViewModel");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_Reports_CreatedByUserId",
                table: "Reports");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                table: "ReportViewModel",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId1",
                table: "Reports",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedByUserId1", "DateOfReport", "DateSpotted" },
                values: new object[] { null, new DateTime(2023, 4, 17, 10, 13, 13, 812, DateTimeKind.Utc).AddTicks(6495), new DateTime(2023, 4, 15, 10, 13, 13, 812, DateTimeKind.Utc).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedByUserId1", "DateOfReport", "DateSpotted" },
                values: new object[] { null, new DateTime(2023, 4, 23, 12, 37, 13, 812, DateTimeKind.Utc).AddTicks(6499), new DateTime(2023, 4, 23, 10, 13, 13, 812, DateTimeKind.Utc).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedByUserId1", "DateOfReport", "DateSpotted" },
                values: new object[] { null, new DateTime(2023, 4, 24, 11, 25, 13, 812, DateTimeKind.Utc).AddTicks(6500), new DateTime(2023, 4, 24, 10, 13, 13, 812, DateTimeKind.Utc).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedByUserId1", "DateOfReport", "DateSpotted" },
                values: new object[] { null, new DateTime(2023, 4, 30, 12, 37, 13, 812, DateTimeKind.Utc).AddTicks(6502), new DateTime(2023, 4, 30, 10, 13, 13, 812, DateTimeKind.Utc).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedByUserId1", "DateOfReport", "DateSpotted" },
                values: new object[] { null, new DateTime(2023, 5, 3, 12, 37, 13, 812, DateTimeKind.Utc).AddTicks(6504), new DateTime(2023, 5, 3, 10, 13, 13, 812, DateTimeKind.Utc).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedByUserId1", "DateOfReport", "DateSpotted" },
                values: new object[] { null, new DateTime(2023, 5, 2, 10, 13, 13, 812, DateTimeKind.Utc).AddTicks(6506), new DateTime(2023, 5, 1, 22, 13, 13, 812, DateTimeKind.Utc).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedByUserId1", "DateOfReport", "DateSpotted" },
                values: new object[] { null, new DateTime(2023, 5, 3, 0, 37, 13, 812, DateTimeKind.Utc).AddTicks(6508), new DateTime(2023, 5, 2, 22, 13, 13, 812, DateTimeKind.Utc).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedByUserId1", "DateOfReport", "DateSpotted" },
                values: new object[] { null, new DateTime(2023, 5, 3, 12, 37, 13, 812, DateTimeKind.Utc).AddTicks(6510), new DateTime(2023, 5, 3, 10, 13, 13, 812, DateTimeKind.Utc).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedByUserId1", "DateOfReport", "DateSpotted" },
                values: new object[] { null, new DateTime(2023, 5, 3, 22, 13, 13, 812, DateTimeKind.Utc).AddTicks(6512), new DateTime(2023, 5, 3, 17, 25, 13, 812, DateTimeKind.Utc).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedByUserId1", "DateOfReport", "DateSpotted" },
                values: new object[] { null, new DateTime(2023, 5, 4, 15, 1, 13, 812, DateTimeKind.Utc).AddTicks(6514), new DateTime(2023, 5, 4, 10, 13, 13, 812, DateTimeKind.Utc).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedByUserId1", "DateOfReport", "DateSpotted" },
                values: new object[] { null, new DateTime(2023, 5, 5, 3, 1, 13, 812, DateTimeKind.Utc).AddTicks(6516), new DateTime(2023, 5, 4, 22, 13, 13, 812, DateTimeKind.Utc).AddTicks(6515) });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_CreatedByUserId1",
                table: "Reports",
                column: "CreatedByUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_AspNetUsers_CreatedByUserId1",
                table: "Reports",
                column: "CreatedByUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

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
                name: "FK_Reports_AspNetUsers_CreatedByUserId1",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportViewModel_AspNetUsers_CreatedByUserId",
                table: "ReportViewModel");

            migrationBuilder.DropIndex(
                name: "IX_Reports_CreatedByUserId1",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId1",
                table: "Reports");

            migrationBuilder.AlterColumn<int>(
                name: "CreatedByUserId",
                table: "ReportViewModel",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "User",
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
                    table.PrimaryKey("PK_User", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Reports_CreatedByUserId",
                table: "Reports",
                column: "CreatedByUserId");

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
    }
}
