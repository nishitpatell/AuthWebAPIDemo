using AuthWebAPIDemo.Entities;
using AuthWebAPIDemo.Models;
using AuthWebAPIDemo.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthWebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<User?>> Register(UserDto request)
        {
            var user = await _authService.RegisterAsync(request);
            if (user is null)
                return BadRequest("Username already exists");
            return Ok(user);
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserDto request)
        {
            string token = await _authService.Loginasync(request);
            if(token is null)
                return BadRequest("Username/password is wrong");
            return Ok(token);
        }

        [HttpGet("Auth-Endpoint")]
        [Authorize]
        public ActionResult AuthCheck()
        {
            return Ok("You are able to access this end point");
        }

        [HttpGet("Admin-EndPoint")]
        [Authorize(Roles = "Admin")]
        public ActionResult AdminCheck()
        {
            return Ok("You are able to access this end point");
        }
    }
}
