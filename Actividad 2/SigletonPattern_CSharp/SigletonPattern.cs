using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_2.SigletonPattern_CSharp
{
    public class SigletonPattern
    {
        public void Main()
        {
            Console.WriteLine("Your selection was the Sigleton Pattern: ");

            SigletonObject Object = SigletonObject.GetSigleton();

            Object.ShowMessage();
        }
    }
}
