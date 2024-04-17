using Iterator.Abstraction;

namespace Iterator.Implementation;

public class BookCollectionIterator : IIterator
{
    private BookCollection _buchCollection;
    private int _currentIndex = 0;

    public BookCollectionIterator(BookCollection bookCollection)
    {
        _buchCollection = bookCollection;
    }

    public bool HasNext()
    {
        return _currentIndex < _buchCollection.Count();
    }

    public object Next()
    {
        return _buchCollection.GetBook(_currentIndex++);
    }
}