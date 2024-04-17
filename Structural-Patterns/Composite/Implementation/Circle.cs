using Composite.Abstraction;

namespace Composite.Implementation;

public class Circle : IGraphic
{
    public void Draw()
    {
        Console.WriteLine("Circle Drawn.");
    }
    
    public void Add(IGraphic? graphic) { }
    public void Remove(IGraphic? graphic) { }
    public IGraphic? GetChild(int index) { return null; }
}