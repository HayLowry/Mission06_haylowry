using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_haylowry.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext (DbContextOptions<MoviesContext> options) : base (options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    cateogry = "Action/Adventure",
                    title = "Inception",
                    year = 2010,
                    director = "Christopher Nolan",
                    rating = "PG-13"
                },
                new Movie
                {
                    MovieId = 2,
                    cateogry = "Drama",
                    title = "Pride & Prejudice",
                    year = 2005,
                    director = "Joe Wright",
                    rating = "PG"
                },
                new Movie
                {
                    MovieId = 3,
                    cateogry = "Comedy",
                    title = "Bee Movie",
                    year = 2007,
                    director = "Simon J. Smith",
                    rating = "PG"
                }
            );
        }
    }
}
