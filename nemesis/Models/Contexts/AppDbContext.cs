using Microsoft.EntityFrameworkCore;

namespace nemesis.Models.Contexts
{
    public class AppDbContext : DbContext
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
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Name = "Charles",
                    Surname = "Gatt",
                    Email = "chalijgatt@sampleemail.com",
                    PhoneNum = 44236421,
                    Ranking = null,
                    IsInvestigator = false,
                },
                new User()
                {
                    Id = 2,
                    Name = "Peter",
                    Surname = "Dimech",
                    Email = "dimpeter@sampleemail.com",
                    PhoneNum = 12345668,
                    Ranking = null,
                    IsInvestigator = false,
                },
                new User()
                {
                    Id = 3,
                    Name = "Valentina",
                    Surname = "Buttigieg",
                    Email = "valbutt@sampleemail.com",
                    PhoneNum = 36435173,
                    Ranking = null,
                    IsInvestigator = true,
                },
                new User()
                {
                    Id = 4,
                    Name = "David",
                    Surname = "Briffa",
                    Email = "david_d_best@sampleemail.com",
                    PhoneNum = 77777777,
                    Ranking = null,
                    IsInvestigator = false,
                },
                new User()
                {
                    Id = 5,
                    Name = "Wayne",
                    Surname = "Borg",
                    Email = "borgwayne420@sampleemail.com",
                    PhoneNum = 94215242,
                    Ranking = null,
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
                }
            );
        }
    }
}
