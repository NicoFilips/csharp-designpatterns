using State.Abstraction;

namespace State.Implementation;

public class RedState : ITrafficLightState
{
    public void Change(TrafficLight trafficLight)
    {
        Console.WriteLine("Red - You'll have to wait");
        trafficLight.SetState(new GreenState());
    }
}