using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MYMVC_ViewModelDemo.Models
{
    public class CategoryProductViewModel
    {    [Key]
        public int productid { get; set; }
        public int catId { get; set; }
       
        public string Productname { get; set; }
        public string Catname { get; set; }
        public decimal Price { get; set; }
    }
}
