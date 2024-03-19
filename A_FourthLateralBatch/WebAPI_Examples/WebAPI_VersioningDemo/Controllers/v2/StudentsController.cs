
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_VersioningDemo.Controllers.v2
{
    [Route("api/v{version:apiversion}/[controller]")]
    [ApiController]
    [ApiVersion("2.0")]
    public class StudentsController : ControllerBase
    {
        [HttpGet("students")]
        public IEnumerable<Student2> GetStudents()
        {
            return new List<Student2>
            {
                new()
                {FirstName="Geeta",
                LastName="Roy",
                City="Mumbai",
                Country="India"},
                new()
                {FirstName="Seeta",
                LastName="Roy",
                City="Paris",
                Country="Franse"
                },

            };
        }




    }
    public class Student2
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

    }
}
