using Visitor.Abstraction;

namespace Visitor.Implementation;


public class ConcreteVisitor2 : IVisitor
{
    public void VisitElementA(ElementA element)
    {
        Console.WriteLine($"ConcreteVisitor2: ElementA visited with method {element.ExclusiveMethodOfElementA()}");
    }

    public void VisitElementB(ElementB element)
    {
        Console.WriteLine($"ConcreteVisitor2: ElementB visited with method {element.ExclusiveMethodOfElementB()}");
    }
}