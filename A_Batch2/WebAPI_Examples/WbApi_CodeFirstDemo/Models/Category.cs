using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WbApi_CodeFirstDemo.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
       

    }
}