using System.ComponentModel.DataAnnotations;

namespace WbApi_CodeFirstDemo.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [StringLength(25)]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}