using Abstract_Factory.Abstraction;

namespace Abstract_Factory.Implementation;

public class MacOSButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Rendering a button in MacOS style.");
    }
}