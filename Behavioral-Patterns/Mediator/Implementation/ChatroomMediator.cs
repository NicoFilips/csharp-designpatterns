using Mediator.Abstraction;

namespace Mediator.Implementation;

public class ChatroomMediator : IChatroomMediator
{
    private List<User> _users = new List<User>();

    public void RegisterUser(User user)
    {
        _users.Add(user);
    }

    public void SendMessage(string message, User sender)
    {
        foreach (var user in _users)
        {
            // Der Sender erhält seine eigene Nachricht nicht
            if (user != sender)
            {
                user.Receive(message);
            }
        }
    }
}