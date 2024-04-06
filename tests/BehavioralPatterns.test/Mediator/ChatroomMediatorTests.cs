using BehavioralPatterns.test.Mediator.Util;
using FluentAssertions;
using Mediator.Implementation;

namespace BehavioralPatterns.test.Mediator;

[TestFixture]
public class ChatroomMediatorTests
{
    [Test]
    public void User_Should_Receive_Message_From_Other_User()
    {
        // Arrange
        var mediator = new ChatroomMediator();
        var alice = new TestableUser(mediator, "Alice");
        var bob = new TestableUser(mediator, "Bob");
        mediator.RegisterUser(alice);
        mediator.RegisterUser(bob);

        // Act
        alice.Send("Hi Bob!");

        // Assert
        bob.ReceivedMessages.Should().ContainSingle()
            .And.Contain("Hi Bob!");
    }

    [Test]
    public void User_Should_Not_Receive_Its_Own_Message()
    {
        // Arrange
        var mediator = new ChatroomMediator();
        var alice = new TestableUser(mediator, "Alice");
        mediator.RegisterUser(alice);

        // Act
        alice.Send("Hi Alice!");

        // Assert
        alice.ReceivedMessages.Should().BeEmpty();
    }

    [Test]
    public void All_Users_Should_Receive_Message_Except_Sender()
    {
        // Arrange
        var mediator = new ChatroomMediator();
        var alice = new TestableUser(mediator, "Alice");
        var bob = new TestableUser(mediator, "Bob");
        var charlie = new TestableUser(mediator, "Charlie");
        mediator.RegisterUser(alice);
        mediator.RegisterUser(bob);
        mediator.RegisterUser(charlie);

        // Act
        alice.Send("Hello everyone!");

        // Assert
        alice.ReceivedMessages.Should().BeEmpty();
        bob.ReceivedMessages.Should().ContainSingle()
            .And.Contain("Hello everyone!");
        charlie.ReceivedMessages.Should().ContainSingle()
            .And.Contain("Hello everyone!");
    }
}