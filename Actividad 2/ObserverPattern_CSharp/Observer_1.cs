using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_2.ObserverPattern_CSharp
{
    public class Observer_1 : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 3)
            {
                Console.WriteLine("Observer #1 (Michael): Reacted to the event.");
            }
        }
    }
}
