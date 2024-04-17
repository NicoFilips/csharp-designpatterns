using Bridge.Abstraction;

namespace Bridge.Implementation;

public class EmailSender : IMessageSender
{
    public void SendMessage(string subject, string body)
    {
        Console.WriteLine($"E-Mail was send with subject: '{subject}' and body: '{body}'");
    }
}