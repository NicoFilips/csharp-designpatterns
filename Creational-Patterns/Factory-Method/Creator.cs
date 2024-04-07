using Factory_Method.Abstraction;

namespace Factory_Method;

// The 'Creator' abstract class
public abstract class Creator
{
    // Factory Method is abstract and needs to be implemented by the subclass
    public abstract IProduct FactoryMethod();

    // The Operation, which uses the Product. This Product will be created by the Factory Method.
    public string SomeOperation()
    {
        // Calls the Factory Method, to create a product-object.
        var product = FactoryMethod();
        // uses the created Product.
        return $"Creator: The same creator's code has just worked with {product.Operation()}";
    }
}


