using Abstract_Factory.Abstraction;

namespace Abstract_Factory.Implementation;

public class MacOsCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("Rendering a checkbox in MacOS style.");
    }
}