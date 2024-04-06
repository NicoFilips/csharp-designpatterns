namespace FlyWeight;

// Flyweight pattern
public class TreeType
{
    public string Type { get; private set; }
    public string Color { get; private set; }
    public string Texture { get; private set; }

    public TreeType(string type, string color, string texture)
    {
        Type = type;
        Color = color;
        Texture = texture;
    }

    public void paint(int x, int y)
    {
        Console.WriteLine($"Tree of type {this.Type} with the color {this.Color} and Texture {this.Texture} is located at ({x},{y}).");
    }
}