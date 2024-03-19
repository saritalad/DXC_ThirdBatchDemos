using ViewModel_Demo.Models;

namespace ViewModel_Demo.Viewmodels
{
    public class StudentDetailsViewModel
    {
        public Student Student { get; set; }
        public Address Address { get; set; }
        public string Title { get; set; }
        public string Header { get; set; }
    }
}
