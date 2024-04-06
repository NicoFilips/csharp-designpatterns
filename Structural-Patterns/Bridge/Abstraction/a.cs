namespace Bridge.Abstraction;

// Die Abstraktion
public abstract class Message
{
    protected IMessageSender sender;

    public Message(INachrichtenSender sender)
    {
        this.sender = sender;
    }

    public abstract void Send(string betreff, string inhalt);
}

// Interface to implement
public interface IMessageSender
{
    void SendMessage(string betreff, string inhalt);
}