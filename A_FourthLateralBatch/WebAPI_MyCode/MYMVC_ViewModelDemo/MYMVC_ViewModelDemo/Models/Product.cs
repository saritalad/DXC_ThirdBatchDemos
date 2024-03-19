using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MYMVC_ViewModelDemo.Models
{
    public class Product
    {    [Key]
        public int ProductId { get; set; }
        public string Productname { get; set; }
        public decimal Price { get; set; }
        public int Catid { get; set; }
    }
}
