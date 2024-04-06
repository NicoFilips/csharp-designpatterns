namespace Memento;

public class EditorMemento
{
    private string _state;

    public EditorMemento(string state)
    {
        _state = state;
    }

    public string GetState()
    {
        return _state;
    }
}