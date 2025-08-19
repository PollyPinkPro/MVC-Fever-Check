using Microsoft.AspNetCore.Mvc;

using MVCAssignment_1___2;
using MVCAssignment_1___2.Models;

namespace MVCAssignment_1___2.Controllers
{
    public class StudentController : Controller
    {
        List<Student> students = new List<Student>()
        {
            new Student(1,"Nalini P", "12354", "nalini@gmail.com"), 
            new Student(1,"Pipi L", "558877", "pippi@gmail.com"), 
            new Student(1,"Johan K", "25368", "johan@gmail.com"), 
            new Student(1,"Iggi O", "897463", "iggi@gmail.com"), 



        };
        public IActionResult Index()
        {
            return View(students);
        }
         public IActionResult Details(int id)
         {
            var student = from s in students
                          where s.SId == id
                          select s;

            var query = students.FirstOrDefault(s => s.SId == id);

            return View(query);
         }

    }
}
