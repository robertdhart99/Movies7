﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movies7.Models;

namespace Movies7.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20211204162905_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberID");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            MemberID = "bea",
                            Name = "Beasley Chevaux"
                        },
                        new
                        {
                            MemberID = "bro",
                            Name = "Brown Chistopher"
                        },
                        new
                        {
                            MemberID = "dan",
                            Name = "Daniel Ibukunoluwa"
                        },
                        new
                        {
                            MemberID = "har",
                            Name = "Hart Robert"
                        },
                        new
                        {
                            MemberID = "emi",
                            Name = "Hempker Emily"
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
                            LogoImage = "",
                            Name = "Shrek"
                        },
                        new
                        {
                            MovieID = "shrek2",
                            GenreID = "com",
                            LogoImage = "",
                            Name = "Shrek 2"
                        },
                        new
                        {
                            MovieID = "shrek3",
                            GenreID = "com",
                            LogoImage = "",
                            Name = "Shrek 3"
                        },
                        new
                        {
                            MovieID = "shrek4",
                            GenreID = "com",
                            LogoImage = "",
                            Name = "Shrek 4"
                        },
                        new
                        {
                            MovieID = "silent",
                            GenreID = "hor",
                            LogoImage = "",
                            Name = "Silent Hill"
                        },
                        new
                        {
                            MovieID = "long",
                            GenreID = "com",
                            LogoImage = "",
                            Name = "Longest Yard"
                        },
                        new
                        {
                            MovieID = "pirates",
                            GenreID = "act",
                            LogoImage = "",
                            Name = "Pirates of the Caribbean"
                        },
                        new
                        {
                            MovieID = "October",
                            GenreID = "dra",
                            LogoImage = "",
                            Name = "October Sky"
                        },
                        new
                        {
                            MovieID = "princess",
                            GenreID = "dra",
                            LogoImage = "",
                            Name = "Princess Bride"
                        },
                        new
                        {
                            MovieID = "anchor",
                            GenreID = "com",
                            LogoImage = "",
                            Name = "Anchor Man"
                        },
                        new
                        {
                            MovieID = "dodgeball",
                            GenreID = "com",
                            LogoImage = "",
                            Name = "Dodgeball"
                        },
                        new
                        {
                            MovieID = "castle",
                            GenreID = "act",
                            LogoImage = "",
                            Name = "Castle Cagliostro"
                        },
                        new
                        {
                            MovieID = "fail",
                            GenreID = "hor",
                            LogoImage = "",
                            Name = "Fail Safe"
                        },
                        new
                        {
                            MovieID = "saving",
                            GenreID = "act",
                            LogoImage = "",
                            Name = "Saving Private Ryan"
                        },
                        new
                        {
                            MovieID = "arsenic",
                            GenreID = "hor",
                            LogoImage = "",
                            Name = "Arsenic and Old Lace"
                        },
                        new
                        {
                            MovieID = "santa",
                            GenreID = "com",
                            LogoImage = "",
                            Name = "The Santa Clause"
                        },
                        new
                        {
                            MovieID = "fast",
                            GenreID = "act",
                            LogoImage = "",
                            Name = "2 Fast 2 Furious"
                        },
                        new
                        {
                            MovieID = "nemo",
                            GenreID = "com",
                            LogoImage = "",
                            Name = "Finding Nemo"
                        },
                        new
                        {
                            MovieID = "black",
                            GenreID = "act",
                            LogoImage = "",
                            Name = "Black Panther"
                        },
                        new
                        {
                            MovieID = "blonde",
                            GenreID = "com",
                            LogoImage = "",
                            Name = "Legally Blonde"
                        },
                        new
                        {
                            MovieID = "dragon",
                            GenreID = "act",
                            LogoImage = "",
                            Name = "Dragon Ball Super"
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
