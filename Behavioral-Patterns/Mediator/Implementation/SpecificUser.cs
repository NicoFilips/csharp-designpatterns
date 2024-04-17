using Mediator.Abstraction;

namespace Mediator.Implementation;

public class SpecificUser : User
{
    private string Name { get; set; }

    public SpecificUser(IChatroomMediator mediator, string name) : base(mediator)
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
    }
}