using Day24_task.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day24_task.ViewModel
{
    public class StudentDeptViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public List<Department> DeptList { get; set; }
    }
}
