using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.ObserverPattern
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float _lastPressure;
        private float _currentPressure;
        private readonly ISubject _subject;

        public ForecastDisplay(ISubject subject, float currentPressure)
        {
            _subject = subject;
            _currentPressure = currentPressure;
            _subject.registerObserver(this);
        }

        ~ForecastDisplay()
        {
            _subject.removeObserver(this);
        }

        public string display()
        {
            if (_currentPressure > _lastPressure)
            {
                return "Improving weather on the way!";
            }
            else if (_currentPressure == _lastPressure)
            {
                return "More of the same";
            }
            else 
            {
                return "Watch out for cooler, rainy weather";
            }
        }

        public void update(float temperature, float humidity, float pressure)
        {
            _lastPressure = _currentPressure;
            _currentPressure = pressure;
        }
    }
}
