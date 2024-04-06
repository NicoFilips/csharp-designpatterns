using Decorator.Abstraction;

namespace Decorator.Implementation;

// Concrete decorator for adding milk to the coffee
public class WithMilk : CoffeeDecorator
{
    public WithMilk(ICoffee coffee) : base(coffee) { }

    public override string Description => $"{_coffee.Description}, Milk";

    public override double Cost()
    {
        return _coffee.Cost() + 0.50; // adding cost of milk
    }
}