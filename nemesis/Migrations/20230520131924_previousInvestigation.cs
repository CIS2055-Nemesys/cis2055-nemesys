using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class previousInvestigation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PreviousVersionID",
                table: "Investigations",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a525ac-d446-4c8c-983c-047afdffed13",
                column: "ConcurrencyStamp",
                value: "1a49c2a8-971f-47d2-b32e-83ff37a6b94e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca95d41-370a-4218-b0aa-8502494448fb",
                column: "ConcurrencyStamp",
                value: "f513eb88-b292-41a4-9da9-b6b87d83c9f0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99ee6bb2-560f-4f59-ad99-853aaf8a3bb4", "AQAAAAEAACcQAAAAEMj1hVvS1nesdv2Qx+cFcA3Utpv7MmfuWUD9zS9jOfzOd1S1JP1eL2L2r9bL77gohQ==", "321fd25c-3e8d-4122-a4d8-714f50ebc392" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d3aaf9e-dd79-4f74-9a19-bbb145c5e236", "AQAAAAEAACcQAAAAEJviUq83/VhZFC69VTEIM/Htk3q9vB1kvnk5V+Zku/keIvdv1+mgJYXR9ByBsroCwQ==", "6beea2c0-ad46-4bfc-af20-a3cfe35c2a52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bc99afa-86e5-4a52-bc3f-878fa38d3322", "AQAAAAEAACcQAAAAELKaZnXtOwwEHruniduCssspdQ6VuqGWD0XyErjGKt9VR0YCH+jZ40/4D2O+i4l7Dw==", "d34b686f-ba21-4e4e-b88b-d076bdab95a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b37ba28-b453-444c-85ff-9dd10fd83972", "AQAAAAEAACcQAAAAEDPb9E+A2TezCAkQEiG5olQoQMLl1D1+/C7fVwduA8E8b/GC/vW3B1duyiVdjj8lCA==", "7cc2c56b-5ead-48eb-adbe-3c43081a4722" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bcbf07f-efb2-4bbb-888b-1a9872ae4dc6", "AQAAAAEAACcQAAAAEBytNWsr6qhaioLC+3PJOOHA63JBvHXWG/xfQd10fRsALg8f7dv8Szg/9mc866AMqQ==", "4533856d-9059-4456-bffb-4f683fcd5d3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c22d2a8-d45a-4ae7-8917-93d43d1fdf72", "AQAAAAEAACcQAAAAEPUtTSuY8BWWyb2GUqX3hMyHIAbSYFiY69+bTUG/UM20oEEJ4Th6af4KAh6yY5zimA==", "6f406d72-dbff-4b12-a932-f717b4fc1f8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "929f04ac-d0df-4a0f-bb65-236e4c58b897", "AQAAAAEAACcQAAAAEAlKnFlrw5dNsm7JX6g6ZvRpxXE91w91QWuvHAENHm2t62bpJKL9iyRfe7Wbd1p/9A==", "7497d918-00c4-416f-a252-352ff24b7e59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fec381d3-cf4b-47a2-8ce3-9e9809535241", "AQAAAAEAACcQAAAAEAqSzuXT5JZCPapzbU4iPEjswqCX++zNX/RObbzG3k/CQ/005G9pFWfBtBNwu/6EmA==", "0e598330-26b9-4621-b118-c9735f9e3bf2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e970e86-ed73-4d5a-9c10-7b8af1f11a4c", "AQAAAAEAACcQAAAAEKUsQufcWs0LrImG7gXl49lG8Dfg2Aj+U1EWGUiL92FHcXB6rxboFW0XXQaCHslAYQ==", "27731bb3-c029-471d-9aa4-1d547ea46ec6" });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfAction", "PreviousVersionID" },
                values: new object[] { new DateTime(2023, 5, 20, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(13), null });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfAction", "PreviousVersionID" },
                values: new object[] { new DateTime(2023, 5, 20, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(15), null });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfAction", "PreviousVersionID" },
                values: new object[] { new DateTime(2023, 5, 20, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(16), null });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfAction", "PreviousVersionID" },
                values: new object[] { new DateTime(2023, 5, 20, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(17), null });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfAction", "PreviousVersionID" },
                values: new object[] { new DateTime(2023, 5, 20, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(18), null });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfAction", "PreviousVersionID" },
                values: new object[] { new DateTime(2023, 5, 20, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(19), null });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfAction", "PreviousVersionID" },
                values: new object[] { new DateTime(2023, 5, 20, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(19), null });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfAction", "PreviousVersionID" },
                values: new object[] { new DateTime(2023, 5, 20, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(20), null });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfAction", "PreviousVersionID" },
                values: new object[] { new DateTime(2023, 5, 20, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(21), null });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 2, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(83), new DateTime(2023, 4, 30, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 43, 24, 215, DateTimeKind.Utc).AddTicks(87), new DateTime(2023, 5, 8, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 31, 24, 215, DateTimeKind.Utc).AddTicks(89), new DateTime(2023, 5, 9, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 43, 24, 215, DateTimeKind.Utc).AddTicks(91), new DateTime(2023, 5, 15, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 18, 15, 43, 24, 215, DateTimeKind.Utc).AddTicks(93), new DateTime(2023, 5, 18, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 17, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(95), new DateTime(2023, 5, 17, 1, 19, 24, 215, DateTimeKind.Utc).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 18, 3, 43, 24, 215, DateTimeKind.Utc).AddTicks(97), new DateTime(2023, 5, 18, 1, 19, 24, 215, DateTimeKind.Utc).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 18, 15, 43, 24, 215, DateTimeKind.Utc).AddTicks(100), new DateTime(2023, 5, 18, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 19, 1, 19, 24, 215, DateTimeKind.Utc).AddTicks(102), new DateTime(2023, 5, 18, 20, 31, 24, 215, DateTimeKind.Utc).AddTicks(101) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 7, 24, 215, DateTimeKind.Utc).AddTicks(104), new DateTime(2023, 5, 19, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 20, 6, 7, 24, 215, DateTimeKind.Utc).AddTicks(106), new DateTime(2023, 5, 20, 1, 19, 24, 215, DateTimeKind.Utc).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 20, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(107), new DateTime(2023, 5, 19, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(107) });

            migrationBuilder.CreateIndex(
                name: "IX_Investigations_PreviousVersionID",
                table: "Investigations",
                column: "PreviousVersionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Investigations_Investigations_PreviousVersionID",
                table: "Investigations",
                column: "PreviousVersionID",
                principalTable: "Investigations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investigations_Investigations_PreviousVersionID",
                table: "Investigations");

            migrationBuilder.DropIndex(
                name: "IX_Investigations_PreviousVersionID",
                table: "Investigations");

            migrationBuilder.DropColumn(
                name: "PreviousVersionID",
                table: "Investigations");

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
        }
    }
}
