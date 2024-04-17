using Observer.Abstraction;

namespace Observer.Implementation;

public class CurrentConditionsDisplay : IObserver
{
    private float _temperature;
    private float _humidity;

    public void Update(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        Display();
    }

    private void Display()
    {
        Console.WriteLine($"Current conditions: {_temperature}C degrees and {_humidity}% humidity");
    }
}