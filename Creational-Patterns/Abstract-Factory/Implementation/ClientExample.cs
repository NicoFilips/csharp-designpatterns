using Abstract_Factory.Abstraction;

namespace Abstract_Factory.Implementation;

public class ClientExample
{
    private readonly IButton _button;
    private readonly ICheckbox _checkbox;

    public ClientExample(IGuiFactory factory)
    {
        _button = factory.CreateButton();
        _checkbox = factory.CreateCheckbox();
    }

    public void Paint()
    {
        _button.Paint();
        _checkbox.Paint();
    }
}