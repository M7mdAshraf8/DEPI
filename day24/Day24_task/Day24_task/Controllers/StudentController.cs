using Day24_task.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day24_task.Controllers
{
    public class StudentController : Controller
    {
        StudentBL bl = new StudentBL();
        public IActionResult ShowAll()
        {
            
            var students = bl.GetAll();
            return View("ShowAll", students);
        }

        public IActionResult ShowDetails(int id)
        {
            var student = bl.GetById(id);
            return View("ShowDetails", student);
        }
    }
}
