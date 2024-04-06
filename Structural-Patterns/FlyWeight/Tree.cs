namespace FlyWeight;

public class Tree
{
    private int _x, _y;
    private TreeType _treeType;

    public Tree(int x, int y, TreeType treeType)
    {
        _x = x;
        _y = y;
        _treeType = treeType;
    }

    public void Zeichnen()
    {
        _treeType.paint(_x, _y);
    }
}