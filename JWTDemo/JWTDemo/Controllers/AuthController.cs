using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using JWTDemo.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace JWTDemo.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        [HttpPost("token")]
        public IActionResult Token()
        {
            var header = Request.Headers["Authorization"];
            if (header.ToString().StartsWith("Basic"))
            {
                var credvalue = header.ToString().Substring("Basic ".Length).Trim();
                var usernameAndPassenc = Encoding.UTF8.GetString(Convert.FromBase64String(credvalue));
                var usernameAndPass = usernameAndPassenc.Split(":");

                LoginRepo login = new LoginRepo();
                var listLogin = login.getAll();

                foreach (var temp in listLogin)
                {
                    if (usernameAndPass[0] == temp.Nim && usernameAndPass[1] == temp.Password)
                    {
                        var claimsdata = new[] { new Claim(ClaimTypes.Name, temp.Nim) };
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


        //private IConfiguration _config;

        //public AuthController(IConfiguration config)
        //{
        //    _config = config;
        //}

        //[HttpPost("Token")]
        //public IActionResult CreateToken([FromBody]Login login)
        //{
        //    IActionResult response = Unauthorized();
        //    var user = validation(login);

        //    if (user != null)
        //    {
        //        var tokenString = BuildToken(login);
        //        response = Ok(tokenString);
        //    }

        //    return response;
        //}

        //private string BuildToken(Login user)
        //{
        //    var headers = Request.Body;
        //    var credValue = headers.ToString().Substring("Basic".Length).Trim();

        //    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("dsadasd!@#12364488993_====++++"));
        //    var signInCred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
        //    var ClaimsData = new[] { new Claim(ClaimTypes.Name, user.Nim) };
        //    var token = new JwtSecurityToken(
        //        issuer: "computercorner.com",
        //        audience: "computercorner.com",
        //        expires: DateTime.Now.AddMinutes(20),
        //        claims: ClaimsData,
        //        signingCredentials: signInCred
        //        );

        //    var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
        //    return tokenString;
        //}

        //private Login validation(Login login)
        //{ 
        //    LoginRepo temp = new LoginRepo();
        //    var listLogin = temp.getAll();

        //    Login sign = null;

        //    foreach (var key in listLogin)
        //    {
        //        if (login.Nim == key.Nim && login.Password == key.Password)
        //        {
        //            sign = key;
        //        }
        //    }

        //    return sign;
        //}
    }
}