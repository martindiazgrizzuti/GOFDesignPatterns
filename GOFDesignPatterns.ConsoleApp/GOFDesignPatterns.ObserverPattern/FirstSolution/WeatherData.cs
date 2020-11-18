using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.ObserverPattern
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void registerObserver(IObserver observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }

        public bool removeObserver(IObserver observer)
        {
            return observers.Remove(observer);
        }

        public void notifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.update(_temperature, _humidity, _pressure);
            }
        }

        /// <summary>
        ///     Notify the observers when we get updated measurements from the Weather Station
        /// </summary>
        public void measurementsChanged()
        {
            notifyObservers();
        }

        /// <summary>
        ///     This method is created for testing the notifyObservers method
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            measurementsChanged();
        }



    }
}
