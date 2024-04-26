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
}