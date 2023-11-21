using AutoMapper;
using HotelListing.API.Data;

using HotelListing.API.Models.Hotel;
using HotelListing.API.Models.Users;

namespace HotelListing.API.Configurations
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        {
    
                
                CreateMap<Hotel, HotelModel>().ReverseMap();
                CreateMap<Hotel, CreateHotelModel>().ReverseMap();

                CreateMap<ApiUserModel, ApiUser>().ReverseMap();

        }
    }
}
