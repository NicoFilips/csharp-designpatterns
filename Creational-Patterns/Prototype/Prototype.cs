using System;

namespace Prototype;

// The 'Prototype' abstract class
public abstract class Prototype
{
    public int Id { get; private set; }

    public Prototype(int id)
    {
        this.Id = id;
    }

    // The Clone method is declared abstract so it must be implemented in derived classes.
    public abstract Prototype Clone();
}

// A concrete implementation of 'Prototype'
public class ConcretePrototype : Prototype
{
    public string Name { get; set; }

    // Constructor
    public ConcretePrototype(int id, string name) : base(id)
    {
        this.Name = name;
    }

    // Implementation of the Clone method, which creates a copy of this ConcretePrototype object.
    public override Prototype Clone()
    {
        // Performs a shallow copy of this object.
        return (Prototype)this.MemberwiseClone();
    }
}