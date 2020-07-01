using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Actividad_2.ObserverPattern_CSharp
{
    public class Subject : ISubject
    {
        public int State { get; set; } = -0;

        private readonly List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Source of content: Attached a suscribers.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Source of content: Detached a suscribers.");
        }

        public void Notify()
        {
            Console.WriteLine("Source of content: Notifying suscribers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSource of content: I'm doing something important.");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Source of content: My state has just changed to: " + this.State);
            this.Notify();
        }
    }
}

