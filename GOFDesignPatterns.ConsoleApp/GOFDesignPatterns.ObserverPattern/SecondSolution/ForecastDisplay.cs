using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.ObserverPattern.SecondSolution
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float _lastPressure;
        private float _currentPressure;
        private readonly WeatherData _weatherData;

        public ForecastDisplay(WeatherData weatherData, float currentPressure)
        {
            _weatherData = weatherData;
            _currentPressure = currentPressure;
            _weatherData.registerObserver(this);
        }

        ~ForecastDisplay()
        {
            _weatherData.removeObserver(this);
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

        public void update()
        {
            _lastPressure = _currentPressure;
            _currentPressure = _weatherData.getPressure();
        }
    }
}
