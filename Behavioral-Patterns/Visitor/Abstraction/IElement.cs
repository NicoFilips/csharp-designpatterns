namespace Visitor.Abstraction;

public interface IElement
{
    void Accept(IVisitor visitor);
}