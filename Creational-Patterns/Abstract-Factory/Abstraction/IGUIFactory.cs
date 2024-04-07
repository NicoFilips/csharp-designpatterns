namespace Abstract_Factory.Abstraction;

// Abstract factory interface declaring operations that create abstract products
public interface IGUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}