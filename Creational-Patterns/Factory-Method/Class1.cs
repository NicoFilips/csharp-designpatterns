namespace Factory_Method;

using System;

// 'Product' Interface
public interface IProduct
{
    string Operation();
}

// Implementation of the Product Interfaces
public class ConcreteProductA : IProduct
{
    public string Operation()
    {
        return "Result of ConcreteProductA";
    }
}

public class ConcreteProductB : IProduct
{
    public string Operation()
    {
        return "Result of ConcreteProductB";
    }
}

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

// The Creator-classes, which implements the Factory Method to get a specific Product
public class ConcreteCreatorA : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductA();
    }
}

public class ConcreteCreatorB : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductB();
    }
}