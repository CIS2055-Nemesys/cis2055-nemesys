﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using nemesis.Models.Contexts;

#nullable disable

namespace nemesis.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230503102236_identity")]
    partial class identity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("nemesis.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Uncategorised"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Unsafe act"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Condition"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Equipment"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Structure"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Apocalyptic Event"
                        });
                });

            modelBuilder.Entity("nemesis.Models.Investigation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfAction")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InvestigatorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Investigations");
                });

            modelBuilder.Entity("nemesis.Models.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfReport")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateSpotted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InvestigationId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Upvotes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatedByUserId");

                    b.ToTable("Reports");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 6,
                            CreatedByUserId = 2,
                            DateOfReport = new DateTime(2023, 4, 15, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1416),
                            DateSpotted = new DateTime(2023, 4, 13, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1405),
                            Description = "I've recently discovered that the Maghtab garbage dump is actually an active volcano. Not only that, it's apparently sentient and has been constantly demanding tribute in the form of human sacrifice, will the authorities please do something about this before it loses its patience and destroys us all?!",
                            ImageUrl = "/images/SentientVolcano.jpg",
                            Location = "Maghtab",
                            Status = false,
                            Title = "Sentient volcano",
                            Upvotes = 178
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 4,
                            CreatedByUserId = 3,
                            DateOfReport = new DateTime(2023, 4, 21, 12, 46, 36, 71, DateTimeKind.Utc).AddTicks(1531),
                            DateSpotted = new DateTime(2023, 4, 21, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1529),
                            Description = "Someone must be having a bad morning because as I was driving up to work, a truck tyre bounced off my dashboard and kept rolling down the road! I hope some unsuspecting jogger doesn't cross its path because then he'll definitely end up getting 'tyred'.",
                            ImageUrl = "/images/RunawayTyre.jpg",
                            Location = "Birzebbugia",
                            Status = false,
                            Title = "Runaway Tyre",
                            Upvotes = 43
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CreatedByUserId = 5,
                            DateOfReport = new DateTime(2023, 4, 22, 11, 34, 36, 71, DateTimeKind.Utc).AddTicks(1538),
                            DateSpotted = new DateTime(2023, 4, 22, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1537),
                            Description = "Just this evening I took the kids to the children's playground and was shocked when I noticed that one of them had grown an extra appendage! Apparently while I was chatting with the other parents, the kids had found a barrel of radioactive waste hidden in a small room underneath the playground and were making sand castles out of the stuff!",
                            ImageUrl = "/images/RadioactiveBarrel.jpg",
                            Location = "Hal-Qormi",
                            Status = false,
                            Title = "Radioactive Barrels",
                            Upvotes = 482
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            CreatedByUserId = 1,
                            DateOfReport = new DateTime(2023, 4, 28, 12, 46, 36, 71, DateTimeKind.Utc).AddTicks(1542),
                            DateSpotted = new DateTime(2023, 4, 28, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1540),
                            Description = "There is a missing manhole cover on the highway just outside of Cikku bar, I think the storm last night dislodged it and now it's posing a danger to anyone driving through that road. I hope it gets investigated before someone gets hurt!",
                            ImageUrl = "/images/Manhole.jpg",
                            Location = "Haz-Zebbug",
                            Status = false,
                            Title = "Missing manhole cover",
                            Upvotes = 25
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            CreatedByUserId = 4,
                            DateOfReport = new DateTime(2023, 5, 1, 12, 46, 36, 71, DateTimeKind.Utc).AddTicks(1545),
                            DateSpotted = new DateTime(2023, 5, 1, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1544),
                            Description = "I heard some commotion last night but thought it was just the local gang of racoons as usual so I slept through it. This morning, I find that a meteor containing alien worms had crash landed in my backyard! At first I came out with my trusty broomstick but it turns out they're incredibly friendly! I assure you they absolutely have not infiltrated my brain, and are definitely not forcing me to write this. By the way everyone should come see for themselves as soon as possible, the Hivemind demands it.",
                            ImageUrl = "/images/Meteor.jpg",
                            Location = "Siggiewi",
                            Status = false,
                            Title = "Meteor in my backyard",
                            Upvotes = 782
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 6,
                            CreatedByUserId = 4,
                            DateOfReport = new DateTime(2023, 4, 30, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1549),
                            DateSpotted = new DateTime(2023, 4, 29, 22, 22, 36, 71, DateTimeKind.Utc).AddTicks(1548),
                            Description = "I was taking a lovely stroll on the beach last night when suddenly, my partner noted that the ancient old god Cthulhu had manifested out of the sea, heralding the end of days for humanity",
                            ImageUrl = "/images/Cthulhu.jpg",
                            Location = "Ghar Lapsi",
                            Status = false,
                            Title = "Old God rises from the depths",
                            Upvotes = 777
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            CreatedByUserId = 5,
                            DateOfReport = new DateTime(2023, 5, 1, 0, 46, 36, 71, DateTimeKind.Utc).AddTicks(1556),
                            DateSpotted = new DateTime(2023, 4, 30, 22, 22, 36, 71, DateTimeKind.Utc).AddTicks(1552),
                            Description = "We were having lunch at Zeppi's Diner last night when suddenly, a rodent the size of a car scurried out of the kitchen! I have to say it really put us off finishing the meal. I hope the food safety authorities see this post!",
                            ImageUrl = "/images/GiantRodent.jpg",
                            Location = "Hamrun",
                            Status = false,
                            Title = "Giant rodent",
                            Upvotes = 246
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            CreatedByUserId = 5,
                            DateOfReport = new DateTime(2023, 5, 1, 12, 46, 36, 71, DateTimeKind.Utc).AddTicks(1560),
                            DateSpotted = new DateTime(2023, 5, 1, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1559),
                            Description = "We went out for dinner at Fonzu's last night and were having a great time! Hats off to the guy who was playing the accordion with his feet. I ordered the special 'Fonzu's Burger' off the menu, and, to say the least, was shocked when the waitress brought it to the table. It was just a clump of greasy hair! I don't know who thought this was a good idea or how it passed any form of review! Talk about finding a hair in the food! ",
                            ImageUrl = "/images/HairBurger.jpeg",
                            Location = "Naxxar",
                            Status = false,
                            Title = "Hairy Burger",
                            Upvotes = 52
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            CreatedByUserId = 3,
                            DateOfReport = new DateTime(2023, 5, 1, 22, 22, 36, 71, DateTimeKind.Utc).AddTicks(1564),
                            DateSpotted = new DateTime(2023, 5, 1, 17, 34, 36, 71, DateTimeKind.Utc).AddTicks(1563),
                            Description = "I was out shopping with the kids when we came across a passed out man in the middle of the sidewalk. Normally I wouldn't post something like this, because let's face it, we've all been there. However, what really bothered me was that he was snoring so loud it sounded like an entire trombone orchestra! Simply unacceptable!",
                            ImageUrl = "/images/ManPassedOut.jpg",
                            Location = "Bormla",
                            Status = false,
                            Title = "Passed out man",
                            Upvotes = 120
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 6,
                            CreatedByUserId = 4,
                            DateOfReport = new DateTime(2023, 5, 2, 15, 10, 36, 71, DateTimeKind.Utc).AddTicks(1568),
                            DateSpotted = new DateTime(2023, 5, 2, 10, 22, 36, 71, DateTimeKind.Utc).AddTicks(1567),
                            Description = "HOW IS THIS ACCEPTABLE!? MY FAVOURITE HEINZ BAKED BEANZ HAVE BEEN OUT OF STOCK FOR THE LAST 2 DAYS!??!1?111? HOW AM I SUPPOSED TO FEED MY CHILDREN A NUTRITIOUS BREAKFAST IF I DON'T HAVE ANY BEANZ! WHY AREN'T THERE ANY BEANZ!?!11?",
                            ImageUrl = "/images/MissingBeans.webp",
                            Location = "Mosta",
                            Status = false,
                            Title = "MISSING BEANZ",
                            Upvotes = 345
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 1,
                            CreatedByUserId = 5,
                            DateOfReport = new DateTime(2023, 5, 3, 3, 10, 36, 71, DateTimeKind.Utc).AddTicks(1572),
                            DateSpotted = new DateTime(2023, 5, 2, 22, 22, 36, 71, DateTimeKind.Utc).AddTicks(1571),
                            Description = "Like most of you, I buy my toilet paper from the gas station. I was disgusted this morning when some --redacted-- bought out the entire shop! Does this guy have ten --redacted--!? How am I supposed to wipe my --redacted-- without any toilet paper?!",
                            ImageUrl = "/images/ToiletPaperHoarder",
                            Location = "Mosta",
                            Status = false,
                            Title = "Toilet Paper Hoarder",
                            Upvotes = 498
                        });
                });

            modelBuilder.Entity("nemesis.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInvestigator")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhoneNum")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "chalijgatt@sampleemail.com",
                            IsInvestigator = false,
                            Name = "Charles",
                            PhoneNum = 44236421,
                            Surname = "Gatt"
                        },
                        new
                        {
                            Id = 2,
                            Email = "dimpeter@sampleemail.com",
                            IsInvestigator = false,
                            Name = "Peter",
                            PhoneNum = 12345668,
                            Surname = "Dimech"
                        },
                        new
                        {
                            Id = 3,
                            Email = "valbutt@sampleemail.com",
                            IsInvestigator = true,
                            Name = "Valentina",
                            PhoneNum = 36435173,
                            Surname = "Buttigieg"
                        },
                        new
                        {
                            Id = 4,
                            Email = "david_d_best@sampleemail.com",
                            IsInvestigator = false,
                            Name = "David",
                            PhoneNum = 77777777,
                            Surname = "Briffa"
                        },
                        new
                        {
                            Id = 5,
                            Email = "borgwayne420@sampleemail.com",
                            IsInvestigator = false,
                            Name = "Wayne",
                            PhoneNum = 94215242,
                            Surname = "Borg"
                        });
                });

            modelBuilder.Entity("nemesis.ViewModels.CategoryViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CategoryViewModel");
                });

            modelBuilder.Entity("nemesis.ViewModels.ReportViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfReport")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateSpotted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InvestigationId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Upvotes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatedByUserId");

                    b.ToTable("ReportViewModel");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("nemesis.Models.Report", b =>
                {
                    b.HasOne("nemesis.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("nemesis.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("CreatedByUser");
                });

            modelBuilder.Entity("nemesis.ViewModels.ReportViewModel", b =>
                {
                    b.HasOne("nemesis.ViewModels.CategoryViewModel", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("nemesis.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("CreatedByUser");
                });
#pragma warning restore 612, 618
        }
    }
}