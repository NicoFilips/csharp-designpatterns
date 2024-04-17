using Decorator.Abstraction;

namespace Decorator.Implementation;

public class WithMilk : CoffeeDecorator
{
    public WithMilk(ICoffee coffee) : base(coffee) { }

    public override string Description => $"{Coffee.Description}, Milk";

    public override double Cost()
    {
        return Coffee.Cost() + 0.50;
    }
}