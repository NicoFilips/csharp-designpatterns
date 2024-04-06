using ChainOfResponsibility;

namespace hands_on;

public class StructuralPatterns
{
    public static void chainOfResponsibility()
    {
        // Build up the chain
        RequestHandler infoHandler = new InfoHandler();
        RequestHandler beschwerdeHandler = new ConcernHandler();
        RequestHandler featureRequestHandler = new FeatureRequestHandler();

        infoHandler.SetNextHandler(beschwerdeHandler);
        beschwerdeHandler.SetNextHandler(featureRequestHandler);

        // Send a request trough the chain
        infoHandler.HandleRequest("Info");
        infoHandler.HandleRequest("Concern");
        infoHandler.HandleRequest("Feature");
    }
}