using State.Abstraction;

namespace State.Implementation;

public class TrafficLight
{
    private ITrafficLightState _state;

    public TrafficLight()
    {
        _state = new RedState();
    }
    
    public ITrafficLightState GetCurrentState()
    {
        return _state;
    }

    public void SetState(ITrafficLightState state)
    {
        _state = state;
    }

    public void Change()
    {
        _state.Change(this);
    }
}