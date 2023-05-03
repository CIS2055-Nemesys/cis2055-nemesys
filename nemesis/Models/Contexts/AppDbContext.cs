﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using nemesis.ViewModels;

namespace nemesis.Models.Contexts
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Investigation> Investigations { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Name = "Charles",
                    Surname = "Gatt",
                    Email = "chalijgatt@sampleemail.com",
                    PhoneNum = 44236421,
                    IsInvestigator = false,
                },
                new User()
                {
                    Id = 2,
                    Name = "Peter",
                    Surname = "Dimech",
                    Email = "dimpeter@sampleemail.com",
                    PhoneNum = 12345668,
                    IsInvestigator = false,
                },
                new User()
                {
                    Id = 3,
                    Name = "Valentina",
                    Surname = "Buttigieg",
                    Email = "valbutt@sampleemail.com",
                    PhoneNum = 36435173,
                    IsInvestigator = true,
                },
                new User()
                {
                    Id = 4,
                    Name = "David",
                    Surname = "Briffa",
                    Email = "david_d_best@sampleemail.com",
                    PhoneNum = 77777777,
                    IsInvestigator = false,
                },
                new User()
                {
                    Id = 5,
                    Name = "Wayne",
                    Surname = "Borg",
                    Email = "borgwayne420@sampleemail.com",
                    PhoneNum = 94215242,
                    IsInvestigator = false,
                }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Uncategorised"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Unsafe act"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Condition"
                },
                new Category()
                {
                    Id = 4,
                    Name = "Equipment"
                },
                new Category()
                {
                    Id = 5,
                    Name = "Structure"
                },
                new Category()
                {
                    Id = 6,
                    Name = "Apocalyptic Event"
                }
             );

            modelBuilder.Entity<Report>().HasData(
                
                new Report()
                {
                    Id = 1,
                    Title = "Sentient volcano",
                    Description = "I've recently discovered that the Maghtab garbage dump is actually an active volcano. Not only that, it's apparently sentient and has been constantly demanding tribute in the form of human sacrifice, will the authorities please do something about this before it loses its patience and destroys us all?!",
                    Location = "Maghtab",
                    DateSpotted = DateTime.UtcNow.AddDays(-20),
                    DateOfReport = DateTime.UtcNow.AddDays(-18),
                    ImageUrl = "/images/SentientVolcano.jpg",
                    CategoryId = 6,
                    CreatedByUserId = 2,
                    Status = false,
                    InvestigationId = null,
                    Upvotes = 178
                },

                new Report()
                {
                    Id = 2,
                    Title = "Runaway Tyre",
                    Description = "Someone must be having a bad morning because as I was driving up to work, a truck tyre bounced off my dashboard and kept rolling down the road! I hope some unsuspecting jogger doesn't cross its path because then he'll definitely end up getting 'tyred'.",
                    Location = "Birzebbugia",
                    DateSpotted = DateTime.UtcNow.AddDays(-12),
                    DateOfReport = DateTime.UtcNow.AddDays(-11.9),
                    ImageUrl = "/images/RunawayTyre.jpg",
                    CategoryId = 4,
                    CreatedByUserId = 3,
                    Status = false,
                    InvestigationId = null,
                    Upvotes = 43
                },
                new Report()
                {
                    Id = 3,
                    Title = "Radioactive Barrels",
                    Description = "Just this evening I took the kids to the children's playground and was shocked when I noticed that one of them had grown an extra appendage! Apparently while I was chatting with the other parents, the kids had found a barrel of radioactive waste hidden in a small room underneath the playground and were making sand castles out of the stuff!",
                    Location = "Hal-Qormi",
                    DateSpotted = DateTime.UtcNow.AddDays(-11),
                    DateOfReport = DateTime.UtcNow.AddDays(-10.95),
                    ImageUrl = "/images/RadioactiveBarrel.jpg",
                    CategoryId = 2,
                    CreatedByUserId = 5,
                    Status = false,
                    InvestigationId = null,
                    Upvotes = 482
                },
                new Report()
                {
                    Id = 4,
                    Title = "Missing manhole cover",
                    Description = "There is a missing manhole cover on the highway just outside of Cikku bar, I think the storm last night dislodged it and now it's posing a danger to anyone driving through that road. I hope it gets investigated before someone gets hurt!",
                    Location = "Haz-Zebbug",
                    DateSpotted = DateTime.UtcNow.AddDays(-5),
                    DateOfReport = DateTime.UtcNow.AddDays(-4.9),
                    ImageUrl = "/images/Manhole.jpg",
                    CategoryId = 4,
                    CreatedByUserId = 1,
                    Status = false,
                    InvestigationId = null,
                    Upvotes = 25
                },
                new Report()
                {
                    Id = 5,
                    Title = "Meteor in my backyard",
                    Description = "I heard some commotion last night but thought it was just the local gang of racoons as usual so I slept through it. This morning, I find that a meteor containing alien worms had crash landed in my backyard! At first I came out with my trusty broomstick but it turns out they're incredibly friendly! I assure you they absolutely have not infiltrated my brain, and are definitely not forcing me to write this. By the way everyone should come see for themselves as soon as possible, the Hivemind demands it.",
                    Location = "Siggiewi",
                    DateSpotted = DateTime.UtcNow.AddDays(-2),
                    DateOfReport = DateTime.UtcNow.AddDays(-1.9),
                    ImageUrl = "/images/Meteor.jpg",
                    CategoryId = 1,
                    CreatedByUserId = 4,
                    Status = false,
                    InvestigationId = null,
                    Upvotes = 782
                },
                new Report()
                {
                    Id = 6,
                    Title = "Old God rises from the depths",
                    Description = "I was taking a lovely stroll on the beach last night when suddenly, my partner noted that the ancient old god Cthulhu had manifested out of the sea, heralding the end of days for humanity",
                    Location = "Ghar Lapsi",
                    DateSpotted = DateTime.UtcNow.AddDays(-3.5),
                    DateOfReport = DateTime.UtcNow.AddDays(-3),
                    ImageUrl = "/images/Cthulhu.jpg",
                    CategoryId = 6,
                    CreatedByUserId = 4,
                    Status = false,
                    InvestigationId = null,
                    Upvotes = 777
                },
                new Report()
                {
                    Id = 7,
                    Title = "Giant rodent",
                    Description = "We were having lunch at Zeppi's Diner last night when suddenly, a rodent the size of a car scurried out of the kitchen! I have to say it really put us off finishing the meal. I hope the food safety authorities see this post!",
                    Location = "Hamrun",
                    DateSpotted = DateTime.UtcNow.AddDays(-2.5),
                    DateOfReport = DateTime.UtcNow.AddDays(-2.4),
                    ImageUrl = "/images/GiantRodent.jpg",
                    CategoryId = 2,
                    CreatedByUserId = 5,
                    Status = false,
                    InvestigationId = null,
                    Upvotes = 246
                },
                new Report()
                {
                    Id = 8,
                    Title = "Hairy Burger",
                    Description = "We went out for dinner at Fonzu's last night and were having a great time! Hats off to the guy who was playing the accordion with his feet. I ordered the special 'Fonzu's Burger' off the menu, and, to say the least, was shocked when the waitress brought it to the table. It was just a clump of greasy hair! I don't know who thought this was a good idea or how it passed any form of review! Talk about finding a hair in the food! ",
                    Location = "Naxxar",
                    DateSpotted = DateTime.UtcNow.AddDays(-2),
                    DateOfReport = DateTime.UtcNow.AddDays(-1.9),
                    ImageUrl = "/images/HairBurger.jpeg",
                    CategoryId = 1,
                    CreatedByUserId = 5,
                    Status = false,
                    InvestigationId = null,
                    Upvotes = 52
                },
                new Report()
                {
                    Id = 9,
                    Title = "Passed out man",
                    Description = "I was out shopping with the kids when we came across a passed out man in the middle of the sidewalk. Normally I wouldn't post something like this, because let's face it, we've all been there. However, what really bothered me was that he was snoring so loud it sounded like an entire trombone orchestra! Simply unacceptable!",
                    Location = "Bormla",
                    DateSpotted = DateTime.UtcNow.AddDays(-1.7),
                    DateOfReport = DateTime.UtcNow.AddDays(-1.5),
                    ImageUrl = "/images/ManPassedOut.jpg",
                    CategoryId = 2,
                    CreatedByUserId = 3,
                    Status = false,
                    InvestigationId = null,
                    Upvotes = 120
                },
                new Report()
                {
                    Id = 10,
                    Title = "MISSING BEANZ",
                    Description = "HOW IS THIS ACCEPTABLE!? MY FAVOURITE HEINZ BAKED BEANZ HAVE BEEN OUT OF STOCK FOR THE LAST 2 DAYS!??!1?111? HOW AM I SUPPOSED TO FEED MY CHILDREN A NUTRITIOUS BREAKFAST IF I DON'T HAVE ANY BEANZ! WHY AREN'T THERE ANY BEANZ!?!11?",
                    Location = "Mosta",
                    DateSpotted = DateTime.UtcNow.AddDays(-1),
                    DateOfReport = DateTime.UtcNow.AddDays(-0.8),
                    ImageUrl = "/images/MissingBeans.webp",
                    CategoryId = 6,
                    CreatedByUserId = 4,
                    Status = false,
                    InvestigationId = null,
                    Upvotes = 345
                },
                new Report()
                {
                    Id = 11,
                    Title = "Toilet Paper Hoarder",
                    Description = "Like most of you, I buy my toilet paper from the gas station. I was disgusted this morning when some --redacted-- bought out the entire shop! Does this guy have ten --redacted--!? How am I supposed to wipe my --redacted-- without any toilet paper?!",
                    Location = "Mosta",
                    DateSpotted = DateTime.UtcNow.AddDays(-0.5),
                    DateOfReport = DateTime.UtcNow.AddDays(-0.3),
                    ImageUrl = "/images/ToiletPaperHoarder",
                    CategoryId = 1,
                    CreatedByUserId = 5,
                    Status = false,
                    InvestigationId = null,
                    Upvotes = 498
                }


            );
        }


        public DbSet<nemesis.ViewModels.ReportViewModel>? ReportViewModel { get; set; }
    }
}
