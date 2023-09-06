using Microsoft.AspNetCore.Mvc;
using SVLT230905.AlumosAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SVLT230905.AlumosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        static List<Student> students = new List<Student>();

        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return students;
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            return student;
        }

        // POST api/<StudentsController>
        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            students.Add(student);
            return Ok();
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Student student)
        {
            var existingStudent = students.FirstOrDefault(s => s.Id == id);
            if (existingStudent != null)
            {
                existingStudent.Name = student.Name;
                existingStudent.Degree = student.Degree;
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingStudent = students.FirstOrDefault(s => s.Id == id);
            if (existingStudent != null)
            {
                students.Remove(existingStudent);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
