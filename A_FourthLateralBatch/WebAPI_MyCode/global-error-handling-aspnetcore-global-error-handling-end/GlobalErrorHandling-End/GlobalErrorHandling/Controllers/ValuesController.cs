using System;
using LoggerService;
using Microsoft.AspNetCore.Mvc;

namespace GlobalErrorHandling.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		private ILoggerManager _logger;
		public ValuesController(ILoggerManager logger)
		{
			_logger = logger;
		}

		//[HttpGet]
		//public IActionResult Get()
		//{
		//	_logger.LogInfo("Fetching all the Students from the storage");

		//	var students = DataManager.GetAllStudents(); //simulation for the data base access

		//	throw new AccessViolationException("Violation Exception while accessing the resource.");

		////	_logger.LogInfo($"Returning {students.Count} students.");

		//	//return Ok(students);
		//}
		[HttpGet]
        public IActionResult Get()
        {
            try
            {
                _logger.LogInfo("Fetching all the Students from the storage");
                var students = DataManager.GetAllStudents(); //simulation for the data base access
                _logger.LogInfo($"Returning {students.Count} students.");
                return Ok(students);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}