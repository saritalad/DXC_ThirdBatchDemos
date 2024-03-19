using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_DI_LifeScope_Example.Services;

namespace WebAPI_DI_LifeScope_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly iFoodService iFoodService;

        public FoodController(iFoodService foodservice)
        {
            iFoodService=foodservice;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var dish = iFoodService.GetDish();
            return Ok($"Dish Served is {dish}");
        }
    }
}
