using Decorator.Abstraction;

namespace Decorator.Implementation;

public class BasicCoffee : ICoffee
{
    public string Description => "Basic Coffee";

    public double Cost()
    {
        return 1.00;
    }
}