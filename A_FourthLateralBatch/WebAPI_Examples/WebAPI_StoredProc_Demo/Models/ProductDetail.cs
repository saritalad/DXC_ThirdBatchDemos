namespace WebAPI_StoredProc_Demo.Models
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public string Productname { get; set; }=string.Empty;
        public decimal Price { get; set; }
        public DateTime Mfd { get; set; }
        public string CatName { get;set; }=string.Empty;
    }
}
