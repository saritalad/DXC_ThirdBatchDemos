using System.ComponentModel.DataAnnotations;

namespace WebAPI_StoredProc_Demo.Models
{
    public class Category
    {
        [Key]
        public int CatId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
