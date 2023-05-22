using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class toiletPaperFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77e8e86e-8851-4b85-bead-2b3e8cf4b5cc", "AQAAAAEAACcQAAAAEGJrHIFlhzyx496AyaH2FoYPJ/OLnF6g4csPiwEqbZ/Qk5op1reCAaLrI8smLVjgnw==", "5af1c28b-9afb-4118-8a48-1bbcded73786" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8a93a2b-f27b-4cbd-a8ac-a901575000b3", "AQAAAAEAACcQAAAAEKNnTyCE6Ng7cGVZg64kzFdMi1qnVzFCmK+NjrPkUpSakI5EU03F3rUD3azgDV6gjw==", "ee0b1d3a-057f-4383-a0be-b3c9a06d8094" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfe1389b-4a92-4b69-9b82-da1d016a9bbe", "AQAAAAEAACcQAAAAEKEA4h4KS7PY2MnXgGeNWlLB3Y+R81ScB/9FG80ihaeULa0JvXE/kj+rPUNW9KJ+iA==", "d59041de-7773-435b-bcec-d116c9f0899d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bccf172-8d97-4a3c-9bc1-67a8844e5619", "AQAAAAEAACcQAAAAED92LYpcP2kxer8idz9e13a6gaNP+owbZ9zEBZjOWU9rbaWEsg7Ca77C/Lx8a0XrlQ==", "f53e6a9d-ca3e-4347-bf1f-e8a73d086dc2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d2b71ff-a50b-4f72-a491-44409127fcee", "AQAAAAEAACcQAAAAEABEgR2Pqj7lS3z+2cH9k2ZeLAKF0FFHV6YgbDzVaQZsvuXOtCOlEEDeuXROtD8QHw==", "be1dced6-8b96-4642-84be-abbceb6b0ca9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfccbd35-ad89-4d0b-a442-7eae1cd08c21", "AQAAAAEAACcQAAAAENYA+iZfeV4h0jiXFWlqy/myjDgKHtKb0Bq10yFZrz+lpFLcZD7jM3NnpZ3m3bd3hw==", "59de415f-2adc-43f5-ac33-2b8e3dd9989b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18936402-a5a9-46b8-a574-950481eb52f9", "AQAAAAEAACcQAAAAEDeHAuYscaYbNEFM3bBRz5quxgau9dZP38PMSD92Suk0Gzb/Rlf36hZvrlfJ2VUUnw==", "328a734e-7a8b-4084-89f7-b6a5458ba470" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "893da19e-f55b-4fae-91fd-95e8e5e14117", "AQAAAAEAACcQAAAAEA/DbABeK3XOU6ebP2ejyQTD4ja+xZ5e4dB+DhnARuTcuZpxr9vP4dmXtCyYC5fNwg==", "439cb13b-9457-43f7-9e71-2f21536bb949" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3d9f614-5d9c-461a-a899-951d4b73d383", "AQAAAAEAACcQAAAAEI9jofx9UlllvAUKfuE+JOXi2/Ap1CVUzBh9QAvi0FVAQ+4f2MiIpCBeD8zeJMMUJw==", "89f8384c-bf24-4da3-b64f-19ea14892246" });

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
                columns: new[] { "DateOfReport", "DateSpotted", "ImageUrl" },
                values: new object[] { new DateTime(2023, 5, 21, 23, 8, 56, 461, DateTimeKind.Utc).AddTicks(9230), new DateTime(2023, 5, 21, 18, 20, 56, 461, DateTimeKind.Utc).AddTicks(9229), "/images/ToiletPaper.jpg" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 22, 6, 20, 56, 461, DateTimeKind.Utc).AddTicks(9232), new DateTime(2023, 5, 21, 6, 20, 56, 461, DateTimeKind.Utc).AddTicks(9231) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "DateOfReport", "DateSpotted", "ImageUrl" },
                values: new object[] { new DateTime(2023, 5, 21, 23, 5, 24, 21, DateTimeKind.Utc).AddTicks(2085), new DateTime(2023, 5, 21, 18, 17, 24, 21, DateTimeKind.Utc).AddTicks(2084), "/images/ToiletPaperHoarder.jpg" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 22, 6, 17, 24, 21, DateTimeKind.Utc).AddTicks(2088), new DateTime(2023, 5, 21, 6, 17, 24, 21, DateTimeKind.Utc).AddTicks(2087) });
        }
    }
}
