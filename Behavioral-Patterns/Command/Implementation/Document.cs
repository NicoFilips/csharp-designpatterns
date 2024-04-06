using System.Text;

namespace Command.Implementation;

public class Document
{
    private StringBuilder _text = new StringBuilder();

    public void AddText(string text)
    {
        _text.Append(text);
    }

    public void RemoveText(int length)
    {
        if (length > _text.Length) length = _text.Length;
        _text.Remove(_text.Length - length, length);
    }

    public string GetText(int startIndex, int length)
    {
        return _text.ToString(startIndex, length);
    }

    public int TextLength()
    {
        return _text.Length;
    }

    public override string ToString()
    {
        return _text.ToString();
    }
}