using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nemesis.Migrations
{
    /// <inheritdoc />
    public partial class SynchronizedDateAndReportId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedByUserId", "DateOfReport", "DateSpotted", "Description", "ImageUrl", "Location", "Title", "Upvotes" },
                values: new object[] { 6, 2, new DateTime(2023, 4, 10, 7, 31, 32, 550, DateTimeKind.Utc).AddTicks(4089), new DateTime(2023, 4, 8, 7, 31, 32, 550, DateTimeKind.Utc).AddTicks(4088), "I've recently discovered that the Maghtab garbage dump is actually an active volcano. Not only that, it's apparently sentient and has been constantly demanding tribute in the form of human sacrifice, will the authorities please do something about this before it loses its patience and destroys us all?!", "/images/SentientVolcano.jpg", "Maghtab", "Sentient volcano", 178 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedByUserId", "DateOfReport", "DateSpotted", "Description", "ImageUrl", "Location", "Title", "Upvotes" },
                values: new object[] { 4, 3, new DateTime(2023, 4, 16, 9, 55, 32, 550, DateTimeKind.Utc).AddTicks(4091), new DateTime(2023, 4, 16, 7, 31, 32, 550, DateTimeKind.Utc).AddTicks(4090), "Someone must be having a bad morning because as I was driving up to work, a truck tyre bounced off my dashboard and kept rolling down the road! I hope some unsuspecting jogger doesn't cross its path because then he'll definitely end up getting 'tyred'.", "/images/RunawayTyre.jpg", "Birzebbugia", "Runaway Tyre", 43 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedByUserId", "DateOfReport", "DateSpotted", "Description", "ImageUrl", "Location", "Title", "Upvotes" },
                values: new object[] { 2, 5, new DateTime(2023, 4, 17, 8, 43, 32, 550, DateTimeKind.Utc).AddTicks(4094), new DateTime(2023, 4, 17, 7, 31, 32, 550, DateTimeKind.Utc).AddTicks(4094), "Just this evening I took the kids to the children's playground and was shocked when I noticed that one of them had grown an extra appendage! Apparently while I was chatting with the other parents, the kids had found a barrel of radioactive waste hidden in a small room underneath the playground and were making sand castles out of the stuff!", "/images/RadioactiveBarrel.jpg", "Hal-Qormi", "Radioactive Barrels", 482 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedByUserId", "DateOfReport", "DateSpotted", "Description", "ImageUrl", "Location", "Title", "Upvotes" },
                values: new object[] { 4, 1, new DateTime(2023, 4, 23, 9, 55, 32, 550, DateTimeKind.Utc).AddTicks(4085), new DateTime(2023, 4, 23, 7, 31, 32, 550, DateTimeKind.Utc).AddTicks(4080), "There is a missing manhole cover on the highway just outside of Cikku bar, I think the storm last night dislodged it and now it's posing a danger to anyone driving through that road. I hope it gets investigated before someone gets hurt!", "/images/Manhole.jpg", "Haz-Zebbug", "Missing manhole cover", 25 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedByUserId", "DateOfReport", "DateSpotted", "Description", "ImageUrl", "Location", "Title", "Upvotes" },
                values: new object[] { 1, 4, new DateTime(2023, 4, 26, 9, 55, 32, 550, DateTimeKind.Utc).AddTicks(4092), new DateTime(2023, 4, 26, 7, 31, 32, 550, DateTimeKind.Utc).AddTicks(4092), "I heard some commotion last night but thought it was just the local gang of racoons as usual so I slept through it. This morning, I find that a meteor containing alien worms had crash landed in my backyard! At first I came out with my trusty broomstick but it turns out they're incredibly friendly! I assure you they absolutely have not infiltrated my brain, and are definitely not forcing me to write this. By the way everyone should come see for themselves as soon as possible, the Hivemind demands it.", "/images/Meteor.jpg", "Siggiewi", "Meteor in my backyard", 782 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedByUserId", "DateOfReport", "DateSpotted", "Description", "ImageUrl", "Location", "Title", "Upvotes" },
                values: new object[] { 4, 1, new DateTime(2023, 4, 21, 19, 45, 43, 53, DateTimeKind.Utc).AddTicks(5577), new DateTime(2023, 4, 21, 17, 21, 43, 53, DateTimeKind.Utc).AddTicks(5568), "There is a missing manhole cover on the highway just outside of Cikku bar, I think the storm last night dislodged it and now it's posing a danger to anyone driving through that road. I hope it gets investigated before someone gets hurt!", "/images/Manhole.jpg", "Haz-Zebbug", "Missing manhole cover", 25 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedByUserId", "DateOfReport", "DateSpotted", "Description", "ImageUrl", "Location", "Title", "Upvotes" },
                values: new object[] { 6, 2, new DateTime(2023, 4, 8, 17, 21, 43, 53, DateTimeKind.Utc).AddTicks(5584), new DateTime(2023, 4, 6, 17, 21, 43, 53, DateTimeKind.Utc).AddTicks(5583), "I've recently discovered that the Maghtab garbage dump is actually an active volcano. Not only that, it's apparently sentient and has been constantly demanding tribute in the form of human sacrifice, will the authorities please do something about this before it loses its patience and destroys us all?!", "/images/SentientVolcano.jpg", "Maghtab", "Sentient volcano", 178 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedByUserId", "DateOfReport", "DateSpotted", "Description", "ImageUrl", "Location", "Title", "Upvotes" },
                values: new object[] { 4, 3, new DateTime(2023, 4, 14, 19, 45, 43, 53, DateTimeKind.Utc).AddTicks(5587), new DateTime(2023, 4, 14, 17, 21, 43, 53, DateTimeKind.Utc).AddTicks(5586), "Someone must be having a bad morning because as I was driving up to work, a truck tyre bounced off my dashboard and kept rolling down the road! I hope some unsuspecting jogger doesn't cross its path because then he'll definitely end up getting 'tyred'.", "/images/RunawayTyre.jpg", "Birzebbugia", "Runaway Tyre", 43 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedByUserId", "DateOfReport", "DateSpotted", "Description", "ImageUrl", "Location", "Title", "Upvotes" },
                values: new object[] { 1, 4, new DateTime(2023, 4, 24, 19, 45, 43, 53, DateTimeKind.Utc).AddTicks(5589), new DateTime(2023, 4, 24, 17, 21, 43, 53, DateTimeKind.Utc).AddTicks(5589), "I heard some commotion last night but thought it was just the local gang of racoons as usual so I slept through it. This morning, I find that a meteor containing alien worms had crash landed in my backyard! At first I came out with my trusty broomstick but it turns out they're incredibly friendly! I assure you they absolutely have not infiltrated my brain, and are definitely not forcing me to write this. By the way everyone should come see for themselves as soon as possible, the Hivemind demands it.", "/images/Meteor.jpg", "Siggiewi", "Meteor in my backyard", 782 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedByUserId", "DateOfReport", "DateSpotted", "Description", "ImageUrl", "Location", "Title", "Upvotes" },
                values: new object[] { 2, 5, new DateTime(2023, 4, 15, 18, 33, 43, 53, DateTimeKind.Utc).AddTicks(5593), new DateTime(2023, 4, 15, 17, 21, 43, 53, DateTimeKind.Utc).AddTicks(5593), "Just this evening I took the kids to the children's playground and was shocked when I noticed that one of them had grown an extra appendage! Apparently while I was chatting with the other parents, the kids had found a barrel of radioactive waste hidden in a small room underneath the playground and were making sand castles out of the stuff!", "/images/RadioactiveBarrel.jpg", "Hal-Qormi", "Radioactive Barrels", 482 });
        }
    }
}
