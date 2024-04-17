using Abstract_Factory;
using Abstract_Factory.Implementation;
using Builder;
using Factory_Method;
using Factory_Method.Implementation;
using Prototype;
using Singleton;

namespace hands_on;

public class CreationalPatterns
{
    /// <summary>
    /// Hands-on: Abstract-Factory Designpattern
    /// </summary>
    public static void AbstractFactory()
    {
        Console.WriteLine("Client: Testing client code with the first factory type...");
        ClientExample client1 = new ClientExample(new WindowsFactory());
        client1.Paint();

        Console.WriteLine("\nClient: Testing the same client code with the second factory type...");
        ClientExample client2 = new ClientExample(new MacOsFactory());
        client2.Paint();
    }
    

    /// <summary>
    /// Hands-on: Factory-Method Designpattern
    /// </summary>
    public static void FactoryMethod()
    {
        Console.WriteLine("App: Launched with the ConcreteCreatorA.");
        ClientCode(new ConcreteCreatorA());

        Console.WriteLine("");

        Console.WriteLine("App: Launched with the ConcreteCreatorB.");
        ClientCode(new ConcreteCreatorB());
    }

    // Der Client-Code arbeitet mit einer Instanz eines ConcreteCreators, obwohl er durch ihre gemeinsame Basisklasse (Creator) deklariert wird.
    public static void ClientCode(Creator creator)
    {
        // ...
        Console.WriteLine("Client: I'm not aware of the creator's class," +
                          "but it still works.\n" + creator.SomeOperation());
    }

    /// <summary>
    /// Hands-on: Prototype Designpattern
    /// </summary>
    public static void Prototype()
    {
        ConcretePrototype prototype1 = new ConcretePrototype(1, "Prototype1");
        Console.WriteLine($"Original: {prototype1.Id}, {prototype1.Name}");

        ConcretePrototype clone = (ConcretePrototype)prototype1.Clone();
        Console.WriteLine($"Clone:    {clone.Id}, {clone.Name}");

        clone.Name = "Clone1";
        Console.WriteLine($"Modified Clone: {clone.Id}, {clone.Name}");

        Console.WriteLine($"Original after modification: {prototype1.Id}, {prototype1.Name}");
    }

    /// <summary>
    /// Hands-on: Builder Designpattern
    /// </summary>
    public static void Builder()
    {
        Product product = new Product.Builder()
            .SetPartA("CustomA")
            .SetPartB("CustomB")
            .SetPartC("CustomC")
            .Build();
    }

    /// <summary>
    /// Hands-on: Singleton Designpattern
    /// </summary>
    public static void Singleton()
    {
        SingletonService.Instance.DoSomething();
    }
}