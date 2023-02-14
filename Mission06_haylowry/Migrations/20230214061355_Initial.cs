using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_haylowry.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cateogry = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: false),
                    director = table.Column<string>(nullable: true),
                    rating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "cateogry", "director", "rating", "title", "year" },
                values: new object[] { 1, "Action/Adventure", "Christopher Nolan", "PG-13", "Inception", 2010 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "cateogry", "director", "rating", "title", "year" },
                values: new object[] { 2, "Drama", "Joe Wright", "PG", "Pride & Prejudice", 2005 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "cateogry", "director", "rating", "title", "year" },
                values: new object[] { 3, "Comedy", "Simon J. Smith", "PG", "Bee Movie", 2007 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
