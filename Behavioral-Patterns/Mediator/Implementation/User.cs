using Mediator.Abstraction;

namespace Mediator.Implementation;

public abstract class User
{
    protected readonly IChatroomMediator Mediator;

    public User(IChatroomMediator mediator)
    {
        Mediator = mediator;
    }

    public abstract void Send(string message);
    public abstract void Receive(string message);
}