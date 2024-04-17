namespace Decorator.Abstraction;

public abstract class CoffeeDecorator : ICoffee
{
    protected readonly ICoffee Coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        Coffee = coffee;
    }

    public virtual string Description => Coffee.Description;
    public abstract double Cost();
}