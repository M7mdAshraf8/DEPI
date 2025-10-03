using Day24_task.Models;
using Day24_task.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public IActionResult Index(string? search, int? deptId, int page = 1, int pageSize = 5)
        {
            var students = studBL.GetAll();

            if (!string.IsNullOrWhiteSpace(search))
                students = students
                    .Where(s => s.Name?.Contains(search, StringComparison.OrdinalIgnoreCase) == true)
                    .ToList();

            if (deptId.HasValue && deptId.Value > 0)
                students = students
                    .Where(s => s.DepartmentId == deptId.Value)
                    .ToList();

            int total = students.Count;
            if (pageSize <= 0) pageSize = 5;
            int totalPages = Math.Max(1, (int)Math.Ceiling(total / (double)pageSize));
            page = Math.Max(1, Math.Min(page, totalPages));

            students = students
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var vm = new StudentIndexViewModel
            {
                Students = students,
                Departments = deptBL.GetAll(), 
                DeptList = new SelectList(deptBL.GetAll(), "Id", "Name", deptId),
                Search = search,
                DeptId = deptId,
                CurrentPage = page,
                TotalPages = totalPages,
                PageSize = pageSize
            };

            return View("Index", vm);
        }


        public IActionResult ShowDetails(int id)
        {
            var student = studBL.GetById(id);
            return View("ShowDetails", student);
        }

        public IActionResult Add()
        {
            ViewBag.DeptList = new SelectList(deptBL.GetAll(), "Id", "Name");
            return View("Add"); 
        }

        [HttpPost]
        public IActionResult SaveAdd(Student stud)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.DeptList = new SelectList(deptBL.GetAll(), "Id", "Name", stud.DepartmentId);
                return View("Add", stud);
            }

            studBL.Add(stud);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var st = studBL.GetById(id);
            if (st == null) return NotFound();

            var vm = new StudentDeptViewModel
            {
                Id = st.Id,
                Name = st.Name,
                Age = st.Age,
                DepartmentId = st.DepartmentId,
                DeptList = new SelectList(deptBL.GetAll(), "Id", "Name", st.DepartmentId)
            };
            return View("Edit", vm);
        }

        [HttpPost]
        public IActionResult SaveEdit(int id, StudentDeptViewModel vm)
        {

            if (!ModelState.IsValid)
            {
                vm.DeptList = new SelectList(deptBL.GetAll(), "Id", "Name", vm.DepartmentId);
                return View("Edit", vm);
            }

            var old = studBL.GetById(id);
            if (old == null) return NotFound();

            old.Name = vm.Name;
            old.Age = vm.Age;
            old.DepartmentId = vm.DepartmentId;

            studBL.SaveInDB();
            return RedirectToAction(nameof(Index));
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
