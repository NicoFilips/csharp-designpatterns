using Bridge.Abstraction;

namespace Bridge.Implementation;

// Eine verfeinerte Abstraktion für dringende Nachrichten
public class ImportantMessage : Message
{
    public ImportantMessage(IMessageSender sender) : base(sender)
    {
    }

    public override void Senden(string betreff, string inhalt)
    {
        string dringenderBetreff = $"Dringend: {betreff}";
        string dringenderInhalt = $"!!! {inhalt} !!!";
        sender.SendMessage(dringenderBetreff, dringenderInhalt);
    }
}