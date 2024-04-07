namespace Prototype;

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