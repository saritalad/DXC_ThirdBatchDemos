﻿namespace WebAPI_StoredProc_Demo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal  Price { get; set; }
        public int CatId { get; set; }
    }
}