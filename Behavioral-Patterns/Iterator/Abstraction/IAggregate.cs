namespace Iterator.Abstraction;

public interface IAggregate
{
    IIterator CreateIterator();
}