using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPICoreEntity.Model;
using WebAPICoreEntity.Services;

namespace WebAPICoreEntity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StusentController : ControllerBase
    {
       private readonly IStudentService _studentService;
        public StusentController(IStudentService service)
        {
            _studentService = service;
        }
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAllStudents()
        {
            try
            {
                var students = _studentService.GetStudentsList();
                if (students == null) return NotFound();
                return Ok(students);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("[action]/id")]
        public IActionResult GetStudentById(int id)
        {
            try
            {
                var students = _studentService.GetStudentsDetailsById(id);
                if (students == null) return NotFound();
                return Ok(students);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("[action]")]
        public IActionResult SaveEmployees(Students students)
        {
            try
            {
                var model = _studentService.SaveStudents(students);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("[action]")]
        public IActionResult DeleteStudent(int id)
        {
            try
            {
                var model = _studentService.DeleteStudent(id);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
