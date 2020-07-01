using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_2.ObserverPattern_CSharp
{
    public class Observer_2 : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
            {
                Console.WriteLine("Suscriber-(Michell): Reacted to the event.");
            }
        }
    }
}
