namespace Singleton;

public sealed class SingletonService
{
    private static readonly SingletonService _singletonService = new();
    
    private SingletonService(){}
    
    public static SingletonService Instance => _singletonService;
    
    public void DoSomething()
    {
        Console.WriteLine("Singleton Pattern!");
    }
}