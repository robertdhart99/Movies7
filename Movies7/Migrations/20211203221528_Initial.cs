using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies7.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreID);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberID);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    GenreID = table.Column<string>(nullable: true),
                    MemberID = table.Column<string>(nullable: true),
                    LogoImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieID);
                    table.ForeignKey(
                        name: "FK_Movies_Genres_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Genres",
                        principalColumn: "GenreID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movies_Members_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Members",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreID", "Name" },
                values: new object[,]
                {
                    { "com", "Comedy" },
                    { "hor", "Horror" },
                    { "act", "Action" },
                    { "dra", "Drama" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberID", "Name" },
                values: new object[,]
                {
                    { "har", "Hart Robert" },
                    { "dan", "Daniel Ibukunoluwa" },
                    { "emi", "Hempker Emily" },
                    { "bea", "Beasley Chevaux" },
                    { "bro", "Brown Chistopher" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "GenreID", "LogoImage", "MemberID", "Name" },
                values: new object[,]
                {
                    { "castle", "Action", "", null, "Castle Cagliostro" },
                    { "black", "Action", "", null, "Black Panther" },
                    { "nemo", "Comedy", "", null, "Finding Nemo" },
                    { "fast", "Action", "", null, "2 Fast 2 Furious" },
                    { "santa", "Comedy", "", null, "The Santa Clause" },
                    { "arsenic", "Horror", "", null, "Arsenic and Old Lace" },
                    { "saving", "Action", "", null, "Saving Private Ryan" },
                    { "fail", "Horror", "", null, "Fail Safe" },
                    { "dodgeball", "Comedy", "", null, "Dodgeball" },
                    { "long", "Comedy", "", null, "Longest Yard" },
                    { "princess", "Drama", "", null, "Princess Bride" },
                    { "October", "Drama", "", null, "October Sky" },
                    { "pirates", "Action", "", null, "Pirates of the Caribbean" },
                    { "blonde", "Comedy", "", null, "Legally Blonde" },
                    { "silent", "Horror", "", null, "Silent Hill" },
                    { "shrek4", "Comedy", "", null, "Shrek 4" },
                    { "shrek3", "Comedy", "", null, "Shrek 3" },
                    { "shrek2", "Comedy", "", null, "Shrek 2" },
                    { "shrek", "Comedy", "", null, "Shrek" },
                    { "anchor", "Comedy", "", null, "Anchor Man" },
                    { "dragon", "Action", "", null, "Dragon Ball Super" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreID",
                table: "Movies",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_MemberID",
                table: "Movies",
                column: "MemberID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
