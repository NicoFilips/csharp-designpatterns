namespace Bridge.Abstraction;

public abstract class Message
{
    protected readonly IMessageSender Sender;

    public Message(IMessageSender sender)
    {
        this.Sender = sender;
    }

    public abstract void Send(string subject, string body);
}