using Adapter.Abstraction;
using Adapter.Implementation;
using Bridge.Abstraction;
using Bridge.Implementation;
using Composite.Abstraction;
using Composite.Implementation;
using Decorator.Abstraction;
using Decorator.Implementation;
using Facade;
using FlyWeight;
using Proxy.Abstraction;
using Proxy.Implementation;

namespace hands_on.Implementation;

public class StructuralPatterns
{
    /// <summary>
    /// Hands-on: Flyweight Designpattern
    /// </summary>
    public static void Flyweight()
    {
        TreeFactory baumFabrik = new TreeFactory();

        var baumTyp1 = baumFabrik.HoleTreeType("Eiche", "Grün", "EichenTextur");
        var baum1 = new Tree(1, 2, baumTyp1);
        baum1.Draw();

        var baumTyp2 = baumFabrik.HoleTreeType("Eiche", "Grün", "EichenTextur");
        var baum2 = new Tree(3, 4, baumTyp2);
        baum2.Draw();
    }
    
    /// <summary>
    /// Hands-on: Facade Designpattern
    /// </summary>
    public static void Facade()
    {
        MediaConverterFacade mediaConverter = new MediaConverterFacade();
        string result = mediaConverter.ConvertVideo("example.avi", "mp4");
        Console.WriteLine(result);
    }
    
    /// <summary>
    /// Hands-on: Composite Designpattern
    /// </summary>
    public static void Composite()
    {
        // Erstellen von Blattobjekten
        IGraphic? line = new Line();
        IGraphic? circle = new Circle();

        // Erstellen eines zusammengesetzten Objekts und Hinzufügen von Blattobjekten
        GraphicGroup? group = new GraphicGroup();
        group.Add(line);
        group.Add(circle);

        // Zeichnen des zusammengesetzten Objekts, das auch seine Kinder zeichnet
        group.Draw();

        // Erstellen eines weiteren zusammengesetzten Objekts
        GraphicGroup group2 = new GraphicGroup();
        group2.Add(group);
        group2.Draw();
    }
    
    /// <summary>
    /// Hands-on: Proxy Designpattern
    /// </summary>
    public static void Proxy()
    {
        IBankAccount accountProxy = new BankAccountProxy("correctPassword");
        accountProxy.Deposit(100); // Deposit does not require authentication
        
        if (accountProxy.Withdraw(50))
        {
            Console.WriteLine("Withdrawal successful.");
        }
        else
        {
            Console.WriteLine("Withdrawal failed.");
        }

        Console.WriteLine($"Current balance is: ${accountProxy.GetBalance()}");
    }
    
    /// <summary>
    /// Hands-on: Decorator Designpattern
    /// </summary>
    public static void Decorator()
    {
        ICoffee myCoffee = new BasicCoffee();
        Console.WriteLine($"{myCoffee.Description}: ${myCoffee.Cost()}");

        // Decorate the coffee with milk
        myCoffee = new WithMilk(myCoffee);
        Console.WriteLine($"{myCoffee.Description}: ${myCoffee.Cost()}");

        // Further decorate the coffee with sugar
        myCoffee = new WithSugar(myCoffee);
        Console.WriteLine($"{myCoffee.Description}: ${myCoffee.Cost()}");
    }
    
    /// <summary>
    /// Hands-on: Adapter Designpattern
    /// </summary>
    public static void Adapter()
    {
        OldRectangle oldRectangle = new OldRectangle(5, 10);
        INewShape rectangleAdapter = new RectangleAdapter(oldRectangle);

        Console.WriteLine($"The perimeter is: {rectangleAdapter.CalculatePerimeter()}");
    }
    
    /// <summary>
    /// Hands-on: Bridge Designpattern
    /// </summary>
    public static void Bridge()
    {
        Message meineNachricht = new ImportantMessage(new EmailSender());
        meineNachricht.Send("Meeting", "Das Meeting beginnt um 10 Uhr.");

        Message smsNachricht = new ImportantMessage(new SmsSender());
        smsNachricht.Send("Erinnerung", "Vergiss nicht das Meeting um 10 Uhr.");
    }
}