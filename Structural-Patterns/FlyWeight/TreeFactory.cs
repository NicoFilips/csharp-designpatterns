namespace FlyWeight;

public class TreeFactory
{
    private Dictionary<string, TreeType> _treeTypes = new Dictionary<string, TreeType>();

    public TreeType HoleTreeType(string treeType, string treeColor, string treeTexture)
    {
        string schlüssel = $"{treeType}-{treeColor}-{treeTexture}";
        if (!_treeTypes.ContainsKey(schlüssel))
        {
            _treeTypes[schlüssel] = new TreeType(treeType, treeColor, treeTexture);
            Console.WriteLine($"Treetype create: {schlüssel}");
        }
        return _treeTypes[schlüssel];
    }
}