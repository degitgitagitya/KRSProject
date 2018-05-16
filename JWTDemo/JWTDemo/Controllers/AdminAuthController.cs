using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using JWTDemo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace JWTDemo.Controllers
{
    [Route("api/[controller]")]
    public class AdminAuthController : Controller
    {
        [HttpPost("tokenAdmin")]
        public IActionResult Token()
        {
            var header = Request.Headers["Authorization"];
            if (header.ToString().StartsWith("Basic"))
            {
                var credvalue = header.ToString().Substring("Basic ".Length).Trim();
                var usernameAndPassenc = Encoding.UTF8.GetString(Convert.FromBase64String(credvalue));
                var usernameAndPass = usernameAndPassenc.Split(":");

                AdminRepo login = new AdminRepo();
                var listLogin = login.getAll();

                foreach (var temp in listLogin)
                {
                    if (usernameAndPass[0] == temp.Username && usernameAndPass[1] == temp.Password)
                    {
                        var claimsdata = new[] { new Claim(ClaimTypes.Name, temp.Username) };
                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("aowue92187183123nb1273131g9182"));
                        var signInCred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
                        var token = new JwtSecurityToken(
                            issuer: "mysite.com",
                            audience: "mysite.com",
                            expires: DateTime.Now.AddMinutes(1),
                            claims: claimsdata,
                            signingCredentials: signInCred
                            );
                        var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
                        return Ok(tokenString);
                    }
                }
            }

            return BadRequest("Wrong Request");
        }
    }
}