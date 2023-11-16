using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Users
{
    public class ApiUserModel: ApiLoginModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        
    }


}
