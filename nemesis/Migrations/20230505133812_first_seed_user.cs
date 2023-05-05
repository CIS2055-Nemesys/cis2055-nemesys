using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class first_seed_user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "bb62b88e-6ccf-488d-ba0d-13017c32d3fe", "CHALIJGATT@SAMPLEEMAIL.COM", "CHARLESG", "7d95f7e9-f90c-44ab-9246-810ca6a0b468" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 17, 13, 38, 12, 260, DateTimeKind.Utc).AddTicks(7423), new DateTime(2023, 4, 15, 13, 38, 12, 260, DateTimeKind.Utc).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 23, 16, 2, 12, 260, DateTimeKind.Utc).AddTicks(7427), new DateTime(2023, 4, 23, 13, 38, 12, 260, DateTimeKind.Utc).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 24, 14, 50, 12, 260, DateTimeKind.Utc).AddTicks(7429), new DateTime(2023, 4, 24, 13, 38, 12, 260, DateTimeKind.Utc).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 30, 16, 2, 12, 260, DateTimeKind.Utc).AddTicks(7431), new DateTime(2023, 4, 30, 13, 38, 12, 260, DateTimeKind.Utc).AddTicks(7431) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 2, 12, 260, DateTimeKind.Utc).AddTicks(7433), new DateTime(2023, 5, 3, 13, 38, 12, 260, DateTimeKind.Utc).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 2, 13, 38, 12, 260, DateTimeKind.Utc).AddTicks(7436), new DateTime(2023, 5, 2, 1, 38, 12, 260, DateTimeKind.Utc).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 4, 2, 12, 260, DateTimeKind.Utc).AddTicks(7439), new DateTime(2023, 5, 3, 1, 38, 12, 260, DateTimeKind.Utc).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 2, 12, 260, DateTimeKind.Utc).AddTicks(7441), new DateTime(2023, 5, 3, 13, 38, 12, 260, DateTimeKind.Utc).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 4, 1, 38, 12, 260, DateTimeKind.Utc).AddTicks(7443), new DateTime(2023, 5, 3, 20, 50, 12, 260, DateTimeKind.Utc).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 4, 18, 26, 12, 260, DateTimeKind.Utc).AddTicks(7445), new DateTime(2023, 5, 4, 13, 38, 12, 260, DateTimeKind.Utc).AddTicks(7445) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 5, 6, 26, 12, 260, DateTimeKind.Utc).AddTicks(7447), new DateTime(2023, 5, 5, 1, 38, 12, 260, DateTimeKind.Utc).AddTicks(7447) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "fb76fef5-62e2-4cf0-b908-74efd31349e3", null, null, "cd4bc2a6-df80-4726-aa0c-2ecede784a64" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 17, 13, 11, 27, 792, DateTimeKind.Utc).AddTicks(1018), new DateTime(2023, 4, 15, 13, 11, 27, 792, DateTimeKind.Utc).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 23, 15, 35, 27, 792, DateTimeKind.Utc).AddTicks(1030), new DateTime(2023, 4, 23, 13, 11, 27, 792, DateTimeKind.Utc).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 24, 14, 23, 27, 792, DateTimeKind.Utc).AddTicks(1035), new DateTime(2023, 4, 24, 13, 11, 27, 792, DateTimeKind.Utc).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 30, 15, 35, 27, 792, DateTimeKind.Utc).AddTicks(1039), new DateTime(2023, 4, 30, 13, 11, 27, 792, DateTimeKind.Utc).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 15, 35, 27, 792, DateTimeKind.Utc).AddTicks(1043), new DateTime(2023, 5, 3, 13, 11, 27, 792, DateTimeKind.Utc).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 2, 13, 11, 27, 792, DateTimeKind.Utc).AddTicks(1046), new DateTime(2023, 5, 2, 1, 11, 27, 792, DateTimeKind.Utc).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 3, 35, 27, 792, DateTimeKind.Utc).AddTicks(1112), new DateTime(2023, 5, 3, 1, 11, 27, 792, DateTimeKind.Utc).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 15, 35, 27, 792, DateTimeKind.Utc).AddTicks(1117), new DateTime(2023, 5, 3, 13, 11, 27, 792, DateTimeKind.Utc).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 4, 1, 11, 27, 792, DateTimeKind.Utc).AddTicks(1120), new DateTime(2023, 5, 3, 20, 23, 27, 792, DateTimeKind.Utc).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 4, 17, 59, 27, 792, DateTimeKind.Utc).AddTicks(1124), new DateTime(2023, 5, 4, 13, 11, 27, 792, DateTimeKind.Utc).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 5, 5, 59, 27, 792, DateTimeKind.Utc).AddTicks(1127), new DateTime(2023, 5, 5, 1, 11, 27, 792, DateTimeKind.Utc).AddTicks(1127) });
        }
    }
}
