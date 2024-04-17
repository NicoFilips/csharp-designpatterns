using State.Implementation;

namespace State.Abstraction;

public interface ITrafficLightState
{
    void Change(TrafficLight trafficLight);
}