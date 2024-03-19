using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SQLitePCL;
using System.Linq;
using WebApi_DbFirstDemo.Models;

namespace WebApi_DbFirstDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var data=_context.Products.ToList();
            if(data.Count!=0) { 

                return Ok(data);
            }
            else
            { return BadRequest(); }
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data=_context.Products.FirstOrDefault(x => x.Id == id);
            if (data == null)
            {
                return NotFound("Record does not Exist");
            }
            else
            { return Ok(data); }
        }
        [HttpPost]
        public IActionResult Post(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return Ok();
        }









    }
}
