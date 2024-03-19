using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("Hello from WebAPI Application");
        }



    }
}
