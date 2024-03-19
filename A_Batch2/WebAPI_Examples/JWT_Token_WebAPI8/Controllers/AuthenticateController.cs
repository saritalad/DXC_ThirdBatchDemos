using JWT_Token_WebAPI8.Data;
using JWT_Token_WebAPI8.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace JWT_Token_WebAPI8.Controllers
{
    [Route("api/Auth")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private AppDbContext db;
        private IConfiguration config;
        public AuthenticateController(AppDbContext db,IConfiguration _config)
        {
            this.db = db;
            config = _config;
        }

        [HttpPost("register")]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<dynamic>> Register(User user)
        {
            TryValidateModel(user);
            if (ModelState.IsValid)
            {
                user.Status = "Not Verified";
                user.Role = "User";
                await db.Users.AddAsync(user);
                await db.SaveChangesAsync();
                //await SendVerificationMailAsync(user);
                return Created("", new
                {
                    user.Id,
                    user.Fullname,
                    user.Username,
                    user.Email
                });
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        [HttpPost]
        [Route("Login")]
        public ActionResult<dynamic> Login(LogInModel model)
        {
            TryValidateModel(model);
            if (ModelState.IsValid)
            {
                var user = db.Users.SingleOrDefault(s => s.Username == model.Username && s.Password == model.Password);

                if (user != null)
                {
                    var token = GenerateToken(user);
                    return Ok(new { user.Fullname, user.Email, user.Username, user.Role, Token = token });
                }
                else
                {
                    return Unauthorized();// status code 403
                }
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        [NonAction]
        private string GenerateToken(User user)
        {
            //This is a claims list that defined who are the subject, what is to be checked and 
            //who are the audience for the claim

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Fullname),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.GetValue<string>("Jwt:secret")));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: config.GetValue<string>("Jwt:issuer"),
                audience: config.GetValue<string>("Jwt:audience"),
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials
            );
            string tokenString = new JwtSecurityTokenHandler().WriteToken(token);
            return tokenString;
        }

        //[Authorize]
        //[HttpGet("test")]
        //public string Test()
        //{
        //    return "From Identity Page for Authorised Users Only!";
        //}



    }
}
