using Observer.Abstraction;

namespace BehavioralPatterns.test.Observer.Util;

public class MockDisplay : IObserver
{
    public bool HatUpdateErhalten { get; private set; } = false;

    public void Update(float temperatur, float luftfeuchtigkeit, float druck)
    {
        HatUpdateErhalten = true;
    }
}