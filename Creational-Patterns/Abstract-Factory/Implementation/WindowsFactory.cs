using Abstract_Factory.Abstraction;

namespace Abstract_Factory.Implementation;

public class WindowsFactory : IGuiFactory
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