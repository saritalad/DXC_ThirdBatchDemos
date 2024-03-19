using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MYMVC_ViewModelDemo.Models
{
    public class Address
    {
        [Key]
        public int StudentId { get; set; }
        public string City { get; set; }
        public string PIn { get; set; }
    }
}
