using Mediator.Implementation;

namespace Mediator.Abstraction;

public interface IChatroomMediator
{
    void SendMessage(string message, User user);
    void RegisterUser(User user);
}