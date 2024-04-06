using FluentAssertions;
using Memento;

namespace BehavioralPatterns.test.Memento;

[TestFixture]
public class MementoPatternTests
{
    private Editor _editor;
    private Caretaker _caretaker;

    [SetUp]
    public void Setup()
    {
        _editor = new Editor();
        _caretaker = new Caretaker(_editor);
    }

    [Test]
    public void Editor_Should_Save_And_Restore_Text_Correctly_Using_Memento()
    {
        // Arrange
        var initialText = "Initial Text";
        _editor.SetText(initialText);

        // Act
        var memento = _editor.Save();
        _editor.SetText("Modified Text");
        _editor.Restore(memento);

        // Assert
        _editor.GetText().Should().Be(initialText);
    }

    [Test]
    public void Caretaker_Should_Undo_Editor_Changes_Correctly()
    {
        // Arrange
        _editor.SetText("Version 1");
        _caretaker.Backup();
        _editor.SetText("Version 2");

        // Act
        _caretaker.Undo();

        // Assert
        _editor.GetText().Should().Be("Version 2");
    }
    
    [Test]
    public void Caretaker_Should_Redo_Editor_Changes_Correctly()
    {
        // Arrange
        _editor.SetText("Version 1");
        _caretaker.Backup();
        _editor.SetText("Version 2");
        _caretaker.Backup();
        _caretaker.Undo();
        
        // Act
        _caretaker.Redo();

        // Assert
        _editor.GetText().Should().Be("Version 2");
    }
}