using Adapter.Implementation;
using FluentAssertions;
using NUnit.Framework;

namespace StructuralPatterns.test.Adapter;

[TestFixture]
public class AdapterPatternTests
{
    [Test]
    public void RectangleAdapter_CalculatesPerimeterCorrectly()
    {
        // Arrange
        var oldRectangle = new OldRectangle(10, 5);
        var adapter = new RectangleAdapter(oldRectangle);

        // Act
        var perimeter = adapter.CalculatePerimeter();

        // Assert
        perimeter.Should().Be(30, because: "the perimeter of a rectangle with width 10 and height 5 should be 30");
    }
}