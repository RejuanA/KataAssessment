using CheckoutKata.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CheckoutKata.Client.Services.ProductServices
{
    interface IProductService
    {
        List<Product> Products { get; set; }
        Task LoadProducts();
        Task<Product> GetProduct(int Id);
    }
}
