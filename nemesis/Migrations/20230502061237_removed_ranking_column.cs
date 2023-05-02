using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class removed_ranking_column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ranking",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 14, 6, 12, 37, 530, DateTimeKind.Utc).AddTicks(6988), new DateTime(2023, 4, 12, 6, 12, 37, 530, DateTimeKind.Utc).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 20, 8, 36, 37, 530, DateTimeKind.Utc).AddTicks(6991), new DateTime(2023, 4, 20, 6, 12, 37, 530, DateTimeKind.Utc).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 21, 7, 24, 37, 530, DateTimeKind.Utc).AddTicks(6993), new DateTime(2023, 4, 21, 6, 12, 37, 530, DateTimeKind.Utc).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 27, 8, 36, 37, 530, DateTimeKind.Utc).AddTicks(6995), new DateTime(2023, 4, 27, 6, 12, 37, 530, DateTimeKind.Utc).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 30, 8, 36, 37, 530, DateTimeKind.Utc).AddTicks(6996), new DateTime(2023, 4, 30, 6, 12, 37, 530, DateTimeKind.Utc).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 29, 6, 12, 37, 530, DateTimeKind.Utc).AddTicks(6998), new DateTime(2023, 4, 28, 18, 12, 37, 530, DateTimeKind.Utc).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 29, 20, 36, 37, 530, DateTimeKind.Utc).AddTicks(6999), new DateTime(2023, 4, 29, 18, 12, 37, 530, DateTimeKind.Utc).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 30, 8, 36, 37, 530, DateTimeKind.Utc).AddTicks(7001), new DateTime(2023, 4, 30, 6, 12, 37, 530, DateTimeKind.Utc).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 12, 37, 530, DateTimeKind.Utc).AddTicks(7002), new DateTime(2023, 4, 30, 13, 24, 37, 530, DateTimeKind.Utc).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 1, 11, 0, 37, 530, DateTimeKind.Utc).AddTicks(7004), new DateTime(2023, 5, 1, 6, 12, 37, 530, DateTimeKind.Utc).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 1, 23, 0, 37, 530, DateTimeKind.Utc).AddTicks(7005), new DateTime(2023, 5, 1, 18, 12, 37, 530, DateTimeKind.Utc).AddTicks(7005) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ranking",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 13, 12, 36, 12, 25, DateTimeKind.Utc).AddTicks(9033), new DateTime(2023, 4, 11, 12, 36, 12, 25, DateTimeKind.Utc).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 19, 15, 0, 12, 25, DateTimeKind.Utc).AddTicks(9036), new DateTime(2023, 4, 19, 12, 36, 12, 25, DateTimeKind.Utc).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 20, 13, 48, 12, 25, DateTimeKind.Utc).AddTicks(9040), new DateTime(2023, 4, 20, 12, 36, 12, 25, DateTimeKind.Utc).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 26, 15, 0, 12, 25, DateTimeKind.Utc).AddTicks(9043), new DateTime(2023, 4, 26, 12, 36, 12, 25, DateTimeKind.Utc).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 29, 15, 0, 12, 25, DateTimeKind.Utc).AddTicks(9044), new DateTime(2023, 4, 29, 12, 36, 12, 25, DateTimeKind.Utc).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 36, 12, 25, DateTimeKind.Utc).AddTicks(9046), new DateTime(2023, 4, 28, 0, 36, 12, 25, DateTimeKind.Utc).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 29, 3, 0, 12, 25, DateTimeKind.Utc).AddTicks(9048), new DateTime(2023, 4, 29, 0, 36, 12, 25, DateTimeKind.Utc).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 29, 15, 0, 12, 25, DateTimeKind.Utc).AddTicks(9049), new DateTime(2023, 4, 29, 12, 36, 12, 25, DateTimeKind.Utc).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 30, 0, 36, 12, 25, DateTimeKind.Utc).AddTicks(9051), new DateTime(2023, 4, 29, 19, 48, 12, 25, DateTimeKind.Utc).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 30, 17, 24, 12, 25, DateTimeKind.Utc).AddTicks(9052), new DateTime(2023, 4, 30, 12, 36, 12, 25, DateTimeKind.Utc).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 5, 1, 5, 24, 12, 25, DateTimeKind.Utc).AddTicks(9054), new DateTime(2023, 5, 1, 0, 36, 12, 25, DateTimeKind.Utc).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Ranking",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Ranking",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Ranking",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Ranking",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Ranking",
                value: null);
        }
    }
}
