using Day24_task.Models;
using Day24_task.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Day24_task.Controllers
{
    public class DepartmentController : Controller
    {
         DepartmentBL deptBL = new DepartmentBL();

        public IActionResult ShowAll()
        {
            var depts = deptBL.GetAll();
            return View("ShowAll", depts);
        }

        public IActionResult ShowDetails(int id)
        {
            var dept = deptBL.GetById(id);
            return View("ShowDetails", dept);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public IActionResult SaveAdd(Department dept)
        {
            if (ModelState.IsValid)
            {
                deptBL.AddDept(dept);
                return RedirectToAction(nameof(ShowAll));
            }
            return View("Add", dept);
        }

        public IActionResult DeptInfo(int id)
        {
            var dept = deptBL.GetById(id);

            var studentsAbove25 = dept.Students
                                      .Where(s => s.Age > 25)
                                      .Select(s => s.Name)
                                      .ToList();

            string state = dept.Students.Count > 50 ? "Main" : "Branch";

            DeptWithStudentsViewModel vm = new DeptWithStudentsViewModel()
            {
                DeptName = dept.Name,
                StudentsAbove25 = studentsAbove25,
                DeptState = state
            };

            return View("DeptInfo", vm);
        }
    }
}
