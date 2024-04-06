namespace ChainOfResponsibility;

public class ConcernHandler : RequestHandler
{
    public override void HandleRequest(string requestType)
    {
        if (requestType == "Concern")
        {
            Console.WriteLine("ConcernHandler is handling the request.");
        }
        else if (nextHandler != null)
        {
            nextHandler.HandleRequest(requestType);
        }
    }
}