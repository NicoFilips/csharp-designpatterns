using Decorator.Abstraction;
using Decorator.Implementation;
using FluentAssertions;
using Moq;

namespace StructuralPatterns.test.Decorator;

public class DecoratorPatternTests
{
    [Test]
    public void BasicCoffee_ShouldHaveCorrectDescriptionAndCost()
    {
        // Arrange
        var coffee = new BasicCoffee();

        // Act & Assert
        coffee.Description.Should().Be("Basic Coffee");
        coffee.Cost().Should().Be(1.00);
    }
    
    [Test]
    public void WithMilk_ShouldAddMilkToDescriptionAndCost()
    {
        // Arrange
        var mockCoffee = new Mock<ICoffee>();
        mockCoffee.Setup(c => c.Description).Returns("Basic Coffee");
        mockCoffee.Setup(c => c.Cost()).Returns(1.00);
            
        var coffeeWithMilk = new WithMilk(mockCoffee.Object);

        // Act & Assert
        coffeeWithMilk.Description.Should().Be("Basic Coffee, Milk");
        coffeeWithMilk.Cost().Should().Be(1.50);
    }
    
    [Test]
    public void WithSugar_ShouldAddSugarToDescriptionAndCost()
    {
        // Arrange
        var mockCoffee = new Mock<ICoffee>();
        mockCoffee.Setup(c => c.Description).Returns("Basic Coffee");
        mockCoffee.Setup(c => c.Cost()).Returns(1.00);
            
        var coffeeWithSugar = new WithSugar(mockCoffee.Object);

        // Act & Assert
        coffeeWithSugar.Description.Should().Be("Basic Coffee, Sugar");
        coffeeWithSugar.Cost().Should().Be(1.25);
    }
}