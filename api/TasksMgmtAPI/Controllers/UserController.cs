
using Microsoft.AspNetCore.Mvc;
using TasksMgmtAPI.Domain;
using TasksMgmtAPI.Models;
using TasksMgmtAPI.Utilities;

namespace TasksMgmtAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IPasswordHasher _passwordsHasher;
        private static List<User> users = new List<User>();

        public UserController(IPasswordHasher passwordsHasher)
        {
            _passwordsHasher = passwordsHasher;
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            var passwordHash = _passwordsHasher.GeneratePasswordHash(user.Password);
            var savedUser = new User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Password = passwordHash,
                Email = user.Email,
                DateOfBirth = user.DateOfBirth
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

            var verified = _passwordsHasher.VerifyPassword(model.Password, user.Password);
            if (!verified)
            {
                return NotFound("User/Password is incorrect");
            }
            return Ok(new { message = "Login Successful" });
        }
    }
}
