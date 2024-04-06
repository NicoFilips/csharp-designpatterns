namespace Decorator.Abstraction;

// The component interface
public interface ICoffee
{
    string Description { get; }
    double Cost();
}