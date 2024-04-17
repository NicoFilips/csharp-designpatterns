using FluentAssertions;
using Iterator.Implementation;

namespace BehavioralPatterns.test.Iterator;

[TestFixture]
public class IteratorPatternTests
{
    [Test]
    public void IteratesOverCollectionCorrectly()
    {
        var bookCollection = new BookCollection();
        bookCollection.AddBook(new Book("Design Patterns"));
        bookCollection.AddBook(new Book("Clean Code"));
        bookCollection.AddBook(new Book("Refactoring"));

        var iterator = bookCollection.CreateIterator();
        int count = 0;

        while (iterator.HasNext())
        {
            var book = (Book)iterator.Next();
            book.Should().NotBeNull();
            count++;
        }

        count.Should().Be(3, because: "we added three books to the collection");
    }

    [Test]
    public void HasNextReturnsFalseWhenNoMoreElements()
    {
        var bookCollection = new BookCollection();
        bookCollection.AddBook(new Book("Design Patterns"));

        var iterator = bookCollection.CreateIterator();
        iterator.Next(); // Advance to the end

        iterator.HasNext().Should().BeFalse(because: "there are no more elements in the collection");
    }

    [Test]
    public void NextReturnsCorrectBookObjects()
    {
        var bookCollection = new BookCollection();
        var expectedTitle = "Design Patterns";
        bookCollection.AddBook(new Book(expectedTitle));

        var iterator = bookCollection.CreateIterator();
        var book = (Book)iterator.Next();

        book.title.Should().Be(expectedTitle, because: "we expect to retrieve the book we added");
    }
}