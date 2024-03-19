using System.ComponentModel.DataAnnotations;

namespace WebAPI_StoredProc_Demo.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Productname { get; set; }
        public decimal Price { get; set; }
        public int CatId { get; set; }
        public DateTime  Mfd { get; set; }
    }
}
