using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class assignedReportsToUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6634b97d-383b-4e9b-9af6-4efb65c37e86", "54fe972b-c225-4fea-a2fb-581210eebd16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6ff2ee0c-5b88-48f4-ac0b-e41dfe1191ce", "8eced45b-45e4-40f2-bcc8-808dd1243f95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d663c5ee-5df9-4776-beb6-b4404f6d6420", "c23dde49-cd2b-406a-97bd-aab9d07532bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "32ef8c76-fe68-4842-b9de-b8550a9f46ce", "e501f38c-704a-444b-82e8-2a55c0c650b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5acc6b97-9c99-4cd2-bcd0-dbaabf943ecf", "d0f58b86-90a2-4640-b1d5-2c5c3d0aea6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7bff1a8d-e133-44d1-816f-48c06e314ee5", "7d117a9a-6921-4a49-bfe4-ef3d521ef46b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b35719b5-7d18-41b8-a8b9-a242e503bfbd", "50963369-9f61-4bfe-ac79-32b1d80cbc21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "139531e8-445b-47b0-9f97-0d9bdf633c00", "c452e4ad-9234-4026-9641-7948e21068e1" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "555e52b8-22db-4c15-a037-107016c7f827", new DateTime(2023, 4, 17, 15, 44, 59, 452, DateTimeKind.Utc).AddTicks(9839), new DateTime(2023, 4, 15, 15, 44, 59, 452, DateTimeKind.Utc).AddTicks(9833) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "ad9a20a1-779e-4991-8881-9af6171668a5", new DateTime(2023, 4, 23, 18, 8, 59, 452, DateTimeKind.Utc).AddTicks(9842), new DateTime(2023, 4, 23, 15, 44, 59, 452, DateTimeKind.Utc).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "ad9a20a1-779e-4991-8881-9af6171668a5", new DateTime(2023, 4, 24, 16, 56, 59, 452, DateTimeKind.Utc).AddTicks(9845), new DateTime(2023, 4, 24, 15, 44, 59, 452, DateTimeKind.Utc).AddTicks(9844) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "ad9a20a1-779e-4991-8881-9af6171668a5", new DateTime(2023, 4, 30, 18, 8, 59, 452, DateTimeKind.Utc).AddTicks(9847), new DateTime(2023, 4, 30, 15, 44, 59, 452, DateTimeKind.Utc).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "555e52b8-22db-4c15-a037-107016c7f827", new DateTime(2023, 5, 3, 18, 8, 59, 452, DateTimeKind.Utc).AddTicks(9849), new DateTime(2023, 5, 3, 15, 44, 59, 452, DateTimeKind.Utc).AddTicks(9849) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "5888e361-c81f-4ac9-8e16-961b0eeed0ae", new DateTime(2023, 5, 2, 15, 44, 59, 452, DateTimeKind.Utc).AddTicks(9852), new DateTime(2023, 5, 2, 3, 44, 59, 452, DateTimeKind.Utc).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "5888e361-c81f-4ac9-8e16-961b0eeed0ae", new DateTime(2023, 5, 3, 6, 8, 59, 452, DateTimeKind.Utc).AddTicks(9854), new DateTime(2023, 5, 3, 3, 44, 59, 452, DateTimeKind.Utc).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "ad9a20a1-779e-4991-8881-9af6171668a5", new DateTime(2023, 5, 3, 18, 8, 59, 452, DateTimeKind.Utc).AddTicks(9856), new DateTime(2023, 5, 3, 15, 44, 59, 452, DateTimeKind.Utc).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "5cefc46b-1918-4ae3-8a40-4d337ff9a670", new DateTime(2023, 5, 4, 3, 44, 59, 452, DateTimeKind.Utc).AddTicks(9858), new DateTime(2023, 5, 3, 22, 56, 59, 452, DateTimeKind.Utc).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "ad9a20a1-779e-4991-8881-9af6171668a5", new DateTime(2023, 5, 4, 20, 32, 59, 452, DateTimeKind.Utc).AddTicks(9860), new DateTime(2023, 5, 4, 15, 44, 59, 452, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "5888e361-c81f-4ac9-8e16-961b0eeed0ae", new DateTime(2023, 5, 5, 8, 32, 59, 452, DateTimeKind.Utc).AddTicks(9862), new DateTime(2023, 5, 5, 3, 44, 59, 452, DateTimeKind.Utc).AddTicks(9862) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4089cd20-9675-438d-9125-8bf782b31ca7", "476ec68b-0999-4b72-aafb-c69f78ffbd72" });

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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dcd565e2-3b48-4911-ad9c-65ec5d4bb26b", "5cfbd5b5-5f75-422e-9b94-9e45f3c26605" });

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

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", new DateTime(2023, 4, 17, 15, 41, 9, 220, DateTimeKind.Utc).AddTicks(1538), new DateTime(2023, 4, 15, 15, 41, 9, 220, DateTimeKind.Utc).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", new DateTime(2023, 4, 23, 18, 5, 9, 220, DateTimeKind.Utc).AddTicks(1541), new DateTime(2023, 4, 23, 15, 41, 9, 220, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", new DateTime(2023, 4, 24, 16, 53, 9, 220, DateTimeKind.Utc).AddTicks(1543), new DateTime(2023, 4, 24, 15, 41, 9, 220, DateTimeKind.Utc).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", new DateTime(2023, 4, 30, 18, 5, 9, 220, DateTimeKind.Utc).AddTicks(1545), new DateTime(2023, 4, 30, 15, 41, 9, 220, DateTimeKind.Utc).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", new DateTime(2023, 5, 3, 18, 5, 9, 220, DateTimeKind.Utc).AddTicks(1547), new DateTime(2023, 5, 3, 15, 41, 9, 220, DateTimeKind.Utc).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", new DateTime(2023, 5, 2, 15, 41, 9, 220, DateTimeKind.Utc).AddTicks(1549), new DateTime(2023, 5, 2, 3, 41, 9, 220, DateTimeKind.Utc).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", new DateTime(2023, 5, 3, 6, 5, 9, 220, DateTimeKind.Utc).AddTicks(1551), new DateTime(2023, 5, 3, 3, 41, 9, 220, DateTimeKind.Utc).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", new DateTime(2023, 5, 3, 18, 5, 9, 220, DateTimeKind.Utc).AddTicks(1553), new DateTime(2023, 5, 3, 15, 41, 9, 220, DateTimeKind.Utc).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", new DateTime(2023, 5, 4, 3, 41, 9, 220, DateTimeKind.Utc).AddTicks(1555), new DateTime(2023, 5, 3, 22, 53, 9, 220, DateTimeKind.Utc).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", new DateTime(2023, 5, 4, 20, 29, 9, 220, DateTimeKind.Utc).AddTicks(1559), new DateTime(2023, 5, 4, 15, 41, 9, 220, DateTimeKind.Utc).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6", new DateTime(2023, 5, 5, 8, 29, 9, 220, DateTimeKind.Utc).AddTicks(1561), new DateTime(2023, 5, 5, 3, 41, 9, 220, DateTimeKind.Utc).AddTicks(1560) });
        }
    }
}
