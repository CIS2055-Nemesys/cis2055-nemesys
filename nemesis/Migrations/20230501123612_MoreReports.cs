using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class MoreReports : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "CategoryId", "CreatedByUserId", "DateOfReport", "DateSpotted", "Description", "ImageUrl", "InvestigationId", "Location", "Status", "Title", "Upvotes" },
                values: new object[,]
                {
                    { 6, 6, 4, new DateTime(2023, 4, 28, 12, 36, 12, 25, DateTimeKind.Utc).AddTicks(9046), new DateTime(2023, 4, 28, 0, 36, 12, 25, DateTimeKind.Utc).AddTicks(9045), "I was taking a lovely stroll on the beach last night when suddenly, my partner noted that the ancient old god Cthulhu had manifested out of the sea, heralding the end of days for humanity", "/images/Cthulhu.jpg", null, "Ghar Lapsi", false, "Old God rises from the depths", 777 },
                    { 7, 2, 5, new DateTime(2023, 4, 29, 3, 0, 12, 25, DateTimeKind.Utc).AddTicks(9048), new DateTime(2023, 4, 29, 0, 36, 12, 25, DateTimeKind.Utc).AddTicks(9047), "We were having lunch at Zeppi's Diner last night when suddenly, a rodent the size of a car scurried out of the kitchen! I have to say it really put us off finishing the meal. I hope the food safety authorities see this post!", "/images/GiantRodent.jpg", null, "Hamrun", false, "Giant rodent", 246 },
                    { 8, 1, 5, new DateTime(2023, 4, 29, 15, 0, 12, 25, DateTimeKind.Utc).AddTicks(9049), new DateTime(2023, 4, 29, 12, 36, 12, 25, DateTimeKind.Utc).AddTicks(9049), "We went out for dinner at Fonzu's last night and were having a great time! Hats off to the guy who was playing the accordion with his feet. I ordered the special 'Fonzu's Burger' off the menu, and, to say the least, was shocked when the waitress brought it to the table. It was just a clump of greasy hair! I don't know who thought this was a good idea or how it passed any form of review! Talk about finding a hair in the food! ", "/images/HairBurger.jpeg", null, "Naxxar", false, "Hairy Burger", 52 },
                    { 9, 2, 3, new DateTime(2023, 4, 30, 0, 36, 12, 25, DateTimeKind.Utc).AddTicks(9051), new DateTime(2023, 4, 29, 19, 48, 12, 25, DateTimeKind.Utc).AddTicks(9050), "I was out shopping with the kids when we came across a passed out man in the middle of the sidewalk. Normally I wouldn't post something like this, because let's face it, we've all been there. However, what really bothered me was that he was snoring so loud it sounded like an entire trombone orchestra! Simply unacceptable!", "/images/ManPassedOut.jpg", null, "Bormla", false, "Passed out man", 120 },
                    { 10, 6, 4, new DateTime(2023, 4, 30, 17, 24, 12, 25, DateTimeKind.Utc).AddTicks(9052), new DateTime(2023, 4, 30, 12, 36, 12, 25, DateTimeKind.Utc).AddTicks(9052), "HOW IS THIS ACCEPTABLE!? MY FAVOURITE HEINZ BAKED BEANZ HAVE BEEN OUT OF STOCK FOR THE LAST 2 DAYS!??!1?111? HOW AM I SUPPOSED TO FEED MY CHILDREN A NUTRITIOUS BREAKFAST IF I DON'T HAVE ANY BEANZ! WHY AREN'T THERE ANY BEANZ!?!11?", "/images/MissingBeans.webp", null, "Mosta", false, "MISSING BEANZ", 345 },
                    { 11, 1, 5, new DateTime(2023, 5, 1, 5, 24, 12, 25, DateTimeKind.Utc).AddTicks(9054), new DateTime(2023, 5, 1, 0, 36, 12, 25, DateTimeKind.Utc).AddTicks(9053), "Like most of you, I buy my toilet paper from the gas station. I was disgusted this morning when some --redacted-- bought out the entire shop! Does this guy have ten --redacted--!? How am I supposed to wipe my --redacted-- without any toilet paper?!", "/images/ToiletPaperHoarder", null, "Mosta", false, "Toilet Paper Hoarder", 498 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 10, 7, 31, 32, 550, DateTimeKind.Utc).AddTicks(4089), new DateTime(2023, 4, 8, 7, 31, 32, 550, DateTimeKind.Utc).AddTicks(4088) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 16, 9, 55, 32, 550, DateTimeKind.Utc).AddTicks(4091), new DateTime(2023, 4, 16, 7, 31, 32, 550, DateTimeKind.Utc).AddTicks(4090) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 17, 8, 43, 32, 550, DateTimeKind.Utc).AddTicks(4094), new DateTime(2023, 4, 17, 7, 31, 32, 550, DateTimeKind.Utc).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 23, 9, 55, 32, 550, DateTimeKind.Utc).AddTicks(4085), new DateTime(2023, 4, 23, 7, 31, 32, 550, DateTimeKind.Utc).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfReport", "DateSpotted" },
                values: new object[] { new DateTime(2023, 4, 26, 9, 55, 32, 550, DateTimeKind.Utc).AddTicks(4092), new DateTime(2023, 4, 26, 7, 31, 32, 550, DateTimeKind.Utc).AddTicks(4092) });
        }
    }
}
