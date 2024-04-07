using Factory_Method.Abstraction;

namespace Factory_Method.Implementation;

public class ConcreteProductB : IProduct
{
    public string Operation()
    {
        return "Result of ConcreteProductB";
    }
}