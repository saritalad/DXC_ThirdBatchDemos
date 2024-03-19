using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_StoredProc_Demo.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI_StoredProc_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        private readonly AppDBContext _context;

        public ProductDetailsController(AppDBContext context)
        {
            _context=context;
        }


        [HttpGet]
        public ActionResult <IEnumerable<ProductDetail>> Get()
        {
            var data=_context.productsDetails.FromSqlRaw("Exec ProductDetails ").ToList();
            return Ok(data);
        }

        

        
      
    }
}
