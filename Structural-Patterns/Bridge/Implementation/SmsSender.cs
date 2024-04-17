using Bridge.Abstraction;

namespace Bridge.Implementation;

public class SmsSender : IMessageSender
{
    public void SendMessage(string subject, string body)
    {
        Console.WriteLine($"SMS was send with subject: '{subject}' and body: '{body}'");
    }
}