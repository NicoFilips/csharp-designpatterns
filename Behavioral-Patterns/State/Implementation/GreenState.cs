using State.Abstraction;

namespace State.Implementation;
public class GreenState : ITrafficLightState
{
    public void Change(TrafficLight trafficLight)
    {
        Console.WriteLine("Green - GO!");
        trafficLight.SetState(new YellowState());
    }
}