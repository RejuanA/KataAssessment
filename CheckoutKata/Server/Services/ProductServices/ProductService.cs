using CheckoutKata.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckoutKata.Server.Services.ProductServices
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>
        {
            new Product
            {
                Id = 1,
                Title = "A",
                Price = 10
            },
            new Product
            {
                Id = 2,
                Title = "B",
                Price = 15,
                Discount = new Discount{ DiscountTitle = "3 For 40" }
            },
            new Product
            {
                Id = 3,
                Title = "C",
                Price = 40
            },
            new Product
            {
                Id = 4,
                Title = "D",
                Price = 55,
                Discount = new Discount{ DiscountTitle = "25% off every 2 purchased together" }
            }
        };

        public async Task<List<Product>> GetAllProducts()
        {
            return Products;
        }

        public async Task<Product> GetProduct(int Id)
        {
            return Products.FirstOrDefault(p => p.Id == Id);
        }
    }
}
