using Day24_task.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day24_task.ViewModel
{
    public class StudentDeptViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [MinLength(2, ErrorMessage = "Name is short")]
        [MaxLength(50, ErrorMessage = "Name is long")]
        public string Name { get; set; }

        [Range(1, 120, ErrorMessage = "Age invalid")]
        public int Age { get; set; }

        [Display(Name = "Department")]
        [Range(1, int.MaxValue, ErrorMessage = "Enter valid Depariment")]
        public int DepartmentId { get; set; }

        public SelectList? DeptList { get; set; }
    }
}
