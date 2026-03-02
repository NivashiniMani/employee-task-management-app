using System.ComponentModel.DataAnnotations; 

namespace BlazorApp1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Employee name is required")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Shift is required")]
        public string Shift { get; set; } // Morning / Afternoon / Night
        [Required(ErrorMessage = "Department is required")]
        [StringLength(50, ErrorMessage = "Department cannot exceed 50 characters")]
        public string Department { get; set; }
        
        public ICollection<TaskItem>? Tasks { get; set; }
    }
}
