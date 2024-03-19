using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYMVC_ViewModelDemo.Models
{

    // ViewModel for without stored procedure
    public class CategoryViewModel
    {
        public List<Product> productlist { get; set; }
        public Category category { get; set; }



    }
}
