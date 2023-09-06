using Microsoft.AspNetCore.Mvc;
using SVLT230905.ClassroomAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SVLT230905.ClassroomAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassroomController : ControllerBase
    {
        static List<Classroom> classrooms = new List<Classroom>
        {
            new Classroom { Id = 1, Name = "1ro Contador A", NumbersStud = 35, Teacher = "Juan Roman" },
            new Classroom { Id = 2, Name = "2do General B", NumbersStud = 40, Teacher = "Maria Gomez" },
            new Classroom { Id = 3, Name = "1ro Mecanica C", NumbersStud = 26, Teacher = "Gerard Moreno" },
            new Classroom { Id = 4, Name = "1ro Software A", NumbersStud = 30, Teacher = "Angel Perez" },
        };

        // GET: api/<ClassroomController>
        [HttpGet]
        public IEnumerable<Classroom> Get()
        {
            return classrooms;
        }

        
    }
}
