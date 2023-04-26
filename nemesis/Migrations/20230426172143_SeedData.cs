using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Uncategorised" },
                    { 2, "Unsafe act" },
                    { 3, "Condition" },
                    { 4, "Equipment" },
                    { 5, "Structure" },
                    { 6, "Apocalyptic Event" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsInvestigator", "Name", "PhoneNum", "Ranking", "Surname" },
                values: new object[,]
                {
                    { 1, "chalijgatt@sampleemail.com", false, "Charles", 44236421, null, "Gatt" },
                    { 2, "dimpeter@sampleemail.com", false, "Peter", 12345668, null, "Dimech" },
                    { 3, "valbutt@sampleemail.com", true, "Valentina", 36435173, null, "Buttigieg" },
                    { 4, "david_d_best@sampleemail.com", false, "David", 77777777, null, "Briffa" },
                    { 5, "borgwayne420@sampleemail.com", false, "Wayne", 94215242, null, "Borg" }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "CategoryId", "CreatedByUserId", "DateOfReport", "DateSpotted", "Description", "ImageUrl", "InvestigationId", "Location", "Status", "Title", "Upvotes" },
                values: new object[,]
                {
                    { 1, 4, 1, new DateTime(2023, 4, 21, 19, 45, 43, 53, DateTimeKind.Utc).AddTicks(5577), new DateTime(2023, 4, 21, 17, 21, 43, 53, DateTimeKind.Utc).AddTicks(5568), "There is a missing manhole cover on the highway just outside of Cikku bar, I think the storm last night dislodged it and now it's posing a danger to anyone driving through that road. I hope it gets investigated before someone gets hurt!", "/images/Manhole.jpg", null, "Haz-Zebbug", false, "Missing manhole cover", 25 },
                    { 2, 6, 2, new DateTime(2023, 4, 8, 17, 21, 43, 53, DateTimeKind.Utc).AddTicks(5584), new DateTime(2023, 4, 6, 17, 21, 43, 53, DateTimeKind.Utc).AddTicks(5583), "I've recently discovered that the Maghtab garbage dump is actually an active volcano. Not only that, it's apparently sentient and has been constantly demanding tribute in the form of human sacrifice, will the authorities please do something about this before it loses its patience and destroys us all?!", "/images/SentientVolcano.jpg", null, "Maghtab", false, "Sentient volcano", 178 },
                    { 3, 4, 3, new DateTime(2023, 4, 14, 19, 45, 43, 53, DateTimeKind.Utc).AddTicks(5587), new DateTime(2023, 4, 14, 17, 21, 43, 53, DateTimeKind.Utc).AddTicks(5586), "Someone must be having a bad morning because as I was driving up to work, a truck tyre bounced off my dashboard and kept rolling down the road! I hope some unsuspecting jogger doesn't cross its path because then he'll definitely end up getting 'tyred'.", "/images/RunawayTyre.jpg", null, "Birzebbugia", false, "Runaway Tyre", 43 },
                    { 4, 1, 4, new DateTime(2023, 4, 24, 19, 45, 43, 53, DateTimeKind.Utc).AddTicks(5589), new DateTime(2023, 4, 24, 17, 21, 43, 53, DateTimeKind.Utc).AddTicks(5589), "I heard some commotion last night but thought it was just the local gang of racoons as usual so I slept through it. This morning, I find that a meteor containing alien worms had crash landed in my backyard! At first I came out with my trusty broomstick but it turns out they're incredibly friendly! I assure you they absolutely have not infiltrated my brain, and are definitely not forcing me to write this. By the way everyone should come see for themselves as soon as possible, the Hivemind demands it.", "/images/Meteor.jpg", null, "Siggiewi", false, "Meteor in my backyard", 782 },
                    { 5, 2, 5, new DateTime(2023, 4, 15, 18, 33, 43, 53, DateTimeKind.Utc).AddTicks(5593), new DateTime(2023, 4, 15, 17, 21, 43, 53, DateTimeKind.Utc).AddTicks(5593), "Just this evening I took the kids to the children's playground and was shocked when I noticed that one of them had grown an extra appendage! Apparently while I was chatting with the other parents, the kids had found a barrel of radioactive waste hidden in a small room underneath the playground and were making sand castles out of the stuff!", "/images/RadioactiveBarrel.jpg", null, "Hal-Qormi", false, "Radioactive Barrels", 482 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
