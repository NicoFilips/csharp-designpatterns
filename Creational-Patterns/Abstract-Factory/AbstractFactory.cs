namespace Abstract_Factory;

using System;

// Interface for abstract product: Button
public interface IButton
{
    void Paint(); // Method to render the button
}

// Interface for another abstract product: Checkbox
public interface ICheckbox
{
    void Paint(); // Method to render the checkbox
}

// Concrete product: Windows Button
public class WindowsButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Rendering a button in Windows style.");
    }
}

// Concrete product: MacOS Button
public class MacOSButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Rendering a button in MacOS style.");
    }
}

// Concrete product: Windows Checkbox
public class WindowsCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("Rendering a checkbox in Windows style.");
    }
}

// Concrete product: MacOS Checkbox
public class MacOSCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("Rendering a checkbox in MacOS style.");
    }
}

// Abstract factory interface declaring operations that create abstract products
public interface IGUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}

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