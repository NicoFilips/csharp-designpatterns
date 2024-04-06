using System.Reflection.Metadata;

namespace Command.Implementation;

public class AddTextCommand : ICommand
{
    private string _textToAdd;
    private Document _document;

    public AddTextCommand(Document document, string textToAdd)
    {
        _document = document;
        _textToAdd = textToAdd;
    }

    public void Execute()
    {
        _document.AddText(_textToAdd);
    }

    public void Undo()
    {
        _document.RemoveText(_textToAdd.Length);
    }
}