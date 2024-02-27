using Auth_DB_EFCore_Reg_Login.Data;
using Auth_DB_EFCore_Reg_Login.Dtos;
using Auth_DB_EFCore_Reg_Login.Helpers;
using Auth_DB_EFCore_Reg_Login.Models;
using Microsoft.AspNetCore.Mvc;

namespace Auth_DB_EFCore_Reg_Login.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly JwtService _jwtservice;

        public AuthController(IUserRepository userRepository,JwtService jwtservice)
        {
            _userRepository = userRepository;
            _jwtservice = jwtservice;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterDTO  dto)
        {
            var user = new User
            {
                Email = dto.Email,
                Name = dto.Name,
                Password = BCrypt.Net.BCrypt.HashPassword(dto.Password),
            };
           
            return Created("Success", _userRepository.Create(user));
        }
        [HttpPost("login")]
        public IActionResult Login(LoginDTO dto) { 
        var user = _userRepository.GetByEmail(dto.Email);
            if(user == null)
            {
                return BadRequest();
            }
            if(!BCrypt.Net.BCrypt.Verify(dto.Password, user.Password))
            {
                return BadRequest();
            }
            var jwt = _jwtservice.Generate(dto.Email);
            Response.Cookies.Append("jwt", jwt,new CookieOptions
            {
                HttpOnly = true
            });
            return Ok(new
            {
                token =jwt
            });
        }
        [HttpGet("user")]
        public IActionResult User(UserRequestDTO userRequest)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtservice.Verify(jwt);
                var userIdClaim = token.Claims.FirstOrDefault(c => c.Type == "userId");
                if (userIdClaim != null && userIdClaim.Value == userRequest.email)
                {
                    var user = _userRepository.GetByEmail(userRequest.email);
                    return Ok(user);
                }
               return Unauthorized();
           
            }

            catch(Exception ex)
            {
                return Unauthorized();
            }       
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("jwt");
            return Ok(new
            {
                message = "success"
            });
        }
    }
}
