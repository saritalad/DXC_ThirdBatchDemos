using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webAPI6.Models;

namespace webAPI6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult get()
        {
            return Ok(_context.Products);
        }
        [HttpGet("{id}")]

            public IActionResult get(int id)
        {
            var data= _context.Products.FirstOrDefault(p=>p.Id ==id);

            return Ok(data);    
        }
    }
}
