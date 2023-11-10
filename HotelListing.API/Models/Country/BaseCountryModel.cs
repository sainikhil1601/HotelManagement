using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Country
{
    public class BaseCountryModel
    {
        [Required]
        public string Name { get; set; }
        public string Shortname { get; set; }
    }
}
