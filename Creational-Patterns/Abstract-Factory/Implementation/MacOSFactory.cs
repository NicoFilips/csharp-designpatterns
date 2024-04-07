using Abstract_Factory.Abstraction;

namespace Abstract_Factory.Implementation;

// Concrete factory: MacOS Factory
public class MacOSFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new MacOSButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacOSCheckbox();
    }
}