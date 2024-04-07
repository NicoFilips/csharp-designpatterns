using Abstract_Factory.Abstraction;

namespace Abstract_Factory.Implementation;

// Concrete factory: Windows Factory
public class WindowsFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WindowsCheckbox();
    }
}