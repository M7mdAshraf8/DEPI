using Day23_task.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day23_task.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult ShowAll()
        {
            StudentBL bl = new StudentBL();
            var students = bl.GetAll();
            return View("ShowAll", students);
        }

        public IActionResult ShowDetails(int id)
        {
            StudentBL bl = new StudentBL();
            var student = bl.GetById(id);
            return View("ShowDetails", student);
        }
    }
}
