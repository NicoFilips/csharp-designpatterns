using Bridge.Abstraction;

namespace Bridge.Implementation;

// Konkrete Implementierung für E-Mail
public class EmailSender : IMessageSender
{
    public void SendMessage(string betreff, string inhalt)
    {
        Console.WriteLine($"E-Mail gesendet mit Betreff: '{betreff}' und Inhalt: '{inhalt}'");
    }
}

// Konkrete Implementierung für SMS
public class SmsSender : IMessageSender
{
    public void SendMessage(string betreff, string inhalt)
    {
        Console.WriteLine($"SMS gesendet mit Betreff: '{betreff}' und Inhalt: '{inhalt}'");
    }
}