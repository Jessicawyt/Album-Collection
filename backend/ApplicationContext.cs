using Microsoft.EntityFrameworkCore;
using template_csharp_album_collections.Models;

namespace template_csharp_album_collections
{

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        const string CONNECTION_STRING = "Server=(localdb)\\mssqllocaldb; Database=AlbumsDB; Trusted_Connection=True";

        //Add DBSets here

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION_STRING);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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




        }
    }
}
