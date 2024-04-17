using Iterator.Abstraction;

namespace Iterator.Implementation;

public class BookCollection : IAggregate
{
    private readonly List<Book> _books = new();

    public IIterator CreateIterator()
    {
        return new BookCollectionIterator(this);
    }

    public int Count()
    {
        return _books.Count;
    }

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public Book GetBook(int index)
    {
        return _books[index];
    }
}