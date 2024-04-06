namespace Iterator.Abstraction;

public interface IIterator
{
    bool HasNext();
    object Next();
}
