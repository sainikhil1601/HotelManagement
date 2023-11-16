using AutoMapper;
using HotelListing.API.Contracts;
using HotelListing.API.Data;
using HotelListing.API.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace HotelListing.API.Repository
{
    public class AuthManager: IAuthManager
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApiUser> _userManager;

        public AuthManager(IMapper mapper, UserManager<ApiUser> userManager)
        {
            this._mapper = mapper;
            this._userManager = userManager;
        }

        public async Task<bool> Login(ApiLoginModel apiLoginModel)
        {
            bool isValidUser = false;
            try
            { 
           var user =  await _userManager.FindByEmailAsync(apiLoginModel.Email);
                if (user is null)
                {
                    return default;
                }
                isValidUser = await _userManager.CheckPasswordAsync(user, apiLoginModel.Password);

                if (!isValidUser)
                {
                    return default;
                }

            }
            catch (Exception) 
            {
                throw;
            }
            return isValidUser;

        }

        public async Task <IEnumerable<IdentityError>> Register(ApiUserModel usermodel) { 
        
            var user = _mapper.Map<ApiUser>(usermodel);
            user.UserName = usermodel.Email;

            var result = await _userManager.CreateAsync(user, usermodel.Password);

            if (result.Succeeded) 
            {

                await _userManager.AddToRoleAsync(user, "User");
            
            }

            return result.Errors;
        
        }
    }
}
