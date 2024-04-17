using Decorator.Abstraction;

namespace Decorator.Implementation;

public class WithSugar : CoffeeDecorator
{
    public WithSugar(ICoffee coffee) : base(coffee) { }

    public override string Description => $"{Coffee.Description}, Sugar";

    public override double Cost()
    {
        return Coffee.Cost() + 0.25;
    }
}