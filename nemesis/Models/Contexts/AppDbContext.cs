using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using nemesis.ViewModels;

namespace nemesis.Models.Contexts
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Report> Reports { get; set; }
        public DbSet<Investigation> Investigations { get; set; }
        public DbSet<Category> Categories { get; set; }


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
                    CreatedByUserId = "ad9a20a1-779e-4991-8881-9af6171668a5",
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
                    CreatedByUserId = "ad9a20a1-779e-4991-8881-9af6171668a5",
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
                    CreatedByUserId = "ad9a20a1-779e-4991-8881-9af6171668a5",
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
                    CreatedByUserId = "afdb900f-344d-4bf7-9239-34a2e",
                    Status = false,
                    InvestigationId = null,
                    Upvotes = 782
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
                    CreatedByUserId = "afdb900f-344d-4bf7-9239-34a2e",
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
                    CreatedByUserId = "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
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
                    CreatedByUserId = "ad9a20a1-779e-4991-8881-9af6171668a5",
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
                    CreatedByUserId = "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
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
                    CreatedByUserId = "afdb900f-344d-4bf7-9239-34a2e",
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
                    CreatedByUserId = "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                    Status = false,
                    InvestigationId = null,
                    Upvotes = 498
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
                    Status = false,
                    InvestigationId = null,
                    Upvotes = 2000
                }


            );
        }

        private void SeedUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUser>().HasData(


                new IdentityUser()
                {
                    Id = "fac97539-cb0b-4b9f-ae20-497eafb414bc",
                    UserName = "Sudo",
                    NormalizedUserName = "SUDO",
                    Email = "su@do.com",
                    NormalizedEmail = "SU@DO.COM",
                    PhoneNumber = "0", //you don't need to call him, he's already listening
                },
                new IdentityUser()
                {
                    Id = "92b32ccb-8835-4e2d-ae6c-8c86eb2efed6",
                    UserName = "PaulBlart",
                    NormalizedUserName = "PAULBLART",
                    Email = "cop2@mall.com",
                    NormalizedEmail = "COP2@MALL.COM",
                    PhoneNumber = "911911",
                },
                new IdentityUser()
                {
                    Id = "9059e247-2854-40bd-af2b-76088f8dd4e6",
                    UserName = "InspectorGadget",
                    NormalizedUserName = "INSPECTORGADGET",
                    Email = "gadget@inspect.com",
                    NormalizedEmail = "GADGET@INSPECT.COM",
                    PhoneNumber = "23480922",
                },
                new IdentityUser()
                {
                    Id = "84b91c9f-74d1-452d-927b-439bfd3a7287",
                    UserName = "Element",
                    NormalizedUserName = "ELEMENT",
                    Email = "element@inspect.com",
                    NormalizedEmail = "ELEMENT@INSPECT.COM",
                    PhoneNumber = "(650) 253-0000",
                },
                new IdentityUser()
                {
                    Id = "5888e361-c81f-4ac9-8e16-961b0eeed0ae",
                    UserName = "Cetta",
                    NormalizedUserName = "CETTA",
                    Email = "cetta@hotmail.com",
                    NormalizedEmail = "CETTA@HOTMAIL.COM",
                    PhoneNumber = "21249200",
                },
                new IdentityUser()
                {
                    Id = "ad9a20a1-779e-4991-8881-9af6171668a5",
                    UserName = "Karen",
                    NormalizedUserName = "KAREN",
                    Email = "karen@qrid.com",
                    NormalizedEmail = "KAREN@QRID.COM",
                    PhoneNumber = "10291029",
                },
                new IdentityUser()
                {
                    Id = "555e52b8-22db-4c15-a037-107016c7f827",
                    UserName = "Candice",
                    NormalizedUserName = "CANDICE",
                    Email = "CandiceFlynn@snitch.com",
                    NormalizedEmail = "CANDICEFLYNN@SNITCH.COM",
                    PhoneNumber = "201920192",
                },new IdentityUser()
                {
                    Id = "5cefc46b-1918-4ae3-8a40-4d337ff9a670",
                    UserName = "6ix9ine",
                    NormalizedUserName = "6IX9INE",
                    Email = "head@snitch.com",
                    NormalizedEmail = "HEAD@SNITCH.COM",
                    PhoneNumber = "1231233412",
                }, new IdentityUser()
                {
                    Id = "3303fdaf-f438-4582-8f10-52b578c50cb8",
                    UserName = "homeworkReminder",
                    NormalizedUserName = "HOMEWORKREMINDER",
                    Email = "homework@reminder.com",
                    NormalizedEmail = "HOMEWORK@REMINDER.COM",
                    PhoneNumber = "123412521",
                }
            );
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

        public DbSet<nemesis.ViewModels.ReportViewModel>? ReportViewModel { get; set; }
    }
}
