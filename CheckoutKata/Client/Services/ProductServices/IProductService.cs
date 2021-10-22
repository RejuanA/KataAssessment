using CheckoutKata.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckoutKata.Client.Services.ProductServices
{
    interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts();
    }
}
