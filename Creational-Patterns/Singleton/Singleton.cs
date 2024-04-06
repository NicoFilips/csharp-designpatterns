namespace Singleton;

public sealed class SingletonClass
{
    // A private static variable that holds the single instance of the class.
    private static readonly SingletonClass instance = new SingletonClass();

    // Private constructor ensures that the class cannot be instantiated from outside.
    private SingletonClass()
    {
    }

    // A public static property that provides access to the single instance.
    public static SingletonClass Instance
    {
        get { return instance; }
    }

    // An example method that can be called on the singleton instance.
    public void DoSomething()
    {
        Console.WriteLine("Singleton Pattern!");
    }
}