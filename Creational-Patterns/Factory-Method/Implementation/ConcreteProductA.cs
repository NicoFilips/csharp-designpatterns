using Factory_Method.Abstraction;

namespace Factory_Method.Implementation;

public class ConcreteProductA : IProduct
{
    public string Operation()
    {
        return "Result of ConcreteProductA";
    }
}
