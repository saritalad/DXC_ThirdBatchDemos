using JWT_Demo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace JWT_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _config;
        public LoginController(AppDbContext context,IConfiguration config)
        {
            _context = context;
            _config = config;
        }
        //private Users AuthenticateUser(Users user)
        //{
        //    Users _user = null;
        //    if (user.UserName == "admin" && user.Password == "12345")
        //    {
        //        _user = new Users { UserName = user.UserName, Password = user.Password };
        //    }
        //    return _user;
        //}


        private string GenerateToken(User user)
        {
            var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:key"]));
            var credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(_config["JWT:Issuer"], _config["JWT:Audience"], null, expires: DateTime.Now.AddMinutes(1), signingCredentials: credentials);// 
            return new JwtSecurityTokenHandler().WriteToken(token);
        }


        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(User user)
        {
            IActionResult response = Unauthorized();
            var user_ = _context.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password); 
            if (user_ != null)
            {
                var token = GenerateToken(user_);
                response = Ok(new { token = token });
            }
            return response;
        }


    }
}
