using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Domain.Services.Authorization;

namespace Application.Services.Authorization
{
    public class JwtAuthenticationManager : IJwtAuthenticationManager
    {
        public string Authenticate(string username, string email, string role)
        {
            if(username.IsNullOrEmpty() || email.IsNullOrEmpty() || role.IsNullOrEmpty())
                throw new Exception("Email and/or password wrong or missing");

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes("sport-specialist-federicocarminedannysportspecilisT");
            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Audience = "https://SportSpecialist.com",
                Issuer = "https://SportSpecialist.com",
                
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, username),
                    new Claim(ClaimTypes.Email, email),
                    new Claim(ClaimTypes.Role, role)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature)
                
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

    }
}