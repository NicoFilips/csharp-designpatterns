namespace Decorator.Abstraction;

// The abstract decorator class
public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee _coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public virtual string Description => _coffee.Description;
    public abstract double Cost();
}