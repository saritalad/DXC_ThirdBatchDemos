using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_VersioningDemo.Controllers.v3
{
    [Route("api/v{version:apiversion}/[controller]")]
    [ApiController]
    [ApiVersion("3.0")]
    public class StudentsController : ControllerBase
    {
        [HttpGet("students")]
        public IEnumerable<Student3> GetStudents()
        {
            return new List<Student3>
            {
                new(){FirstName="Geeta",
                LastName="Roy",
                Email="Geeta@gmail.com",
                PhoneNumber="8765434567"},
                new(){FirstName="Seeta",
                LastName="Roy",
                Email="Seeta@gmail.com",
                PhoneNumber="9876543223"},

            };
        }

    }
    public class Student3
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; }=string.Empty;
    }
}
