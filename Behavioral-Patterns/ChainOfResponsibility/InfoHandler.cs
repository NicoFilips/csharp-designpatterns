namespace ChainOfResponsibility;

public class InfoHandler : RequestHandler
{
    public override void HandleRequest(string requestType)
    {
        if (requestType == "Info")
        {
            Console.WriteLine("InfoHandler is handling the request.");
        }
        else if (nextHandler != null)
        {
            nextHandler.HandleRequest(requestType);
        }
    }
}