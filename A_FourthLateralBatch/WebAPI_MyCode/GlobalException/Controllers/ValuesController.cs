using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
namespace GlobalException.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
      
        public IActionResult Get()
        {
            int x = 10, y = 0,z;
           
            z = x / y;
           
            return Ok(z);
        }
    }
}
