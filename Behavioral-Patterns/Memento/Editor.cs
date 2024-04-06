namespace Memento;

public class Editor
{
    private string _content;

    public void SetText(string text)
    {
        _content = text;
    }

    public string GetText()
    {
        return _content;
    }

    public EditorMemento Save()
    {
        return new EditorMemento(_content);
    }

    public void Restore(EditorMemento memento)
    {
        _content = memento.GetState();
    }
}