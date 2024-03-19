using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//https://code-maze.com/aspnetcore-api-versioning/
namespace WebAPI_VersioningDemo.Controllers.v1
{
    [Route("api/v{version:apiversion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class StudentsController : ControllerBase
    {
        [HttpGet("students")]
        public IEnumerable<Student1> GetStudents()
        {
            return new List<Student1>
            {
                new(){FirstName="Geeta",
                LastName="Roy"},
                new(){FirstName="Seeta",
                LastName="Roy"},

            };
        }

    }
    public class Student1
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;
    }
}
