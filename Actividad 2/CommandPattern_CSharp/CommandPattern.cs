using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_2.CommandPattern_CSharp
{
    public class CommandPattern
    {
        public string name;
        public int price;
        public int quantity;
        public void Main()
        {
            Console.WriteLine("Your selection was the Command Pattern: ");

            Console.WriteLine("Put a product name here: ");
            name = Console.ReadLine();
            Console.WriteLine("Put a price here: ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Put a quantity here: ");
            quantity = Convert.ToInt32(Console.ReadLine());

            Product product = new Product(name, price, quantity);

            BuyProduct buyProductOrder = new BuyProduct(product);
            SellProduct sellProductOrder = new SellProduct(product);

            Broker broker = new Broker();
            broker.TakeOrder(buyProductOrder);
            broker.TakeOrder(sellProductOrder);

            broker.PlaceOrder();
        }
    }
}
