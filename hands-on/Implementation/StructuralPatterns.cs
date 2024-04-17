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
        TreeFactory treeFactory = new TreeFactory();

        var treeType1 = treeFactory.HoleTreeType("Oak", "Green", "OakTexture");
        var firstTree = new Tree(1, 2, treeType1);
        firstTree.Draw();

        var treeType2 = treeFactory.HoleTreeType("Oak", "Green", "OakTexture");
        var secondTree = new Tree(3, 4, treeType2);
        secondTree.Draw();
    }
    
    /// <summary>
    /// Hands-on: Facade Designpattern
    /// </summary>
    public static void Facade()
    {
        var mediaConverter = new MediaConverterFacade();
        var result = mediaConverter.ConvertVideo("example.avi", "mp4");
        Console.WriteLine(result);
    }
    
    /// <summary>
    /// Hands-on: Composite Designpattern
    /// </summary>
    public static void Composite()
    {
        IGraphic? line = new Line();
        IGraphic? circle = new Circle();
        
        GraphicGroup? group = new GraphicGroup();
        group.Add(line);
        group.Add(circle);
        
        group.Draw();
        
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
        accountProxy.Deposit(100);

        Console.WriteLine(accountProxy.Withdraw(50) ? "Withdrawal successful." : "Withdrawal failed.");

        Console.WriteLine($"Current balance is: ${accountProxy.GetBalance()}");
    }
    
    /// <summary>
    /// Hands-on: Decorator Designpattern
    /// </summary>
    public static void Decorator()
    {
        ICoffee myCoffee = new BasicCoffee();
        Console.WriteLine($"{myCoffee.Description}: ${myCoffee.Cost()}");
        
        myCoffee = new WithMilk(myCoffee);
        Console.WriteLine($"{myCoffee.Description}: ${myCoffee.Cost()}");
        
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
        meineNachricht.Send("Meeting", "The Meeting is starting at 10 o'clock.");

        Message smsNachricht = new ImportantMessage(new SmsSender());
        smsNachricht.Send("Reminder", "Don't forget the Meeting at 10 o'clock");
    }
}