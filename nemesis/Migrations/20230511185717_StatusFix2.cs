using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class StatusFix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Investigations");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Investigations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a525ac-d446-4c8c-983c-047afdffed13",
                column: "ConcurrencyStamp",
                value: "fe1f65bb-f2e5-4fb3-ba9c-83e3fa5b3f9d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca95d41-370a-4218-b0aa-8502494448fb",
                column: "ConcurrencyStamp",
                value: "dc8b907f-f214-427d-993f-6481e2b052b0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1622921a-fc91-40cd-9c52-96bb4e7ba658", "df3dea03-749c-429a-b395-f255b93f4d75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a75fd789-0f46-4327-8e57-0dd141363029", "7a176ccd-e386-48ec-acd1-36a488068fea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d7010ec1-2a55-4754-8627-15393a44a6f2", "aa39383c-3e07-441b-bde0-35e27c369b55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7debb255-a970-4d67-b01c-fcbd92d28246", "3c696e0b-8dff-448c-aa99-5bd2f82958da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "62c5f6f8-1395-427e-8196-bf5411188daf", "8aad40f7-0e8a-4518-9e6a-dd1f6816593e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bd156388-3530-4928-bce4-38f1831729cc", "2acee0b0-986c-4be9-9534-39877f1d1e33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b724e597-5eef-41cc-bd97-0bccba7f9e88", "d470242f-95c3-4a92-9793-c657de6c7e94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e68f68c8-62c9-4b55-a90c-c1606b9ca356", "d242455e-1f4f-4834-ae15-a26403f9cf97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2db57347-092f-4d36-a27a-c2c7e0b8fe33", "f9444981-d3fc-46ca-b902-6d632204d4cb" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted", "InvestigationId" },
                values: new object[] { new DateTime(2023, 4, 23, 18, 57, 16, 819, DateTimeKind.Utc).AddTicks(7039), new DateTime(2023, 4, 21, 18, 57, 16, 819, DateTimeKind.Utc).AddTicks(7034), 1 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted", "InvestigationId" },
                values: new object[] { new DateTime(2023, 4, 29, 21, 21, 16, 819, DateTimeKind.Utc).AddTicks(7042), new DateTime(2023, 4, 29, 18, 57, 16, 819, DateTimeKind.Utc).AddTicks(7041), 2 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 30, 20, 9, 16, 819, DateTimeKind.Utc).AddTicks(7044), new DateTime(2023, 4, 30, 18, 57, 16, 819, DateTimeKind.Utc).AddTicks(7044) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 6, 21, 21, 16, 819, DateTimeKind.Utc).AddTicks(7046), new DateTime(2023, 5, 6, 18, 57, 16, 819, DateTimeKind.Utc).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 9, 21, 21, 16, 819, DateTimeKind.Utc).AddTicks(7048), new DateTime(2023, 5, 9, 18, 57, 16, 819, DateTimeKind.Utc).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 8, 18, 57, 16, 819, DateTimeKind.Utc).AddTicks(7050), new DateTime(2023, 5, 8, 6, 57, 16, 819, DateTimeKind.Utc).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 21, 16, 819, DateTimeKind.Utc).AddTicks(7051), new DateTime(2023, 5, 9, 6, 57, 16, 819, DateTimeKind.Utc).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 9, 21, 21, 16, 819, DateTimeKind.Utc).AddTicks(7053), new DateTime(2023, 5, 9, 18, 57, 16, 819, DateTimeKind.Utc).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 57, 16, 819, DateTimeKind.Utc).AddTicks(7054), new DateTime(2023, 5, 10, 2, 9, 16, 819, DateTimeKind.Utc).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 10, 23, 45, 16, 819, DateTimeKind.Utc).AddTicks(7056), new DateTime(2023, 5, 10, 18, 57, 16, 819, DateTimeKind.Utc).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 11, 11, 45, 16, 819, DateTimeKind.Utc).AddTicks(7057), new DateTime(2023, 5, 11, 6, 57, 16, 819, DateTimeKind.Utc).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 11, 18, 57, 16, 819, DateTimeKind.Utc).AddTicks(7059), new DateTime(2023, 5, 10, 18, 57, 16, 819, DateTimeKind.Utc).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Being Investigated");

            migrationBuilder.CreateIndex(
                name: "IX_Investigations_StatusId",
                table: "Investigations",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Investigations_Statuses_StatusId",
                table: "Investigations",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investigations_Statuses_StatusId",
                table: "Investigations");

            migrationBuilder.DropIndex(
                name: "IX_Investigations_StatusId",
                table: "Investigations");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Investigations");

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
                columns: new[] { "DateOfReport", "DateSpotted", "InvestigationId" },
                values: new object[] { new DateTime(2023, 4, 23, 16, 58, 5, 192, DateTimeKind.Utc).AddTicks(9227), new DateTime(2023, 4, 21, 16, 58, 5, 192, DateTimeKind.Utc).AddTicks(9220), null });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted", "InvestigationId" },
                values: new object[] { new DateTime(2023, 4, 29, 19, 22, 5, 192, DateTimeKind.Utc).AddTicks(9231), new DateTime(2023, 4, 29, 16, 58, 5, 192, DateTimeKind.Utc).AddTicks(9230), null });

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

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Being Investigated,");
        }
    }
}
