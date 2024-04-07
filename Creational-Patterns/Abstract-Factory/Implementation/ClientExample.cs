using Abstract_Factory.Abstraction;

namespace Abstract_Factory.Implementation;

public class ClientExample
{
    private IButton _button;
    private ICheckbox _checkbox;

    public ClientExample(IGUIFactory factory)
    {
        // The client code works with factories and products only through abstract types.
        _button = factory.CreateButton();
        _checkbox = factory.CreateCheckbox();
    }

    public void Paint()
    {
        // The client code works with factories and products only through abstract types.
        _button.Paint();
        _checkbox.Paint();
    }
}