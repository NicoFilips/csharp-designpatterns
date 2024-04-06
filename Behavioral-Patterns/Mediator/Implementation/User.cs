using Mediator.Abstraction;

namespace Mediator.Implementation;

public abstract class User
{
    protected IChatroomMediator _mediator;

    public User(IChatroomMediator mediator)
    {
        _mediator = mediator;
    }

    public abstract void Send(string message);
    public abstract void Receive(string message);
}