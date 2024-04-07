using FluentAssertions;
using NUnit.Framework;
using Abstract_Factory;
using Abstract_Factory.Implementation;

namespace CreationalPatterns.test.AbstractFactory;

[TestFixture]
public class AbstractFactoryPatternTests
{
    [Test]
    public void WindowsFactory_CreatesWindowsButton()
    {
        var factory = new WindowsFactory();
        var button = factory.CreateButton();

        button.Should().BeOfType<WindowsButton>(because: "WindowsFactory should create WindowsButton objects");
    }

    [Test]
    public void WindowsFactory_CreatesWindowsCheckbox()
    {
        var factory = new WindowsFactory();
        var checkbox = factory.CreateCheckbox();

        checkbox.Should().BeOfType<WindowsCheckbox>(because: "WindowsFactory should create WindowsCheckbox objects");
    }

    [Test]
    public void MacOSFactory_CreatesMacOSButton()
    {
        var factory = new MacOSFactory();
        var button = factory.CreateButton();

        button.Should().BeOfType<MacOSButton>(because: "MacOSFactory should create MacOSButton objects");
    }

    [Test]
    public void MacOSFactory_CreatesMacOSCheckbox()
    {
        var factory = new MacOSFactory();
        var checkbox = factory.CreateCheckbox();

        checkbox.Should().BeOfType<MacOSCheckbox>(because: "MacOSFactory should create MacOSCheckbox objects");
    }
}