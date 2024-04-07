namespace Bridge.Abstraction;

public abstract class Message
{
    protected IMessageSender sender;

    public Message(IMessageSender sender)
    {
        this.sender = sender;
    }

    public abstract void Send(string betreff, string inhalt);
}