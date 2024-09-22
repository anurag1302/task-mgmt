
using Microsoft.AspNetCore.Mvc;
using TasksMgmtAPI.Domain;
using TasksMgmtAPI.Utilities;

namespace TasksMgmtAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IPasswordHasher _passwordsHasher;

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
            return Ok(savedUser);
        }
    }
}
