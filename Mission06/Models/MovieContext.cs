using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06.Models
{
    public class MovieContext : DbContext
    {
        // Constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            //Leave blank for now
        }

        public DbSet<Movie> movies { get; set; }


        //Seed the database with 3 movies
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieID = 1,
                    Category = "Adventure",
                    Title = "Hook",
                    Year = 1991,
                    Director = "Steven Spielberg",
                    Rating = "PG"
                },
                new Movie
                {
                    MovieID = 2,
                    Category = "Comedy",
                    Title = "School of Rock",
                    Year = 2003,
                    Director = "Richard Linklater",
                    Rating = "PG-13"
                },
                new Movie
                {
                    MovieID = 3,
                    Category = "Action",
                    Title = "Scott Pilgrim vs. the World",
                    Year = 2010,
                    Director = "Edgar Wright",
                    Rating = "PG-13"
                }
            );
        }
    }
}
