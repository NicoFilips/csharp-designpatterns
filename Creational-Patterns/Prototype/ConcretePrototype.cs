namespace Prototype;

public class ConcretePrototype : Prototype
{
    public string Name { get; set; }
    
    public ConcretePrototype(int id, string name) : base(id)
    {
        Name = name;
    }
    
    public override Prototype Clone()
    {
        return (Prototype)MemberwiseClone();
    }
}