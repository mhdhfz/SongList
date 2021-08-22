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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    SongId = 1,
                    Name = "Assalamualaikum",
                    Year = 2018,
                    Rating = 5
                },
                new Song
                {
                    SongId = 2,
                    Name = "Dewi Puspita",
                    Year = 2021,
                    Rating = 4
                },
                new Song
                {
                    SongId = 3,
                    Name = "Nak Dara Rindu",
                    Year = 2021,
                    Rating = 3
                });
        }
    }
}
