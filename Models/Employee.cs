using System.ComponentModel.DataAnnotations; 

namespace BlazorApp1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Shift { get; set; } // Morning / Afternoon / Night
        public string? Department { get; set; }
        public ICollection<TaskItem>? Tasks { get; set; }
    }
}
