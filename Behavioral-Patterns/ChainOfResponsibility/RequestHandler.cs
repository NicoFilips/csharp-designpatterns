namespace ChainOfResponsibility;

public abstract class RequestHandler
{
    protected RequestHandler nextHandler;

    public void SetNextHandler(RequestHandler handler)
    {
        nextHandler = handler;
    }

    public abstract void HandleRequest(string anfrageTyp);
}