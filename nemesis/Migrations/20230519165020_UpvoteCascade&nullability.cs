using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class UpvoteCascadenullability : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Upvotes_Reports_ReportID",
                table: "Upvotes");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a525ac-d446-4c8c-983c-047afdffed13",
                column: "ConcurrencyStamp",
                value: "d668029a-ae95-46e2-92ac-008ed00521dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca95d41-370a-4218-b0aa-8502494448fb",
                column: "ConcurrencyStamp",
                value: "28560db0-3c32-459e-9bca-7edbbe47a37a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0ba4153-3225-4641-8d93-714701af7adc", "AQAAAAEAACcQAAAAEHjGGRySnqu/USOUuFXAE2W9i6WJWPGxHYTrSjkkap5JgITfezJXgPY3S1qWWpM7Sw==", "ea842b88-d8f0-4bad-952c-0d50eda68b96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70215502-a6c7-44bf-8114-719b2b9320e8", "AQAAAAEAACcQAAAAEN3YwYeoae1RCMy8C04Ah7OfYGoVZ2shwogLg7H9qUWAkteyP5vBPwC6YYKrbm3YBA==", "0c8ae03c-2277-4a89-8f6e-dfc8bd5de8d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45a13f65-28ad-4b50-81d9-64dea3c2cd9b", "AQAAAAEAACcQAAAAEHxI8VAPKbewDpUBUQkwA8lqqv1JGkG8+QhIKUFiPKyiJ6v6PG2h8O0Hwy8HoZFZUA==", "5462eeb1-7dd3-4113-b4c5-a6a55aac76b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a241cb1-07ec-404c-8f39-f92f130af5a1", "AQAAAAEAACcQAAAAEGnXqxtPCmiNupsyF3/vcT1ggb2D5KknWktuijY9mzXpquJirIqobJ+UqVSE0srNrQ==", "1fc471e9-6fee-4295-86fd-fac6e186652c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c9b51e3-7d5a-480f-b9fe-50343a3d0cc6", "AQAAAAEAACcQAAAAEOD82KUs+slB5MKdFHfgEjP4S5tDExld3YU2Kne2J+Xb7COqN/2uWTpK/VUbS1HVNg==", "caf53fc7-9ad5-49ec-8c37-22172565d1ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28b12955-1452-4fe3-9a79-1fcafa5306ef", "AQAAAAEAACcQAAAAEBljGXw52o1+eUUSOC2U1fW2vFjH8ol7JxiHjL7wqe0Iv4V+mjiZ0KP5dK6mSneKRw==", "6fb14507-b431-45ad-bf18-abc09041bca7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ba53ca2-f4a5-40a3-ab7d-f80bf2002580", "AQAAAAEAACcQAAAAEHffp3O1rs1Jmoa5914Yoq554SZY+8BKcXpWyL5ZBNeqSgQwyeynFM29WmwzaYkzWw==", "ab6cc9c9-6b40-4628-b784-a3625fe8bf4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3dc03fac-481b-4f50-82d3-b0d0dd2adb13", "AQAAAAEAACcQAAAAEGbOFk02CMFMvGth0PtY3p8pMmPxuSrYCDb67s0WxX0fXCLK/XQdVxZvkQgtsY1fIA==", "278692cc-c576-4264-bf5f-69acf82e05ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be06fd2a-7005-4054-adab-1d6b2d44bb1d", "AQAAAAEAACcQAAAAEJr0bv5FDWP8knjBq3XCZ7SvbJkoe/e45iePC8FUkyd0hacfr7XUE5BbaJCu4bDGCQ==", "5b8ceac4-faee-4311-92fb-cf3db1a5f9a6" });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 19, 16, 50, 19, 694, DateTimeKind.Utc).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 19, 16, 50, 19, 694, DateTimeKind.Utc).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 19, 16, 50, 19, 694, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 19, 16, 50, 19, 694, DateTimeKind.Utc).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 19, 16, 50, 19, 694, DateTimeKind.Utc).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 19, 16, 50, 19, 694, DateTimeKind.Utc).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 19, 16, 50, 19, 694, DateTimeKind.Utc).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 19, 16, 50, 19, 694, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 19, 16, 50, 19, 694, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 50, 19, 694, DateTimeKind.Utc).AddTicks(6350), new DateTime(2023, 4, 29, 16, 50, 19, 694, DateTimeKind.Utc).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 7, 19, 14, 19, 694, DateTimeKind.Utc).AddTicks(6355), new DateTime(2023, 5, 7, 16, 50, 19, 694, DateTimeKind.Utc).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 8, 18, 2, 19, 694, DateTimeKind.Utc).AddTicks(6358), new DateTime(2023, 5, 8, 16, 50, 19, 694, DateTimeKind.Utc).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 14, 19, 14, 19, 694, DateTimeKind.Utc).AddTicks(6361), new DateTime(2023, 5, 14, 16, 50, 19, 694, DateTimeKind.Utc).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 17, 19, 14, 19, 694, DateTimeKind.Utc).AddTicks(6364), new DateTime(2023, 5, 17, 16, 50, 19, 694, DateTimeKind.Utc).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 16, 16, 50, 19, 694, DateTimeKind.Utc).AddTicks(6366), new DateTime(2023, 5, 16, 4, 50, 19, 694, DateTimeKind.Utc).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 17, 7, 14, 19, 694, DateTimeKind.Utc).AddTicks(6368), new DateTime(2023, 5, 17, 4, 50, 19, 694, DateTimeKind.Utc).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 17, 19, 14, 19, 694, DateTimeKind.Utc).AddTicks(6371), new DateTime(2023, 5, 17, 16, 50, 19, 694, DateTimeKind.Utc).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 18, 4, 50, 19, 694, DateTimeKind.Utc).AddTicks(6373), new DateTime(2023, 5, 18, 0, 2, 19, 694, DateTimeKind.Utc).AddTicks(6372) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 18, 21, 38, 19, 694, DateTimeKind.Utc).AddTicks(6375), new DateTime(2023, 5, 18, 16, 50, 19, 694, DateTimeKind.Utc).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 38, 19, 694, DateTimeKind.Utc).AddTicks(6377), new DateTime(2023, 5, 19, 4, 50, 19, 694, DateTimeKind.Utc).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 19, 16, 50, 19, 694, DateTimeKind.Utc).AddTicks(6456), new DateTime(2023, 5, 18, 16, 50, 19, 694, DateTimeKind.Utc).AddTicks(6455) });

            migrationBuilder.AddForeignKey(
                name: "FK_Upvotes_Reports_ReportID",
                table: "Upvotes",
                column: "ReportID",
                principalTable: "Reports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Upvotes_Reports_ReportID",
                table: "Upvotes");

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
                column: "DateOfAction",
                value: new DateTime(2023, 5, 18, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(5119));

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
                column: "DateOfAction",
                value: new DateTime(2023, 5, 18, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(5304));

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
                column: "DateOfAction",
                value: new DateTime(2023, 5, 18, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(5308));

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
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 54, 4, 24, DateTimeKind.Utc).AddTicks(4892), new DateTime(2023, 5, 16, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(4895), new DateTime(2023, 5, 15, 3, 30, 4, 24, DateTimeKind.Utc).AddTicks(4895) });

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
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 17, 20, 18, 4, 24, DateTimeKind.Utc).AddTicks(4906), new DateTime(2023, 5, 17, 15, 30, 4, 24, DateTimeKind.Utc).AddTicks(4905) });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Upvotes_Reports_ReportID",
                table: "Upvotes",
                column: "ReportID",
                principalTable: "Reports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
