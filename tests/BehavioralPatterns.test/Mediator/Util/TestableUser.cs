using Mediator.Abstraction;
using Mediator.Implementation;

namespace BehavioralPatterns.test.Mediator.Util;

public class TestableUser : User
{
    public List<string> ReceivedMessages { get; } = new List<string>();
    public string Name { get; private set; }

    public TestableUser(IChatroomMediator mediator, string name) : base(mediator)
    {
        Name = name;
    }

    public override void Send(string message)
    {
        Console.WriteLine($"{Name} sends: {message}");
        Mediator.SendMessage(message, this);
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"{Name} receives: {message}");
        ReceivedMessages.Add(message);
    }
}