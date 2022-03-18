﻿using Microsoft.EntityFrameworkCore;
using template_csharp_album_collections.Models;

<<<<<<< HEAD
namespace template_csharp_album_collections
{

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        const string CONNECTION_STRING = "Server=(localdb)\\mssqllocaldb; Database=AlbumsDB; Trusted_Connection=True";

=======

namespace template_csharp_album_collections
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        const string CONNECTION_STRING = "Server=(localdb)\\mssqllocaldb; Database=AlbumsDB; Trusted_Connection=True";

       
>>>>>>> 69ed26d6781a6524a85b47ad8c651e5f798a60e4
        //Add DBSets here

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION_STRING);
<<<<<<< HEAD
=======
            optionsBuilder.UseLazyLoadingProxies();
>>>>>>> 69ed26d6781a6524a85b47ad8c651e5f798a60e4
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
<<<<<<< HEAD
            //Artist

            //Album
            modelBuilder.Entity<Album>().HasData(
                new Album() { Id = 1,
                    Title = "DAMN.",
                    Image = "https://m.media-amazon.com/images/I/71FvMBLmheL._SL1200_.jpg",
                    ArtistId = 1,
                    RecordLabel = "Aftermath"}
                );
            modelBuilder.Entity<Album>().HasData(
                new Album()
                {
                    Id = 2,
                    Title = "Plastic Hearts",
                    Image = "https://i.pinimg.com/originals/38/e0/6e/38e06ed03db63c6d75338a5a76b3135b.png",
                    ArtistId = 2,
                    RecordLabel = "RCA Records"

                }
                );
            modelBuilder.Entity<Album>().HasData(
                new Album()
                {
                    Id = 1,
                    Title = "House of Balloons",
                    Image = "https://m.media-amazon.com/images/I/81-blrK5yoL._SL1400_.jpg",
                    ArtistId = 3,
                    RecordLabel = "XO"
                }
                );
            //Song

            //Review
=======
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Artist>().HasData(new Artist
            {
                Id = 1,
                Name = "Kendrick Lamar",
                Genre = "Rap",
                Bio = "Born in compton",
                HeroImage= "/images/kendrick.jpg"
            });

            modelBuilder.Entity<Artist>().HasData(new Artist
            {
                Id = 2,
                Name = "Miley Cyrus",
                Genre = "Pop",
                Bio = "Daughter of Billy Ray",
                HeroImage = "/images/miley.jpg"
            });



            modelBuilder.Entity<Artist>().HasData(new Artist
            {
                Id = 3,
                Name = "The Weekend",
                Genre = "R&B",
                Bio = "Abel Makkonen Tefaye, Known professionally as the Weekend",
                HeroImage = "/images/theweekend.webp"
            });
>>>>>>> 69ed26d6781a6524a85b47ad8c651e5f798a60e4




<<<<<<< HEAD
=======



           
>>>>>>> 69ed26d6781a6524a85b47ad8c651e5f798a60e4
        }
    }
}
