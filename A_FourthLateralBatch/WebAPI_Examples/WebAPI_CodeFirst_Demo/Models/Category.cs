using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI_CodeFirst_Demo.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}