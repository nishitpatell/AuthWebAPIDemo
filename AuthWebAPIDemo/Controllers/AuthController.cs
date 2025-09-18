using AuthWebAPIDemo.Entities;
using AuthWebAPIDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuthWebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private static User user = new User();
        [HttpPost("register")]
        public ActionResult<User?> Register(UserDto request)
        {
            user.Username = request.Username;
            user.PasswordHash = new PasswordHasher<User>()
                .HashPassword(user, request.Password);

            return Ok(user);
        }

        [HttpPost("login")]
        public ActionResult<User?> Login(UserDto request)
        {

        }
    }
}
