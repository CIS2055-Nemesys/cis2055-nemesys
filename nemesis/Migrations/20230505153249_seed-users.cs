using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class seedusers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "543bb2ec-bb98-470a-a86a-2fdc9939d2d1", "cop2@mall.com", "COP2@MALL.COM", "PAULBLART", "911911", "0604d871-9590-478f-95d7-448ccce76cee", "PaulBlart" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "555e52b8-22db-4c15-a037-107016c7f827", 0, "24c224b9-3f69-4296-aebe-7ef0f609e692", "CandiceFlynn@snitch.com", false, false, null, "CANDICEFLYNN@SNITCH.COM", "CANDICE", null, "201920192", false, "3b575be6-31fd-4b70-83cf-452e6c52dc99", false, "Candice" },
                    { "5888e361-c81f-4ac9-8e16-961b0eeed0ae", 0, "bd3f6a7e-3a44-44c4-a2c7-2bc039d745cf", "cetta@hotmail.com", false, false, null, "CETTA@HOTMAIL.COM", "CETTA", null, "21249200", false, "36d0f4df-ec50-41fd-b782-4d69601900be", false, "Cetta" },
                    { "5cefc46b-1918-4ae3-8a40-4d337ff9a670", 0, "9760d0ee-39e7-44db-a89e-9f156fe60ee3", "head@snitch.com", false, false, null, "HEAD@SNITCH.COM", "6IX9INE", null, "1231233412", false, "01f2e7c2-bb62-4888-a83f-8975881c4ba8", false, "6ix9ine" },
                    { "84b91c9f-74d1-452d-927b-439bfd3a7287", 0, "7ad57cbc-dcac-46a5-9f80-48aae28fd23b", "element@inspect.com", false, false, null, "ELEMENT@INSPECT.COM", "ELEMENT", null, "(650) 253-0000", false, "6e8f4b2e-6adb-43b9-9f96-eb9237cac91c", false, "Element" },
                    { "9059e247-2854-40bd-af2b-76088f8dd4e6", 0, "dbc80c06-04ef-4a21-bfd1-c5da3b4ee550", "gadget@inspect.com", false, false, null, "GADGET@INSPECT.COM", "InspectorGadget", null, "23480922", false, "3ba24e8b-6f2c-482b-8f53-e7f975b3f7d9", false, "InspectorGadget" },
                    { "ad9a20a1-779e-4991-8881-9af6171668a5", 0, "6890fe2e-2648-4c1e-8c18-54707115a5f9", "karen@qrid.com", false, false, null, "KAREN@QRID.COM", "KAREN", null, "10291029", false, "be75e155-671d-4f6c-be7b-ed082776c145", false, "Karen" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "bb62b88e-6ccf-488d-ba0d-13017c32d3fe", "chalijgatt@sampleemail.com", "CHALIJGATT@SAMPLEEMAIL.COM", "CHARLESG", "44236421", "7d95f7e9-f90c-44ab-9246-810ca6a0b468", "CharlesG" });

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
    }
}
