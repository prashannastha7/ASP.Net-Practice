using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NpWalks.API.Controllers
{
    //https://localhost:portnumber/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //Get: https://localhost:portnumber/api/students

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentNames = new string[]
            {
                "Ram", "Shyam", "Sita", "Krishna", "Radha"
            };

            return Ok(studentNames);
        }
    }
}
