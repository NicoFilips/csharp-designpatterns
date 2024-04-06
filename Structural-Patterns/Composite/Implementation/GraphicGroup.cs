using Composite.Abstraction;

namespace Composite.Implementation;

public class GraphicGroup : IGraphic
{
    private List<IGraphic> _graphics = new List<IGraphic>();

    public void Draw()
    {
        Console.WriteLine("Graphic Group:");
        foreach (var graphic in _graphics)
        {
            graphic.Draw();
        }
    }

    public void Add(IGraphic graphic)
    {
        _graphics.Add(graphic);
    }

    public void Remove(IGraphic graphic)
    {
        _graphics.Remove(graphic);
    }

    public IGraphic GetChild(int index)
    {
        if (index < _graphics.Count)
        {
            return _graphics[index];
        }
        return null;
    }
}