using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Auth_DB_EFCore_Reg_Login.Helpers
{
    public class JwtService
    {
        private readonly IConfiguration _configuration;
        public JwtService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string Generate(string email)
        {
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);
            var header = new JwtHeader(credentials);
            // Assuming 'id' is the user ID
            var idClaim = new Claim("userId", email); // Custom claim for user ID

            var claims = new[] { idClaim };

            var payload = new JwtPayload(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, null, DateTime.Today.AddDays(1)); // 1 day
            var securityToken = new JwtSecurityToken(header, payload);

            return new JwtSecurityTokenHandler().WriteToken(securityToken);
        }

        public JwtSecurityToken Verify(string jwt)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);
            tokenHandler.ValidateToken(jwt, new TokenValidationParameters
            {
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuerSigningKey = true,
                // Set issuer and audience validation
                ValidateIssuer = true,
                ValidIssuer = _configuration["Jwt:Issuer"],

                ValidateAudience = true,
                ValidAudience = _configuration["Jwt:Audience"],
            }, out SecurityToken validatedToken);
  
            return (JwtSecurityToken)validatedToken;
        }

    }
}
