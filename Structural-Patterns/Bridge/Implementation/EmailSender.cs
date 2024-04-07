using Bridge.Abstraction;

namespace Bridge.Implementation;

public class EmailSender : IMessageSender
{
    public void SendMessage(string betreff, string inhalt)
    {
        Console.WriteLine($"E-Mail gesendet mit Betreff: '{betreff}' und Inhalt: '{inhalt}'");
    }
}