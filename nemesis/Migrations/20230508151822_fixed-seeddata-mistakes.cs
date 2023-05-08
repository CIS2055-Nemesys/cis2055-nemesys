using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class fixedseeddatamistakes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a525ac-d446-4c8c-983c-047afdffed13",
                column: "ConcurrencyStamp",
                value: "2bb78e00-12c0-41d6-9267-742c44a6e597");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca95d41-370a-4218-b0aa-8502494448fb",
                column: "ConcurrencyStamp",
                value: "af729811-0bc9-49e5-a7ee-14314f819a0d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fbf0a15c-7b10-434f-8932-0b899c329c61", "b841f4ff-c886-416a-86fc-d28d799ee3cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ba384e61-88b3-41d7-95d1-bedefdd44d61", "8f36e6ca-05f6-49c6-a7c0-698771e32c10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a8a24640-f583-4891-8bd7-b6f5599b6c87", "baa3f9bb-1da7-46c9-b418-597047f16832" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "494f8d56-711b-4d0f-a72f-8fb5e4142e9a", "a3ad2979-2ace-4ad9-b00b-01329a4d8c28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "79596d67-53ad-4f34-88de-29df503ddc18", "b0aeb2c7-16a1-489c-835c-e1711dda6e7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4bf9c7b1-38dc-42b1-8561-845e97206bf2", "bcb77857-92b5-4e26-8772-888f47bc9cb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0ccf9165-6c0a-4a8c-aed9-2c1e698fc84d", "6c572100-7e07-464e-babd-e9340a9e9dbc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d3515c90-fd07-48e7-a2ef-3d9992f03970", "261762e2-70cc-4ec6-bb03-d0a699c31726" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4c92a0b5-fd9a-4beb-beef-4ac0442ead08", "36f8c067-89ba-4745-ac32-54b89571f821" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 20, 15, 18, 21, 845, DateTimeKind.Utc).AddTicks(8094), new DateTime(2023, 4, 18, 15, 18, 21, 845, DateTimeKind.Utc).AddTicks(8088) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 26, 17, 42, 21, 845, DateTimeKind.Utc).AddTicks(8097), new DateTime(2023, 4, 26, 15, 18, 21, 845, DateTimeKind.Utc).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 27, 16, 30, 21, 845, DateTimeKind.Utc).AddTicks(8098), new DateTime(2023, 4, 27, 15, 18, 21, 845, DateTimeKind.Utc).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 17, 42, 21, 845, DateTimeKind.Utc).AddTicks(8100), new DateTime(2023, 5, 3, 15, 18, 21, 845, DateTimeKind.Utc).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 6, 17, 42, 21, 845, DateTimeKind.Utc).AddTicks(8102), new DateTime(2023, 5, 6, 15, 18, 21, 845, DateTimeKind.Utc).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 5, 15, 18, 21, 845, DateTimeKind.Utc).AddTicks(8104), new DateTime(2023, 5, 5, 3, 18, 21, 845, DateTimeKind.Utc).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 6, 5, 42, 21, 845, DateTimeKind.Utc).AddTicks(8106), new DateTime(2023, 5, 6, 3, 18, 21, 845, DateTimeKind.Utc).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 6, 17, 42, 21, 845, DateTimeKind.Utc).AddTicks(8108), new DateTime(2023, 5, 6, 15, 18, 21, 845, DateTimeKind.Utc).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 7, 3, 18, 21, 845, DateTimeKind.Utc).AddTicks(8110), new DateTime(2023, 5, 6, 22, 30, 21, 845, DateTimeKind.Utc).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 7, 20, 6, 21, 845, DateTimeKind.Utc).AddTicks(8112), new DateTime(2023, 5, 7, 15, 18, 21, 845, DateTimeKind.Utc).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 8, 8, 6, 21, 845, DateTimeKind.Utc).AddTicks(8114), new DateTime(2023, 5, 8, 3, 18, 21, 845, DateTimeKind.Utc).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted", "Description", "Title" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 18, 21, 845, DateTimeKind.Utc).AddTicks(8116), new DateTime(2023, 5, 7, 15, 18, 21, 845, DateTimeKind.Utc).AddTicks(8115), "Impostor detected!!!!!!\n This van tried to impersonate Dr Chris Porter (PhD, MD, JD, MBA, MS, MFA, DSc, DPhil, DEd, DPT, DVM, DSW, DMus, DEng, DM, DNurs, DLit, DDS, DClinPsy, DPharm, DArch, and DBA), the erudite, brilliant, innovative, charismatic, awe-inspiring, compassionate, visionary, and unparalleled intellectual powerhouse, whose prodigious knowledge, remarkable expertise, and boundless passion for teaching have transformed countless minds and left an indelible mark on the realm of academia.\n\nps: chatgpt is really useful", "Porter imposter" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a525ac-d446-4c8c-983c-047afdffed13",
                column: "ConcurrencyStamp",
                value: "5c3b2b9e-bbf5-41eb-87b2-31ee6ead38c8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca95d41-370a-4218-b0aa-8502494448fb",
                column: "ConcurrencyStamp",
                value: "00a89a57-7782-4c59-815a-b6f414a5590f");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "14e7d3e9-7fc6-4316-806e-f489041371aa", "183c4d66-1744-4ace-8ef2-1cfb4eb92983" });

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

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted", "Description", "Title" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 15, 40, 450, DateTimeKind.Utc).AddTicks(8392), new DateTime(2023, 5, 7, 15, 15, 40, 450, DateTimeKind.Utc).AddTicks(8392), "Impersonator detected!!!!!!\n This van tried to impersonate Dr Chris Porter (PhD, MD, JD, MBA, MS, MFA, DSc, DPhil, DEd, DPT, DVM, DSW, DMus, DEng, DM, DNurs, DLit, DDS, DClinPsy, DPharm, DArch, and DBA), the erudite, brilliant, innovative, charismatic, awe-inspiring, compassionate, visionary, and unparalleled intellectual powerhouse, whose prodigious knowledge, remarkable expertise, and boundless passion for teaching have transformed countless minds and left an indelible mark on the realm of academia.\n\nps: chatgpt is really useful", "9059e247-2854-40bd-af2b-76088f8dd4e6" });
        }
    }
}
