using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheckoutKata.Shared
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Image { get; set; } = "https://via.placeholder.com/300x300";
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int? DiscountId { get; set; }
        //[ForeignKey("DiscountId")]
        //public Discount Discount { get; set; }
        public string Description { get; set; } = "N/A";
    }
}
