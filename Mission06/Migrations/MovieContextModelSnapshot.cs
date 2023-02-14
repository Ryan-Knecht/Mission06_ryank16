﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06.Models;

namespace Mission06.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission06.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Category = "Adventure",
                            Director = "Steven Spielberg",
                            Edited = false,
                            Rating = "PG",
                            Title = "Hook",
                            Year = 1991
                        },
                        new
                        {
                            MovieID = 2,
                            Category = "Comedy",
                            Director = "Richard Linklater",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "School of Rock",
                            Year = 2003
                        },
                        new
                        {
                            MovieID = 3,
                            Category = "Action",
                            Director = "Edgar Wright",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Scott Pilgrim vs. the World",
                            Year = 2010
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
