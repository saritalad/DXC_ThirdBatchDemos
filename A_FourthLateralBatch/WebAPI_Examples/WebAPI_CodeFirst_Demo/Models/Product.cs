using System.ComponentModel.DataAnnotations;

namespace WebAPI_CodeFirst_Demo.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public decimal price { get; set; }
    }
}