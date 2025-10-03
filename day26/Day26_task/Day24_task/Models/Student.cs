using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day24_task.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Name is required.")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters.")]
        [MaxLength(50, ErrorMessage = "Name must be at most 50 characters.")]
        [RegularExpression(@"^[\p{L}\p{N}\s\.'-]+$", ErrorMessage = "Name may contain letters, numbers, spaces, apostrophes, periods, and hyphens only.")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Age")]
        [Range(1, 120, ErrorMessage = "Age must be between 1 and 120.")]
        public int Age { get; set; }

        [Display(Name = "Department")]
        [ForeignKey("Department")]
        [Range(1, int.MaxValue, ErrorMessage = "Enter a valid department.")]
        public int DepartmentId { get; set; }

        public Department? Department { get; set; }

        public List<StCrRes>? StCrRes { get; set; }
    }
}
