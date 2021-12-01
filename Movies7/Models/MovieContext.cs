using Microsoft.EntityFrameworkCore;

namespace Movies7.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreID = "com", Name = "Comedy"},
                new Genre { GenreID = "hor", Name = "Horror" }, 
                new Genre { GenreID = "act", Name = "Action" }, 
                new Genre { GenreID = "dra", Name = "Drama" }
            );
            modelBuilder.Entity<Member>().HasData(
                new Member { MemberID = "bea", Name = "Beasley Chevaux" },
                new Member { MemberID = "bro", Name = "Brown Chistopher" },
                new Member { MemberID = "dan", Name = "Daniel Ibukunoluwa" },
                new Member { MemberID = "har", Name = "Hart Robert" }, 
                new Member { MemberID = "emi", Name = "Hempker Emily" }
            );
            modelBuilder.Entity<Movie>().HasData(
               new { MovieID = "shrek", Name = "Shrek", GenreID = "Comedy", LogoImage = "" },
               new { MovieID = "shrek2", Name = "Shrek 2", GenreID = "Comedy", LogoImage = "" },
               new { MovieID = "shrek3", Name = "Shrek 3", GenreID = "Comedy", LogoImage = "" },
               new { MovieID = "shrek4", Name = "Shrek 4", GenreID = "Comedy", LogoImage = "" },
               new { MovieID = "silent", Name = "Silent Hill", GenreID = "Horror", LogoImage = "" },
               new { MovieID = "long", Name = "Longest Yard", GenreID = "Comedy", LogoImage = "" },
               new { MovieID = "pirates", Name = "Pirates of the Caribbean", GenreID = "Action", LogoImage = "" },
               new { MovieID = "October", Name = "October Sky", GenreID = "Drama", LogoImage = "" },
               new { MovieID = "princess", Name = "Princess Bride", GenreID = "Drama", LogoImage = "" },
               new { MovieID = "anchor", Name = "Anchor Man", GenreID = "Comedy", LogoImage = "" },
               new { MovieID = "dodgeball", Name = "Dodgeball", GenreID = "Comedy", LogoImage = "" },
               new { MovieID = "castle", Name = "Castle Cagliostro", GenreID = "Action", LogoImage = "" },
               new { MovieID = "fail", Name = "Fail Safe", GenreID = "Horror", LogoImage = "" },
               new { MovieID = "saving", Name = "Saving Private Ryan", GenreID = "Action", LogoImage = "" },
               new { MovieID = "arsenic", Name = "Arsenic and Old Lace", GenreID = "Horror", LogoImage = "" },
               new { MovieID = "santa", Name = "The Santa Clause", GenreID = "Comedy", LogoImage = "" },
               new { MovieID = "fast", Name = "2 Fast 2 Furious", GenreID = "Action", LogoImage = "" },
               new { MovieID = "nemo", Name = "Finding Nemo", GenreID = "Comedy", LogoImage = "" }, 
               new { MovieID = "black", Name = "Black Panther", GenreID = "Action", LogoImage = "" }, 
               new { MovieID = "blonde", Name = "Legally Blonde", GenreID = "Comedy", LogoImage = "" },
               new { MovieID = "dragon", Name = "Dragon Ball Super", GenreID = "Action", LogoImage = "" }






           );
        }
    }
}
