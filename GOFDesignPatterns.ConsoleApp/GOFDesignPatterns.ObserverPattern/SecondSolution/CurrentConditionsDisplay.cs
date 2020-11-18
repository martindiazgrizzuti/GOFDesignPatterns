using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.ObserverPattern.SecondSolution
{
    public class CurrentConditionsDisplay : IDisplayElement, IObserver
    {
        private float _temperature;
        private float _humidity;
        private readonly WeatherData _weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.registerObserver(this);
        }

        ~CurrentConditionsDisplay()
        {
            _weatherData.removeObserver(this);
        }

        public string display()
        {
            return $"Current conditions: {_temperature:N2} F degree and humidity %{_humidity:N2}.";
        }

        public void update()
        {
            _temperature = _weatherData.getTemperature();
            _humidity = _weatherData.getHumidity();
        }
    }
}
