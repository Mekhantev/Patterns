using System.Collections.Generic;

namespace Core.Observer
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        private double _temp;
        private double _humidity;
        private double _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            _observers.ForEach(o => o.Update(_temp, _humidity, _pressure));
        }

        public void SetMeasurements(double temp, double humidity, double pressure)
        {
            _temp = temp;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }

        private void MeasurementsChanged()
        {
            NotifyObservers();
        }
    }
}