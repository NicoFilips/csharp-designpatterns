using Bridge.Abstraction;
using Bridge.Implementation;
using Moq;

namespace StructuralPatterns.test.Bridge;

[TestFixture]
public class BridgeTests
{
    [Test]
    public void ImportantMessage_SendsUrgentEmailCorrectly()
    {
        // Arrange
        var mockSender = new Mock<IMessageSender>();
        var message = new ImportantMessage(mockSender.Object);
        string betreff = "Test";
        string inhalt = "Test Inhalt";

        // Act
        message.Send(betreff, inhalt);

        // Assert
        mockSender.Verify(sender => sender.SendMessage(
                It.Is<string>(s => s == $"urgent: {betreff}"),
                It.Is<string>(s => s == $"!!! {inhalt} !!!")),
            Times.Once(), "ImportantMessage should format and send the message using the sender");
    }

    [Test]
    public void ImportantMessage_SendsUrgentSmsCorrectly()
    {
        // Arrange
        var mockSender = new Mock<IMessageSender>();
        var message = new ImportantMessage(mockSender.Object);
        string betreff = "Alert";
        string inhalt = "Critical Warning";

        // Act
        message.Send(betreff, inhalt);

        // Assert
        mockSender.Verify(sender => sender.SendMessage(
                It.Is<string>(s => s == $"urgent: {betreff}"),
                It.Is<string>(s => s == $"!!! {inhalt} !!!")),
            Times.Once(), "ImportantMessage should format and send the message using the sender");
    }
}