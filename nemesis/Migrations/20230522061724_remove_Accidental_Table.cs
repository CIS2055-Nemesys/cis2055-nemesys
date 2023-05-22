using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class remove_Accidental_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Upvotes_ReportViewModel_ReportViewModelId",
                table: "Upvotes");

            migrationBuilder.DropTable(
                name: "ReportViewModel");

            migrationBuilder.DropTable(
                name: "CategoryViewModel");

            migrationBuilder.DropTable(
                name: "StatusViewModel");

            migrationBuilder.DropIndex(
                name: "IX_Upvotes_ReportViewModelId",
                table: "Upvotes");

            migrationBuilder.DropColumn(
                name: "ReportViewModelId",
                table: "Upvotes");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a525ac-d446-4c8c-983c-047afdffed13",
                column: "ConcurrencyStamp",
                value: "51037c9d-72d2-45fe-a3fc-2253d187f1f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca95d41-370a-4218-b0aa-8502494448fb",
                column: "ConcurrencyStamp",
                value: "c8cb68ea-3f9f-43e3-906a-d30e52bc3a83");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75aefe2a-536b-4e9d-bc2b-9cfe8e84209a", "AQAAAAEAACcQAAAAEEu65KsalUU/S+357umSPgudphh/aTrYOyvvZARcvVSEorgU7cmHwjMN+xHNNVDU5g==", "09c59c79-af23-491b-b01a-bfdafabc1d74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d200f368-54ec-4561-bcfe-0afe20d89685", "AQAAAAEAACcQAAAAEMRsRwCWUA0lutdjYi5xKijjt6f098/sESuFkZhCua4PkMlGKk7Sz4oPcdBBU1AIuw==", "e5523ad5-c780-4d23-9329-034e0212c4b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f6bd04f-f354-48c4-a84d-c4f787046fb0", "AQAAAAEAACcQAAAAEKo8md9Y9opG1JiLkcbMiM3BtBHRrD6oOtpcowSEXXxT0AMaZBqpjN1jwfC23hJqlA==", "d8209878-d2d2-44c0-bf0d-f26553af013b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1fcf51e-9d91-46b0-83fa-c43e3a9684ea", "AQAAAAEAACcQAAAAEGDCfmaDjiI4q9u6GrQXD4gXP390QCOQ+e8JNrLgLZ6XPrVO+uSrT7qggpYqBPtG7g==", "1fac24d7-63ba-4b60-992c-2c289f55a6df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99888785-7664-4d7f-a9bc-9c4e8495a3d5", "AQAAAAEAACcQAAAAEAHaRqnQOHBczbSkvPms3KrgqaCoWVERESXet17xvE3+OKBP+V98a5ZMiVuNoQWwcQ==", "8095a050-8e30-49d3-add7-46d0ba729171" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "021c3589-0043-4852-9c15-1742c4d5d7de", "AQAAAAEAACcQAAAAED27YLb/O6LJPgVYaK0RtQ6GuCHUeePFRG79SdtfoNSIszMZrA1GD9nZVSk/uLr6cA==", "de25494b-863f-4b33-8ba0-82075952df7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0501d149-f171-4c9e-8214-8ad324d860fd", "AQAAAAEAACcQAAAAEGrwzRv9OzWGhupDEoll0fSB9GqB25CeC9vFOkfq1HXGFwDAAceHBwXeQrXkUKkD9A==", "6c7dd34f-1dd9-4a58-9e84-ed56617254c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92c7970f-c4ce-436d-b49c-364567b984f4", "AQAAAAEAACcQAAAAEE0HER30NyXDkw1nUWJYU2dMHNRehDAcNyyVrnLL+ZwX3Ho3uGa04ZsvSflqn7+fkA==", "a0083764-278c-43c3-85d8-073a275b66b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea332322-9053-40dd-8dc4-62d91ced55b9", "AQAAAAEAACcQAAAAEBpvS48Yz1k9AajWtJY5A1/PBTbg47Jx7imO+sahm2wv6+ITtJYfigq/g5yUYVzsag==", "ae7e3670-d724-4fbc-9d92-db08a6be1c8c" });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 6, 17, 24, 21, DateTimeKind.Utc).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 6, 17, 24, 21, DateTimeKind.Utc).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 6, 17, 24, 21, DateTimeKind.Utc).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 6, 17, 24, 21, DateTimeKind.Utc).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 6, 17, 24, 21, DateTimeKind.Utc).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 6, 17, 24, 21, DateTimeKind.Utc).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 6, 17, 24, 21, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 6, 17, 24, 21, DateTimeKind.Utc).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 6, 17, 24, 21, DateTimeKind.Utc).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 4, 6, 17, 24, 21, DateTimeKind.Utc).AddTicks(1982), new DateTime(2023, 5, 2, 6, 17, 24, 21, DateTimeKind.Utc).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 10, 8, 41, 24, 21, DateTimeKind.Utc).AddTicks(1988), new DateTime(2023, 5, 10, 6, 17, 24, 21, DateTimeKind.Utc).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 11, 7, 29, 24, 21, DateTimeKind.Utc).AddTicks(1993), new DateTime(2023, 5, 11, 6, 17, 24, 21, DateTimeKind.Utc).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 17, 8, 41, 24, 21, DateTimeKind.Utc).AddTicks(1997), new DateTime(2023, 5, 17, 6, 17, 24, 21, DateTimeKind.Utc).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 20, 8, 41, 24, 21, DateTimeKind.Utc).AddTicks(2001), new DateTime(2023, 5, 20, 6, 17, 24, 21, DateTimeKind.Utc).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 19, 6, 17, 24, 21, DateTimeKind.Utc).AddTicks(2006), new DateTime(2023, 5, 18, 18, 17, 24, 21, DateTimeKind.Utc).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 41, 24, 21, DateTimeKind.Utc).AddTicks(2009), new DateTime(2023, 5, 19, 18, 17, 24, 21, DateTimeKind.Utc).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 20, 8, 41, 24, 21, DateTimeKind.Utc).AddTicks(2013), new DateTime(2023, 5, 20, 6, 17, 24, 21, DateTimeKind.Utc).AddTicks(2012) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 20, 18, 17, 24, 21, DateTimeKind.Utc).AddTicks(2017), new DateTime(2023, 5, 20, 13, 29, 24, 21, DateTimeKind.Utc).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 21, 11, 5, 24, 21, DateTimeKind.Utc).AddTicks(2080), new DateTime(2023, 5, 21, 6, 17, 24, 21, DateTimeKind.Utc).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 21, 23, 5, 24, 21, DateTimeKind.Utc).AddTicks(2085), new DateTime(2023, 5, 21, 18, 17, 24, 21, DateTimeKind.Utc).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 22, 6, 17, 24, 21, DateTimeKind.Utc).AddTicks(2088), new DateTime(2023, 5, 21, 6, 17, 24, 21, DateTimeKind.Utc).AddTicks(2087) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReportViewModelId",
                table: "Upvotes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategoryViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryViewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusViewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    DateOfReport = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateSpotted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvestigationId = table.Column<int>(type: "int", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportViewModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportViewModel_AspNetUsers_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReportViewModel_CategoryViewModel_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CategoryViewModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReportViewModel_StatusViewModel_StatusId",
                        column: x => x.StatusId,
                        principalTable: "StatusViewModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                column: "DateOfAction",
                value: new DateTime(2023, 5, 20, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 20, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 20, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 20, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 20, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 20, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 20, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 20, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 20, 13, 19, 24, 215, DateTimeKind.Utc).AddTicks(21));

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

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 4, "555e52b8-22db-4c15-a037-107016c7f827" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 7, "555e52b8-22db-4c15-a037-107016c7f827" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 8, "555e52b8-22db-4c15-a037-107016c7f827" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 9, "555e52b8-22db-4c15-a037-107016c7f827" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 10, "555e52b8-22db-4c15-a037-107016c7f827" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 11, "555e52b8-22db-4c15-a037-107016c7f827" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 3, "5888e361-c81f-4ac9-8e16-961b0eeed0ae" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 5, "5888e361-c81f-4ac9-8e16-961b0eeed0ae" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 6, "5888e361-c81f-4ac9-8e16-961b0eeed0ae" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 7, "5888e361-c81f-4ac9-8e16-961b0eeed0ae" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 9, "5888e361-c81f-4ac9-8e16-961b0eeed0ae" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 10, "5888e361-c81f-4ac9-8e16-961b0eeed0ae" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 11, "5888e361-c81f-4ac9-8e16-961b0eeed0ae" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 12, "5888e361-c81f-4ac9-8e16-961b0eeed0ae" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 1, "9059e247-2854-40bd-af2b-76088f8dd4e6" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 2, "9059e247-2854-40bd-af2b-76088f8dd4e6" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 3, "9059e247-2854-40bd-af2b-76088f8dd4e6" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 4, "9059e247-2854-40bd-af2b-76088f8dd4e6" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 5, "9059e247-2854-40bd-af2b-76088f8dd4e6" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 7, "9059e247-2854-40bd-af2b-76088f8dd4e6" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 8, "9059e247-2854-40bd-af2b-76088f8dd4e6" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 9, "9059e247-2854-40bd-af2b-76088f8dd4e6" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 10, "9059e247-2854-40bd-af2b-76088f8dd4e6" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 11, "9059e247-2854-40bd-af2b-76088f8dd4e6" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 12, "9059e247-2854-40bd-af2b-76088f8dd4e6" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 1, "ad9a20a1-779e-4991-8881-9af6171668a5" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 2, "ad9a20a1-779e-4991-8881-9af6171668a5" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 4, "ad9a20a1-779e-4991-8881-9af6171668a5" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 6, "ad9a20a1-779e-4991-8881-9af6171668a5" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 7, "ad9a20a1-779e-4991-8881-9af6171668a5" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 8, "ad9a20a1-779e-4991-8881-9af6171668a5" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 9, "ad9a20a1-779e-4991-8881-9af6171668a5" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Upvotes",
                keyColumns: new[] { "ReportID", "UserId" },
                keyValues: new object[] { 11, "ad9a20a1-779e-4991-8881-9af6171668a5" },
                column: "ReportViewModelId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Upvotes_ReportViewModelId",
                table: "Upvotes",
                column: "ReportViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportViewModel_CategoryId",
                table: "ReportViewModel",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportViewModel_CreatedByUserId",
                table: "ReportViewModel",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportViewModel_StatusId",
                table: "ReportViewModel",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Upvotes_ReportViewModel_ReportViewModelId",
                table: "Upvotes",
                column: "ReportViewModelId",
                principalTable: "ReportViewModel",
                principalColumn: "Id");
        }
    }
}
