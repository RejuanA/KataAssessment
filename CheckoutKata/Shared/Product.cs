using System;

namespace CheckoutKata.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; } = "https://via.placeholder.com/300x300";
        public decimal Price { get; set; }
        public Discount Discount { get; set; }
        public string Description { get; set; } = "N/A";
    }
}
