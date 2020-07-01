using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Actividad_2.CommandPattern_CSharp
{
    public class Product
    {
        private readonly string Name;
        private readonly int Price;
        private readonly int Quatity;

        public Product(string name, int price, int quatity)
        {
            this.Name = name;
            this.Price = price;
            this.Quatity = quatity;
        }

        public void Buy()
        {
            Console.WriteLine("Product Name: " + Name + ", Prince: " + Price +", Quatity: " + Quatity + " was bought");
        }

        public void Sell()
        {
            Console.WriteLine("Product Name: " + Name + ", Prince: " + Price + ", Quatity: " + Quatity + " was sold");
        }
    }
}
