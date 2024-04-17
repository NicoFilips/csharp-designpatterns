using BehavioralPatterns.test.Observer.Util;
using Observer.Implementation;
using NUnit.Framework;
using FluentAssertions;

namespace BehavioralPatterns.test.Observer;

[TestFixture]
public class WetterstationTests
{
    [Test]
    public void Anzeige_Sollte_Update_Erhalten_Wenn_Wetterstation_Daten_Aktualisiert()
    {
        // Arrange
        var wetterstation = new WeatherStation();
        var mockAnzeige = new MockDisplay();
        wetterstation.RegisterObserver(mockAnzeige);

        // Act
        wetterstation.SetMeasurements(25.0f, 65.0f, 1013.0f);

        // Assert
        mockAnzeige.HatUpdateErhalten.Should().BeTrue();
    }

    [Test]
    public void Anzeige_Sollte_Kein_Update_Erhalten_Nach_Deregistrierung()
    {
        // Arrange
        var wetterstation = new WeatherStation();
        var mockAnzeige = new MockDisplay();
        wetterstation.RegisterObserver(mockAnzeige);
        wetterstation.RemoveObserver(mockAnzeige);

        // Act
        wetterstation.SetMeasurements(20.0f, 70.0f, 1010.0f);

        // Assert
        mockAnzeige.HatUpdateErhalten.Should().BeFalse();
    }
}