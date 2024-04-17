using Abstract_Factory.Abstraction;

namespace Abstract_Factory.Implementation;

public class MacOsFactory : IGuiFactory
{
    public IButton CreateButton()
    {
        return new MacOsButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacOsCheckbox();
    }
}