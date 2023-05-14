using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class passwordsForSeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a525ac-d446-4c8c-983c-047afdffed13",
                column: "ConcurrencyStamp",
                value: "f58229bf-9c71-4824-abe6-d26e33cba99b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca95d41-370a-4218-b0aa-8502494448fb",
                column: "ConcurrencyStamp",
                value: "21c70162-952e-4284-85b7-8d81544747be");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3303fdaf-f438-4582-8f10-52b578c50cb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd99fc73-e793-4a2d-bb69-c8ad6ede35fd", "AQAAAAEAACcQAAAAEMJ5UwOTwO7aZw+NfPANCT2a+Fe96Q+V0kVrdIir/gwqY2mPPu3xDAmH8IupxajTJA==", "9a780cb6-923d-4ee9-b74f-dcd666e6a350" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30fe9224-d473-4376-983f-fa35020db96a", "AQAAAAEAACcQAAAAEL/JjLX3SY16ojByQLlze3t3dZWEgthSFEMcok3KlTevv24AIucbPyizb3fymdg5ZA==", "e684d78b-c5db-4b78-8269-e4982fb2c566" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64a5155c-89a5-4bf8-af37-224ffa2cf88b", "AQAAAAEAACcQAAAAEC63adcbXpA2uNQ1RzaNFxy7BUFV9NGEaXsXQ5QDr26NbBs1NgMh/xjqxCPrBDSf7Q==", "e70654e7-52f5-45bc-a316-229e15757089" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6f084c8-8f39-4467-8657-06b1cdb17b42", "AQAAAAEAACcQAAAAEFBqWBMZgBlqj5JKRR9G7buBpiais8NbI3Gn9FR0gVNfYgWURh93L6kWV13Pl3qmYg==", "443a5831-7bf6-480d-a0fc-0dde5780284a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d13e418-cb53-4748-993c-c747332a434d", "AQAAAAEAACcQAAAAELwc88T5LU0xh2KxrR4Xj/nMZggyWgtWNM+R6Mtg2Gaeodd102yLWjlK5k/4ckJzEA==", "5ae6e3a4-797e-4c8c-b6a1-497450437f15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39d74c72-c3ec-42aa-acd8-27a9f617d83e", "AQAAAAEAACcQAAAAEGuCc/8tmxlJgCg6rj4BmGsUkpUKiWchY9Lz+zhmhJlilOk1RIvfope8DkCdxsm8sg==", "720f9488-b9c9-4838-90cf-480a7b66547d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7329fdee-067e-4836-bf64-d24d5be4f72a", "AQAAAAEAACcQAAAAEIOmJ3KVPRlfHlXcomQkMTCRvqgpxI/h/wRSL5p35bYpD7sOjgXofred+09fUa9DQw==", "621737f8-e431-42cd-814e-3a769b42a9eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea719d34-c996-4249-9df8-74398a7489d8", "AQAAAAEAACcQAAAAEAxOwZLCuHWzmFtmGMe+vUTLSOuh+ieVsdOc13b7KYrlkja7ZtHNki9rz9NCNiWqsg==", "f6c28d06-3b57-485c-9183-9ddc728dc836" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1d480f1-4fc7-4828-adf3-1874c147a1c3", "AQAAAAEAACcQAAAAECDQssnR+jwWMidJ68YBFDnGS5pL4Lo9Tj1nVqKa/WOPiQnrcwzBLEwB9yZlpxZ04w==", "028a6809-cc5d-4c93-bef8-4eb1461f3428" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 26, 8, 51, 10, 434, DateTimeKind.Utc).AddTicks(1748), new DateTime(2023, 4, 24, 8, 51, 10, 434, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 2, 11, 15, 10, 434, DateTimeKind.Utc).AddTicks(1752), new DateTime(2023, 5, 2, 8, 51, 10, 434, DateTimeKind.Utc).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 10, 3, 10, 434, DateTimeKind.Utc).AddTicks(1754), new DateTime(2023, 5, 3, 8, 51, 10, 434, DateTimeKind.Utc).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 15, 10, 434, DateTimeKind.Utc).AddTicks(1756), new DateTime(2023, 5, 9, 8, 51, 10, 434, DateTimeKind.Utc).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 12, 11, 15, 10, 434, DateTimeKind.Utc).AddTicks(1758), new DateTime(2023, 5, 12, 8, 51, 10, 434, DateTimeKind.Utc).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 11, 8, 51, 10, 434, DateTimeKind.Utc).AddTicks(1760), new DateTime(2023, 5, 10, 20, 51, 10, 434, DateTimeKind.Utc).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 11, 23, 15, 10, 434, DateTimeKind.Utc).AddTicks(1761), new DateTime(2023, 5, 11, 20, 51, 10, 434, DateTimeKind.Utc).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 12, 11, 15, 10, 434, DateTimeKind.Utc).AddTicks(1764), new DateTime(2023, 5, 12, 8, 51, 10, 434, DateTimeKind.Utc).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 51, 10, 434, DateTimeKind.Utc).AddTicks(1765), new DateTime(2023, 5, 12, 16, 3, 10, 434, DateTimeKind.Utc).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 13, 13, 39, 10, 434, DateTimeKind.Utc).AddTicks(1767), new DateTime(2023, 5, 13, 8, 51, 10, 434, DateTimeKind.Utc).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 14, 1, 39, 10, 434, DateTimeKind.Utc).AddTicks(1769), new DateTime(2023, 5, 13, 20, 51, 10, 434, DateTimeKind.Utc).AddTicks(1769) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 14, 8, 51, 10, 434, DateTimeKind.Utc).AddTicks(1771), new DateTime(2023, 5, 13, 8, 51, 10, 434, DateTimeKind.Utc).AddTicks(1770) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1622921a-fc91-40cd-9c52-96bb4e7ba658", null, "df3dea03-749c-429a-b395-f255b93f4d75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555e52b8-22db-4c15-a037-107016c7f827",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a75fd789-0f46-4327-8e57-0dd141363029", null, "7a176ccd-e386-48ec-acd1-36a488068fea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7010ec1-2a55-4754-8627-15393a44a6f2", null, "aa39383c-3e07-441b-bde0-35e27c369b55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7debb255-a970-4d67-b01c-fcbd92d28246", null, "3c696e0b-8dff-448c-aa99-5bd2f82958da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b91c9f-74d1-452d-927b-439bfd3a7287",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62c5f6f8-1395-427e-8196-bf5411188daf", null, "8aad40f7-0e8a-4518-9e6a-dd1f6816593e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9059e247-2854-40bd-af2b-76088f8dd4e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd156388-3530-4928-bce4-38f1831729cc", null, "2acee0b0-986c-4be9-9534-39877f1d1e33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b724e597-5eef-41cc-bd97-0bccba7f9e88", null, "d470242f-95c3-4a92-9793-c657de6c7e94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad9a20a1-779e-4991-8881-9af6171668a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e68f68c8-62c9-4b55-a90c-c1606b9ca356", null, "d242455e-1f4f-4834-ae15-a26403f9cf97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2db57347-092f-4d36-a27a-c2c7e0b8fe33", null, "f9444981-d3fc-46ca-b902-6d632204d4cb" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 23, 18, 57, 16, 819, DateTimeKind.Utc).AddTicks(7039), new DateTime(2023, 4, 21, 18, 57, 16, 819, DateTimeKind.Utc).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 29, 21, 21, 16, 819, DateTimeKind.Utc).AddTicks(7042), new DateTime(2023, 4, 29, 18, 57, 16, 819, DateTimeKind.Utc).AddTicks(7041) });

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
        }
    }
}
