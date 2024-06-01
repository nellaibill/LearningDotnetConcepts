using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using System;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Cors;

namespace MVCCoreTraining.Controllers
{
    public class Token
    {
        public string value { get; set; }
    }
    public class User
    {
        public string username { get; set; }
    }
    [EnableCors("AllowMyOrigin")]
    public class SecurityController : Controller
    {
        public IConfiguration _config = null;
        public SecurityController(IConfiguration config)
        {
            _config = config;
        }
       

        public IActionResult Index()
        {
            return View();
        }
  
        // To generate token
        public  string GenerateJSONWebToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,"Saleem"),
                new Claim(JwtRegisteredClaimNames.Email,""),
                new Claim("Role","Saleem"),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };
            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);


            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public IActionResult Login([FromBody] User user)
        {
            if (user.username == "test")
            {
                var token = new Token();
                string str = GenerateJSONWebToken();
                token.value = str;
               return  Ok(token);
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
