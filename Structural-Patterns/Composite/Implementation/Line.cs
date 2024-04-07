using Composite.Abstraction;

namespace Composite.Implementation;

public class Line : IGraphic
{
    public void Draw()
    {
        Console.WriteLine("Line Drawn.");
    }
    
    public void Add(IGraphic graphic) { }
    public void Remove(IGraphic graphic) { }
    public IGraphic GetChild(int index) { return null; }
}