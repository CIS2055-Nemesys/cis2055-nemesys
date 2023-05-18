using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class SeedUpvotes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a525ac-d446-4c8c-983c-047afdffed13",
                column: "ConcurrencyStamp",
                value: "39a58ae7-e074-479a-809b-03d492c069da");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca95d41-370a-4218-b0aa-8502494448fb",
                column: "ConcurrencyStamp",
                value: "73da3424-c95e-45c4-8298-81999d500ac9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8d1e278-9e36-4a58-aa70-a3e3c576f50a", "AQAAAAEAACcQAAAAEN3mFuNnJTR2RW+/mpHMXB2+tgjAYWO+92gkv1PmQ/ODiGuo3N9oI8vldtCFFhVcqQ==", "b6de0b14-fa5e-4d23-a8e5-fe7bc6fa0210" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fa21dcf-8553-405e-8157-db221f9a3174", "AQAAAAEAACcQAAAAEI2BRWuoDZpiTa53j6E6B8ot/yIZZ8vndyc4SVxulFOTovXzoAO/cwaAx2V2cpEQAQ==", "5be8ac23-a1c4-47be-abde-4faae305fab5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c659385-8231-472c-8c2b-215706c4e079", "AQAAAAEAACcQAAAAEDzsIsCRfFoZJXDI9nzTvfEUMmpVdPP+DWf1N0ePOaegfJnQ2YSn5vUSb2nBbtJunw==", "ebd0411c-7773-4ac5-80e2-148c0d8fc53c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db0e2a37-b781-431d-8ada-8d7b91e7b3db", "AQAAAAEAACcQAAAAEMhY7yzp+KznzIZDYHal8Hi388Ak5Ik8RQUTUzoH21IzD4aRvr2da07ilqwk8M0Kjg==", "5fc22d49-255a-4aaf-9799-f5562829a8d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec975e07-93c4-44ee-a530-01936512019c", "AQAAAAEAACcQAAAAEOXiwQnpApqNjf8VUNypm8fdJYDhJNyuW13EduJgNmkKAGgTVTiQC6mrKpnFXNpWsw==", "b666021e-047d-453a-b165-3bf57b7e9337" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09dc9e6a-8c41-4512-ac86-b14ca12d9465", "AQAAAAEAACcQAAAAEKjTC4zi1WiUvawhPPcKtSzFwM9T+rP99JpgFHnBlLzJ2UjALKcSe6CjwOifvVIsUw==", "5cb0d5a4-34f1-4ab4-8e90-570b8bb1fad3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55a12214-4e9f-4089-8f7b-9e2e36372539", "AQAAAAEAACcQAAAAEORNuOrD2lL+dFm8s2Io70F2xuFrZOcd0mNtjPOkON5vROrrawW8rBjegvGpTyyhcQ==", "c4ce47f0-4ff2-4adb-b923-967310671074" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0878d93-a445-4ab1-8ab2-406bc78ca37d", "AQAAAAEAACcQAAAAENlhQpCk0BMoQhu6sBt+5U1tuwxrmpDZXfwg47vhxbDLwLMf6U/Aa/XWyY8ki0lS4w==", "5dae2937-ad4d-490d-81fe-d3b43fcdf466" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f51bc532-b9cf-4c26-8e75-bc21b348c2a9", "AQAAAAEAACcQAAAAEO1UZF5nD9Hz4t6HYbI+bceMsfDgvIuMYHoNT8MlI/Sooqrs+D/I7ZcCifPOcumpWQ==", "bc9e75a1-cb34-4185-9271-093ad1b80c11" });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 18, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 18, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfAction", "InvestigatorId" },
                values: new object[] { new DateTime(2023, 5, 18, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(5119), "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6" });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 18, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 18, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfAction", "InvestigatorId" },
                values: new object[] { new DateTime(2023, 5, 18, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(5304), "9059e247-2854-40bd-af2b-76088f8dd4e6" });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 18, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfAction", "InvestigatorId" },
                values: new object[] { new DateTime(2023, 5, 18, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(5308), "9059e247-2854-40bd-af2b-76088f8dd4e6" });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 18, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 30, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(4878), new DateTime(2023, 4, 28, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 6, 17, 54, 4, 24, DateTimeKind.Utc).AddTicks(4884), new DateTime(2023, 5, 6, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(4883) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 7, 16, 42, 4, 24, DateTimeKind.Utc).AddTicks(4888), new DateTime(2023, 5, 7, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(4886) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 13, 17, 54, 4, 24, DateTimeKind.Utc).AddTicks(4890), new DateTime(2023, 5, 13, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "9059e247-2854-40bd-af2b-76088f8dd4e6", new DateTime(2023, 5, 16, 17, 54, 4, 24, DateTimeKind.Utc).AddTicks(4892), new DateTime(2023, 5, 16, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "ad9a20a1-779e-4991-8881-9af6171668a5", new DateTime(2023, 5, 15, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(4895), new DateTime(2023, 5, 15, 3, 30, 4, 24, DateTimeKind.Utc).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 16, 5, 54, 4, 24, DateTimeKind.Utc).AddTicks(4898), new DateTime(2023, 5, 16, 3, 30, 4, 24, DateTimeKind.Utc).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 54, 4, 24, DateTimeKind.Utc).AddTicks(4901), new DateTime(2023, 5, 16, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 17, 3, 30, 4, 24, DateTimeKind.Utc).AddTicks(4903), new DateTime(2023, 5, 16, 22, 42, 4, 24, DateTimeKind.Utc).AddTicks(4902) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "5888e361-c81f-4ac9-8e16-961b0eeed0ae", new DateTime(2023, 5, 17, 20, 18, 4, 24, DateTimeKind.Utc).AddTicks(4906), new DateTime(2023, 5, 17, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(4905) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 18, 8, 18, 4, 24, DateTimeKind.Utc).AddTicks(4908), new DateTime(2023, 5, 18, 3, 30, 4, 24, DateTimeKind.Utc).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 18, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(4911), new DateTime(2023, 5, 17, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(4910) });

            migrationBuilder.InsertData(
                table: "Upvotes",
                columns: new[] { "ReportID", "UserId", "ReportViewModelId" },
                values: new object[,]
                {
                    { 4, "555e52b8-22db-4c15-a037-107016c7f827", null },
                    { 7, "555e52b8-22db-4c15-a037-107016c7f827", null },
                    { 8, "555e52b8-22db-4c15-a037-107016c7f827", null },
                    { 9, "555e52b8-22db-4c15-a037-107016c7f827", null },
                    { 10, "555e52b8-22db-4c15-a037-107016c7f827", null },
                    { 11, "555e52b8-22db-4c15-a037-107016c7f827", null },
                    { 3, "5888e361-c81f-4ac9-8e16-961b0eeed0ae", null },
                    { 5, "5888e361-c81f-4ac9-8e16-961b0eeed0ae", null },
                    { 6, "5888e361-c81f-4ac9-8e16-961b0eeed0ae", null },
                    { 7, "5888e361-c81f-4ac9-8e16-961b0eeed0ae", null },
                    { 9, "5888e361-c81f-4ac9-8e16-961b0eeed0ae", null },
                    { 10, "5888e361-c81f-4ac9-8e16-961b0eeed0ae", null },
                    { 11, "5888e361-c81f-4ac9-8e16-961b0eeed0ae", null },
                    { 12, "5888e361-c81f-4ac9-8e16-961b0eeed0ae", null },
                    { 1, "9059e247-2854-40bd-af2b-76088f8dd4e6", null },
                    { 2, "9059e247-2854-40bd-af2b-76088f8dd4e6", null },
                    { 3, "9059e247-2854-40bd-af2b-76088f8dd4e6", null },
                    { 4, "9059e247-2854-40bd-af2b-76088f8dd4e6", null },
                    { 5, "9059e247-2854-40bd-af2b-76088f8dd4e6", null },
                    { 7, "9059e247-2854-40bd-af2b-76088f8dd4e6", null },
                    { 8, "9059e247-2854-40bd-af2b-76088f8dd4e6", null },
                    { 9, "9059e247-2854-40bd-af2b-76088f8dd4e6", null },
                    { 10, "9059e247-2854-40bd-af2b-76088f8dd4e6", null },
                    { 11, "9059e247-2854-40bd-af2b-76088f8dd4e6", null },
                    { 12, "9059e247-2854-40bd-af2b-76088f8dd4e6", null },
                    { 1, "ad9a20a1-779e-4991-8881-9af6171668a5", null },
                    { 2, "ad9a20a1-779e-4991-8881-9af6171668a5", null },
                    { 4, "ad9a20a1-779e-4991-8881-9af6171668a5", null },
                    { 6, "ad9a20a1-779e-4991-8881-9af6171668a5", null },
                    { 7, "ad9a20a1-779e-4991-8881-9af6171668a5", null },
                    { 8, "ad9a20a1-779e-4991-8881-9af6171668a5", null },
                    { 9, "ad9a20a1-779e-4991-8881-9af6171668a5", null },
                    { 11, "ad9a20a1-779e-4991-8881-9af6171668a5", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 4, "555e52b8-22db-4c15-a037-107016c7f827" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 7, "555e52b8-22db-4c15-a037-107016c7f827" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 8, "555e52b8-22db-4c15-a037-107016c7f827" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 9, "555e52b8-22db-4c15-a037-107016c7f827" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 10, "555e52b8-22db-4c15-a037-107016c7f827" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 11, "555e52b8-22db-4c15-a037-107016c7f827" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 3, "5888e361-c81f-4ac9-8e16-961b0eeed0ae" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 5, "5888e361-c81f-4ac9-8e16-961b0eeed0ae" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 6, "5888e361-c81f-4ac9-8e16-961b0eeed0ae" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 7, "5888e361-c81f-4ac9-8e16-961b0eeed0ae" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 9, "5888e361-c81f-4ac9-8e16-961b0eeed0ae" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 10, "5888e361-c81f-4ac9-8e16-961b0eeed0ae" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 11, "5888e361-c81f-4ac9-8e16-961b0eeed0ae" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 12, "5888e361-c81f-4ac9-8e16-961b0eeed0ae" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 1, "9059e247-2854-40bd-af2b-76088f8dd4e6" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 2, "9059e247-2854-40bd-af2b-76088f8dd4e6" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 3, "9059e247-2854-40bd-af2b-76088f8dd4e6" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 4, "9059e247-2854-40bd-af2b-76088f8dd4e6" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 5, "9059e247-2854-40bd-af2b-76088f8dd4e6" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 7, "9059e247-2854-40bd-af2b-76088f8dd4e6" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 8, "9059e247-2854-40bd-af2b-76088f8dd4e6" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 9, "9059e247-2854-40bd-af2b-76088f8dd4e6" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 10, "9059e247-2854-40bd-af2b-76088f8dd4e6" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 11, "9059e247-2854-40bd-af2b-76088f8dd4e6" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 12, "9059e247-2854-40bd-af2b-76088f8dd4e6" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 1, "ad9a20a1-779e-4991-8881-9af6171668a5" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 2, "ad9a20a1-779e-4991-8881-9af6171668a5" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 4, "ad9a20a1-779e-4991-8881-9af6171668a5" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 6, "ad9a20a1-779e-4991-8881-9af6171668a5" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 7, "ad9a20a1-779e-4991-8881-9af6171668a5" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 8, "ad9a20a1-779e-4991-8881-9af6171668a5" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 9, "ad9a20a1-779e-4991-8881-9af6171668a5" });

            migrationBuilder.DeleteData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 11, "ad9a20a1-779e-4991-8881-9af6171668a5" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a525ac-d446-4c8c-983c-047afdffed13",
                column: "ConcurrencyStamp",
                value: "df0d80eb-b0cb-4cf9-8b00-d65838b36096");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca95d41-370a-4218-b0aa-8502494448fb",
                column: "ConcurrencyStamp",
                value: "1feb194d-2c23-4205-9d30-9fa9a599f7fd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46ad767f-432d-4670-9163-fe77ee72c294", "AQAAAAEAACcQAAAAEO85TAzyj8Yn1olCveaQYyi+aD96UcOGYlzmsMRoiy0UnSIeSWmfQouGJgKep3uq2Q==", "f94f13e4-2640-4c78-8965-59bd28426824" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd0c992d-e4b3-406c-a2f9-7757433f89c6", "AQAAAAEAACcQAAAAEDuhwbetdyOfZpIscOM47j3gxqRzQLidbsDS7I/YrQqoIHZnSPO60q4rKP96Y9WpaQ==", "a5b8ac06-1221-480d-b981-356182ca50ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c615f001-cb88-4c1b-af9c-2e63996ed40e", "AQAAAAEAACcQAAAAELyXNThJ26bYsg8a00kXmL4XGgQj2UIG3EejmPmpmDSWPn/reWEalg2AGgQ6mec3Sg==", "9c93ad05-fc42-40dc-8933-1737ef47d7b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c5f9c41-7bcf-4d21-87e6-47d602c7948f", "AQAAAAEAACcQAAAAEBbxAsAwaKFI/gZZW6SAjlgZVZO5Uffa+M63kqOe2CjzY16tIdXrB6/gpc7MG9IJkA==", "bf278899-1a0e-46b0-9edc-ded267ebf564" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fbe9699-21d8-4835-82a2-6c84f5a2373b", "AQAAAAEAACcQAAAAEDFWB5RsiVHEy9/OrTY3chhQX0UFMDjPJhZZOGCY2jGGh/F0ocpgpPT9WkEqyZ3y7w==", "cc54b66c-70ec-41d2-8abb-6d0de3e0532b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c608a211-75da-4a2e-be27-852074847b0b", "AQAAAAEAACcQAAAAECdhLa5Jquu8vQbxcJYwT+9Zy1VbSZnBqVMT5wXax9ONbwGG4XMLFvnvuyBbpk87Qg==", "14f07c36-d0f5-475b-b9ea-83d6d5abf2f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2765bba9-9548-45b9-8e85-88d8d4f8fa5e", "AQAAAAEAACcQAAAAEL6I1cEWjUDKWbcJIRe93Q5Rvxo9pP4JbK84yMyvCQ6fb5KDcJEp2us899088mvsKA==", "fb9a64c0-31aa-49e7-b6b7-5092ec8d5c03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9ac514b-e8bd-4a67-9989-ab07f443739f", "AQAAAAEAACcQAAAAEAgIISXMPyIgsBQg+yylze47ldeRqCq0b4dT/F2lAJiM8FhUMEVWZ9i1/wE0BjS3hg==", "c988290c-1042-4404-900e-3bf86832d394" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c447afe6-e53d-4f03-8f0d-745421fcd09a", "AQAAAAEAACcQAAAAEMlv2qrGg1nrwO0T8qah9hd949VOHMytVvOisqDn1OCSMn2aZu2bpfVOUSCZ7Nb1VA==", "3ee3927c-a606-4977-ae7f-3988c7a976c3" });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 18, 14, 31, 22, 311, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 18, 14, 31, 22, 311, DateTimeKind.Utc).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfAction", "InvestigatorId" },
                values: new object[] { new DateTime(2023, 5, 18, 14, 31, 22, 311, DateTimeKind.Utc).AddTicks(914), "afdb900f-344d-4bf7-9239-34a2ea4336be" });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 18, 14, 31, 22, 311, DateTimeKind.Utc).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 18, 14, 31, 22, 311, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfAction", "InvestigatorId" },
                values: new object[] { new DateTime(2023, 5, 18, 14, 31, 22, 311, DateTimeKind.Utc).AddTicks(973), "afdb900f-344d-4bf7-9239-34a2ea4336be" });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 18, 14, 31, 22, 311, DateTimeKind.Utc).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfAction", "InvestigatorId" },
                values: new object[] { new DateTime(2023, 5, 18, 14, 31, 22, 311, DateTimeKind.Utc).AddTicks(975), "afdb900f-344d-4bf7-9239-34a2ea4336be" });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 18, 14, 31, 22, 311, DateTimeKind.Utc).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 31, 22, 311, DateTimeKind.Utc).AddTicks(854), new DateTime(2023, 4, 28, 14, 31, 22, 311, DateTimeKind.Utc).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 55, 22, 311, DateTimeKind.Utc).AddTicks(859), new DateTime(2023, 5, 6, 14, 31, 22, 311, DateTimeKind.Utc).AddTicks(857) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 7, 15, 43, 22, 311, DateTimeKind.Utc).AddTicks(861), new DateTime(2023, 5, 7, 14, 31, 22, 311, DateTimeKind.Utc).AddTicks(861) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 13, 16, 55, 22, 311, DateTimeKind.Utc).AddTicks(863), new DateTime(2023, 5, 13, 14, 31, 22, 311, DateTimeKind.Utc).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "afdb900f-344d-4bf7-9239-34a2e", new DateTime(2023, 5, 16, 16, 55, 22, 311, DateTimeKind.Utc).AddTicks(865), new DateTime(2023, 5, 16, 14, 31, 22, 311, DateTimeKind.Utc).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "afdb900f-344d-4bf7-9239-34a2e", new DateTime(2023, 5, 15, 14, 31, 22, 311, DateTimeKind.Utc).AddTicks(867), new DateTime(2023, 5, 15, 2, 31, 22, 311, DateTimeKind.Utc).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 16, 4, 55, 22, 311, DateTimeKind.Utc).AddTicks(870), new DateTime(2023, 5, 16, 2, 31, 22, 311, DateTimeKind.Utc).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 16, 16, 55, 22, 311, DateTimeKind.Utc).AddTicks(872), new DateTime(2023, 5, 16, 14, 31, 22, 311, DateTimeKind.Utc).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 17, 2, 31, 22, 311, DateTimeKind.Utc).AddTicks(874), new DateTime(2023, 5, 16, 21, 43, 22, 311, DateTimeKind.Utc).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedByUserId", "DateOfReport", "DateSpotted" },
                values: new object[] { "afdb900f-344d-4bf7-9239-34a2e", new DateTime(2023, 5, 17, 19, 19, 22, 311, DateTimeKind.Utc).AddTicks(875), new DateTime(2023, 5, 17, 14, 31, 22, 311, DateTimeKind.Utc).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 18, 7, 19, 22, 311, DateTimeKind.Utc).AddTicks(877), new DateTime(2023, 5, 18, 2, 31, 22, 311, DateTimeKind.Utc).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 18, 14, 31, 22, 311, DateTimeKind.Utc).AddTicks(879), new DateTime(2023, 5, 17, 14, 31, 22, 311, DateTimeKind.Utc).AddTicks(878) });
        }
    }
}
