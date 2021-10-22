using CheckoutKata.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckoutKata.Server.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProduct(int Id);
    }
}
