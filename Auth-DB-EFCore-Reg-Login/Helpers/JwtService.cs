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
        public string Generate(int id)
        {
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);
            var header = new JwtHeader(credentials);
            // Assuming 'id' is the user ID
            var idClaim = new Claim("userId", id.ToString()); // Custom claim for user ID

            var claims = new[] { idClaim };

            var payload = new JwtPayload(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, null, DateTime.Today.AddDays(1)); // 1 day
            var securityToken = new JwtSecurityToken(header, payload);

            return new JwtSecurityTokenHandler().WriteToken(securityToken);
        }

        public JwtSecurityToken Verify(string jwt,int id)
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

            // Check if the validated token is a JWT token
            if (validatedToken is JwtSecurityToken jwtToken)
            {
                // Access the claims from the validated JWT token
                var userIdClaim = jwtToken.Claims.FirstOrDefault(c => c.Type == "userId");

                // Check if the userId claim exists and its value matches the expected value
                if (userIdClaim != null && userIdClaim.Value == id.ToString())
                {
                    // Token validation successful
                    return jwtToken;
                }
                else
                {
                    // Token validation failed due to userId claim mismatch
                    throw new SecurityTokenValidationException("Invalid userId claim");
                }
            }
            else
            {
                // Token validation failed due to token not being a JWT token
                throw new SecurityTokenValidationException("Invalid token format");
            }

            //return (JwtSecurityToken)validatedToken;
        }

    }
}
