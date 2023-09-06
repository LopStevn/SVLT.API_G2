using Microsoft.AspNetCore.Mvc;
using SVLT230905.DocentesAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SVLT230905.DocentesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        static List<Teacher> teachers = new List<Teacher>();

        
        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        public Teacher Get(int id)
        {
            var teacher = teachers.FirstOrDefault(t => t.Id == id);
            return teacher;
        }

        // POST api/<TeacherController>
        [HttpPost]
        public IActionResult Post([FromBody] Teacher teacher)
        {
            teachers.Add(teacher);
            return Ok();
        }

    }
}
