namespace NFLTeams.Models
{
    public class Movie
    {
        public string MovieID { get; set; }
        public string Name { get; set; }
        public Year Year { get; set; }
        public Genre Genre { get; set; }
        public string LogoImage { get; set; }
    }
}
