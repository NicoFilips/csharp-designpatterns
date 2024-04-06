using Iterator.Abstraction;

namespace Iterator.Implementation;

public class BookCollection : IAggregate
{
    private List<Book> _books = new List<Book>();

    public IIterator CreateIterator()
    {
        return new BookCollectionIterator(this);
    }

    public int Count()
    {
        return _books.Count;
    }

    public void AddBuch(Book buch)
    {
        _books.Add(buch);
    }

    public Book GetBook(int index)
    {
        return _books[index];
    }
}