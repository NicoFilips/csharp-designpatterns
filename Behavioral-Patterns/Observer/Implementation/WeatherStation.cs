using Observer.Abstraction;

namespace Observer.Implementation;

public class WeatherStation : ISubject
{
    private readonly List<IObserver> _observers;
    private float _temperature;
    private float _humidity;
    private float _pressure;

    public WeatherStation()
    {
        _observers = new List<IObserver>();
    }

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_temperature, _humidity, _pressure);
        }
    }

    private void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        this._temperature = temperature;
        this._humidity = humidity;
        this._pressure = pressure;
        MeasurementsChanged();
    }
}