using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class Downvotes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a525ac-d446-4c8c-983c-047afdffed13",
                column: "ConcurrencyStamp",
                value: "f64c0f21-6c08-4bb5-87fd-a4fb3be02ade");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca95d41-370a-4218-b0aa-8502494448fb",
                column: "ConcurrencyStamp",
                value: "57e8fbdb-9ca8-4fd5-b6ad-56b56f99fed5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69b67ddc-ac4e-48fc-8cc1-2d70d2ef8d77", "AQAAAAEAACcQAAAAENy+F3BhBclcrg1e25ZtuWzBAK597cCg5hyYggPxTH6o5YX6hBR0pX/hADv5+1Ejqg==", "7d64b1ea-5817-4768-a178-eab7d4a1a375" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f14f5ed-262f-4827-ae1e-7a1acf537e9e", "AQAAAAEAACcQAAAAED9sLQUiOuF8ASWJQCgQv0d2emAN1MbTVuJAjlEHCDXsSzYrepKtMJM3jGDLsJLKfQ==", "1e5e7717-3034-4f80-b73b-c58e03c22b8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7231873-5b2e-4577-a418-e3a61f27733a", "AQAAAAEAACcQAAAAENvwzQDupZQt3O3QYn63yOFS7aUFjHPzCUA/Q0lacDJfOGOIQRP1CyeygEac3uUIHA==", "4e9a4236-f97b-48e7-a059-fcc67bd33f26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f92bb13-5f5d-4090-ad74-7d3c40bc15e5", "AQAAAAEAACcQAAAAEOqawNmn2H3o8QMA8oyLwBMqyiiy1SACU6bBkqQv9K55YiqkkZIy2A425iLuF0XBGg==", "3e9b8b6f-b885-4ff0-8c99-fa491b7bab04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8e49e76-848e-469c-abc5-c140a772a747", "AQAAAAEAACcQAAAAEIRDeVAXOA4xi6Z752w2UzZjnnyBzTAIMnatJObS7S84+HKm5j4VSaRZKMnseRKlpQ==", "468c8ba3-b8df-45fd-aa97-c4c67dd7c01a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa3c3e95-6040-478c-9d86-e61b8fb0c4f1", "AQAAAAEAACcQAAAAEMYx+WoLemP69Qg9c9vRnlKxjWuxoUfsISn+WIf+yWZUoumWohZF4ONuLhsH5XKs7A==", "37a7a15f-e3c9-490c-bbba-a60004025eb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7957117c-7909-40c7-8f5d-266a0c290944", "AQAAAAEAACcQAAAAEA1ecs3XxpzxsCa2yMUeYR1UXkAbO5bbR8ADGzI62dmIVLVsq0c6DBNRe9aWhK9pHg==", "251bb846-b93d-4f82-8e62-a09facd81cf9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9068b66c-8391-43af-89a7-83cfb681ea9e", "AQAAAAEAACcQAAAAEC6Ad2L92quYiSaIf0USLpWglzxVIwo/8luywsp3bwXSEGkgHWQidranB0hsCaMReg==", "de6d12b1-823e-49c1-98dc-205f99a169c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58909858-da46-4117-98f3-f3094341dad8", "AQAAAAEAACcQAAAAELfXOuevoH6PpvF2nf42kqntbi6S0VgvgyPOrF1Y98HnsOLmhzEU6U3qDe3Z1GPJFg==", "d7c8de98-0487-40b8-9d6e-51ecfabab9f6" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 29, 7, 52, 10, 788, DateTimeKind.Utc).AddTicks(8947), new DateTime(2023, 4, 27, 7, 52, 10, 788, DateTimeKind.Utc).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 5, 10, 16, 10, 788, DateTimeKind.Utc).AddTicks(8951), new DateTime(2023, 5, 5, 7, 52, 10, 788, DateTimeKind.Utc).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 6, 9, 4, 10, 788, DateTimeKind.Utc).AddTicks(8953), new DateTime(2023, 5, 6, 7, 52, 10, 788, DateTimeKind.Utc).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 12, 10, 16, 10, 788, DateTimeKind.Utc).AddTicks(8954), new DateTime(2023, 5, 12, 7, 52, 10, 788, DateTimeKind.Utc).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 15, 10, 16, 10, 788, DateTimeKind.Utc).AddTicks(8956), new DateTime(2023, 5, 15, 7, 52, 10, 788, DateTimeKind.Utc).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 14, 7, 52, 10, 788, DateTimeKind.Utc).AddTicks(8958), new DateTime(2023, 5, 13, 19, 52, 10, 788, DateTimeKind.Utc).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 14, 22, 16, 10, 788, DateTimeKind.Utc).AddTicks(8959), new DateTime(2023, 5, 14, 19, 52, 10, 788, DateTimeKind.Utc).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 15, 10, 16, 10, 788, DateTimeKind.Utc).AddTicks(8961), new DateTime(2023, 5, 15, 7, 52, 10, 788, DateTimeKind.Utc).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 15, 19, 52, 10, 788, DateTimeKind.Utc).AddTicks(8963), new DateTime(2023, 5, 15, 15, 4, 10, 788, DateTimeKind.Utc).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 16, 12, 40, 10, 788, DateTimeKind.Utc).AddTicks(8965), new DateTime(2023, 5, 16, 7, 52, 10, 788, DateTimeKind.Utc).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 17, 0, 40, 10, 788, DateTimeKind.Utc).AddTicks(8966), new DateTime(2023, 5, 16, 19, 52, 10, 788, DateTimeKind.Utc).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 17, 7, 52, 10, 788, DateTimeKind.Utc).AddTicks(8969), new DateTime(2023, 5, 16, 7, 52, 10, 788, DateTimeKind.Utc).AddTicks(8969) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a525ac-d446-4c8c-983c-047afdffed13",
                column: "ConcurrencyStamp",
                value: "8b6b3fd3-df4b-4588-8a49-1decb485511c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca95d41-370a-4218-b0aa-8502494448fb",
                column: "ConcurrencyStamp",
                value: "2b11e6c9-ab40-4afe-ab77-8367cb35fa1a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "685c3342-0c5a-40ad-bb54-d44cc96690f9", "AQAAAAEAACcQAAAAECwZQgUstm6fd33G9vdZVZC1XnvAnos4xBJWjfcL+xYx4aKbJ8CmhfMwnsPDVxeQDg==", "1d15e3e9-a0a7-434e-a3c6-e4d8a0aa629b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d355f2e8-d1d2-4c38-8af4-1c4738c5cbc9", "AQAAAAEAACcQAAAAEBAWmLZYTyMb/4Roxw3iCyjOtRSUtV9IOF54Racfgf+JpgjZSC7FS/GIDC7oBjpygQ==", "e87ae9d0-f551-45f4-8e48-a3774fd1cefd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7537c3c8-b8c4-4a6d-afc6-8d73f8ff9809", "AQAAAAEAACcQAAAAEACPhgKC37f6yGri2zM9wFpYRkZlxvI5Vc+I2IXQSU2uc3c7ZgVZ8fAbsa2Khn3OKw==", "0488d535-8c41-42c3-9e9e-66dc189da283" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b36804fc-a77d-4312-993c-c682050f5ed2", "AQAAAAEAACcQAAAAEAqhIyJZDEQnJkbZur+GRXbuBlAoajY998NVfOA4ZCqkrJlQLVJ1gFpJ8VfhQZNC1w==", "d5565884-2390-4bfd-8a08-996009036aa1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "471fbf6d-efd4-4a8d-94e3-1ba7f3a6165b", "AQAAAAEAACcQAAAAEDYgKNoXv6MNAsUaJLVALYn8X73N0naS4G8OOReOWSRk9GZZ7+rLePx5bRhnQR26tw==", "5681970f-9a10-4aa0-a47c-bd8d21ec9da4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d153934-ab73-41e2-a7a5-d4dc9ed074df", "AQAAAAEAACcQAAAAEAwrpCd1zRaOoo4ZMw7vc2rwqrxSHFSD6C1ITgp5NX+ct0IWziFKxF+1d5RGnfhc+w==", "535f8f62-4366-4d03-8000-d45b59e7077e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08a720ce-9b9b-407b-9a24-904c2f558f57", "AQAAAAEAACcQAAAAECXpwH65PgikAoa50ZmPMWA4BR4WUlBkn3YcvK4GbvQu5/K/rdmJs+ah55JDQqhv0Q==", "64851a26-b4ce-4326-83ec-f8fe04ddc075" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3a26b59-9959-4c9e-a9ff-6c8197724631", "AQAAAAEAACcQAAAAECvOUJMtpKuNmxlOZ3QyE/ysfbsdqSkjlh/KCcxvYu/6ukegus9uq3UNxccmc126PQ==", "42a2bba1-5b7e-43fe-bc72-24370ca476ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35186923-e72f-4485-bb80-4bf410c11f40", "AQAAAAEAACcQAAAAEBIuAWGIPvFWunlSE1nHx/HgBt7NhugRPul36/nHmFw6jPJo/Y+ymUa1m5vYgsiefg==", "0b933a59-ce08-42bc-b88f-569450863b44" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 29, 6, 41, 22, 982, DateTimeKind.Utc).AddTicks(6633), new DateTime(2023, 4, 27, 6, 41, 22, 982, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 5, 9, 5, 22, 982, DateTimeKind.Utc).AddTicks(6638), new DateTime(2023, 5, 5, 6, 41, 22, 982, DateTimeKind.Utc).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 6, 7, 53, 22, 982, DateTimeKind.Utc).AddTicks(6640), new DateTime(2023, 5, 6, 6, 41, 22, 982, DateTimeKind.Utc).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 12, 9, 5, 22, 982, DateTimeKind.Utc).AddTicks(6642), new DateTime(2023, 5, 12, 6, 41, 22, 982, DateTimeKind.Utc).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 15, 9, 5, 22, 982, DateTimeKind.Utc).AddTicks(6644), new DateTime(2023, 5, 15, 6, 41, 22, 982, DateTimeKind.Utc).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 14, 6, 41, 22, 982, DateTimeKind.Utc).AddTicks(6646), new DateTime(2023, 5, 13, 18, 41, 22, 982, DateTimeKind.Utc).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 14, 21, 5, 22, 982, DateTimeKind.Utc).AddTicks(6647), new DateTime(2023, 5, 14, 18, 41, 22, 982, DateTimeKind.Utc).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 15, 9, 5, 22, 982, DateTimeKind.Utc).AddTicks(6649), new DateTime(2023, 5, 15, 6, 41, 22, 982, DateTimeKind.Utc).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 41, 22, 982, DateTimeKind.Utc).AddTicks(6650), new DateTime(2023, 5, 15, 13, 53, 22, 982, DateTimeKind.Utc).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 29, 22, 982, DateTimeKind.Utc).AddTicks(6652), new DateTime(2023, 5, 16, 6, 41, 22, 982, DateTimeKind.Utc).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 16, 23, 29, 22, 982, DateTimeKind.Utc).AddTicks(6655), new DateTime(2023, 5, 16, 18, 41, 22, 982, DateTimeKind.Utc).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 17, 6, 41, 22, 982, DateTimeKind.Utc).AddTicks(6657), new DateTime(2023, 5, 16, 6, 41, 22, 982, DateTimeKind.Utc).AddTicks(6656) });
        }
    }
}
