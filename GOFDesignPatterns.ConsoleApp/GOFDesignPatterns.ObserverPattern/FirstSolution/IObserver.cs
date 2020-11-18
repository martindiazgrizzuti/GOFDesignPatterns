using System;

namespace GOFDesignPatterns.ObserverPattern
{
    public interface IObserver
    {
        void update(float temperature, float humidity, float pressure);
    }
}
