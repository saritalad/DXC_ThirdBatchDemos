using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MYMVC_ViewModelDemo.Models
{
    public class Category
    {   [Key]
        public int Catid { get; set; }

        public string Catname { get; set; }

      //  public List<Product> products { get; set; }
    }
}
