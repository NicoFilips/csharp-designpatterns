using Visitor.Abstraction;

namespace Visitor.Implementation;

public class ElementB : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitElementB(this);
    }

    public string ExclusiveMethodOfElementB()
    {
        return "Result from B";
    }
}