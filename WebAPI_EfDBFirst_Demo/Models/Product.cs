namespace WebAPI_EfDBFirst_Demo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public DateTime Mfd { get; set; }

    }
}