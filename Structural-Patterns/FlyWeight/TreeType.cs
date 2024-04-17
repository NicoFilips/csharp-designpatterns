namespace FlyWeight;

public class TreeType
{
    private string Type { get; set; }
    private string Color { get; set; }
    private string Texture { get; set; }

    public TreeType(string type, string color, string texture)
    {
        Type = type;
        Color = color;
        Texture = texture;
    }

    public void Paint(int x, int y)
    {
        Console.WriteLine($"Tree of type {this.Type} with the color {this.Color} and Texture {this.Texture} is located at ({x},{y}).");
    }
}