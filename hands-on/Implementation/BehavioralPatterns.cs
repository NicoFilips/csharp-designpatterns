using ChainOfResponsibility;
using Command;
using Command.Implementation;
using Iterator.Abstraction;
using Iterator.Implementation;
using Mediator.Implementation;

namespace hands_on;

public class BehavioralPatterns
{
    
    /// <summary>
    /// Hands-on: Command Designpattern
    /// </summary>
    public static void Command()
    {
        Document document = new Document();
        List<ICommand> commands = new List<ICommand>();

        // Add text
        ICommand addCommand = new AddTextCommand(document, "Hello, ");
        addCommand.Execute();
        commands.Add(addCommand);

        // Add more text
        ICommand addMoreTextCommand = new AddTextCommand(document, "world!");
        addMoreTextCommand.Execute();
        commands.Add(addMoreTextCommand);

        Console.WriteLine(document);

        // Undo last action
        ICommand lastCommand = commands.LastOrDefault();
        if (lastCommand != null)
        {
            lastCommand.Undo();
            commands.Remove(lastCommand);
        }

        Console.WriteLine(document);
    }
    
    
    /// <summary>
    /// Hands-on: Chain-Of-Responsibility Designpattern
    /// </summary>
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
    
    /// <summary>
    /// Hands-on: Iterator Designpattern
    /// </summary>
    static void Iterator()
    {
        BookCollection buchSammlung = new BookCollection();
        buchSammlung.AddBuch(new Book("Design Patterns"));
        buchSammlung.AddBuch(new Book("Clean Code"));
        buchSammlung.AddBuch(new Book("Refactoring"));

        IIterator iterator = buchSammlung.CreateIterator();

        while (iterator.HasNext())
        {
            Book buch = (Book)iterator.Next();
            Console.WriteLine(buch.title);
        }
    }
    
    /// <summary>
    /// Hands-on: Mediator Designpattern
    /// </summary>
    static void Mediator(string[] args)
    {
        ChatroomMediator mediator = new ChatroomMediator();

        User user1 = new ConcreteUser(mediator, "Alice");
        User user2 = new ConcreteUser(mediator, "Bob");
        User user3 = new ConcreteUser(mediator, "Charlie");

        mediator.RegisterUser(user1);
        mediator.RegisterUser(user2);
        mediator.RegisterUser(user3);

        user1.Send("Hi everyone!");
        user2.Send("Hello Alice!");
        user3.Send("Hey Bob and Alice!");
    }
    
}