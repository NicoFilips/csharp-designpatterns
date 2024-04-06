namespace Singleton;

public sealed class Singleton
{
    // A private static variable that holds the single instance of the class.
    private static readonly Singleton instance = new Singleton();

    // Private constructor ensures that the class cannot be instantiated from outside.
    private Singleton()
    {
    }

    // A public static property that provides access to the single instance.
    public static Singleton Instance
    {
        get { return instance; }
    }

    // An example method that can be called on the singleton instance.
    public void DoSomething()
    {
        Console.WriteLine("Singleton Pattern!");
    }
}