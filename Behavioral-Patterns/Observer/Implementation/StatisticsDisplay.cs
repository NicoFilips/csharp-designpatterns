using Observer.Abstraction;

namespace Observer.Implementation;

public class StatisticsDisplay : IObserver
{
    private float maxTemp = 0.0f;
    private float minTemp = 200;
    private float tempSum= 0.0f;
    private int numReadings;

    public void Update(float temperature, float humidity, float pressure)
    {
        tempSum += temperature;
        numReadings++;

        if (temperature > maxTemp) {
            maxTemp = temperature;
        }
 
        if (temperature < minTemp) {
            minTemp = temperature;
        }

        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Avg/Max/Min temperature = {tempSum / numReadings}/{maxTemp}/{minTemp}");
    }
}