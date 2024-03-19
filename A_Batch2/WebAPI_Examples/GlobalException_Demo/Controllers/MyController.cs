using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GlobalException_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {

        [HttpGet]
        public ActionResult Get()
        {
            int x=10,y=0,z=0;
            //try
            //{
            //    z = x / y;
            //    return Ok(z);
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest(ex.Message);
            //}
            z = x / y;
            return Ok(z);

        }
    }
}
