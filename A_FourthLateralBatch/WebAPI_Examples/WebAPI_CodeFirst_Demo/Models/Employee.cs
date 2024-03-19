using System.ComponentModel.DataAnnotations;

namespace WebAPI_CodeFirst_Demo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}