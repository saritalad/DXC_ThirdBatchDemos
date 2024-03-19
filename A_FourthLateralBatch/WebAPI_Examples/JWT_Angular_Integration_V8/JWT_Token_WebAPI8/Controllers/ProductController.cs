
using JWT_Token_WebAPI8.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Core_Identity_API_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        //  [Authorize(Roles ="manager")]
        [Authorize]
        public IActionResult Get()
        {
            return Ok(_context.Products.ToList());
        }
    }
}
