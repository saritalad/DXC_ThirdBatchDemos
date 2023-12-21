using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XSSDemo.Models;


namespace XSSDemo.Controllers
{
    
    [ApiController]
    public class DemoController : ControllerBase
    {

        [Route("PostContactMessage")]
        [HttpPost]
        public async Task<IActionResult> PostContactMessage(ContactFormModel model)
        {
            if (model != null) {
                return Ok("Success");
            }
            else { return BadRequest(); }
        }
    }

    
}
