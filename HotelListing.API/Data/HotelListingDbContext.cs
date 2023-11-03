using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext: DbContext
    {
        public HotelListingDbContext(DbContextOptions options): base(options) { 
        
        
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country { 
                
                Id = 1,
                Name = "Costa Rica",
                Shortname = "CR"

                },
                new Country {

                    Id = 2,
                    Name = "Jamaica",
                    Shortname = "JM"

                },
                new Country
                {

                    Id = 3,
                    Name = "Japan",
                    Shortname = "JP"

                } );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {

                    Id = 1,
                    Name = "Puma Resort",
                    Address = "Puerto Viejo",
                    CountryId = 1,
                    Rating = 4.5

                },
                new Hotel
                {

                    Id = 2,
                    Name = "Grand Idia",
                    Address = "Blv B",
                    CountryId = 2,
                    Rating = 3

                },
                new Hotel
                {

                    Id = 3,
                    Name = "Grand Resort",
                    Address = "Osaka",
                    CountryId = 3,
                    Rating = 4

                });








        }




    }
}
