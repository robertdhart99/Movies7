﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movies7.Models;

namespace Movies7.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Movies7.Models.Genre", b =>
                {
                    b.Property<string>("GenreID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreID");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreID = "com",
                            Name = "Comedy"
                        },
                        new
                        {
                            GenreID = "hor",
                            Name = "Horror"
                        },
                        new
                        {
                            GenreID = "act",
                            Name = "Action"
                        },
                        new
                        {
                            GenreID = "dra",
                            Name = "Drama"
                        });
                });

            modelBuilder.Entity("Movies7.Models.Member", b =>
                {
                    b.Property<string>("MemberID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Major")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberID");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            MemberID = "bea",
                            Bio = "I like cars, watching anime and playing video games",
                            Major = "Information Techology",
                            Name = "Chevaux Beasley",
                            Year = "Senior"
                        },
                        new
                        {
                            MemberID = "bro",
                            Bio = "I'm a nerd.",
                            Major = "Information Techology - Software Development",
                            Name = "Chris Brown",
                            Year = "Junior"
                        },
                        new
                        {
                            MemberID = "dan",
                            Bio = "I am groot",
                            Major = "Information Techology - Software Development || CS minor",
                            Name = "Ibukun Daniel",
                            Year = "Junior"
                        },
                        new
                        {
                            MemberID = "har",
                            Bio = "I go by Bobby. I am about to finish my IT software dev and cybersecurity degrees. I love spending time outdoors but also like playing games.",
                            Major = "Information Techology - Software Development || Cyber Security",
                            Name = "Robert Hart",
                            Year = "Senior"
                        },
                        new
                        {
                            MemberID = "emi",
                            Bio = "I'm a weeb and a furry.",
                            Major = "Information Techology - Software Development",
                            Name = "Emily Hempker",
                            Year = "Junior"
                        });
                });

            modelBuilder.Entity("Movies7.Models.Movie", b =>
                {
                    b.Property<string>("MovieID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GenreID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LogoImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieID");

                    b.HasIndex("GenreID");

                    b.HasIndex("MemberID");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieID = "shrek",
                            GenreID = "com",
                            LogoImage = "shrek.png",
                            MemberID = "emi",
                            Name = "Shrek"
                        },
                        new
                        {
                            MovieID = "shrek2",
                            GenreID = "com",
                            LogoImage = "shrek_2.png",
                            MemberID = "emi",
                            Name = "Shrek 2"
                        },
                        new
                        {
                            MovieID = "shrek3",
                            GenreID = "com",
                            LogoImage = "shrek_3.png",
                            MemberID = "emi",
                            Name = "Shrek 3"
                        },
                        new
                        {
                            MovieID = "shrek4",
                            GenreID = "com",
                            LogoImage = "shrek_4.png",
                            MemberID = "emi",
                            Name = "Shrek 4"
                        },
                        new
                        {
                            MovieID = "silent",
                            GenreID = "hor",
                            LogoImage = "silent_hill.png",
                            MemberID = "emi",
                            Name = "Silent Hill"
                        },
                        new
                        {
                            MovieID = "long",
                            GenreID = "com",
                            LogoImage = "longest_yard.png",
                            MemberID = "har",
                            Name = "Longest Yard"
                        },
                        new
                        {
                            MovieID = "pirates",
                            GenreID = "act",
                            LogoImage = "pirates_caribbean.png",
                            MemberID = "har",
                            Name = "Pirates of the Caribbean"
                        },
                        new
                        {
                            MovieID = "October",
                            GenreID = "dra",
                            LogoImage = "october_sky.png",
                            MemberID = "har",
                            Name = "October Sky"
                        },
                        new
                        {
                            MovieID = "princess",
                            GenreID = "dra",
                            LogoImage = "princess_bride.png",
                            MemberID = "har",
                            Name = "Princess Bride"
                        },
                        new
                        {
                            MovieID = "castle",
                            GenreID = "act",
                            LogoImage = "castle_cagliostro.png",
                            MemberID = "bro",
                            Name = "Castle Cagliostro"
                        },
                        new
                        {
                            MovieID = "fail",
                            GenreID = "hor",
                            LogoImage = "fail_safe_64.png",
                            MemberID = "bro",
                            Name = "Fail Safe"
                        },
                        new
                        {
                            MovieID = "saving",
                            GenreID = "act",
                            LogoImage = "saving_private_ryan.png",
                            MemberID = "bro",
                            Name = "Saving Private Ryan"
                        },
                        new
                        {
                            MovieID = "arsenic",
                            GenreID = "hor",
                            LogoImage = "arsenic_old_lace.png",
                            MemberID = "bro",
                            Name = "Arsenic and Old Lace"
                        },
                        new
                        {
                            MovieID = "santa",
                            GenreID = "com",
                            LogoImage = "santa_clause.png",
                            MemberID = "bro",
                            Name = "The Santa Clause"
                        },
                        new
                        {
                            MovieID = "fast",
                            GenreID = "act",
                            LogoImage = "2_fast_2_furious.png",
                            MemberID = "bea",
                            Name = "2 Fast 2 Furious"
                        },
                        new
                        {
                            MovieID = "nemo",
                            GenreID = "com",
                            LogoImage = "finding_nemo.png",
                            MemberID = "bea",
                            Name = "Finding Nemo"
                        },
                        new
                        {
                            MovieID = "black",
                            GenreID = "act",
                            LogoImage = "black_panther.png",
                            MemberID = "bea",
                            Name = "Black Panther"
                        },
                        new
                        {
                            MovieID = "blonde",
                            GenreID = "com",
                            LogoImage = "legally_blonde.png",
                            MemberID = "bea",
                            Name = "Legally Blonde"
                        },
                        new
                        {
                            MovieID = "dragon",
                            GenreID = "act",
                            LogoImage = "db_super_broly.png",
                            MemberID = "bea",
                            Name = "Dragon Ball Super"
                        },
                        new
                        {
                            MovieID = "rn",
                            GenreID = "act",
                            LogoImage = "red_notice.png",
                            MemberID = "dan",
                            Name = "Red Notice"
                        },
                        new
                        {
                            MovieID = "hog",
                            GenreID = "dra",
                            LogoImage = "house_gucci.png",
                            MemberID = "dan",
                            Name = "House of Gucci"
                        },
                        new
                        {
                            MovieID = "ttb",
                            GenreID = "dra",
                            LogoImage = "train_to_busan.png",
                            MemberID = "dan",
                            Name = "Train to Busan"
                        },
                        new
                        {
                            MovieID = "par",
                            GenreID = "hor",
                            LogoImage = "parasite.png",
                            MemberID = "dan",
                            Name = "Parasite"
                        },
                        new
                        {
                            MovieID = "free",
                            GenreID = "com",
                            LogoImage = "free_guy.png",
                            MemberID = "dan",
                            Name = "Free Guy"
                        });
                });

            modelBuilder.Entity("Movies7.Models.Movie", b =>
                {
                    b.HasOne("Movies7.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreID");

                    b.HasOne("Movies7.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberID");
                });
#pragma warning restore 612, 618
        }
    }
}
