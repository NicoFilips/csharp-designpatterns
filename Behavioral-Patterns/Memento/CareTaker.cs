namespace Memento;

public class Caretaker
{
    private readonly List<EditorMemento> _mementos = new();
    private readonly Editor _editor;
    private int _currentIndex = -1;

    public Caretaker(Editor editor)
    {
        _editor = editor;
    }

    public void Backup()
    {
        _mementos.Add(_editor.Save());
        _currentIndex++;
    }

    public void Undo()
    {
        if (_currentIndex <= 0) return;

        _currentIndex--;
        var memento = _mementos[_currentIndex];
        _editor.Restore(memento);
    }

    public void Redo()
    {
        if (_currentIndex >= _mementos.Count - 1) return;

        _currentIndex++;
        var memento = _mementos[_currentIndex];
        _editor.Restore(memento);
    }
}