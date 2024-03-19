using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYMVC_ViewModelDemo.Models
{
    public class StudentDetailsViewModel
    {
        public int Id { get; set; }
        public Student student { get; set; }
        public Address address { get; set; }
        public string Title { get; set; }
        public string University { get; set; }

    }
}
