using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
