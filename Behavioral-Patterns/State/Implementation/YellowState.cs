using State.Abstraction;

namespace State.Implementation;

public class YellowState : ITrafficLightState
{
    public void Change(TrafficLight trafficLight)
    {
        Console.WriteLine("Yellow - be prepared to stop");
        trafficLight.SetState(new RedState());
    }
}