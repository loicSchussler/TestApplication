using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace testApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {

        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Id = 1, FirstName = "Loïc", LastName = "Schussler", Age = 19 });
            students.Add(new Student() { Id = 2, FirstName = "Aurelien", LastName = "A", Age = 19 });
            students.Add(new Student() { Id = 3, FirstName = "Aurelien", LastName = "B", Age = 19 });
            students.Add(new Student() { Id = 4, FirstName = "Hamza", LastName = "C", Age = 18 });
            students.Add(new Student() { Id = 5, FirstName = "Nael", LastName = "D", Age = 18 });

            return students;
        }

        [HttpGet]

        public ActionResult<IEnumerable<Student>> GetStudents_List()
        {
            return GetStudents();
        }

        [HttpGet("{id}")]

        public ActionResult<Student> GetGames_ById(int id)
        {
            var students = GetStudents().Find(x => x.Id == id);
            if (students != null)
                return students;
            return NotFound();
        }
        // GET: /<controller>/

    }
}
