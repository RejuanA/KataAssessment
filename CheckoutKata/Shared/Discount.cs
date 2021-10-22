using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata.Shared
{
    public class Discount
    {
        [Key]
        public int DiscountId { get; set; }
        public string DiscountTitle { get; set; }

        public int ThreeForFourty(int Values)
        {
            return 0;
        }

        public int TwentFivePercentOffForTwo(int Values)
        {
            return 0;
        }
    }
}
