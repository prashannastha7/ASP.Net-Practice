using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NpWalk.Controllers
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
            string[] studentName = new string[] { "Ram", "Shyam", "Sita", "Krishna", "Radha" };

            return Ok(studentName);
        }
    }
}
