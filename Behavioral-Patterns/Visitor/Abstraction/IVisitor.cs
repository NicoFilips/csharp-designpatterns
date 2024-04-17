using Visitor.Implementation;

namespace Visitor.Abstraction;

public interface IVisitor
{
    void VisitElementA(ElementA element);
    void VisitElementB(ElementB element);
}