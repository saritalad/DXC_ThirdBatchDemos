using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop.Infrastructure;
using WebAPI_EFCodeFirst_Demo.Models;

namespace WebAPI_EFCodeFirst_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDBContext _context;

        public ProductsController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult <IEnumerable<Product>>Get()
        {
            return _context.Products.ToList();

        }

        [HttpGet("{id}")]
        public  Product Get(int id)
        {
            var data=_context.Products.FirstOrDefault(p => p.Id == id);

            return data;
        }
        [HttpPost]
        public ActionResult Post([FromBody]Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
           // return Ok();
           return CreatedAtAction("Get",new {Id=product.Id},product);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id ,[FromBody]Product product) {

            if(id!=product.Id)
            {
                return BadRequest();
             }
            else
            {

                var data=_context.Products.FirstOrDefault(x=>x.Id==id);

                data.ProductName = product.ProductName;
                data.Price= product.Price;
                _context.SaveChanges();
                return NoContent();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var data = _context.Products.FirstOrDefault(x=>x.Id == id);
            if(data!=null)
            {
                _context.Products.Remove(data);
                _context.SaveChanges();
                return NoContent();
            }
            else { return NotFound(); }
        }
    }
}
