using LINk_Lambda_Demo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebAPI1.Controllers
{    // attribute
     // [Route("api/[controller]")]
    [Route("api/emp")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        [Route("Allemp")]
        [Route("All")]
        public IActionResult Get()
        {
            var emplist=Employee.GetEmployees();
            return Ok(emplist);
        }
        [Route("details/{id}")]
        // routing parameter or route-variable 
        // Url pattern  http://localhost:5678/api/emp/details/102
        public IActionResult Get(int id) { 
         var emp=Employee.GetEmployees().FirstOrDefault(e=>e.ID==id);
                return Ok(emp);
        }

        [Route("Gender/{Gender}/City/{CityId}")]
        public string GetEmployeesByGenderAndCity(string Gender, int CityId)
        {
            return $"Return Employees with Gender : {Gender}, City: {CityId}";
        }
        // QueryString example

        [Route("Search")]
        //http://localhost:65291/api/emp/search?department=IT&Gender=Male&City=Pune
        public string SearchEmployees(string Department, string Gender, string City)
        {

            return $"Return Employees with Department : {Department}, Gender : {Gender}, City : {City}";

        }
        [Route("~/department/all")]
        public string GetAllDepartment()
        {
            return "Response from GetAllDepartment Method";
        }
    }
}
