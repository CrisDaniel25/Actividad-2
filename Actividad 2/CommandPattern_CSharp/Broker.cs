using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_2.CommandPattern_CSharp
{
    public class Broker
    {
        private readonly List<IOrder> orderlist = new List<IOrder>();

        public void TakeOrder(IOrder order)
        {
            orderlist.Add(order);
        }

        public void PlaceOrder()
        {
            foreach(IOrder order in orderlist)
            {
                order.Execute();
            }

            orderlist.Clear();
        }
    }
}
