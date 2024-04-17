using Visitor.Abstraction;

namespace Visitor.Implementation;

public class ConcreteVisitor1 : IVisitor
{
    public void VisitElementA(ElementA element)
    {
        Console.WriteLine($"ConcreteVisitor1: ElementA visited with method {element.ExclusiveMethodOfElementA()}");
    }

    public void VisitElementB(ElementB element)
    {
        Console.WriteLine($"ConcreteVisitor1: ElementB visited with method {element.ExclusiveMethodOfElementB()}");
    }
}