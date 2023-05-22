using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class PhoneNum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNum",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNum",
                table: "Investigations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a525ac-d446-4c8c-983c-047afdffed13",
                column: "ConcurrencyStamp",
                value: "9e583356-553a-4c4c-bd5d-f2ef6ba81afc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca95d41-370a-4218-b0aa-8502494448fb",
                column: "ConcurrencyStamp",
                value: "881b6aac-29b8-4b3f-91b8-879ad79d9828");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "186a680a-d4c2-4e7b-9185-c1464573dca0", "AQAAAAEAACcQAAAAEOvFmF24f4nZMKvUIcNVh7uf1lv5MblKlcG1NWiTTlF7VunFl09SkiXHqiZ/IKZ2tA==", "29a0f14d-0d3c-40ef-a521-cd64489f837e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c03f142-52e4-4f5e-b0be-9918fb8ba0a8", "AQAAAAEAACcQAAAAEO8Z5cNC6rGK6+AT6Y9knpibtWxlkA1eAnq4J1CLsTPyAVcOCvjIfi57jMRRNIQcqA==", "6ed04027-55c2-481d-85cf-2b6471d906af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35ac1d29-fc53-4ac1-89a2-52f61772022d", "AQAAAAEAACcQAAAAEDUpX8+Cpz1dpR/q6hlK849MW+BNyiafpOAPWGzCsKsMX3FgRxDtgmAM3pa9SjFBaA==", "adae5b11-a683-48c1-ab50-8cdbfaac9225" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c4cb951-1003-4d82-aec5-c88795971caf", "AQAAAAEAACcQAAAAEIf4yHtiLxJWlAZKilsq+syLEa0np5iL8EyQ3Hx80hmLOA2EieB/1YiBNVxsQwfNow==", "b52a0213-c8f6-44cc-91b7-8013e8dbad66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f642aba-8181-4789-9a38-08f710b0f234", "AQAAAAEAACcQAAAAEO2ir/T5l4pTVPelZ/Iyep7fdDJUFEfEqCXgApzocdq6BCPy1QMgGknIIrM3bjApFA==", "077cb900-def5-4603-b278-0d598b834fdc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7b8305c-fd3e-485a-a04a-006f2443efd9", "AQAAAAEAACcQAAAAEDbwCMWnVATcnyaYBvvirLuZB9zUhmnT0ufyI19+yzw6KpkmMq5wGsQysInuM/XO/Q==", "11573319-e686-4afd-9a44-e31da4a4c0c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cf947bc-28e4-44d7-963e-da9d79b54214", "AQAAAAEAACcQAAAAEDmFl/80JwWh6JsHqkKejxcYPelsCb0syOwdMb1V6/RhKBBSlGS+KtELcskBgMUdYg==", "f673fc2b-5938-419b-a1fb-83847693b96e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb79622f-c7c4-405b-8d57-f2ebb03b2ab0", "AQAAAAEAACcQAAAAEKSbU3cJFr4D47oivRIz1rmAN1n3/p9VR9KKOsMkZp7DEpBKO/WuKczG7E/9cOI/aQ==", "efc0189c-7793-4397-b600-a944c665dbcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e7a6c15-9817-4410-a81d-ac69d6cac17e", "AQAAAAEAACcQAAAAECxoJtl7+2BVh1JTxpLyuywk5iJXst2QYXOlgUt3m/eGsihOvQF08hm+xG6BDha/Qg==", "43f3c29c-7684-490b-86fd-6c2463ae1463" });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfAction", "PhoneNum" },
                values: new object[] { new DateTime(2023, 5, 22, 10, 20, 27, 522, DateTimeKind.Utc).AddTicks(6891), "No Phone number available" });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfAction", "PhoneNum" },
                values: new object[] { new DateTime(2023, 5, 22, 10, 20, 27, 522, DateTimeKind.Utc).AddTicks(6893), "No Phone number available" });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfAction", "PhoneNum" },
                values: new object[] { new DateTime(2023, 5, 22, 10, 20, 27, 522, DateTimeKind.Utc).AddTicks(6895), "No Phone number available" });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfAction", "PhoneNum" },
                values: new object[] { new DateTime(2023, 5, 22, 10, 20, 27, 522, DateTimeKind.Utc).AddTicks(6896), "No Phone number available" });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfAction", "PhoneNum" },
                values: new object[] { new DateTime(2023, 5, 22, 10, 20, 27, 522, DateTimeKind.Utc).AddTicks(6897), "No Phone number available" });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfAction", "PhoneNum" },
                values: new object[] { new DateTime(2023, 5, 22, 10, 20, 27, 522, DateTimeKind.Utc).AddTicks(6898), "No Phone number available" });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfAction", "PhoneNum" },
                values: new object[] { new DateTime(2023, 5, 22, 10, 20, 27, 522, DateTimeKind.Utc).AddTicks(6899), "No Phone number available" });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfAction", "PhoneNum" },
                values: new object[] { new DateTime(2023, 5, 22, 10, 20, 27, 522, DateTimeKind.Utc).AddTicks(6900), "No Phone number available" });

            migrationBuilder.UpdateData(
                table: "Investigations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfAction", "PhoneNum" },
                values: new object[] { new DateTime(2023, 5, 22, 10, 20, 27, 522, DateTimeKind.Utc).AddTicks(6901), "No Phone number available" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted", "PhoneNum" },
                values: new object[] { new DateTime(2023, 5, 4, 10, 20, 27, 522, DateTimeKind.Utc).AddTicks(6922), new DateTime(2023, 5, 2, 10, 20, 27, 522, DateTimeKind.Utc).AddTicks(6917), "No Phone number available" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted", "PhoneNum" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 44, 27, 522, DateTimeKind.Utc).AddTicks(6925), new DateTime(2023, 5, 10, 10, 20, 27, 522, DateTimeKind.Utc).AddTicks(6925), "No Phone number available" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted", "PhoneNum" },
                values: new object[] { new DateTime(2023, 5, 11, 11, 32, 27, 522, DateTimeKind.Utc).AddTicks(6928), new DateTime(2023, 5, 11, 10, 20, 27, 522, DateTimeKind.Utc).AddTicks(6927), "No Phone number available" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted", "PhoneNum" },
                values: new object[] { new DateTime(2023, 5, 17, 12, 44, 27, 522, DateTimeKind.Utc).AddTicks(6930), new DateTime(2023, 5, 17, 10, 20, 27, 522, DateTimeKind.Utc).AddTicks(6929), "No Phone number available" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted", "PhoneNum" },
                values: new object[] { new DateTime(2023, 5, 20, 12, 44, 27, 522, DateTimeKind.Utc).AddTicks(6932), new DateTime(2023, 5, 20, 10, 20, 27, 522, DateTimeKind.Utc).AddTicks(6932), "No Phone number available" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted", "PhoneNum" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 20, 27, 522, DateTimeKind.Utc).AddTicks(6934), new DateTime(2023, 5, 18, 22, 20, 27, 522, DateTimeKind.Utc).AddTicks(6933), "No Phone number available" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted", "PhoneNum" },
                values: new object[] { new DateTime(2023, 5, 20, 0, 44, 27, 522, DateTimeKind.Utc).AddTicks(6987), new DateTime(2023, 5, 19, 22, 20, 27, 522, DateTimeKind.Utc).AddTicks(6986), "No Phone number available" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted", "PhoneNum" },
                values: new object[] { new DateTime(2023, 5, 20, 12, 44, 27, 522, DateTimeKind.Utc).AddTicks(6989), new DateTime(2023, 5, 20, 10, 20, 27, 522, DateTimeKind.Utc).AddTicks(6989), "No Phone number available" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted", "PhoneNum" },
                values: new object[] { new DateTime(2023, 5, 20, 22, 20, 27, 522, DateTimeKind.Utc).AddTicks(6991), new DateTime(2023, 5, 20, 17, 32, 27, 522, DateTimeKind.Utc).AddTicks(6991), "No Phone number available" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted", "PhoneNum" },
                values: new object[] { new DateTime(2023, 5, 21, 15, 8, 27, 522, DateTimeKind.Utc).AddTicks(6993), new DateTime(2023, 5, 21, 10, 20, 27, 522, DateTimeKind.Utc).AddTicks(6992), "No Phone number available" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted", "PhoneNum" },
                values: new object[] { new DateTime(2023, 5, 22, 3, 8, 27, 522, DateTimeKind.Utc).AddTicks(6995), new DateTime(2023, 5, 21, 22, 20, 27, 522, DateTimeKind.Utc).AddTicks(6994), "No Phone number available" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted", "PhoneNum" },
                values: new object[] { new DateTime(2023, 5, 22, 10, 20, 27, 522, DateTimeKind.Utc).AddTicks(6996), new DateTime(2023, 5, 21, 10, 20, 27, 522, DateTimeKind.Utc).AddTicks(6996), "No Phone number available" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNum",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "PhoneNum",
                table: "Investigations");

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
