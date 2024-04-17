namespace FlyWeight;

public class TreeFactory
{
    private readonly Dictionary<string, TreeType> _treeTypes = [];

    public TreeType HoleTreeType(string treeType, string treeColor, string treeTexture)
    {
        var key = $"{treeType}-{treeColor}-{treeTexture}";
        if (_treeTypes.ContainsKey(key)) return _treeTypes[key];
        
        _treeTypes[key] = new TreeType(treeType, treeColor, treeTexture);
        Console.WriteLine($"TreeType create: {key}");
        return _treeTypes[key];
    }
}