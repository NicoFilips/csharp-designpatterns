using Decorator.Abstraction;

namespace Decorator.Implementation;

// Concrete decorator for adding sugar to the coffee
public class WithSugar : CoffeeDecorator
{
    public WithSugar(ICoffee coffee) : base(coffee) { }

    public override string Description => $"{_coffee.Description}, Sugar";

    public override double Cost()
    {
        return _coffee.Cost() + 0.25; // adding cost of sugar
    }
}