namespace Prototype;

public abstract class Prototype
{
    public int Id { get; private set; }

    protected Prototype(int id)
    {
        Id = id;
    }
    
    public abstract Prototype Clone();
}