namespace Decorator.Abstraction;

public interface ICoffee
{
    string Description { get; }
    double Cost();
}