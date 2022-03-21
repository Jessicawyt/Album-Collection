using Microsoft.EntityFrameworkCore;
using template_csharp_album_collections.Models;


namespace template_csharp_album_collections
{

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Song> Songs { get; set; }

        const string CONNECTION_STRING = "Server=(localdb)\\mssqllocaldb; Database=AlbumsDB; Trusted_Connection=True";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION_STRING).UseLazyLoadingProxies();

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Artist
            modelBuilder.Entity<Artist>().HasData(new Artist
            {
                Id = 1,
                Name = "Kendrick Lamar",
                Genre = "Rap",
                Bio = "Born in compton",
                HeroImage = "/images/kendrick.jpg"
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
            //Album
            modelBuilder.Entity<Album>().HasData(new Album
            {   Id = 1,
                Title = "DAMN.",
                Image = "https://m.media-amazon.com/images/I/71FvMBLmheL._SL1200_.jpg",
                ArtistId = 1,
                RecordLabel = "Aftermath"
            });
            modelBuilder.Entity<Album>().HasData(new Album
            {
                Id = 2,
                Title = "Plastic Hearts",
                Image = "https://i.pinimg.com/originals/38/e0/6e/38e06ed03db63c6d75338a5a76b3135b.png",
                ArtistId = 2,
                RecordLabel = "RCA Records"

            });
            modelBuilder.Entity<Album>().HasData(new Album
            {
                Id = 3,
                Title = "House of Balloons",
                Image = "https://m.media-amazon.com/images/I/81-blrK5yoL._SL1400_.jpg",
                ArtistId = 3,
                RecordLabel = "XO"
            });
            //Song
            modelBuilder.Entity<Song>().HasData(new Song
            {
                Id = 1,
                Title = "Loyalty ft. Rihanna",
                AlbumId = 1
            });
            modelBuilder.Entity<Song>().HasData(new Song
            {
                Id = 2,
                Title = "Lust",
                AlbumId = 1
            });
            modelBuilder.Entity<Song>().HasData(new Song
            {
                Id = 3,
                Title = "Prisoner (FEAT. DUA LIPA)",
                AlbumId = 2
            });
            modelBuilder.Entity<Song>().HasData(new Song
            {
                Id = 4,
                Title = "Angels Like You",
                AlbumId = 2
            });
            modelBuilder.Entity<Song>().HasData(new Song
            {
                Id = 5,
                Title = "The Morning",
                AlbumId = 3
            });
            modelBuilder.Entity<Song>().HasData(new Song
            {
                Id = 6,
                Title = "Wicked Games",
                AlbumId = 3
            });
            //Review
            modelBuilder.Entity<Review>().HasData(new Review
            {
                Id = 1,
                ReviewerName = "Miranda",
                Content = "My boyfriend fave album",             
                AlbumId = 1
            });
            modelBuilder.Entity<Review>().HasData(new Review
            {
                Id = 2,
                ReviewerName = "user05079786",
                Content = "I really wish she could do better",
                AlbumId = 2
            });
            modelBuilder.Entity<Review>().HasData(new Review
            {
                Id = 3,
                ReviewerName = "TheWeekandJunkie",
                Content = "Love him!Praying for him every night<3",
                AlbumId = 3
            });

            base.OnModelCreating(modelBuilder);

            

        }
    }
}
