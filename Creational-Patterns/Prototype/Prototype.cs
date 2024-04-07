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