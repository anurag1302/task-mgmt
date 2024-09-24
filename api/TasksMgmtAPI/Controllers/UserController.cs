
using Microsoft.AspNetCore.Mvc;
using TasksMgmt.API.Models;
using TasksMgmt.Core.Entities;
using TasksMgmtAPI.Models;
using TasksMgmtAPI.Utilities;

namespace TasksMgmtAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IPasswordHasher _passwordsHasher;
        private static List<User> users = [];

        public UserController(IPasswordHasher passwordsHasher)
        {
            _passwordsHasher = passwordsHasher;
        }

        [HttpPost("register")]
        public IActionResult Register(UserModel userModel)
        {
            var passwordHash = _passwordsHasher.GeneratePasswordHash(userModel.Password);
            var savedUser = new User
            {
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                PasswordHash = passwordHash,
                Email = userModel.Email,
                DateOfBirth = userModel.DateOfBirth
            };
            users.Add(savedUser);
            return Ok(savedUser);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginModel model)
        {
            if (model is null)
            {
                return BadRequest();
            }

            var user = users.SingleOrDefault(u => u.Email == model.Email);
            if (user is null)
            {
                return NotFound("User not found");
            }

            var verified = _passwordsHasher.VerifyPassword(model.Password, user.PasswordHash);
            if (!verified)
            {
                return NotFound("User/Password is incorrect");
            }
            return Ok(new { message = "Login Successful" });
        }
    }
}
