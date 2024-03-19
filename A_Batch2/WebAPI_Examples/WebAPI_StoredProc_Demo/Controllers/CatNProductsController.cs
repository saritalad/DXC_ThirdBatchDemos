using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_StoredProc_Demo.Models;

namespace WebAPI_StoredProc_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatNProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CatNProductsController(AppDbContext context)
        {
            _context=context;
        }
        [HttpGet]
        public IActionResult Get() {

            var data = _context.CatNProducts.FromSqlInterpolated($"SP_CatAndProduct");

            return Ok(data);


        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            var data = _context.CatNProducts.FromSqlInterpolated($"dbo.SP_ProductbyCategory {id}");
            return Ok(data);
        }

    }
}
