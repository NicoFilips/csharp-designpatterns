using Composite.Abstraction;
using Moq;
using Composite.Implementation;
using FluentAssertions;

namespace StructuralPatterns.test.Composite;

[TestFixture]
public class CompositePatternTests
{
    [Test]
    public void GraphicGroup_AddsAndGetsGraphicCorrectly()
    {
        // Arrange
        var graphicGroup = new GraphicGroup();
        var graphic = new Mock<IGraphic?>();

        // Act
        graphicGroup.Add(graphic.Object);
        var result = graphicGroup.GetChild(0);

        // Assert
        result.Should().BeSameAs(graphic.Object, because: "the added graphic should be retrievable");
    }

    [Test]
    public void GraphicGroup_RemovesGraphicCorrectly()
    {
        // Arrange
        var graphicGroup = new GraphicGroup();
        var graphic = new Mock<IGraphic?>();
        graphicGroup.Add(graphic.Object);

        // Act
        graphicGroup.Remove(graphic.Object);
        var result = graphicGroup.GetChild(0);

        // Assert
        result.Should().BeNull(because: "the removed graphic should not be retrievable");
    }

    [Test]
    public void GraphicGroup_DrawsAllContainedGraphics()
    {
        // Arrange
        var graphicGroup = new GraphicGroup();
        var circle = new Mock<IGraphic?>();
        var line = new Mock<IGraphic?>();
        graphicGroup.Add(circle.Object);
        graphicGroup.Add(line.Object);

        // Act
        graphicGroup.Draw();

        // Assert
        circle.Verify(g => g.Draw(), Times.Once(), "Draw should be called on the circle once");
        line.Verify(g => g.Draw(), Times.Once(), "Draw should be called on the line once");
    }
}