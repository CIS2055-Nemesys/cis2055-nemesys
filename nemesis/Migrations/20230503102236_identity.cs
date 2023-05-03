using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 15, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1416), new DateTime(2023, 4, 13, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1405) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 46, 36, 71, DateTimeKind.Utc).AddTicks(1531), new DateTime(2023, 4, 21, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 22, 11, 34, 36, 71, DateTimeKind.Utc).AddTicks(1538), new DateTime(2023, 4, 22, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 46, 36, 71, DateTimeKind.Utc).AddTicks(1542), new DateTime(2023, 4, 28, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 46, 36, 71, DateTimeKind.Utc).AddTicks(1545), new DateTime(2023, 5, 1, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 30, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1549), new DateTime(2023, 4, 29, 22, 22, 36, 71, DateTimeKind.Utc).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 1, 0, 46, 36, 71, DateTimeKind.Utc).AddTicks(1556), new DateTime(2023, 4, 30, 22, 22, 36, 71, DateTimeKind.Utc).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 46, 36, 71, DateTimeKind.Utc).AddTicks(1560), new DateTime(2023, 5, 1, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 1, 22, 22, 36, 71, DateTimeKind.Utc).AddTicks(1564), new DateTime(2023, 5, 1, 17, 34, 36, 71, DateTimeKind.Utc).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 2, 15, 10, 36, 71, DateTimeKind.Utc).AddTicks(1568), new DateTime(2023, 5, 2, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 3, 10, 36, 71, DateTimeKind.Utc).AddTicks(1572), new DateTime(2023, 5, 2, 22, 22, 36, 71, DateTimeKind.Utc).AddTicks(1571) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 15, 10, 7, 17, 291, DateTimeKind.Utc).AddTicks(9561), new DateTime(2023, 4, 13, 10, 7, 17, 291, DateTimeKind.Utc).AddTicks(9549) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 31, 17, 291, DateTimeKind.Utc).AddTicks(9568), new DateTime(2023, 4, 21, 10, 7, 17, 291, DateTimeKind.Utc).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 22, 11, 19, 17, 291, DateTimeKind.Utc).AddTicks(9573), new DateTime(2023, 4, 22, 10, 7, 17, 291, DateTimeKind.Utc).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 31, 17, 291, DateTimeKind.Utc).AddTicks(9577), new DateTime(2023, 4, 28, 10, 7, 17, 291, DateTimeKind.Utc).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 31, 17, 291, DateTimeKind.Utc).AddTicks(9581), new DateTime(2023, 5, 1, 10, 7, 17, 291, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 30, 10, 7, 17, 291, DateTimeKind.Utc).AddTicks(9585), new DateTime(2023, 4, 29, 22, 7, 17, 291, DateTimeKind.Utc).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 1, 0, 31, 17, 291, DateTimeKind.Utc).AddTicks(9589), new DateTime(2023, 4, 30, 22, 7, 17, 291, DateTimeKind.Utc).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 31, 17, 291, DateTimeKind.Utc).AddTicks(9593), new DateTime(2023, 5, 1, 10, 7, 17, 291, DateTimeKind.Utc).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 1, 22, 7, 17, 291, DateTimeKind.Utc).AddTicks(9597), new DateTime(2023, 5, 1, 17, 19, 17, 291, DateTimeKind.Utc).AddTicks(9596) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 2, 14, 55, 17, 291, DateTimeKind.Utc).AddTicks(9601), new DateTime(2023, 5, 2, 10, 7, 17, 291, DateTimeKind.Utc).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 3, 2, 55, 17, 291, DateTimeKind.Utc).AddTicks(9605), new DateTime(2023, 5, 2, 22, 7, 17, 291, DateTimeKind.Utc).AddTicks(9604) });
        }
    }
}
