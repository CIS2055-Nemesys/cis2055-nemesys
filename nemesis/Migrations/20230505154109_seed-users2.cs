using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class seedusers2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "09d1e73c-da1b-400b-9ab0-1a3ca21a2b81", "72af7393-f74f-4013-95b7-0d6ece2eea4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1a6d9272-998b-466f-8156-89d0a12f4d75", "5d1b9b72-c3b4-4ff9-93b1-c98c0915ba01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b082543f-2732-4e62-bb17-5992e067d6b8", "db538149-dc8c-4ea4-b4aa-328feacfd3e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7fdcdbb6-43c0-4ee4-8e4c-60009ddd4760", "77c2107d-3b40-4cd3-b0ad-70547c333556" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "dcd565e2-3b48-4911-ad9c-65ec5d4bb26b", "INSPECTORGADGET", "5cfbd5b5-5f75-422e-9b94-9e45f3c26605" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4c9fc09f-c030-4e82-b189-5441dc3e39f4", "66d043a5-d29e-4037-bc56-fe086d1d9758" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "82de7563-6e9e-436b-8ce6-9623a03ee4f6", "9d5d9278-b889-47bc-8a09-9ff73e114f38" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3303fdaf-f438-4582-8f10-52b578c50cb8", 0, "4089cd20-9675-438d-9125-8bf782b31ca7", "homework@reminder.com", false, false, null, "HOMEWORK@REMINDER.COM", "HOMEWORKREMINDER", null, "123412521", false, "476ec68b-0999-4b72-aafb-c69f78ffbd72", false, "homeworkReminder" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 17, 15, 41, 9, 220, DateTimeKind.Utc).AddTicks(1538), new DateTime(2023, 4, 15, 15, 41, 9, 220, DateTimeKind.Utc).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 23, 18, 5, 9, 220, DateTimeKind.Utc).AddTicks(1541), new DateTime(2023, 4, 23, 15, 41, 9, 220, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 24, 16, 53, 9, 220, DateTimeKind.Utc).AddTicks(1543), new DateTime(2023, 4, 24, 15, 41, 9, 220, DateTimeKind.Utc).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 5, 9, 220, DateTimeKind.Utc).AddTicks(1545), new DateTime(2023, 4, 30, 15, 41, 9, 220, DateTimeKind.Utc).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 18, 5, 9, 220, DateTimeKind.Utc).AddTicks(1547), new DateTime(2023, 5, 3, 15, 41, 9, 220, DateTimeKind.Utc).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 2, 15, 41, 9, 220, DateTimeKind.Utc).AddTicks(1549), new DateTime(2023, 5, 2, 3, 41, 9, 220, DateTimeKind.Utc).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 6, 5, 9, 220, DateTimeKind.Utc).AddTicks(1551), new DateTime(2023, 5, 3, 3, 41, 9, 220, DateTimeKind.Utc).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 18, 5, 9, 220, DateTimeKind.Utc).AddTicks(1553), new DateTime(2023, 5, 3, 15, 41, 9, 220, DateTimeKind.Utc).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 4, 3, 41, 9, 220, DateTimeKind.Utc).AddTicks(1555), new DateTime(2023, 5, 3, 22, 53, 9, 220, DateTimeKind.Utc).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 4, 20, 29, 9, 220, DateTimeKind.Utc).AddTicks(1559), new DateTime(2023, 5, 4, 15, 41, 9, 220, DateTimeKind.Utc).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 5, 8, 29, 9, 220, DateTimeKind.Utc).AddTicks(1561), new DateTime(2023, 5, 5, 3, 41, 9, 220, DateTimeKind.Utc).AddTicks(1560) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "24c224b9-3f69-4296-aebe-7ef0f609e692", "3b575be6-31fd-4b70-83cf-452e6c52dc99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bd3f6a7e-3a44-44c4-a2c7-2bc039d745cf", "36d0f4df-ec50-41fd-b782-4d69601900be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9760d0ee-39e7-44db-a89e-9f156fe60ee3", "01f2e7c2-bb62-4888-a83f-8975881c4ba8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ad57cbc-dcac-46a5-9f80-48aae28fd23b", "6e8f4b2e-6adb-43b9-9f96-eb9237cac91c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "dbc80c06-04ef-4a21-bfd1-c5da3b4ee550", "InspectorGadget", "3ba24e8b-6f2c-482b-8f53-e7f975b3f7d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "543bb2ec-bb98-470a-a86a-2fdc9939d2d1", "0604d871-9590-478f-95d7-448ccce76cee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6890fe2e-2648-4c1e-8c18-54707115a5f9", "be75e155-671d-4f6c-be7b-ed082776c145" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 17, 15, 32, 49, 506, DateTimeKind.Utc).AddTicks(72), new DateTime(2023, 4, 15, 15, 32, 49, 506, DateTimeKind.Utc).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 23, 17, 56, 49, 506, DateTimeKind.Utc).AddTicks(76), new DateTime(2023, 4, 23, 15, 32, 49, 506, DateTimeKind.Utc).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 24, 16, 44, 49, 506, DateTimeKind.Utc).AddTicks(78), new DateTime(2023, 4, 24, 15, 32, 49, 506, DateTimeKind.Utc).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 30, 17, 56, 49, 506, DateTimeKind.Utc).AddTicks(80), new DateTime(2023, 4, 30, 15, 32, 49, 506, DateTimeKind.Utc).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 17, 56, 49, 506, DateTimeKind.Utc).AddTicks(82), new DateTime(2023, 5, 3, 15, 32, 49, 506, DateTimeKind.Utc).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 2, 15, 32, 49, 506, DateTimeKind.Utc).AddTicks(84), new DateTime(2023, 5, 2, 3, 32, 49, 506, DateTimeKind.Utc).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 5, 56, 49, 506, DateTimeKind.Utc).AddTicks(85), new DateTime(2023, 5, 3, 3, 32, 49, 506, DateTimeKind.Utc).AddTicks(85) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 17, 56, 49, 506, DateTimeKind.Utc).AddTicks(87), new DateTime(2023, 5, 3, 15, 32, 49, 506, DateTimeKind.Utc).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 4, 3, 32, 49, 506, DateTimeKind.Utc).AddTicks(89), new DateTime(2023, 5, 3, 22, 44, 49, 506, DateTimeKind.Utc).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 4, 20, 20, 49, 506, DateTimeKind.Utc).AddTicks(91), new DateTime(2023, 5, 4, 15, 32, 49, 506, DateTimeKind.Utc).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 5, 8, 20, 49, 506, DateTimeKind.Utc).AddTicks(93), new DateTime(2023, 5, 5, 3, 32, 49, 506, DateTimeKind.Utc).AddTicks(93) });
        }
    }
}
