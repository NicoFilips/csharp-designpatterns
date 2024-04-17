using Abstract_Factory.Abstraction;

namespace Abstract_Factory.Implementation;

public class MacOsButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Rendering a button in MacOS style.");
    }
}