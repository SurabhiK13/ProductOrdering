using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2Product;

namespace Test2Product
{
    public class DeliveryService
    {
        public bool PlaceOrder(Product product)
        {
            if (product.Stock > 0)
            {
                return true; // Order can be placed
            }
            else
            {
                throw new ProductOutOfStockException();
            }
        }
    }
}
