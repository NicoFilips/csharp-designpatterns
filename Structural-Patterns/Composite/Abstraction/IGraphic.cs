namespace Composite.Abstraction;

public interface IGraphic
{
    void Draw();
    void Add(IGraphic graphic);
    void Remove(IGraphic graphic);
    IGraphic GetChild(int index);
}