using Microsoft.AspNetCore.Mvc;
using SVLT230905.SubjectAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SVLT230905.SubjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        static List<Subject> subjects = new List<Subject>();

        // GET: api/<SubjectController>
        [HttpGet]
        public IEnumerable<Subject> Get()
        {
            return subjects;
        }

        // POST api/<SubjectController>
        [HttpPost]
        public IActionResult Post([FromBody] Subject subject)
        {
            subjects.Add(subject);
            return Ok();
        }

        // DELETE api/<SubjectController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingSubject = subjects.FirstOrDefault(s => s.Id == id);
            if (existingSubject != null)
            {
                subjects.Remove(existingSubject);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
