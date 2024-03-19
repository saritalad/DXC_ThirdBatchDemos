namespace WebApi_DbFirstDemo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CatId { get; set; }
        public decimal Price { get; set; }
    }
}
