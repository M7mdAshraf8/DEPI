using System.ComponentModel.DataAnnotations;

namespace Day24_task.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Display(Name = "Department Name")]
        [Required(ErrorMessage = "Department name is required.")]
        [MinLength(2, ErrorMessage = "Department name must be at least 2 characters.")]
        [MaxLength(50, ErrorMessage = "Department name must be at most 50 characters.")]
        [RegularExpression(@"^[\p{L}\p{N}\s\-_]+$", ErrorMessage = "Department name may contain letters, numbers, spaces, hyphens, and underscores only.")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Manager Name")]
        [Required(ErrorMessage = "Manager name is required.")]
        [MinLength(2, ErrorMessage = "Manager name must be at least 2 characters.")]
        [MaxLength(50, ErrorMessage = "Manager name must be at most 50 characters.")]
        [RegularExpression(@"^[\p{L}\s\.'-]+$", ErrorMessage = "Manager name may contain letters, spaces, apostrophes, periods, and hyphens only.")]
        public string MgrName { get; set; } = string.Empty;

        public List<Student>? Students { get; set; }
        public List<Teacher>? Teachers { get; set; }
        public List<Course>? Courses { get; set; }
    }
}
