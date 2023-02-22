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
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<Movie> movies { get; set; }
        public DbSet<Category> Categories {get; set;}


        //Add the categories        
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName= "Adventure" },
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Action" },
                new Category { CategoryID = 4, CategoryName = "Horror" },
                new Category { CategoryID = 5, CategoryName = "Suspense" },
                new Category { CategoryID = 6, CategoryName = "Adventure" },
                new Category { CategoryID = 7, CategoryName = "Romance" },
                new Category { CategoryID = 8, CategoryName = "Documentary" },
                new Category { CategoryID = 9, CategoryName = "Fantasy" }
            );

            //Seed the database with 3 movies
            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieID = 1,
                    CategoryID = 1,
                    Title = "Hook",
                    Year = 1991,
                    Director = "Steven Spielberg",
                    Rating = "PG"
                },
                new Movie
                {
                    MovieID = 2,
                    CategoryID = 2,
                    Title = "School of Rock",
                    Year = 2003,
                    Director = "Richard Linklater",
                    Rating = "PG-13"
                },
                new Movie
                {
                    MovieID = 3,
                    CategoryID = 3,
                    Title = "Scott Pilgrim vs. the World",
                    Year = 2010,
                    Director = "Edgar Wright",
                    Rating = "PG-13"
                }
            );
        }
    }
}
