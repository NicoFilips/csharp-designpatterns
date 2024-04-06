using System.Reflection.Metadata;

namespace Command.Implementation;

public class RemoveTextCommand : ICommand
{
    private int _lengthToRemove;
    private Document _document;
    private string _removedText;

    public RemoveTextCommand(Document document, int lengthToRemove)
    {
        _document = document;
        _lengthToRemove = lengthToRemove;
    }

    public void Execute()
    {
        _removedText = _document.GetText(_document.TextLength() - _lengthToRemove, _lengthToRemove);
        _document.RemoveText(_lengthToRemove);
    }

    public void Undo()
    {
        _document.AddText(_removedText);
    }
}