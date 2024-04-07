using FluentAssertions;
using NUnit.Framework;
using Factory_Method;
using Factory_Method.Implementation;

namespace CreationalPatterns.test.FactoryMethod;

[TestFixture]
public class FactoryMethodPatternTests
{
    [Test]
    public void ConcreteCreatorA_Creates_ConcreteProductA()
    {
        var creator = new ConcreteCreatorA();
        var product = creator.FactoryMethod();

        product.Should()
            .BeOfType<ConcreteProductA>(because: "ConcreteCreatorA should create an instance of ConcreteProductA");
    }

    [Test]
    public void ConcreteCreatorB_Creates_ConcreteProductB()
    {
        var creator = new ConcreteCreatorB();
        var product = creator.FactoryMethod();

        product.Should()
            .BeOfType<ConcreteProductB>(because: "ConcreteCreatorB should create an instance of ConcreteProductB");
    }

    [Test]
    public void SomeOperation_With_ConcreteCreatorA_Returns_Expected_Result()
    {
        var creator = new ConcreteCreatorA();
        var result = creator.SomeOperation();

        result.Should().Be("Creator: The same creator's code has just worked with Result of ConcreteProductA",
            because:
            "SomeOperation in ConcreteCreatorA should work with ConcreteProductA and produce the expected message");
    }

    [Test]
    public void SomeOperation_With_ConcreteCreatorB_Returns_Expected_Result()
    {
        var creator = new ConcreteCreatorB();
        var result = creator.SomeOperation();

        result.Should().Be("Creator: The same creator's code has just worked with Result of ConcreteProductB",
            because:
            "SomeOperation in ConcreteCreatorB should work with ConcreteProductB and produce the expected message");
    }
}