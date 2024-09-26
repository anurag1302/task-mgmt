
using Microsoft.AspNetCore.Mvc;
using TasksMgmt.API.Models;
using TasksMgmt.API.Utilities;
using TasksMgmt.Core.Entities;
using TasksMgmt.Core.Interfaces;
using TasksMgmtAPI.Models;
using TasksMgmtAPI.Utilities;

namespace TasksMgmtAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IPasswordHasher _passwordsHasher;
        private readonly IJwtProvider _jwtProvider;
        private readonly IUserRepository _repository; 

        public UserController(IPasswordHasher passwordsHasher, 
            IJwtProvider jwtProvider,
            IUserRepository repository)
        {
            _passwordsHasher = passwordsHasher;
            _jwtProvider = jwtProvider;
            _repository = repository;
        }

        [HttpPost("register")]
        public IActionResult Register(UserModel userModel)
        {
            var passwordHash = _passwordsHasher.GeneratePasswordHash(userModel.Password);
            var savedUser = new User
            {
                Id = Guid.NewGuid(),
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                PasswordHash = passwordHash,
                Email = userModel.Email,
                DateOfBirth = userModel.DateOfBirth,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedBy = 1001
            };
            var user = _repository.CreateAsync(savedUser);

            return Ok(user);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginModel model)
        {
            if (model is null)
            {
                return BadRequest();
            }

            var user = _repository.SelectAsync(x => x.Email == model.Email).FirstOrDefault();
            if (user is null)
            {
                return NotFound("User not found");
            }

            var verified = _passwordsHasher.VerifyPassword(model.Password, user.PasswordHash);
            if (!verified)
            {
                return NotFound("User/Password is incorrect");
            }

            var successMessage = new
            {
                Email = user.Email,
                StatusCode = 200,
                Token = _jwtProvider.GenerateToken(user)
            };
            return Ok(successMessage);
        }
    }
}
