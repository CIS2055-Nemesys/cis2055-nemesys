using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using nemesis.Migrations;
using static nemesis.Models.Upvote;

namespace nemesis.Models.Contexts
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Investigation> Investigations { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Upvote> Upvotes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            this.SeedUsers(modelBuilder);
            this.SeedRoles(modelBuilder);
            this.SeedUserRoles(modelBuilder);

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

            //Investigation seed data
            modelBuilder.Entity<Investigation>().HasData(
                new Investigation()
                {
                    Id = 1,
                    DateOfAction = DateTime.UtcNow,
                    Description = "All must hail Ahman'tuep, the majestic ancient volcano, she who rules over fiery peaks and molten lava with a ceaseless hunger" +
                    " Legend has it that to keep her volcanic wrath at bay, a staggering offering of ten thousand chicken nuggets must be laid at his divine feet each day" +
                    " As the heavens watch in awe, we puny mortals must scurry about, frying, seasoning, and presenting an endless bounty of crispy poultry goodness." +
                    " Perhaps it is the secret blend of herbs and spices that infuses each nugget with just the right amount of flavor to calm his fiery cravings." +
                    " Or maybe Ahman'tuep just really loves the combination of tender chicken and tantalizing dipping sauces. Either way, one thing is certain: if we want to keep" +
                    " a volcano from erupting, she must be fed!",
                    InvestigatorId = "84b91c9f-74d1-452d-927b-439bfd3a7287",
                    StatusId = 2
                },

                new Investigation()
                {
                    Id = 2,
                    DateOfAction = DateTime.UtcNow,
                    Description = "In the battle of the roadways, where rubber meets the asphalt, a case of wild wheelery unfolded this morning." +
                    " Thankfully no one was 'flattened' in the incident! With 'tireless' dedication devoted to uncovering the enigma behind the truck " +
                    " tyre's unexpected detachment. By analyzing the gathered surveillance footage, piecing together witness statements, and examining" +
                    " the evidence, we thankfully managed to unravel the mystery and bring justice to the asphalt.",
                    InvestigatorId = "9059e247-2854-40bd-af2b-76088f8dd4e6",
                    StatusId = 3
                },
                new Investigation()
                {
                    Id = 3,
                    DateOfAction = DateTime.UtcNow,
                    Description = "After much debate among the investigators, we have decided that no action is required as we must all learn to share the playground" +
                    " No, we did not receive an anonymous donation of thirteen million, five hundred and fourty thousand, three hundred and 26 euro and 43 cents to close this case." +
                    " In fact, studies show that a daily exposure to ionized radiation is healthy for children! Think about how special little Billy with be with an extra hand!" +
                    " Have you never considered the convenience of such a mutation?!",
                    InvestigatorId = "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                    StatusId = 4
                },
                new Investigation()
                {
                    Id = 4,
                    DateOfAction = DateTime.UtcNow,
                    Description = "Solid copy, we went on site and socketed back in place, thank you for the report.",
                    InvestigatorId = "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                    StatusId = 3
                },
                new Investigation()
                {
                    Id = 5,
                    DateOfAction = DateTime.UtcNow,
                    Description = "One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us." +
                    " One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us." +
                    " One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us." +
                    " One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us." +
                    " One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us. One of us.",
                    InvestigatorId = "84b91c9f-74d1-452d-927b-439bfd3a7287",
                    StatusId = 4
                },
                new Investigation()
                {
                    Id = 6,
                    DateOfAction = DateTime.UtcNow,
                    Description = "Beware the coming terror as Cthulhu awakens! From the depths, an ancient cosmic horror emerges, heralding the end of all sanity" +
                    " and civilization. Prepare for unimaginable chaos, as madness spreads like wildfire and reality crumbles." +
                    " The mere glimpse of Cthulhu's grotesque form will shatter the minds of those unfortunate enough to witness it." +
                    " Brace for the impending doom, for the world as you know it shall be consumed by darkness and despair. Salvation is" +
                    " but a futile hope against the incomprehensible might of Cthulhu. Abandon all hope, for the age of humanity draws to a close," +
                    " and the reign of the Great Old Ones begins anew.\r\n\r\nTHE END IS NIGH! THE END IS NIGH!",
                    InvestigatorId = "9059e247-2854-40bd-af2b-76088f8dd4e6",
                    StatusId = 4
                },
                new Investigation()
                {
                    Id = 7,
                    DateOfAction = DateTime.UtcNow,
                    Description = "Considering you were at Zeppi's, that was probably just the head rat-chef Remy, he may have fallen on hard times since his wife" +
                    " left him after the sequel to Ratatouille flopped, but that's no excuse to call him fat! Monster!",
                    InvestigatorId = "9059e247-2854-40bd-af2b-76088f8dd4e6",
                    StatusId = 3
                },
                new Investigation()
                {
                    Id = 8,
                    DateOfAction = DateTime.UtcNow,
                    Description = "THE BEAAAAAAAAAAAAAAANZ?!?! WHY WON'T ANYONE THINK OF THE CHILDREN! THE BEAAAAAAAAAAAAAAAANZZZZZ!!",
                    InvestigatorId = "9059e247-2854-40bd-af2b-76088f8dd4e6",
                    StatusId = 2
                },
                new Investigation()
                {
                    Id = 9,
                    DateOfAction = DateTime.UtcNow,
                    Description = "Preliminary reports indicate that the impostor prefers fidget spinners over Rubik's Cubes" +
                    " The impostor must be caught at all costs! All hands on deck!  ",
                    InvestigatorId = "84b91c9f-74d1-452d-927b-439bfd3a7287",
                    StatusId = 2
                });

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
                    CreatedByUserId = "555e52b8-22db-4c15-a037-107016c7f827",
                    StatusId = 1,
                    InvestigationId = 1,
                    Upvotes = null
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
                    CreatedByUserId = "ad9a20a1-779e-4991-8881-9af6171668a5",
                    StatusId = 1,
                    InvestigationId = 2,
                    Upvotes = null
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
                    CreatedByUserId = "ad9a20a1-779e-4991-8881-9af6171668a5",
                    StatusId = 1,
                    InvestigationId = 3,
                    Upvotes = null
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
                    CreatedByUserId = "ad9a20a1-779e-4991-8881-9af6171668a5",
                    StatusId = 1,
                    InvestigationId = 4,
                    Upvotes = null
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
                    CreatedByUserId = "9059e247-2854-40bd-af2b-76088f8dd4e6",
                    StatusId = 1,
                    InvestigationId = 5,
                    Upvotes = null
                },
                new Report()
                {
                    Id = 6,
                    Title = "Old God rises from the depths",
                    Description = "I was taking a lovely stroll on the beach last night when suddenly, my partner noted that the ancient old god Cthulhu had manifested out of the sea, heralding the end of days for humanity and all life as we know it!",
                    Location = "Ghar Lapsi",
                    DateSpotted = DateTime.UtcNow.AddDays(-3.5),
                    DateOfReport = DateTime.UtcNow.AddDays(-3),
                    ImageUrl = "/images/Cthulhu.jpg",
                    CategoryId = 6,
                    CreatedByUserId = "ad9a20a1-779e-4991-8881-9af6171668a5",
                    StatusId = 1,
                    InvestigationId = 6,
                    Upvotes = null
                },
                new Report()
                {
                    Id = 7,
                    Title = "Giant rodent",
                    Description = "We were having lunch at Zeppi's Diner last night when suddenly, a rodent the size of a car scurried out of the kitchen! I have to say it really put us off finishing the meal. I hope the food safety authorities see this post!",
                    Location = "Hamrun",
                    DateSpotted = DateTime.UtcNow.AddDays(-2.5),
                    DateOfReport = DateTime.UtcNow.AddDays(-2.4),
                    ImageUrl = "/images/GiantRodent.png",
                    CategoryId = 2,
                    CreatedByUserId = "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                    StatusId = 1,
                    InvestigationId = null,
                    Upvotes = null
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
                    CreatedByUserId = "ad9a20a1-779e-4991-8881-9af6171668a5",
                    StatusId = 1,
                    InvestigationId = 7,
                    Upvotes = null
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
                    CreatedByUserId = "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                    StatusId = 1,
                    InvestigationId = null,
                    Upvotes = null
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
                    CreatedByUserId = "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                    StatusId = 1,
                    InvestigationId = 8,
                    Upvotes = null
                },
                new Report()
                {
                    Id = 11,
                    Title = "Toilet Paper Hoarder",
                    Description = "Like most of you, I buy my toilet paper from the gas station. I was disgusted this morning when some --redacted-- bought out the entire shop! Does this guy have ten --redacted--!? How am I supposed to wipe my --redacted-- without any toilet paper?!",
                    Location = "Mosta",
                    DateSpotted = DateTime.UtcNow.AddDays(-0.5),
                    DateOfReport = DateTime.UtcNow.AddDays(-0.3),
                    ImageUrl = "/images/ToiletPaper.jpg",
                    CategoryId = 1,
                    CreatedByUserId = "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                    StatusId = 1,
                    InvestigationId = null,
                    Upvotes = null
                },
                new Report()
                {
                    Id = 12,
                    Title = "Porter imposter",
                    Description = "Imposter detected!!!!!!\n This van tried to impersonate Dr Chris Porter (PhD, MD, JD, MBA, MS, MFA, DSc, DPhil, DEd, DPT, DVM, DSW, DMus, DEng, DM, DNurs, DLit, DDS, DClinPsy, DPharm, DArch, and DBA), the erudite, brilliant, innovative, charismatic, awe-inspiring, compassionate, visionary, and unparalleled intellectual powerhouse, whose prodigious knowledge, remarkable expertise, and boundless passion for teaching have transformed countless minds and left an indelible mark on the realm of academia.\n\nps: chatgpt is really useful",
                    Location = "London",
                    DateSpotted = DateTime.UtcNow.AddDays(-1),
                    DateOfReport = DateTime.UtcNow,
                    ImageUrl = "/images/Porter.jpg",
                    CategoryId = 1,
                    CreatedByUserId = "84b91c9f-74d1-452d-927b-439bfd3a7287",
                    StatusId = 1,
                    InvestigationId = 9,
                    Upvotes = null
                }
            );

            //Status seed data
            modelBuilder.Entity<Status>().HasData(
               new Status()
               {
                   Id = 1,
                   Name = "Open"
               },
               new Status()
               {
                   Id = 2,
                   Name = "Being Investigated"
               },
               new Status()
               {
                   Id = 3,
                   Name = "Closed"
               },
               new Status()
               {
                   Id = 4,
                   Name = "No Action Required"
               }
            );

            //When a report is delted, all upvotes pertaining to that report are deleted with it 
            modelBuilder.Entity<Upvote>()
               .HasOne(upvote => upvote.Report)
               .WithMany(report => report.Upvotes)
               .HasForeignKey(upvote => upvote.ReportID)
               .OnDelete(DeleteBehavior.Cascade);

            //Upvote seed data
            modelBuilder.Entity<Upvote>().HasData(
                new Upvote()
                {
                    UserId = "9059e247-2854-40bd-af2b-76088f8dd4e6",
                    ReportID = 1
                },
                new Upvote()
                {
                    UserId = "ad9a20a1-779e-4991-8881-9af6171668a5",
                    ReportID = 1
                },
                new Upvote()
                {
                    UserId = "9059e247-2854-40bd-af2b-76088f8dd4e6",
                    ReportID = 2
                },
                new Upvote()
                {
                    UserId = "555e52b8-22db-4c15-a037-107016c7f827",
                    ReportID = 4
                },
                new Upvote()
                {
                    UserId = "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                    ReportID = 7
                },
                new Upvote()
                {
                    UserId = "ad9a20a1-779e-4991-8881-9af6171668a5",
                    ReportID = 4
                },
                new Upvote()
                {
                    UserId = "9059e247-2854-40bd-af2b-76088f8dd4e6",
                    ReportID = 3
                },
                new Upvote()
                {
                    UserId = "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                    ReportID = 5
                },
                new Upvote()
                {
                    UserId = "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                    ReportID = 9
                },
                new Upvote()
                {
                    UserId = "9059e247-2854-40bd-af2b-76088f8dd4e6",
                    ReportID = 4
                },
                new Upvote()
                {
                    UserId = "ad9a20a1-779e-4991-8881-9af6171668a5",
                    ReportID = 7
                },
                new Upvote()
                {
                    UserId = "555e52b8-22db-4c15-a037-107016c7f827",
                    ReportID = 8
                },
                new Upvote()
                {
                    UserId = "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                    ReportID = 12
                },
                new Upvote()
                {
                    UserId = "9059e247-2854-40bd-af2b-76088f8dd4e6",
                    ReportID = 5
                },
                new Upvote()
                {
                    UserId = "ad9a20a1-779e-4991-8881-9af6171668a5",
                    ReportID = 9
                },
                new Upvote()
                {
                    UserId = "555e52b8-22db-4c15-a037-107016c7f827",
                    ReportID = 11
                },
                new Upvote()
                {
                    UserId = "9059e247-2854-40bd-af2b-76088f8dd4e6",
                    ReportID = 10
                },



                new Upvote()
                {
                    UserId = "9059e247-2854-40bd-af2b-76088f8dd4e6",
                    ReportID = 9
                },
                new Upvote()
                {
                    UserId = "ad9a20a1-779e-4991-8881-9af6171668a5",
                    ReportID = 6
                },
                new Upvote()
                {
                    UserId = "9059e247-2854-40bd-af2b-76088f8dd4e6",
                    ReportID = 11
                },
                new Upvote()
                {
                    UserId = "555e52b8-22db-4c15-a037-107016c7f827",
                    ReportID = 7
                },
                new Upvote()
                {
                    UserId = "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                    ReportID = 3
                },
                new Upvote()
                {
                    UserId = "ad9a20a1-779e-4991-8881-9af6171668a5",
                    ReportID = 8
                },
                new Upvote()
                {
                    UserId = "9059e247-2854-40bd-af2b-76088f8dd4e6",
                    ReportID = 12
                },
                new Upvote()
                {
                    UserId = "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                    ReportID = 6
                },
                new Upvote()
                {
                    UserId = "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                    ReportID = 10
                },
                new Upvote()
                {
                    UserId = "ad9a20a1-779e-4991-8881-9af6171668a5",
                    ReportID = 2
                },
                new Upvote()
                {
                    UserId = "555e52b8-22db-4c15-a037-107016c7f827",
                    ReportID = 9
                },
                new Upvote()
                {
                    UserId = "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                    ReportID = 11
                },
                new Upvote()
                {
                    UserId = "9059e247-2854-40bd-af2b-76088f8dd4e6",
                    ReportID = 7
                },
                new Upvote()
                {
                    UserId = "ad9a20a1-779e-4991-8881-9af6171668a5",
                    ReportID = 11
                },
                new Upvote()
                {
                    UserId = "555e52b8-22db-4c15-a037-107016c7f827",
                    ReportID = 10
                },
                new Upvote()
                {
                    UserId = "9059e247-2854-40bd-af2b-76088f8dd4e6",
                    ReportID = 8
                }






                );
        }

        private void SeedUsers(ModelBuilder modelBuilder)
        {

            PasswordHasher<IdentityUser> hasher = new PasswordHasher<IdentityUser>();


            IdentityUser u = new IdentityUser()
            {
                Id = "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                UserName = "Sudo",
                NormalizedUserName = "SUDO",
                Email = "su@do.com",
                NormalizedEmail = "SU@DO.COM",
                PhoneNumber = "0", //you don't need to call him, he's already listening
                EmailConfirmed = true
            };
            u.PasswordHash = hasher.HashPassword(u, "Password1_");
            IdentityUser u1 = new IdentityUser()
            {
                Id = "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                UserName = "PaulBlart",
                NormalizedUserName = "PAULBLART",
                Email = "cop2@mall.com",
                NormalizedEmail = "COP2@MALL.COM",
                PhoneNumber = "911911",
                EmailConfirmed = true
            };
            u1.PasswordHash = hasher.HashPassword(u, "Password1_");
            IdentityUser u2 = new IdentityUser()
            {
                Id = "9059e247-2854-40bd-af2b-76088f8dd4e6",
                UserName = "InspectorGadget",
                NormalizedUserName = "INSPECTORGADGET",
                Email = "gadget@inspect.com",
                NormalizedEmail = "GADGET@INSPECT.COM",
                PhoneNumber = "23480922",
                EmailConfirmed = true
            };
            u2.PasswordHash = hasher.HashPassword(u, "Password1_");
            IdentityUser u3 = new IdentityUser()
            {
                Id = "84b91c9f-74d1-452d-927b-439bfd3a7287",
                UserName = "Element",
                NormalizedUserName = "ELEMENT",
                Email = "element@inspect.com",
                NormalizedEmail = "ELEMENT@INSPECT.COM",
                PhoneNumber = "(650) 253-0000",
                EmailConfirmed = true
            };
            u3.PasswordHash = hasher.HashPassword(u, "Password1_");
            IdentityUser u4 = new IdentityUser()
            {
                Id = "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                UserName = "Cetta",
                NormalizedUserName = "CETTA",
                Email = "cetta@hotmail.com",
                NormalizedEmail = "CETTA@HOTMAIL.COM",
                PhoneNumber = "21249200",
                EmailConfirmed = true
            };
            u4.PasswordHash = hasher.HashPassword(u, "Password1_");
            IdentityUser u5 = new IdentityUser()
            {
                Id = "ad9a20a1-779e-4991-8881-9af6171668a5",
                UserName = "Karen",
                NormalizedUserName = "KAREN",
                Email = "karen@qrid.com",
                NormalizedEmail = "KAREN@QRID.COM",
                PhoneNumber = "10291029",
                EmailConfirmed = true
            };
            u5.PasswordHash = hasher.HashPassword(u, "Password1_");
            IdentityUser u6 = new IdentityUser()
            {
                Id = "555e52b8-22db-4c15-a037-107016c7f827",
                UserName = "Candice",
                NormalizedUserName = "CANDICE",
                Email = "CandiceFlynn@snitch.com",
                NormalizedEmail = "CANDICEFLYNN@SNITCH.COM",
                PhoneNumber = "201920192",
                EmailConfirmed = true
            };
            u6.PasswordHash = hasher.HashPassword(u, "Password1_");
            IdentityUser u7 = new IdentityUser()
            {
                Id = "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                UserName = "6ix9ine",
                NormalizedUserName = "6IX9INE",
                Email = "head@snitch.com",
                NormalizedEmail = "HEAD@SNITCH.COM",
                PhoneNumber = "1231233412",
                EmailConfirmed = true
            };
            u7.PasswordHash = hasher.HashPassword(u, "Password1_");
            IdentityUser u8 = new IdentityUser()
            {
                Id = "3303fdaf-f438-4582-8f10-52b578c50cb8",
                UserName = "homeworkReminder",
                NormalizedUserName = "HOMEWORKREMINDER",
                Email = "homework@reminder.com",
                NormalizedEmail = "HOMEWORK@REMINDER.COM",
                PhoneNumber = "123412521",
                EmailConfirmed = true
            };
            u8.PasswordHash = hasher.HashPassword(u, "Password1_");





            modelBuilder.Entity<IdentityUser>().HasData(

                u, u1, u2, u3, u4, u5, u6, u7, u8

            );

            modelBuilder.ApplyConfiguration(new UpvoteConfiguration());

            //Addresses max key length
            modelBuilder.Entity<Upvote>().HasIndex(u => new { u.UserId, u.ReportID }).IsUnique().IsClustered(false);


        }

        private void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    Id = "68a525ac-d446-4c8c-983c-047afdffed13"
                },
                new IdentityRole
                {
                    Name = "Investigator",
                    NormalizedName = "INVESTIGATOR",
                    Id = "fca95d41-370a-4218-b0aa-8502494448fb"
                }
            );;
        }

        private void SeedUserRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    //admin
                    RoleId = "68a525ac-d446-4c8c-983c-047afdffed13",
                    UserId = "fac97539-cb0b-4b9f-ae20-497eafb414bc"
                },

                //investigators
                new IdentityUserRole<string>
                {
                    RoleId = "fca95d41-370a-4218-b0aa-8502494448fb",
                    UserId = "fac97539-cb0b-4b9f-ae20-497eafb414bc"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "fca95d41-370a-4218-b0aa-8502494448fb",
                    UserId = "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "fca95d41-370a-4218-b0aa-8502494448fb",
                    UserId = "9059e247-2854-40bd-af2b-76088f8dd4e6"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "fca95d41-370a-4218-b0aa-8502494448fb",
                    UserId = "84b91c9f-74d1-452d-927b-439bfd3a7287"
                }
            );
        }

    }

    //config for upvote composite PK
    public class UpvoteConfiguration : IEntityTypeConfiguration<Upvote>
    {
        public void Configure(EntityTypeBuilder<Upvote> builder)
        {
            builder.HasKey(u => new { u.UserId, u.ReportID });

            builder.HasOne(u => u.User)
                .WithMany()
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(u => u.Report)
                .WithMany(r => r.Upvotes)
                .HasForeignKey(u => u.ReportID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }


}
