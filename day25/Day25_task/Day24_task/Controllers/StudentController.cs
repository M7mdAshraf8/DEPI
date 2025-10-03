using Day24_task.Models;
using Day24_task.ViewModel;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day24_task.Controllers
{
    public class StudentController : Controller
    {
        StudentBL studBL = new StudentBL();
        DepartmentBL deptBL = new DepartmentBL();
        public IActionResult ShowAll()
        {
            
            var students = studBL.GetAll();
            return View("ShowAll", students);
        }
        public IActionResult Index(string search, int? deptId, int page = 1, int pageSize = 5)
        {
            var students = studBL.GetAll();

            if (!string.IsNullOrEmpty(search))
                students = students.Where(s => s.Name.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();

            if (deptId.HasValue && deptId > 0)
                students = students.Where(s => s.DepartmentId == deptId).ToList();

            int total = students.Count;
            students = students.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            var vm = new StudentIndexViewModel
            {
                Students = students,
                Departments = deptBL.GetAll(),
                Search = search,
                DeptId = deptId,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling((double)total / pageSize)
            };

            return View("Index", vm);
        }

        public IActionResult ShowDetails(int id)
        {
            var student = studBL.GetById(id);
            return View("ShowDetails", student);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        public IActionResult SaveAdd(Student stud)
        {
            if (ModelState.IsValid)
            {
                studBL.Add(stud);
                return RedirectToAction(nameof(Index));
            }
            return View("Add", stud);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Student student = studBL.GetById(id);
            List<Department> DeptList = deptBL.GetAll();
            StudentDeptViewModel SDVM = new StudentDeptViewModel()
            {
                Id = student.Id,
                Name = student.Name,
                Age = student.Age,
                DepartmentId = student.DepartmentId,
                DeptList = DeptList
            };

            return View("Edit", SDVM);
        }

        [HttpPost]
        public IActionResult SaveEdit(Student newStudent, int id)
        {
            if (newStudent.Name != null)
            {
                Student OldEmp = studBL.GetById(id);

                OldEmp.Name = newStudent.Name;
                OldEmp.Age = newStudent.Age;
                OldEmp.DepartmentId = newStudent.DepartmentId;

                studBL.SaveInDB();

                return RedirectToAction(nameof(Index));
            }
            return View("Edit", newStudent);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = studBL.GetById(id);
            return View("Delete", student);
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            var student = studBL.GetById(id);
            if (student != null)
            {
                studBL.Delete(student);
                return RedirectToAction(nameof(Index));
            }
            return NotFound();
        }
    }
}
