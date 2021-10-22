using CheckoutKata.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CheckoutKata.Client.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;
        public List<Product> Products { get; set; } = new List<Product>();
        public ProductService(HttpClient Http) => _http = Http;

        public async Task LoadProducts()
        {
            Products = await _http.GetFromJsonAsync<List<Product>>("api/Product");
        }

        public async Task<Product> GetProduct(int Id)
        {
            return await _http.GetFromJsonAsync<Product>($"api/Product/{Id}");
        }
    }
}
