using System.ComponentModel.DataAnnotations;

namespace RazorEF_CodeFirstDemo.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "name is required")]
        [StringLength(30, ErrorMessage = "Must be between 3 and 30 characters")]
        public string Name { get; set; }
       // public ICollection<Employee> employees { get;}
    }
}