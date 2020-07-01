using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_2.ObserverPattern_CSharp
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }

    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}
