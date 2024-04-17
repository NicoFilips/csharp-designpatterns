namespace Abstract_Factory.Abstraction;

public interface IGuiFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}