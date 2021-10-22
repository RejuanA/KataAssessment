using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata.Shared
{
    public class Kata
    {
        [Key]
        public int Id { get; set; }
        public List<Product> Products { get; set; }
        public decimal BasketTotal { get; set; }
    }
}
