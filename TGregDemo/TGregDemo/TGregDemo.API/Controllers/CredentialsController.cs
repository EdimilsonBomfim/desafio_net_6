using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TGregDemo.Application.DTOs.Login;
using TGregDemo.Domain.Core.Settings;

namespace TGregDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CredentialsController : ControllerBase
    {
        [HttpPost]
        public ActionResult<dynamic> Post([FromBody] LoginDTO loginDTO)
        {
            if (loginDTO.Email == "admin123@tgregdemo.com" && loginDTO.Password == "admin123")
            {
                //criar o token
                var token = GenerateToken(loginDTO);

                return new
                {
                    user = loginDTO.Email,
                    token = token
                };
            }

            return NotFound(new { message = "Usuário ou senha inválidos" });
        }

        protected string GenerateToken(LoginDTO loginDTO)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(TokenSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Email, loginDTO.Email.ToString())                    
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
