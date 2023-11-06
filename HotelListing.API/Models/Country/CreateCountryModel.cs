using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Country
{
    public class CreateCountryModel
    {
        [Required]
        public string Name { get; set; }
        public string Shortname { get; set; }

        
    }
}
