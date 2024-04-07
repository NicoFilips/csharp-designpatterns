using Command.Implementation;
using FluentAssertions;
using NUnit.Framework;

namespace BehavioralPatterns.test.Command;

[TestFixture]
public class CommandPatternTests
{
    private Document _document;

    [SetUp]
    public void Setup()
    {
        _document = new Document();
    }

    [Test]
    public void AddTextCommandAddsTextCorrectly()
    {
        var command = new AddTextCommand(_document, "Hello");
        command.Execute();

        _document.ToString().Should().Be("Hello", because: "the command should add 'Hello' to the document");
    }

    [Test]
    public void AddTextCommandUndoRemovesTextCorrectly()
    {
        var command = new AddTextCommand(_document, "Hello");
        command.Execute();
        command.Undo();

        _document.ToString().Should().BeEmpty(because: "undoing the command should remove the added text");
    }

    [Test]
    public void RemoveTextCommandUndoAddsTextBackCorrectly()
    {
        _document.AddText("Hello, World");
        var command = new RemoveTextCommand(_document, 7);
        command.Execute();
        command.Undo();

        _document.ToString().Should()
            .Be("Hello, World", because: "undoing the command should add the removed text back");
    }

    [Test]
    public void CombinedCommandsExecuteAndUndoCorrectly()
    {
        var addCommand = new AddTextCommand(_document, "Hello");
        var removeCommand = new RemoveTextCommand(_document, 5);

        addCommand.Execute(); // Document: "Hello"
        removeCommand.Execute(); // Document: ""

        removeCommand.Undo(); // Document: "Hello"
        addCommand.Undo(); // Document: ""

        _document.ToString().Should()
            .BeEmpty(because: "executing and then undoing both commands should leave the document empty");
    }
}