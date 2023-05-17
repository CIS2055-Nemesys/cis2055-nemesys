using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class Upvotes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Upvotes",
                table: "ReportViewModel");

            migrationBuilder.DropColumn(
                name: "Upvotes",
                table: "Reports");

            migrationBuilder.CreateTable(
                name: "Upvotes",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReportID = table.Column<int>(type: "int", nullable: false),
                    ReportViewModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Upvotes", x => new { x.UserId, x.ReportID });
                    table.ForeignKey(
                        name: "FK_Upvotes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Upvotes_ReportViewModel_ReportViewModelId",
                        column: x => x.ReportViewModelId,
                        principalTable: "ReportViewModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Upvotes_Reports_ReportID",
                        column: x => x.ReportID,
                        principalTable: "Reports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a525ac-d446-4c8c-983c-047afdffed13",
                column: "ConcurrencyStamp",
                value: "8b6b3fd3-df4b-4588-8a49-1decb485511c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca95d41-370a-4218-b0aa-8502494448fb",
                column: "ConcurrencyStamp",
                value: "2b11e6c9-ab40-4afe-ab77-8367cb35fa1a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "685c3342-0c5a-40ad-bb54-d44cc96690f9", "AQAAAAEAACcQAAAAECwZQgUstm6fd33G9vdZVZC1XnvAnos4xBJWjfcL+xYx4aKbJ8CmhfMwnsPDVxeQDg==", "1d15e3e9-a0a7-434e-a3c6-e4d8a0aa629b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d355f2e8-d1d2-4c38-8af4-1c4738c5cbc9", "AQAAAAEAACcQAAAAEBAWmLZYTyMb/4Roxw3iCyjOtRSUtV9IOF54Racfgf+JpgjZSC7FS/GIDC7oBjpygQ==", "e87ae9d0-f551-45f4-8e48-a3774fd1cefd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7537c3c8-b8c4-4a6d-afc6-8d73f8ff9809", "AQAAAAEAACcQAAAAEACPhgKC37f6yGri2zM9wFpYRkZlxvI5Vc+I2IXQSU2uc3c7ZgVZ8fAbsa2Khn3OKw==", "0488d535-8c41-42c3-9e9e-66dc189da283" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b36804fc-a77d-4312-993c-c682050f5ed2", "AQAAAAEAACcQAAAAEAqhIyJZDEQnJkbZur+GRXbuBlAoajY998NVfOA4ZCqkrJlQLVJ1gFpJ8VfhQZNC1w==", "d5565884-2390-4bfd-8a08-996009036aa1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "471fbf6d-efd4-4a8d-94e3-1ba7f3a6165b", "AQAAAAEAACcQAAAAEDYgKNoXv6MNAsUaJLVALYn8X73N0naS4G8OOReOWSRk9GZZ7+rLePx5bRhnQR26tw==", "5681970f-9a10-4aa0-a47c-bd8d21ec9da4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d153934-ab73-41e2-a7a5-d4dc9ed074df", "AQAAAAEAACcQAAAAEAwrpCd1zRaOoo4ZMw7vc2rwqrxSHFSD6C1ITgp5NX+ct0IWziFKxF+1d5RGnfhc+w==", "535f8f62-4366-4d03-8000-d45b59e7077e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08a720ce-9b9b-407b-9a24-904c2f558f57", "AQAAAAEAACcQAAAAECXpwH65PgikAoa50ZmPMWA4BR4WUlBkn3YcvK4GbvQu5/K/rdmJs+ah55JDQqhv0Q==", "64851a26-b4ce-4326-83ec-f8fe04ddc075" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3a26b59-9959-4c9e-a9ff-6c8197724631", "AQAAAAEAACcQAAAAECvOUJMtpKuNmxlOZ3QyE/ysfbsdqSkjlh/KCcxvYu/6ukegus9uq3UNxccmc126PQ==", "42a2bba1-5b7e-43fe-bc72-24370ca476ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35186923-e72f-4485-bb80-4bf410c11f40", "AQAAAAEAACcQAAAAEBIuAWGIPvFWunlSE1nHx/HgBt7NhugRPul36/nHmFw6jPJo/Y+ymUa1m5vYgsiefg==", "0b933a59-ce08-42bc-b88f-569450863b44" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 29, 6, 41, 22, 982, DateTimeKind.Utc).AddTicks(6633), new DateTime(2023, 4, 27, 6, 41, 22, 982, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 5, 9, 5, 22, 982, DateTimeKind.Utc).AddTicks(6638), new DateTime(2023, 5, 5, 6, 41, 22, 982, DateTimeKind.Utc).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 6, 7, 53, 22, 982, DateTimeKind.Utc).AddTicks(6640), new DateTime(2023, 5, 6, 6, 41, 22, 982, DateTimeKind.Utc).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 12, 9, 5, 22, 982, DateTimeKind.Utc).AddTicks(6642), new DateTime(2023, 5, 12, 6, 41, 22, 982, DateTimeKind.Utc).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 15, 9, 5, 22, 982, DateTimeKind.Utc).AddTicks(6644), new DateTime(2023, 5, 15, 6, 41, 22, 982, DateTimeKind.Utc).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 14, 6, 41, 22, 982, DateTimeKind.Utc).AddTicks(6646), new DateTime(2023, 5, 13, 18, 41, 22, 982, DateTimeKind.Utc).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted", "ImageUrl" },
                values: new object[] { new DateTime(2023, 5, 14, 21, 5, 22, 982, DateTimeKind.Utc).AddTicks(6647), new DateTime(2023, 5, 14, 18, 41, 22, 982, DateTimeKind.Utc).AddTicks(6647), "/images/GiantRodent.png" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 15, 9, 5, 22, 982, DateTimeKind.Utc).AddTicks(6649), new DateTime(2023, 5, 15, 6, 41, 22, 982, DateTimeKind.Utc).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 41, 22, 982, DateTimeKind.Utc).AddTicks(6650), new DateTime(2023, 5, 15, 13, 53, 22, 982, DateTimeKind.Utc).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 29, 22, 982, DateTimeKind.Utc).AddTicks(6652), new DateTime(2023, 5, 16, 6, 41, 22, 982, DateTimeKind.Utc).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 16, 23, 29, 22, 982, DateTimeKind.Utc).AddTicks(6655), new DateTime(2023, 5, 16, 18, 41, 22, 982, DateTimeKind.Utc).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 17, 6, 41, 22, 982, DateTimeKind.Utc).AddTicks(6657), new DateTime(2023, 5, 16, 6, 41, 22, 982, DateTimeKind.Utc).AddTicks(6656) });

            migrationBuilder.CreateIndex(
                name: "IX_Upvotes_ReportID",
                table: "Upvotes",
                column: "ReportID");

            migrationBuilder.CreateIndex(
                name: "IX_Upvotes_ReportViewModelId",
                table: "Upvotes",
                column: "ReportViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Upvotes_UserId_ReportID",
                table: "Upvotes",
                columns: new[] { "UserId", "ReportID" },
                unique: true)
                .Annotation("SqlServer:Clustered", false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Upvotes");

            migrationBuilder.AddColumn<int>(
                name: "Upvotes",
                table: "ReportViewModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Upvotes",
                table: "Reports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a525ac-d446-4c8c-983c-047afdffed13",
                column: "ConcurrencyStamp",
                value: "6812ec62-2a55-434c-b19b-9a93034abb2f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca95d41-370a-4218-b0aa-8502494448fb",
                column: "ConcurrencyStamp",
                value: "16e41272-29ce-4708-a8c4-177bed29cb62");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c628641-733f-4505-86f3-144d2df5253b", "AQAAAAEAACcQAAAAEAOsgF5SYp6GEeZr8+JDmJfQlyx99Cuc23fU4ectwzXxL8+8Mp5uR5FbFP5KzlJybw==", "32acb2e0-37dd-4e83-894f-72c2d68db79c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6f7e944-7b07-4b6d-b5ad-a60151102d8c", "AQAAAAEAACcQAAAAEHE5g0qhkfi/6HuzdafGnBbe+1I8Ycc7b+R3HqD4HP5109Sj+dPV8GBZLA2QGhrvzA==", "4c90cc73-abd0-48a4-b321-604e7d7aa218" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40c4cb9c-5577-478a-acd6-3d778f145882", "AQAAAAEAACcQAAAAEKEGFN2OtXLAKo2+Haj8z5AZTvKnvZks5/HQ1SYedr+Byx+lasBDzKpmTp5+Vc3eEg==", "b1a31c55-94bf-4d80-aa99-1d7936baaf91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7b029d2-4f6c-4319-b558-ce55dbe12a65", "AQAAAAEAACcQAAAAELadbDzimjENQgRlOpEywW1rEabsEZWHoY+vvop0sfx0yy586o7K/Ksz3pBaxGYrnw==", "74bfd693-7b39-445b-a446-66b3d579950a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "359646cc-c88d-4439-b1e9-e04dc3381881", "AQAAAAEAACcQAAAAEGfQ3oznYKhrzMvxhJmyUCKC241at2FyAXEaVx/2kcQKNQIRI21h2YwQJWRt2SSWSQ==", "ad9a82ef-a3c8-4c9a-b77c-1187959e366c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5026082c-7eb5-4f94-9185-6c78a41e93e9", "AQAAAAEAACcQAAAAEOlvb/fcIMx+O4IpbmUzeZBY7hRRBfv+ZBbrTRUtaxckdqTHSJCYpJw3c/wI1nCSMQ==", "047e34e7-2113-46cc-baa6-92585d4ca9af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "452a5faf-5783-4da0-9633-5a688e005488", "AQAAAAEAACcQAAAAEIx6UjWT0pn5RvYQ4FbXAIEKZIhZWY+sugKK1L7H2JLAA5lz5smEVy9xeiV9YLw5lA==", "fd06951b-793b-4899-bf8b-c0454d4a80c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee8dcdff-cd83-4218-984e-f0ee739a25c0", "AQAAAAEAACcQAAAAEO8GNg2hBBx0NePfLmnWcAHQymjadyI49WE2UmCz76mWg0Tz0pI+4Z1HudEmMWSuIw==", "a652dcb9-cd2a-4c8d-b467-f4d8f0af0afb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d9d7e3a-b905-475e-90c2-9f644fad98f2", "AQAAAAEAACcQAAAAENPFW2q21zmtINeSatCM1eO9B81ngtHqc2xVfCUscXH46m4ayd0YSJ+g3KfR/QAPCQ==", "729fb519-fd53-4c4f-a62a-7642c3643164" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted", "Upvotes" },
                values: new object[] { new DateTime(2023, 4, 26, 8, 57, 59, 298, DateTimeKind.Utc).AddTicks(9151), new DateTime(2023, 4, 24, 8, 57, 59, 298, DateTimeKind.Utc).AddTicks(9146), 178 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted", "Upvotes" },
                values: new object[] { new DateTime(2023, 5, 2, 11, 21, 59, 298, DateTimeKind.Utc).AddTicks(9154), new DateTime(2023, 5, 2, 8, 57, 59, 298, DateTimeKind.Utc).AddTicks(9154), 43 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted", "Upvotes" },
                values: new object[] { new DateTime(2023, 5, 3, 10, 9, 59, 298, DateTimeKind.Utc).AddTicks(9156), new DateTime(2023, 5, 3, 8, 57, 59, 298, DateTimeKind.Utc).AddTicks(9155), 482 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted", "Upvotes" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 21, 59, 298, DateTimeKind.Utc).AddTicks(9158), new DateTime(2023, 5, 9, 8, 57, 59, 298, DateTimeKind.Utc).AddTicks(9157), 25 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted", "Upvotes" },
                values: new object[] { new DateTime(2023, 5, 12, 11, 21, 59, 298, DateTimeKind.Utc).AddTicks(9160), new DateTime(2023, 5, 12, 8, 57, 59, 298, DateTimeKind.Utc).AddTicks(9159), 782 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted", "Upvotes" },
                values: new object[] { new DateTime(2023, 5, 11, 8, 57, 59, 298, DateTimeKind.Utc).AddTicks(9161), new DateTime(2023, 5, 10, 20, 57, 59, 298, DateTimeKind.Utc).AddTicks(9161), 777 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted", "ImageUrl", "Upvotes" },
                values: new object[] { new DateTime(2023, 5, 11, 23, 21, 59, 298, DateTimeKind.Utc).AddTicks(9163), new DateTime(2023, 5, 11, 20, 57, 59, 298, DateTimeKind.Utc).AddTicks(9163), "/images/GiantRodent.jpg", 246 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted", "Upvotes" },
                values: new object[] { new DateTime(2023, 5, 12, 11, 21, 59, 298, DateTimeKind.Utc).AddTicks(9165), new DateTime(2023, 5, 12, 8, 57, 59, 298, DateTimeKind.Utc).AddTicks(9165), 52 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted", "Upvotes" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 57, 59, 298, DateTimeKind.Utc).AddTicks(9167), new DateTime(2023, 5, 12, 16, 9, 59, 298, DateTimeKind.Utc).AddTicks(9167), 120 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted", "Upvotes" },
                values: new object[] { new DateTime(2023, 5, 13, 13, 45, 59, 298, DateTimeKind.Utc).AddTicks(9169), new DateTime(2023, 5, 13, 8, 57, 59, 298, DateTimeKind.Utc).AddTicks(9169), 345 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted", "Upvotes" },
                values: new object[] { new DateTime(2023, 5, 14, 1, 45, 59, 298, DateTimeKind.Utc).AddTicks(9171), new DateTime(2023, 5, 13, 20, 57, 59, 298, DateTimeKind.Utc).AddTicks(9171), 498 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted", "Upvotes" },
                values: new object[] { new DateTime(2023, 5, 14, 8, 57, 59, 298, DateTimeKind.Utc).AddTicks(9173), new DateTime(2023, 5, 13, 8, 57, 59, 298, DateTimeKind.Utc).AddTicks(9172), 2000 });
        }
    }
}
