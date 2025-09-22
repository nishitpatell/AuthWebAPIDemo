using AuthWebAPIDemo.Entities;
using AuthWebAPIDemo.Models;

namespace AuthWebAPIDemo.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);
        Task<TokenResponseDto?> Loginasync(UserDto request);
        //client side app will call this method after certai intervals while the user is using the app.
        Task<TokenResponseDto?> RefreshTokenAsync(RefreshTokenRequestDto request);
    }
}