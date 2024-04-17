namespace Bridge.Abstraction;

public interface IMessageSender
{
    void SendMessage(string subject, string body);
}