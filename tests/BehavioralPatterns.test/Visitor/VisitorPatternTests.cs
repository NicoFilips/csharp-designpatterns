using Visitor.Abstraction;
using Visitor.Implementation;

namespace BehavioralPatterns.test.Visitor;

using NUnit.Framework;
using FluentAssertions;

[TestFixture]
public class VisitorPatternTests
{
    private class MockVisitor : IVisitor
    {
        public bool VisitedElementA { get; private set; }
        public bool VisitedElementB { get; private set; }

        public void VisitElementA(ElementA element)
        {
            VisitedElementA = true;
        }

        public void VisitElementB(ElementB element)
        {
            VisitedElementB = true;
        }
    }

    [Test]
    public void ElementA_ShouldAcceptVisitor()
    {
        // Arrange
        var elementA = new ElementA();
        var visitor = new MockVisitor();

        // Act
        elementA.Accept(visitor);

        // Assert
        visitor.VisitedElementA.Should().BeTrue();
    }

    [Test]
    public void ElementB_ShouldAcceptVisitor()
    {
        // Arrange
        var elementB = new ElementB();
        var visitor = new MockVisitor();

        // Act
        elementB.Accept(visitor);

        // Assert
        visitor.VisitedElementB.Should().BeTrue();
    }
}
