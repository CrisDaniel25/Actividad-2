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
            Console.WriteLine("Subject: Attached an observer.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Subject (Sender): Detached an observer.");
        }

        public void Notify()
        {
            Console.WriteLine("Subject (Sender): Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject (Sender): I'm doing something important.");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Subject (Sender): My state has just changed to: " + this.State);
            this.Notify();
        }
    }
}

