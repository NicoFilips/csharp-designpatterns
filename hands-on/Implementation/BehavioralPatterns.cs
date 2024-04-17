using ChainOfResponsibility;
using Command;
using Command.Implementation;
using Iterator.Abstraction;
using Iterator.Implementation;
using Mediator.Implementation;
using Memento;
using Observer.Implementation;
using State.Implementation;

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
    public static void Iterator()
    {
        BookCollection bookCollection = new BookCollection();
        bookCollection.AddBook(new Book("Design Patterns"));
        bookCollection.AddBook(new Book("Clean Code"));
        bookCollection.AddBook(new Book("Refactoring"));

        IIterator iterator = bookCollection.CreateIterator();

        while (iterator.HasNext())
        {
            Book book = (Book)iterator.Next();
            Console.WriteLine(book.title);
        }
    }
    
    /// <summary>
    /// Hands-on: Mediator Designpattern
    /// </summary>
    public static void Mediator()
    {
        ChatroomMediator mediator = new ChatroomMediator();

        User user1 = new SpecificUser(mediator, "Alice");
        User user2 = new SpecificUser(mediator, "Bob");
        User user3 = new SpecificUser(mediator, "Charlie");

        mediator.RegisterUser(user1);
        mediator.RegisterUser(user2);
        mediator.RegisterUser(user3);

        user1.Send("Hi everyone!");
        user2.Send("Hello Alice!");
        user3.Send("Hey Bob and Alice!");
    }
    
    
    /// <summary>
    /// Hands-on: Memento Designpattern
    /// </summary>
    public static void Memento()
    {
        Editor editor = new Editor();
        Caretaker caretaker = new Caretaker(editor);

        editor.SetText("Version 1");
        caretaker.Backup();

        editor.SetText("Version 2");
        caretaker.Backup();

        editor.SetText("Version 3");
        caretaker.Backup();

        Console.WriteLine(editor.GetText()); // Ausgabe: Version 3

        caretaker.Undo();
        Console.WriteLine(editor.GetText()); // Ausgabe: Version 2

        caretaker.Undo();
        Console.WriteLine(editor.GetText()); // Ausgabe: Version 1

        caretaker.Redo();
        Console.WriteLine(editor.GetText()); // Ausgabe: Version 2
    }
    
    /// <summary>
    /// Hands-on: Observer Designpattern
    /// </summary>
    public static void Observer()
    {
        WeatherStation weatherStation = new WeatherStation();
        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay();
        StatisticsDisplay statisticsDisplay = new StatisticsDisplay();

        weatherStation.RegisterObserver(currentDisplay);
        weatherStation.RegisterObserver(statisticsDisplay);

        weatherStation.SetMeasurements(25f, 65f, 30.4f);
        weatherStation.SetMeasurements(27f, 70f, 29.2f);
        weatherStation.SetMeasurements(26f, 90f, 29.2f);

        weatherStation.RemoveObserver(statisticsDisplay);
        weatherStation.SetMeasurements(28f, 90f, 29.2f);
    }
    
    /// <summary>
    /// Hands-on: Observer Designpattern
    /// </summary>
    public static void State()
    {
            var trafficLight = new TrafficLight();
            trafficLight.Change();
            trafficLight.Change();
            trafficLight.Change();
    }

    
}