using Abstract_Factory.Abstraction;

namespace Abstract_Factory.Implementation;

public class WindowsButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Rendering a button in Windows style.");
    }
}