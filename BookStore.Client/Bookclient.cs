using BookStore.Client.Models;

namespace BookStore.Client;

public static class Bookclient
{
    private static readonly List<Book> books = new()
    {
        new Book()
        {
            Id = 1,
            Name = "The Witcher",
            Genre = "Fantasy",
            Author = "Andrzej Sapkowski",
            Price = 19.99M,
            ReleaseDate = new DateTime(2000, 2, 4)
        },
        new Book()
        {
            Id = 2,
            Name = "Tokyo ghoul",
            Genre = "Manga",
            Author = "Sui ishida",
            Price = 20.99M,
            ReleaseDate = new DateTime(2010, 2, 4)
        },
        new Book()
        {
            Id = 3,
            Name = "Neuro Biology",
            Genre = "Science",
            Author = "Joe Branton",
            Price = 8.99M,
            ReleaseDate = new DateTime(2020, 5, 4)
        }
    };

    public static Book[] GetBooks()
    {
        return books.ToArray();
    }

    public static void AddBook(Book book)
    {
        book.Id = books.Max(book => book.Id) + 1;
        books.Add(book);
    }

    public static Book GetBook(int id)
    {
        return books.Find(book => book.Id == id) ?? throw new Exception("Could not find game!");
    }

    public static void UpdateBook(Book updatedBook)
    {
        Book existingBook = GetBook(updatedBook.Id);
        existingBook.Name = updatedBook.Name;
        existingBook.Genre = updatedBook.Genre;
        existingBook.Author = updatedBook.Author;
        existingBook.Price = updatedBook.Price;
        existingBook.ReleaseDate = updatedBook.ReleaseDate;
    }

    public static void DeleteBook(int id)
    {
        Book book = GetBook(id);
        books.Remove(book);
    }
}