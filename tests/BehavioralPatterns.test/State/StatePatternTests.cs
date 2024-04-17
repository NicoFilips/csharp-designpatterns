using FluentAssertions;
using State.Implementation;

namespace BehavioralPatterns.test.State;

[TestFixture]
public class StatePatternTests
{
    [Test]
    public void TrafficLight_InitialState_IsRed()
    {
        // Arrange
        var trafficLight = new TrafficLight();

        // Act
        var state = trafficLight.GetCurrentState();

        // Assert
        state.Should().BeOfType<RedState>();
    }

    [Test]
    public void TrafficLight_ChangesFromRedToGreen()
    {
        // Arrange
        var trafficLight = new TrafficLight();
        
        // Act
        trafficLight.Change();
        var state = trafficLight.GetCurrentState();

        // Assert
        state.Should().BeOfType<GreenState>();
    }

    [Test]
    public void TrafficLight_ChangesFromGreenToYellow()
    {
        // Arrange
        var trafficLight = new TrafficLight();
        trafficLight.Change();

        // Act
        trafficLight.Change();
        var state = trafficLight.GetCurrentState();

        // Assert
        state.Should().BeOfType<YellowState>();
    }

    [Test]
    public void TrafficLight_ChangesFromYellowToRed()
    {
        // Arrange
        var trafficLight = new TrafficLight();
        trafficLight.Change();
        trafficLight.Change();

        // Act
        trafficLight.Change();
        var state = trafficLight.GetCurrentState();

        // Assert
        state.Should().BeOfType<RedState>();
    }
}