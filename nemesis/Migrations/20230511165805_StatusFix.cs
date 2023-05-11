using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class StatusFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Status",
                table: "Status");

            migrationBuilder.RenameTable(
                name: "Status",
                newName: "Statuses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses",
                column: "Id");

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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a525ac-d446-4c8c-983c-047afdffed13",
                column: "ConcurrencyStamp",
                value: "c9f6a27f-d5f3-4b60-810b-ad8f0703765d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca95d41-370a-4218-b0aa-8502494448fb",
                column: "ConcurrencyStamp",
                value: "42d4277e-bab9-47f7-8ffc-925aae0bc638");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "731c168e-cd3b-4987-abf8-7a2fbe407379", "50679d32-74f8-4282-b254-7416f3258b9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5545c50a-9497-41c7-91a3-2b485145cb1e", "804a7112-5704-4f7a-9b88-d682f1af813b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b0c76a9-20fe-4180-baa1-c4201e76f881", "4edabc5b-4985-4eb9-87a8-200bbc06b6f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "952eeb6b-355a-4abe-9a04-ca92ed295663", "1ac02336-400c-4807-af95-f99b23856c6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9de278b4-d7b8-4168-ac4c-365fed270f00", "28787b80-9b1f-4d59-93a9-737e17a06fda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3342900e-6dcd-42e7-9761-bb05b0810177", "d5b3f359-9909-4946-9fa1-f8c807d91ba8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2c51b933-1dd5-4a4a-a645-f57bc0ecb738", "22e18d8e-b7da-4a04-9707-674ec8dc7508" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "14d900fa-ed2c-4e0f-a84b-07d36514a02c", "a7b29f74-42f1-4165-bdbd-7ad4b8de9ae0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bcc31fd5-c4e8-4720-9887-2ad2b767f8ff", "3a103891-4643-45de-934f-97c25f4bd81e" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 23, 16, 58, 5, 192, DateTimeKind.Utc).AddTicks(9227), new DateTime(2023, 4, 21, 16, 58, 5, 192, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 29, 19, 22, 5, 192, DateTimeKind.Utc).AddTicks(9231), new DateTime(2023, 4, 29, 16, 58, 5, 192, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 10, 5, 192, DateTimeKind.Utc).AddTicks(9233), new DateTime(2023, 4, 30, 16, 58, 5, 192, DateTimeKind.Utc).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 6, 19, 22, 5, 192, DateTimeKind.Utc).AddTicks(9235), new DateTime(2023, 5, 6, 16, 58, 5, 192, DateTimeKind.Utc).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 9, 19, 22, 5, 192, DateTimeKind.Utc).AddTicks(9237), new DateTime(2023, 5, 9, 16, 58, 5, 192, DateTimeKind.Utc).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 8, 16, 58, 5, 192, DateTimeKind.Utc).AddTicks(9238), new DateTime(2023, 5, 8, 4, 58, 5, 192, DateTimeKind.Utc).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 22, 5, 192, DateTimeKind.Utc).AddTicks(9240), new DateTime(2023, 5, 9, 4, 58, 5, 192, DateTimeKind.Utc).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 9, 19, 22, 5, 192, DateTimeKind.Utc).AddTicks(9242), new DateTime(2023, 5, 9, 16, 58, 5, 192, DateTimeKind.Utc).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 10, 4, 58, 5, 192, DateTimeKind.Utc).AddTicks(9244), new DateTime(2023, 5, 10, 0, 10, 5, 192, DateTimeKind.Utc).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 46, 5, 192, DateTimeKind.Utc).AddTicks(9245), new DateTime(2023, 5, 10, 16, 58, 5, 192, DateTimeKind.Utc).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 11, 9, 46, 5, 192, DateTimeKind.Utc).AddTicks(9247), new DateTime(2023, 5, 11, 4, 58, 5, 192, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 58, 5, 192, DateTimeKind.Utc).AddTicks(9248), new DateTime(2023, 5, 10, 16, 58, 5, 192, DateTimeKind.Utc).AddTicks(9248) });

            migrationBuilder.CreateIndex(
                name: "IX_ReportViewModel_StatusId",
                table: "ReportViewModel",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_StatusId",
                table: "Reports",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Statuses_StatusId",
                table: "Reports",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReportViewModel_StatusViewModel_StatusId",
                table: "ReportViewModel",
                column: "StatusId",
                principalTable: "StatusViewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Statuses_StatusId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportViewModel_StatusViewModel_StatusId",
                table: "ReportViewModel");

            migrationBuilder.DropTable(
                name: "StatusViewModel");

            migrationBuilder.DropIndex(
                name: "IX_ReportViewModel_StatusId",
                table: "ReportViewModel");

            migrationBuilder.DropIndex(
                name: "IX_Reports_StatusId",
                table: "Reports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses");

            migrationBuilder.RenameTable(
                name: "Statuses",
                newName: "Status");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Status",
                table: "Status",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a525ac-d446-4c8c-983c-047afdffed13",
                column: "ConcurrencyStamp",
                value: "2e7d8e26-78c2-4261-af8e-b507b61f0ac2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca95d41-370a-4218-b0aa-8502494448fb",
                column: "ConcurrencyStamp",
                value: "2f45cf87-60e1-49a9-87d5-e0632eb5c51b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "82e0fedf-c456-48d2-87a7-0142db5f6ef9", "58075920-cbdf-4363-b6cd-a0e13130c894" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "90dfab77-c4db-4cc6-8be3-24e47b6a19a0", "c8901578-23e7-455e-95b8-eba36b7f6d13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f487c329-74a0-47ae-a7fb-ca9155fdf817", "13b52c96-85a5-4fc5-a9aa-78f80154cb10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c39a664d-e38e-436b-859f-5d41c3330b9f", "b583d8d6-0c5f-44b5-82ef-085da57ca2fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cbb3904a-ed11-4c5f-aa90-f1216df48723", "1b63b3f6-aa49-473d-8a78-41173d7cd787" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7f9b9f92-cb17-4281-81d2-92060c58abb8", "46fe7687-8839-4454-b135-2f13ba77269b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "111bb32e-5ed3-4bb7-b2c2-f71993a3ee20", "6c036f59-7870-4b66-b243-fef58c3d7c5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5ec16ec0-21e7-4def-a0f4-cfe0f8bff626", "7289718b-4d09-46ad-a68c-f1656d7b03f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c3cbcd9b-46a0-4b87-b057-8d74d3b6f570", "97f04796-2602-4601-a849-0025a4bd1cb2" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 23, 16, 38, 32, 67, DateTimeKind.Utc).AddTicks(4024), new DateTime(2023, 4, 21, 16, 38, 32, 67, DateTimeKind.Utc).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 29, 19, 2, 32, 67, DateTimeKind.Utc).AddTicks(4028), new DateTime(2023, 4, 29, 16, 38, 32, 67, DateTimeKind.Utc).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 30, 17, 50, 32, 67, DateTimeKind.Utc).AddTicks(4031), new DateTime(2023, 4, 30, 16, 38, 32, 67, DateTimeKind.Utc).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 6, 19, 2, 32, 67, DateTimeKind.Utc).AddTicks(4033), new DateTime(2023, 5, 6, 16, 38, 32, 67, DateTimeKind.Utc).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 9, 19, 2, 32, 67, DateTimeKind.Utc).AddTicks(4036), new DateTime(2023, 5, 9, 16, 38, 32, 67, DateTimeKind.Utc).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 8, 16, 38, 32, 67, DateTimeKind.Utc).AddTicks(4038), new DateTime(2023, 5, 8, 4, 38, 32, 67, DateTimeKind.Utc).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 2, 32, 67, DateTimeKind.Utc).AddTicks(4040), new DateTime(2023, 5, 9, 4, 38, 32, 67, DateTimeKind.Utc).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 9, 19, 2, 32, 67, DateTimeKind.Utc).AddTicks(4042), new DateTime(2023, 5, 9, 16, 38, 32, 67, DateTimeKind.Utc).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 10, 4, 38, 32, 67, DateTimeKind.Utc).AddTicks(4046), new DateTime(2023, 5, 9, 23, 50, 32, 67, DateTimeKind.Utc).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 26, 32, 67, DateTimeKind.Utc).AddTicks(4048), new DateTime(2023, 5, 10, 16, 38, 32, 67, DateTimeKind.Utc).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 11, 9, 26, 32, 67, DateTimeKind.Utc).AddTicks(4113), new DateTime(2023, 5, 11, 4, 38, 32, 67, DateTimeKind.Utc).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 38, 32, 67, DateTimeKind.Utc).AddTicks(4116), new DateTime(2023, 5, 10, 16, 38, 32, 67, DateTimeKind.Utc).AddTicks(4115) });
        }
    }
}
