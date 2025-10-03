using Day24_task.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Day24_task.ViewModel
{
    public class StudentIndexViewModel
    {
        public List<Student> Students { get; set; } = new();
        public List<Department> Departments { get; set; } = new(); 

        public SelectList? DeptList { get; set; }

        public string? Search { get; set; }
        public int? DeptId { get; set; }

        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; } = 5; 

    }
}
