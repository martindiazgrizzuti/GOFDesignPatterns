using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.ObserverPattern
{
    public interface ISubject
    {
        void registerObserver(IObserver observer);
        bool removeObserver(IObserver observer);
        void notifyObservers();
    }
}
