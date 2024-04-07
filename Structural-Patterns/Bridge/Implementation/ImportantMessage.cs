using Bridge.Abstraction;

namespace Bridge.Implementation;

public class ImportantMessage : Message
{
    public ImportantMessage(IMessageSender sender) : base(sender)
    {
    }

    public override void Send(string head, string body)
    {
        string importantHead = $"urgent: {head}";
        string importantBody = $"!!! {body} !!!";
        sender.SendMessage(importantHead, importantBody);
    }
}