using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_2.CommandPattern_CSharp
{
    public class BuyProduct : IOrder
    {
        private readonly Product product;
        public BuyProduct(Product product)
        {
            this.product = product;
        }

        public void Execute()
        {
            product.Buy();
        }
    }
}
