namespace Facade;

public class CodecConverter
{
    public string Convert(string filename, string format)
    {
        return $"Converted {filename} to {format}.";
    }
}