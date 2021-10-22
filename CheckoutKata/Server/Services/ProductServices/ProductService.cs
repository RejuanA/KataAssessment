using CheckoutKata.Server.Data;
using CheckoutKata.Shared;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckoutKata.Server.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext Context)
        {
            _context = Context;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProduct(int Id)
        {
            Product p = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == Id);
            return p;
        }
    }
}
