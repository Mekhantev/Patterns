using System;

namespace Core.Observer
{
    public class SimpleDisplay : IDisplayElement, IObserver
    {
        private ISubject _weatherData;
        private double _temp;
        private double _humidity;

        public SimpleDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.Register(this);
        }

        public void Display()
        {
            Console.WriteLine("Temp: " + _temp + " Humidity: " + _humidity);
        }

        public void Update(double temp, double humidity, double pressure)
        {
            _temp = temp;
            _humidity = humidity;
            Display();
        }
    }
}