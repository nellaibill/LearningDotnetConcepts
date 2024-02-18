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
            var jwt = _jwtservice.Generate(user.Id);
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
                var token = _jwtservice.Verify(jwt, userRequest.id);
                var userIdClaim = token.Claims.FirstOrDefault(c => c.Type == "userId");
                if (userIdClaim != null && userIdClaim.Value == userRequest.id.ToString())
                {
                    var user = _userRepository.GetById(userRequest.id);
                    return Ok(user);
                }
               // int userId = int.Parse(userIdClaim?.userId);
               return BadRequest();
           
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
