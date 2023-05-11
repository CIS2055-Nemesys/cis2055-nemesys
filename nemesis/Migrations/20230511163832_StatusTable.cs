using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class StatusTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "ReportViewModel");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Reports");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "ReportViewModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Reports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

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
                columns: new[] { "DateOfReport", "DateSpotted", "StatusId" },
                values: new object[] { new DateTime(2023, 4, 23, 16, 38, 32, 67, DateTimeKind.Utc).AddTicks(4024), new DateTime(2023, 4, 21, 16, 38, 32, 67, DateTimeKind.Utc).AddTicks(4012), 1 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted", "StatusId" },
                values: new object[] { new DateTime(2023, 4, 29, 19, 2, 32, 67, DateTimeKind.Utc).AddTicks(4028), new DateTime(2023, 4, 29, 16, 38, 32, 67, DateTimeKind.Utc).AddTicks(4028), 1 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted", "StatusId" },
                values: new object[] { new DateTime(2023, 4, 30, 17, 50, 32, 67, DateTimeKind.Utc).AddTicks(4031), new DateTime(2023, 4, 30, 16, 38, 32, 67, DateTimeKind.Utc).AddTicks(4030), 1 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted", "StatusId" },
                values: new object[] { new DateTime(2023, 5, 6, 19, 2, 32, 67, DateTimeKind.Utc).AddTicks(4033), new DateTime(2023, 5, 6, 16, 38, 32, 67, DateTimeKind.Utc).AddTicks(4033), 1 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted", "StatusId" },
                values: new object[] { new DateTime(2023, 5, 9, 19, 2, 32, 67, DateTimeKind.Utc).AddTicks(4036), new DateTime(2023, 5, 9, 16, 38, 32, 67, DateTimeKind.Utc).AddTicks(4035), 1 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted", "StatusId" },
                values: new object[] { new DateTime(2023, 5, 8, 16, 38, 32, 67, DateTimeKind.Utc).AddTicks(4038), new DateTime(2023, 5, 8, 4, 38, 32, 67, DateTimeKind.Utc).AddTicks(4037), 1 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted", "StatusId" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 2, 32, 67, DateTimeKind.Utc).AddTicks(4040), new DateTime(2023, 5, 9, 4, 38, 32, 67, DateTimeKind.Utc).AddTicks(4040), 1 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted", "StatusId" },
                values: new object[] { new DateTime(2023, 5, 9, 19, 2, 32, 67, DateTimeKind.Utc).AddTicks(4042), new DateTime(2023, 5, 9, 16, 38, 32, 67, DateTimeKind.Utc).AddTicks(4042), 1 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted", "StatusId" },
                values: new object[] { new DateTime(2023, 5, 10, 4, 38, 32, 67, DateTimeKind.Utc).AddTicks(4046), new DateTime(2023, 5, 9, 23, 50, 32, 67, DateTimeKind.Utc).AddTicks(4045), 1 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted", "StatusId" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 26, 32, 67, DateTimeKind.Utc).AddTicks(4048), new DateTime(2023, 5, 10, 16, 38, 32, 67, DateTimeKind.Utc).AddTicks(4047), 1 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted", "StatusId" },
                values: new object[] { new DateTime(2023, 5, 11, 9, 26, 32, 67, DateTimeKind.Utc).AddTicks(4113), new DateTime(2023, 5, 11, 4, 38, 32, 67, DateTimeKind.Utc).AddTicks(4112), 1 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted", "StatusId" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 38, 32, 67, DateTimeKind.Utc).AddTicks(4116), new DateTime(2023, 5, 10, 16, 38, 32, 67, DateTimeKind.Utc).AddTicks(4115), 1 });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Open" },
                    { 2, "Being Investigated," },
                    { 3, "Closed" },
                    { 4, "No Action Required" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "ReportViewModel");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Reports");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "ReportViewModel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Reports",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a525ac-d446-4c8c-983c-047afdffed13",
                column: "ConcurrencyStamp",
                value: "a59359f8-06e3-4a57-af66-b57d9c2ec8c1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca95d41-370a-4218-b0aa-8502494448fb",
                column: "ConcurrencyStamp",
                value: "3960b031-0a77-464e-8122-5b381c835792");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b9ed8a91-dab9-4546-9002-dae6f48103b3", "6986673b-023e-4427-a634-4d6b7cc24917" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "44e5d4d9-3543-4be7-97c7-dcc43b39845f", "8318d665-c8e4-4cda-bd82-b32c8fecbdcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "90fbeecf-6186-42e0-af0b-b8a37e311ba3", "8a9b4585-30ae-41d3-adb2-529b9a79687f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b3944fb2-5ac7-4871-a5d1-e5846d8d32e3", "cea57fd0-4268-47b2-a0e0-10faf9bb0251" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4156054c-4967-4191-a07c-d8553fcfb766", "c57e6541-ef53-45b9-a0f4-235401521041" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0552b336-981d-4b8b-a029-265d74994073", "03f7591d-8b90-4586-b30d-494bf7a0979d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d8bc6037-0ad9-4998-b475-8774e04e637f", "a7c04805-6c9e-4f9c-a69a-b2c707edae37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2670ac7f-9e70-46f2-a418-2965412b889c", "bbae59bf-28bd-4549-9a45-ee23c601b3b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0ca3e7fe-f71e-4844-834e-b42448f08ed4", "974b8c54-92e2-4ace-992a-35bc1f1327bf" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted", "Status" },
                values: new object[] { new DateTime(2023, 4, 23, 13, 23, 19, 984, DateTimeKind.Utc).AddTicks(6891), new DateTime(2023, 4, 21, 13, 23, 19, 984, DateTimeKind.Utc).AddTicks(6886), false });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted", "Status" },
                values: new object[] { new DateTime(2023, 4, 29, 15, 47, 19, 984, DateTimeKind.Utc).AddTicks(6895), new DateTime(2023, 4, 29, 13, 23, 19, 984, DateTimeKind.Utc).AddTicks(6894), false });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted", "Status" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 35, 19, 984, DateTimeKind.Utc).AddTicks(6897), new DateTime(2023, 4, 30, 13, 23, 19, 984, DateTimeKind.Utc).AddTicks(6896), false });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted", "Status" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 47, 19, 984, DateTimeKind.Utc).AddTicks(6898), new DateTime(2023, 5, 6, 13, 23, 19, 984, DateTimeKind.Utc).AddTicks(6898), false });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted", "Status" },
                values: new object[] { new DateTime(2023, 5, 9, 15, 47, 19, 984, DateTimeKind.Utc).AddTicks(6900), new DateTime(2023, 5, 9, 13, 23, 19, 984, DateTimeKind.Utc).AddTicks(6899), false });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted", "Status" },
                values: new object[] { new DateTime(2023, 5, 8, 13, 23, 19, 984, DateTimeKind.Utc).AddTicks(6902), new DateTime(2023, 5, 8, 1, 23, 19, 984, DateTimeKind.Utc).AddTicks(6901), false });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted", "Status" },
                values: new object[] { new DateTime(2023, 5, 9, 3, 47, 19, 984, DateTimeKind.Utc).AddTicks(6903), new DateTime(2023, 5, 9, 1, 23, 19, 984, DateTimeKind.Utc).AddTicks(6903), false });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted", "Status" },
                values: new object[] { new DateTime(2023, 5, 9, 15, 47, 19, 984, DateTimeKind.Utc).AddTicks(6905), new DateTime(2023, 5, 9, 13, 23, 19, 984, DateTimeKind.Utc).AddTicks(6905), false });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted", "Status" },
                values: new object[] { new DateTime(2023, 5, 10, 1, 23, 19, 984, DateTimeKind.Utc).AddTicks(6907), new DateTime(2023, 5, 9, 20, 35, 19, 984, DateTimeKind.Utc).AddTicks(6906), false });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted", "Status" },
                values: new object[] { new DateTime(2023, 5, 10, 18, 11, 19, 984, DateTimeKind.Utc).AddTicks(6908), new DateTime(2023, 5, 10, 13, 23, 19, 984, DateTimeKind.Utc).AddTicks(6908), false });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted", "Status" },
                values: new object[] { new DateTime(2023, 5, 11, 6, 11, 19, 984, DateTimeKind.Utc).AddTicks(6910), new DateTime(2023, 5, 11, 1, 23, 19, 984, DateTimeKind.Utc).AddTicks(6910), false });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted", "Status" },
                values: new object[] { new DateTime(2023, 5, 11, 13, 23, 19, 984, DateTimeKind.Utc).AddTicks(6912), new DateTime(2023, 5, 10, 13, 23, 19, 984, DateTimeKind.Utc).AddTicks(6911), false });
        }
    }
}
