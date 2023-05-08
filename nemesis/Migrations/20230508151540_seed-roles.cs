using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class seedroles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "68a525ac-d446-4c8c-983c-047afdffed13", "5c3b2b9e-bbf5-41eb-87b2-31ee6ead38c8", "Admin", "ADMIN" },
                    { "fca95d41-370a-4218-b0aa-8502494448fb", "00a89a57-7782-4c59-815a-b6f414a5590f", "Investigator", "INVESTIGATOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0c1d507a-3f49-4018-b6ba-5dbcde6978b9", "e21c0122-e010-4043-acaa-c15e69ad0f36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ec9204f-07be-4dbe-bedd-d018cfcd9115", "2ebf4ae2-183c-447d-8c54-f048ef589bc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f1a3b795-7d70-4d9f-8e50-16fe745094c4", "7681ee66-762f-4116-ad49-a26e0567d679" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bc67becf-3e9a-450f-97d2-246d007fd6b9", "0cc1a6a4-f370-46d2-832a-90c6a29b79b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e0f7b391-6899-4cb7-bc63-ca2d493ed8b9", "508d6385-434e-4b50-bf3d-83a4fe5a0877" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4c0e33ad-2388-4851-803d-43a92ac4be05", "527bcd57-0b16-4dc3-92ae-3c09e7127dcf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "381b88b2-c024-47bb-9b44-526e1ca8dcaa", "40f143ae-9d12-4ecc-a3c4-15ea87bf3354" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "013008fd-d4fa-4a6c-894f-7a580e87211d", "8d85118f-64a9-4fd5-a1f5-cc27a350b779" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fac97539-cb0b-4b9f-ae20-497eafb414bc", 0, "14e7d3e9-7fc6-4316-806e-f489041371aa", "su@do.com", false, false, null, "SU@DO.COM", "SUDO", null, "0", false, "183c4d66-1744-4ace-8ef2-1cfb4eb92983", false, "Sudo" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 20, 15, 15, 40, 450, DateTimeKind.Utc).AddTicks(8370), new DateTime(2023, 4, 18, 15, 15, 40, 450, DateTimeKind.Utc).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 26, 17, 39, 40, 450, DateTimeKind.Utc).AddTicks(8374), new DateTime(2023, 4, 26, 15, 15, 40, 450, DateTimeKind.Utc).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 27, 16, 27, 40, 450, DateTimeKind.Utc).AddTicks(8376), new DateTime(2023, 4, 27, 15, 15, 40, 450, DateTimeKind.Utc).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 17, 39, 40, 450, DateTimeKind.Utc).AddTicks(8377), new DateTime(2023, 5, 3, 15, 15, 40, 450, DateTimeKind.Utc).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 6, 17, 39, 40, 450, DateTimeKind.Utc).AddTicks(8379), new DateTime(2023, 5, 6, 15, 15, 40, 450, DateTimeKind.Utc).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 5, 15, 15, 40, 450, DateTimeKind.Utc).AddTicks(8381), new DateTime(2023, 5, 5, 3, 15, 40, 450, DateTimeKind.Utc).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 6, 5, 39, 40, 450, DateTimeKind.Utc).AddTicks(8383), new DateTime(2023, 5, 6, 3, 15, 40, 450, DateTimeKind.Utc).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 6, 17, 39, 40, 450, DateTimeKind.Utc).AddTicks(8385), new DateTime(2023, 5, 6, 15, 15, 40, 450, DateTimeKind.Utc).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 7, 3, 15, 40, 450, DateTimeKind.Utc).AddTicks(8387), new DateTime(2023, 5, 6, 22, 27, 40, 450, DateTimeKind.Utc).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 7, 20, 3, 40, 450, DateTimeKind.Utc).AddTicks(8389), new DateTime(2023, 5, 7, 15, 15, 40, 450, DateTimeKind.Utc).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 8, 8, 3, 40, 450, DateTimeKind.Utc).AddTicks(8390), new DateTime(2023, 5, 8, 3, 15, 40, 450, DateTimeKind.Utc).AddTicks(8390) });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "CategoryId", "CreatedByUserId", "DateOfReport", "DateSpotted", "Description", "ImageUrl", "InvestigationId", "Location", "Status", "Title", "Upvotes" },
                values: new object[] { 12, 1, "84b91c9f-74d1-452d-927b-439bfd3a7287", new DateTime(2023, 5, 8, 15, 15, 40, 450, DateTimeKind.Utc).AddTicks(8392), new DateTime(2023, 5, 7, 15, 15, 40, 450, DateTimeKind.Utc).AddTicks(8392), "Impersonator detected!!!!!!\n This van tried to impersonate Dr Chris Porter (PhD, MD, JD, MBA, MS, MFA, DSc, DPhil, DEd, DPT, DVM, DSW, DMus, DEng, DM, DNurs, DLit, DDS, DClinPsy, DPharm, DArch, and DBA), the erudite, brilliant, innovative, charismatic, awe-inspiring, compassionate, visionary, and unparalleled intellectual powerhouse, whose prodigious knowledge, remarkable expertise, and boundless passion for teaching have transformed countless minds and left an indelible mark on the realm of academia.\n\nps: chatgpt is really useful", "/images/Porter.jpg", null, "London", false, "9059e247-2854-40bd-af2b-76088f8dd4e6", 2000 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "fca95d41-370a-4218-b0aa-8502494448fb", "84b91c9f-74d1-452d-927b-439bfd3a7287" },
                    { "fca95d41-370a-4218-b0aa-8502494448fb", "9059e247-2854-40bd-af2b-76088f8dd4e6" },
                    { "fca95d41-370a-4218-b0aa-8502494448fb", "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6" },
                    { "68a525ac-d446-4c8c-983c-047afdffed13", "fac97539-cb0b-4b9f-ae20-497eafb414bc" },
                    { "fca95d41-370a-4218-b0aa-8502494448fb", "fac97539-cb0b-4b9f-ae20-497eafb414bc" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fca95d41-370a-4218-b0aa-8502494448fb", "84b91c9f-74d1-452d-927b-439bfd3a7287" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fca95d41-370a-4218-b0aa-8502494448fb", "9059e247-2854-40bd-af2b-76088f8dd4e6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fca95d41-370a-4218-b0aa-8502494448fb", "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "68a525ac-d446-4c8c-983c-047afdffed13", "fac97539-cb0b-4b9f-ae20-497eafb414bc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fca95d41-370a-4218-b0aa-8502494448fb", "fac97539-cb0b-4b9f-ae20-497eafb414bc" });

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a525ac-d446-4c8c-983c-047afdffed13");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca95d41-370a-4218-b0aa-8502494448fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc");

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
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 17, 15, 44, 59, 452, DateTimeKind.Utc).AddTicks(9839), new DateTime(2023, 4, 15, 15, 44, 59, 452, DateTimeKind.Utc).AddTicks(9833) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 23, 18, 8, 59, 452, DateTimeKind.Utc).AddTicks(9842), new DateTime(2023, 4, 23, 15, 44, 59, 452, DateTimeKind.Utc).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 24, 16, 56, 59, 452, DateTimeKind.Utc).AddTicks(9845), new DateTime(2023, 4, 24, 15, 44, 59, 452, DateTimeKind.Utc).AddTicks(9844) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 8, 59, 452, DateTimeKind.Utc).AddTicks(9847), new DateTime(2023, 4, 30, 15, 44, 59, 452, DateTimeKind.Utc).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 18, 8, 59, 452, DateTimeKind.Utc).AddTicks(9849), new DateTime(2023, 5, 3, 15, 44, 59, 452, DateTimeKind.Utc).AddTicks(9849) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 2, 15, 44, 59, 452, DateTimeKind.Utc).AddTicks(9852), new DateTime(2023, 5, 2, 3, 44, 59, 452, DateTimeKind.Utc).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 6, 8, 59, 452, DateTimeKind.Utc).AddTicks(9854), new DateTime(2023, 5, 3, 3, 44, 59, 452, DateTimeKind.Utc).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 18, 8, 59, 452, DateTimeKind.Utc).AddTicks(9856), new DateTime(2023, 5, 3, 15, 44, 59, 452, DateTimeKind.Utc).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 4, 3, 44, 59, 452, DateTimeKind.Utc).AddTicks(9858), new DateTime(2023, 5, 3, 22, 56, 59, 452, DateTimeKind.Utc).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 4, 20, 32, 59, 452, DateTimeKind.Utc).AddTicks(9860), new DateTime(2023, 5, 4, 15, 44, 59, 452, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 5, 8, 32, 59, 452, DateTimeKind.Utc).AddTicks(9862), new DateTime(2023, 5, 5, 3, 44, 59, 452, DateTimeKind.Utc).AddTicks(9862) });
        }
    }
}
