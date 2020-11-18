using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.ObserverPattern
{
    public class CurrentConditionsDisplay : IDisplayElement, IObserver
    {
        private float _temperature;
        private float _humidity;
        private readonly ISubject _subject;

        public CurrentConditionsDisplay(ISubject subject)
        {
            _subject = subject;
            _subject.registerObserver(this);
        }

        ~CurrentConditionsDisplay()
        {
            _subject.removeObserver(this);
        }

        public string display()
        {
            return $"Current conditions: {_temperature:N2} F degree and humidity %{_humidity:N2}.";
        }

        public void update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
        }
    }
}
