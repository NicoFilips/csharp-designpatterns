using Decorator.Abstraction;

namespace Decorator.Implementation;

// Concrete component
public class BasicCoffee : ICoffee
{
    public string Description => "Basic Coffee";

    public double Cost()
    {
        return 1.00; // base price for basic coffee
    }
}