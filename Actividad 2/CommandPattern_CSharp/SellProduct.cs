using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_2.CommandPattern_CSharp
{
    public class SellProduct : IOrder
    {
        private readonly Product product;
        public SellProduct(Product product)
        {
            this.product = product;
        }

        public void Execute()
        {
            product.Sell();
        }
    }
}
