namespace Adapter.Implementation;

// Existing class with an old interface
public class OldRectangle
{
    public double Width;
    public double Height;

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