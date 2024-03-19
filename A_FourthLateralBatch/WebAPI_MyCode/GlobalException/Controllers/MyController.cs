using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GlobalException.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            int x = 10, y = 0, z;

            z = x / y;

            return Ok(z);
        }
        [HttpGet]
        [Route("GetCustomError")]
        public IActionResult GetCustomError()
        {

            throw new Exception("Custom Exception Occurred");
        }
    }
}
