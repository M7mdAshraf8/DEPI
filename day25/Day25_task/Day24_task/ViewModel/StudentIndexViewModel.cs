using Day24_task.Models;

namespace Day24_task.ViewModel
{
    public class StudentIndexViewModel
    {
        public List<Student> Students { get; set; }
        public List<Department> Departments { get; set; }

        public string Search { get; set; }
        public int? DeptId { get; set; }

        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
