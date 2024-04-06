namespace ChainOfResponsibility;

public class FeatureRequestHandler : RequestHandler
{
    public override void HandleRequest(string requestType)
    {
        if (requestType == "Feature")
        {
            Console.WriteLine("FeatureRequestHandler is handling the request.");
        }
        else if (nextHandler != null)
        {
            nextHandler.HandleRequest(requestType);
        }
    }
}