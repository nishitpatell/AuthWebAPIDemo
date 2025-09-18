using AuthWebAPIDemo.Entities;
using AuthWebAPIDemo.Models;

namespace AuthWebAPIDemo.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);
        Task<string?> Loginasync(UserDto request);
    }
}