using Bridge.Abstraction;

namespace Bridge.Implementation;

public class SmsSender : IMessageSender
{
    public void SendMessage(string betreff, string inhalt)
    {
        Console.WriteLine($"SMS gesendet mit Betreff: '{betreff}' und Inhalt: '{inhalt}'");
    }
}