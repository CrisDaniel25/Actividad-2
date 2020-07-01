using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_2.SigletonPattern_CSharp
{
    public class SigletonObject
    {
        private string Name;
        private string LastName;
        private int Age;

        private readonly static SigletonObject Instance = new SigletonObject();

        private SigletonObject() { }

        public static SigletonObject GetSigleton()
        {
            return Instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Put your name here: ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Put your lastname here: ");
            this.LastName = Console.ReadLine();
            Console.WriteLine("Put your age here: ");
            this.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + "I'm " + Name + " " + LastName + " and my age is " + Age);
        }
    }
}
