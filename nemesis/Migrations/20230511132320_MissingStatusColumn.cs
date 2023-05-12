using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class MissingStatusColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Investigations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Investigations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 23, 13, 23, 19, 984, DateTimeKind.Utc).AddTicks(6891), new DateTime(2023, 4, 21, 13, 23, 19, 984, DateTimeKind.Utc).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 29, 15, 47, 19, 984, DateTimeKind.Utc).AddTicks(6895), new DateTime(2023, 4, 29, 13, 23, 19, 984, DateTimeKind.Utc).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 35, 19, 984, DateTimeKind.Utc).AddTicks(6897), new DateTime(2023, 4, 30, 13, 23, 19, 984, DateTimeKind.Utc).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 47, 19, 984, DateTimeKind.Utc).AddTicks(6898), new DateTime(2023, 5, 6, 13, 23, 19, 984, DateTimeKind.Utc).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 9, 15, 47, 19, 984, DateTimeKind.Utc).AddTicks(6900), new DateTime(2023, 5, 9, 13, 23, 19, 984, DateTimeKind.Utc).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 8, 13, 23, 19, 984, DateTimeKind.Utc).AddTicks(6902), new DateTime(2023, 5, 8, 1, 23, 19, 984, DateTimeKind.Utc).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 9, 3, 47, 19, 984, DateTimeKind.Utc).AddTicks(6903), new DateTime(2023, 5, 9, 1, 23, 19, 984, DateTimeKind.Utc).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 9, 15, 47, 19, 984, DateTimeKind.Utc).AddTicks(6905), new DateTime(2023, 5, 9, 13, 23, 19, 984, DateTimeKind.Utc).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 10, 1, 23, 19, 984, DateTimeKind.Utc).AddTicks(6907), new DateTime(2023, 5, 9, 20, 35, 19, 984, DateTimeKind.Utc).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 10, 18, 11, 19, 984, DateTimeKind.Utc).AddTicks(6908), new DateTime(2023, 5, 10, 13, 23, 19, 984, DateTimeKind.Utc).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 11, 6, 11, 19, 984, DateTimeKind.Utc).AddTicks(6910), new DateTime(2023, 5, 11, 1, 23, 19, 984, DateTimeKind.Utc).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 11, 13, 23, 19, 984, DateTimeKind.Utc).AddTicks(6912), new DateTime(2023, 5, 10, 13, 23, 19, 984, DateTimeKind.Utc).AddTicks(6911) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Investigations");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Investigations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a525ac-d446-4c8c-983c-047afdffed13",
                column: "ConcurrencyStamp",
                value: "a8dae121-ecc8-499d-9d96-261e1e0f5314");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca95d41-370a-4218-b0aa-8502494448fb",
                column: "ConcurrencyStamp",
                value: "cd22351d-afdd-4f0b-834a-ac7bbe9cd9b4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4e4375fb-c7e6-4055-b7e6-fcbbd85399ab", "575b077e-9505-406e-a45b-d89ff5d4251b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "705aedbc-e116-42e7-b76f-830eee5a807e", "3769d321-5b92-41d4-a63e-02eab8cda46c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "057a3b36-78c0-4a3d-81d0-2d4586137eca", "848b75ad-27f0-4daf-acb8-4fd6f46e8214" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f651a829-3f61-4510-b56e-75e8cab7f68d", "c3cea3ed-5c3b-41ce-a8ad-bbea511a673c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6f7c9fb9-2a25-456d-9da2-d99ea7c51327", "ed13a7c6-5f21-440a-b345-99224a9933c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8476d81b-4399-41d2-bb17-9d1b8e3b27f1", "93c1e442-9cb5-4479-8ac6-ade76c3b0e71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2f8665a3-752a-4b40-bb7c-42a9d9a7d1ce", "e7396a08-8224-493f-9fcc-13bf2ad272e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e37f451c-e333-4b82-a800-9af39a600584", "16a1fb38-2e47-44e3-9baf-396db5fb84c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "79ea7bb5-8a9c-4983-8ad2-552f0c4e15be", "7a96f83d-e449-4e82-b315-16daf94b6d19" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 22, 14, 58, 29, 849, DateTimeKind.Utc).AddTicks(6516), new DateTime(2023, 4, 20, 14, 58, 29, 849, DateTimeKind.Utc).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 28, 17, 22, 29, 849, DateTimeKind.Utc).AddTicks(6520), new DateTime(2023, 4, 28, 14, 58, 29, 849, DateTimeKind.Utc).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 29, 16, 10, 29, 849, DateTimeKind.Utc).AddTicks(6523), new DateTime(2023, 4, 29, 14, 58, 29, 849, DateTimeKind.Utc).AddTicks(6522) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 5, 17, 22, 29, 849, DateTimeKind.Utc).AddTicks(6524), new DateTime(2023, 5, 5, 14, 58, 29, 849, DateTimeKind.Utc).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 8, 17, 22, 29, 849, DateTimeKind.Utc).AddTicks(6526), new DateTime(2023, 5, 8, 14, 58, 29, 849, DateTimeKind.Utc).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 58, 29, 849, DateTimeKind.Utc).AddTicks(6528), new DateTime(2023, 5, 7, 2, 58, 29, 849, DateTimeKind.Utc).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 8, 5, 22, 29, 849, DateTimeKind.Utc).AddTicks(6530), new DateTime(2023, 5, 8, 2, 58, 29, 849, DateTimeKind.Utc).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 8, 17, 22, 29, 849, DateTimeKind.Utc).AddTicks(6531), new DateTime(2023, 5, 8, 14, 58, 29, 849, DateTimeKind.Utc).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 9, 2, 58, 29, 849, DateTimeKind.Utc).AddTicks(6533), new DateTime(2023, 5, 8, 22, 10, 29, 849, DateTimeKind.Utc).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 9, 19, 46, 29, 849, DateTimeKind.Utc).AddTicks(6535), new DateTime(2023, 5, 9, 14, 58, 29, 849, DateTimeKind.Utc).AddTicks(6534) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 10, 7, 46, 29, 849, DateTimeKind.Utc).AddTicks(6537), new DateTime(2023, 5, 10, 2, 58, 29, 849, DateTimeKind.Utc).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 58, 29, 849, DateTimeKind.Utc).AddTicks(6538), new DateTime(2023, 5, 9, 14, 58, 29, 849, DateTimeKind.Utc).AddTicks(6538) });
        }
    }
}
