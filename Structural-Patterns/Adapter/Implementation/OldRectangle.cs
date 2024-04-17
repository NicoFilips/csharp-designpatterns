namespace Adapter.Implementation;

public class OldRectangle
{
    public readonly double Width;
    public readonly double Height;

    public OldRectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }
}