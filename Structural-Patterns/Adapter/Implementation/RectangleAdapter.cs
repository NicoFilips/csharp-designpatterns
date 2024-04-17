using Adapter.Abstraction;

namespace Adapter.Implementation;

public class RectangleAdapter : INewShape
{
    private OldRectangle _oldRectangle;

    public RectangleAdapter(OldRectangle oldRectangle)
    {
        _oldRectangle = oldRectangle;
    }

    public double CalculatePerimeter()
    {
        return 2 * (_oldRectangle.Width + _oldRectangle.Height);
    }
}