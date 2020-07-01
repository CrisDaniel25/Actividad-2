using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_2.ObserverPattern_CSharp
{    
    public class ObserverPattern
    {
        public void Main()
        {
            Console.WriteLine("Your selection was the Observer Pattern: ");

            var subject = new Subject();
            var observerA = new Observer_1();
            subject.Attach(observerA);

            var observerB = new Observer_2();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);

            subject.SomeBusinessLogic();
        }

    }
}
