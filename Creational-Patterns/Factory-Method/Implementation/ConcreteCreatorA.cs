using Factory_Method.Abstraction;

namespace Factory_Method.Implementation;

public class ConcreteCreatorA : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductA();
    }
}