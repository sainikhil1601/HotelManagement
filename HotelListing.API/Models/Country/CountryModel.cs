using HotelListing.API.Models.Hotel;

namespace HotelListing.API.Models.Country
{
    public class CountryModel
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Shortname { get; set; }

            public List<HotelModel> Hotels { get; set; }
        }
    }


