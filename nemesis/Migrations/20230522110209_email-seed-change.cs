using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class emailseedchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a525ac-d446-4c8c-983c-047afdffed13",
                column: "ConcurrencyStamp",
                value: "fb6feb35-4763-4565-9802-78f9b0062010");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca95d41-370a-4218-b0aa-8502494448fb",
                column: "ConcurrencyStamp",
                value: "e876d9e3-1ab3-454b-b6af-e895e04e9649");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb3f3d43-6abe-497a-a970-69f54ed9da22", "NEMESIS-ACCOUNTS-UM+homework-reminder@wayne.mt", "NEMESIS-ACCOUNTS-UM+HOMEWORK-REMINDER@wayne.mt", "AQAAAAEAACcQAAAAEFLklpby4H2GeB7H192IuZl6ZJlXiyYR749O9QvLhbnHtu/95vgczyFnpDmK6EoHEQ==", "0f2bf6bf-2c09-4b0b-b3ab-fa04042c848c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0ba964e-cda1-4397-892a-2def7d676527", "NEMESIS-ACCOUNTS-UM+CandiceFlynn-snitch@wayne.mt", "NEMESIS-ACCOUNTS-UM+CANDICEFLYNN-SNITCH@wayne.mt", "AQAAAAEAACcQAAAAEGznxtDH1wa/0xTEi7y8q6BD7ZVruMtZP08YjXxCPbr8TBI3oJ2GfRlL9Z/Ia1x6Vg==", "8311b1c5-0c3c-48bf-b83e-3826189385a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bceeff3c-447f-4752-b043-aec67cc02118", "NEMESIS-ACCOUNTS-UM+cetta-hotmail@wayne.mt", "NEMESIS-ACCOUNTS-UM+CETTA-HOTMAIL@wayne.mt", "AQAAAAEAACcQAAAAENnsOmqYaB1v0khsZqqn6IyCkAkW8Ylxrsni3WO8u6ObXP/OcPKuLvWW0+TZTX7e6w==", "3a7b5487-130b-45e9-8b17-11b15ed2a55e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81674c43-3b20-4506-b0d6-b32c97522840", "NEMESIS-ACCOUNTS-UM+head-snitch@wayne.mt", "NEMESIS-ACCOUNTS-UM+HEAD-SNITCH@wayne.mt", "AQAAAAEAACcQAAAAENKYRHUTg0E47akTzOhPMbEBGIDgxvJL6DIw+IaWy7oYtvoaNu9+U8ZK5eK7RCdaVQ==", "65a1049a-248e-40be-bb9b-dfcc9a93712f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "023952bc-be21-427a-87cc-5c19dc29cf73", "NEMESIS-ACCOUNTS-UM+element-inspect@wayne.mt", "NEMESIS-ACCOUNTS-UM+ELEMENT-INSPECT@wayne.mt", "AQAAAAEAACcQAAAAENTe46/XIXycYEKddaPnH0FpPkjdq5+zMSf+IjjHQa4bezFWdvn3lqVwlOQC5pADWQ==", "ac54bdd5-9358-4111-a98d-13f8d3a82cf2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12ef495d-dc65-4fb4-84ad-4dc98382c596", "NEMESIS-ACCOUNTS-UM+gadget-inspect@wayne.mt", "NEMESIS-ACCOUNTS-UM+GADGET-INSPECT@wayne.mt", "AQAAAAEAACcQAAAAEPH5y5SJ20f2U5GKfMJypOl4DK0W0UlFJY8nqeF2qJ4kcIR4Ms9BEIz76zDgV3hj6A==", "529b5792-02b1-4f0c-8aff-db0323b4f256" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "288a8aa5-2fbb-42c1-96c8-a56436153445", "nemesis-accounts-um+cop2mall@wayne.mt", "NEMESIS-ACCOUNTS-UM+COP2MALL@WAYNE.MT", "AQAAAAEAACcQAAAAEDXhOWahf2b+7ZMVyomM/5lFSyPcNjEF1lYseZN3CyZ2jRVTXwMaChWeKVJ6lEOXMg==", "a68cf6bf-6291-4a42-a92a-66e6d8a3d04b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f41f2d22-152a-4fe5-bb06-a0d18766d220", "NEMESIS-ACCOUNTS-UM+karen-qrid@wayne.mt", "NEMESIS-ACCOUNTS-UM+KAREN-QRID@wayne.mt", "AQAAAAEAACcQAAAAECPU2Lpedxiryfa7CllhvkYcimdtv0lVY3CtwO/6uli/dpeXbL9u2on0c1XBuYA20A==", "e653b9a5-8fcd-437a-a3c4-bc9a6ca5e321" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9314eb39-9edc-407a-93fb-35adaece1027", "nemesis-accounts-um+sudo@wayne.mt", "NEMESIS-ACCOUNTS-UM+SUDO@WAYNE.MT", "AQAAAAEAACcQAAAAEOyd42isedfV6k0gMtQE7bvnLS4a5lqS9NMDtrDjLhqD3o/6YrVTpDfG4pcNodOsbw==", "3f61c511-0b12-4e46-983f-1e630c98f040" });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 11, 2, 9, 671, DateTimeKind.Utc).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 11, 2, 9, 671, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 11, 2, 9, 671, DateTimeKind.Utc).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 11, 2, 9, 671, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 11, 2, 9, 671, DateTimeKind.Utc).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 11, 2, 9, 671, DateTimeKind.Utc).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 11, 2, 9, 671, DateTimeKind.Utc).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 11, 2, 9, 671, DateTimeKind.Utc).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 11, 2, 9, 671, DateTimeKind.Utc).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 2, 9, 671, DateTimeKind.Utc).AddTicks(8283), new DateTime(2023, 5, 2, 11, 2, 9, 671, DateTimeKind.Utc).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 10, 13, 26, 9, 671, DateTimeKind.Utc).AddTicks(8286), new DateTime(2023, 5, 10, 11, 2, 9, 671, DateTimeKind.Utc).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 11, 12, 14, 9, 671, DateTimeKind.Utc).AddTicks(8288), new DateTime(2023, 5, 11, 11, 2, 9, 671, DateTimeKind.Utc).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 17, 13, 26, 9, 671, DateTimeKind.Utc).AddTicks(8290), new DateTime(2023, 5, 17, 11, 2, 9, 671, DateTimeKind.Utc).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 20, 13, 26, 9, 671, DateTimeKind.Utc).AddTicks(8293), new DateTime(2023, 5, 20, 11, 2, 9, 671, DateTimeKind.Utc).AddTicks(8292) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 2, 9, 671, DateTimeKind.Utc).AddTicks(8296), new DateTime(2023, 5, 18, 23, 2, 9, 671, DateTimeKind.Utc).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 20, 1, 26, 9, 671, DateTimeKind.Utc).AddTicks(8298), new DateTime(2023, 5, 19, 23, 2, 9, 671, DateTimeKind.Utc).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 20, 13, 26, 9, 671, DateTimeKind.Utc).AddTicks(8300), new DateTime(2023, 5, 20, 11, 2, 9, 671, DateTimeKind.Utc).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 20, 23, 2, 9, 671, DateTimeKind.Utc).AddTicks(8302), new DateTime(2023, 5, 20, 18, 14, 9, 671, DateTimeKind.Utc).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 21, 15, 50, 9, 671, DateTimeKind.Utc).AddTicks(8303), new DateTime(2023, 5, 21, 11, 2, 9, 671, DateTimeKind.Utc).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 22, 3, 50, 9, 671, DateTimeKind.Utc).AddTicks(8305), new DateTime(2023, 5, 21, 23, 2, 9, 671, DateTimeKind.Utc).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 22, 11, 2, 9, 671, DateTimeKind.Utc).AddTicks(8307), new DateTime(2023, 5, 21, 11, 2, 9, 671, DateTimeKind.Utc).AddTicks(8307) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a525ac-d446-4c8c-983c-047afdffed13",
                column: "ConcurrencyStamp",
                value: "8efb0d26-a640-493f-8ed0-3ef61dd498d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca95d41-370a-4218-b0aa-8502494448fb",
                column: "ConcurrencyStamp",
                value: "838df8a4-d536-44c5-bdb1-3613747a1516");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77e8e86e-8851-4b85-bead-2b3e8cf4b5cc", "homework@reminder.com", "HOMEWORK@REMINDER.COM", "AQAAAAEAACcQAAAAEGJrHIFlhzyx496AyaH2FoYPJ/OLnF6g4csPiwEqbZ/Qk5op1reCAaLrI8smLVjgnw==", "5af1c28b-9afb-4118-8a48-1bbcded73786" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8a93a2b-f27b-4cbd-a8ac-a901575000b3", "CandiceFlynn@snitch.com", "CANDICEFLYNN@SNITCH.COM", "AQAAAAEAACcQAAAAEKNnTyCE6Ng7cGVZg64kzFdMi1qnVzFCmK+NjrPkUpSakI5EU03F3rUD3azgDV6gjw==", "ee0b1d3a-057f-4383-a0be-b3c9a06d8094" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfe1389b-4a92-4b69-9b82-da1d016a9bbe", "cetta@hotmail.com", "CETTA@HOTMAIL.COM", "AQAAAAEAACcQAAAAEKEA4h4KS7PY2MnXgGeNWlLB3Y+R81ScB/9FG80ihaeULa0JvXE/kj+rPUNW9KJ+iA==", "d59041de-7773-435b-bcec-d116c9f0899d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bccf172-8d97-4a3c-9bc1-67a8844e5619", "head@snitch.com", "HEAD@SNITCH.COM", "AQAAAAEAACcQAAAAED92LYpcP2kxer8idz9e13a6gaNP+owbZ9zEBZjOWU9rbaWEsg7Ca77C/Lx8a0XrlQ==", "f53e6a9d-ca3e-4347-bf1f-e8a73d086dc2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d2b71ff-a50b-4f72-a491-44409127fcee", "element@inspect.com", "ELEMENT@INSPECT.COM", "AQAAAAEAACcQAAAAEABEgR2Pqj7lS3z+2cH9k2ZeLAKF0FFHV6YgbDzVaQZsvuXOtCOlEEDeuXROtD8QHw==", "be1dced6-8b96-4642-84be-abbceb6b0ca9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfccbd35-ad89-4d0b-a442-7eae1cd08c21", "gadget@inspect.com", "GADGET@INSPECT.COM", "AQAAAAEAACcQAAAAENYA+iZfeV4h0jiXFWlqy/myjDgKHtKb0Bq10yFZrz+lpFLcZD7jM3NnpZ3m3bd3hw==", "59de415f-2adc-43f5-ac33-2b8e3dd9989b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18936402-a5a9-46b8-a574-950481eb52f9", "cop2@mall.com", "COP2@MALL.COM", "AQAAAAEAACcQAAAAEDeHAuYscaYbNEFM3bBRz5quxgau9dZP38PMSD92Suk0Gzb/Rlf36hZvrlfJ2VUUnw==", "328a734e-7a8b-4084-89f7-b6a5458ba470" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "893da19e-f55b-4fae-91fd-95e8e5e14117", "karen@qrid.com", "KAREN@QRID.COM", "AQAAAAEAACcQAAAAEA/DbABeK3XOU6ebP2ejyQTD4ja+xZ5e4dB+DhnARuTcuZpxr9vP4dmXtCyYC5fNwg==", "439cb13b-9457-43f7-9e71-2f21536bb949" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3d9f614-5d9c-461a-a899-951d4b73d383", "su@do.com", "SU@DO.COM", "AQAAAAEAACcQAAAAEI9jofx9UlllvAUKfuE+JOXi2/Ap1CVUzBh9QAvi0FVAQ+4f2MiIpCBeD8zeJMMUJw==", "89f8384c-bf24-4da3-b64f-19ea14892246" });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 6, 20, 56, 461, DateTimeKind.Utc).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 6, 20, 56, 461, DateTimeKind.Utc).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 6, 20, 56, 461, DateTimeKind.Utc).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 6, 20, 56, 461, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 6, 20, 56, 461, DateTimeKind.Utc).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 6, 20, 56, 461, DateTimeKind.Utc).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 6, 20, 56, 461, DateTimeKind.Utc).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 6, 20, 56, 461, DateTimeKind.Utc).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfAction",
                value: new DateTime(2023, 5, 22, 6, 20, 56, 461, DateTimeKind.Utc).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 4, 6, 20, 56, 461, DateTimeKind.Utc).AddTicks(9203), new DateTime(2023, 5, 2, 6, 20, 56, 461, DateTimeKind.Utc).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 10, 8, 44, 56, 461, DateTimeKind.Utc).AddTicks(9208), new DateTime(2023, 5, 10, 6, 20, 56, 461, DateTimeKind.Utc).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 11, 7, 32, 56, 461, DateTimeKind.Utc).AddTicks(9211), new DateTime(2023, 5, 11, 6, 20, 56, 461, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 17, 8, 44, 56, 461, DateTimeKind.Utc).AddTicks(9213), new DateTime(2023, 5, 17, 6, 20, 56, 461, DateTimeKind.Utc).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 20, 8, 44, 56, 461, DateTimeKind.Utc).AddTicks(9216), new DateTime(2023, 5, 20, 6, 20, 56, 461, DateTimeKind.Utc).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 19, 6, 20, 56, 461, DateTimeKind.Utc).AddTicks(9218), new DateTime(2023, 5, 18, 18, 20, 56, 461, DateTimeKind.Utc).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 44, 56, 461, DateTimeKind.Utc).AddTicks(9220), new DateTime(2023, 5, 19, 18, 20, 56, 461, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 20, 8, 44, 56, 461, DateTimeKind.Utc).AddTicks(9223), new DateTime(2023, 5, 20, 6, 20, 56, 461, DateTimeKind.Utc).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 20, 18, 20, 56, 461, DateTimeKind.Utc).AddTicks(9225), new DateTime(2023, 5, 20, 13, 32, 56, 461, DateTimeKind.Utc).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 21, 11, 8, 56, 461, DateTimeKind.Utc).AddTicks(9227), new DateTime(2023, 5, 21, 6, 20, 56, 461, DateTimeKind.Utc).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 21, 23, 8, 56, 461, DateTimeKind.Utc).AddTicks(9230), new DateTime(2023, 5, 21, 18, 20, 56, 461, DateTimeKind.Utc).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 22, 6, 20, 56, 461, DateTimeKind.Utc).AddTicks(9232), new DateTime(2023, 5, 21, 6, 20, 56, 461, DateTimeKind.Utc).AddTicks(9231) });
        }
    }
}
