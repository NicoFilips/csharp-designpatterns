using Mediator.Abstraction;

namespace Mediator.Implementation;

public class ConcreteUser : User
{
    public string Name { get; private set; }

    public ConcreteUser(IChatroomMediator mediator, string name) : base(mediator)
    {
        Name = name;
    }

    public override void Send(string message)
    {
        Console.WriteLine($"{Name} sends: {message}");
        _mediator.SendMessage(message, this);
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"{Name} receives: {message}");
    }
}