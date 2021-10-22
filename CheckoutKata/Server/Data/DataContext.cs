using CheckoutKata.Shared;
using Microsoft.EntityFrameworkCore;

namespace CheckoutKata.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> Options) : base(Options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            ModelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Title = "A",
                    Price = 10
                },
                new Product
                {
                    ProductId = 2,
                    Title = "B",
                    Price = 15
                    //Discount = new Discount { DiscountId = 1, DiscountTitle = "3 For 40" }
                },
                new Product
                {
                    ProductId = 3,
                    Title = "C",
                    Price = 40
                },
                new Product
                {
                    ProductId = 4,
                    Title = "D",
                    Price = 55
                    //Discount = new Discount { DiscountId = 2, DiscountTitle = "25% off every 2 purchased together" }
                }
            );
        }
    }
}
