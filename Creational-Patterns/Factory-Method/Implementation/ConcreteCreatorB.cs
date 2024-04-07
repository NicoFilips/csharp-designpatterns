using Factory_Method.Abstraction;

namespace Factory_Method.Implementation;

public class ConcreteCreatorB : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductB();
    }
}