using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webAPI6.Models;

namespace webAPI6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatProdController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CatProdController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var data = _context.CategorywiseProducts.FromSqlInterpolated($"SP_Products_Cat");
            return Ok(data);
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var data = _context.CategorywiseProducts.FromSqlInterpolated($"SP_ProductsByCat {id}");
            return Ok(data);
        }
    }
}
