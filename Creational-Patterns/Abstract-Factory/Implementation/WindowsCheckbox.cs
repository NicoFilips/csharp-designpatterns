using Abstract_Factory.Abstraction;

namespace Abstract_Factory.Implementation;

public class WindowsCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("Rendering a checkbox in Windows style.");
    }
}