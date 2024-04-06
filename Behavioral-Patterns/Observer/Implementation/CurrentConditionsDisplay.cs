using Observer.Abstraction;

namespace Observer.Implementation;

public class CurrentConditionsDisplay : IObserver
{
    private float temperature;
    private float humidity;

    public void Update(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {temperature}C degrees and {humidity}% humidity");
    }
}