using Visitor.Abstraction;

namespace Visitor.Implementation;

public class ElementA : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitElementA(this);
    }

    public string ExclusiveMethodOfElementA()
    {
        return "Result from A";
    }
}