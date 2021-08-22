using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongList.Models
{
    public class SongContext : DbContext
    {
        public SongContext(DbContextOptions<SongContext> options)
            : base(options)
        {
        }

        public DbSet<Song> Songs { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = "R" , Name = "Rap"},
                new Genre { GenreId = "I" , Name = "Indie"},
                new Genre { GenreId = "H" , Name = "Hip Hop"},
                new Genre { GenreId = "K" , Name = "Klasik"}
                );

            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    SongId = 1,
                    Name = "Assalamualaikum",
                    Year = 2018,
                    Rating = 5,
                    GenreId = "R"
                },
                new Song
                {
                    SongId = 2,
                    Name = "Dewi Puspita",
                    Year = 2021,
                    Rating = 4,
                    GenreId = "I"
                },
                new Song
                {
                    SongId = 3,
                    Name = "Nak Dara Rindu",
                    Year = 2021,
                    Rating = 3,
                    GenreId = "K"
                },               
                new Song
                {
                    SongId = 4,
                    Name = "Pagi Yang Gelap",
                    Year = 2008,
                    Rating = 4,
                    GenreId = "I"
                });
        }
    }
}
