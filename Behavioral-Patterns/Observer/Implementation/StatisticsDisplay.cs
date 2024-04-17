using Observer.Abstraction;

namespace Observer.Implementation;

public class StatisticsDisplay : IObserver
{
    private float _maxTemp = 0.0f;
    private float _minTemp = 200;
    private float _tempSum = 0.0f;
    private int _numReadings;

    public void Update(float temperature, float humidity, float pressure)
    {
        _tempSum += temperature;
        _numReadings++;

        if (temperature > _maxTemp) {
            _maxTemp = temperature;
        }
 
        if (temperature < _minTemp) {
            _minTemp = temperature;
        }

        Display();
    }

    private void Display()
    {
        Console.WriteLine($"Avg/Max/Min temperature = {_tempSum / _numReadings}/{_maxTemp}/{_minTemp}");
    }
}