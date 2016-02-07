namespace BooksLibrary.Services.Contracts
{
    using BooksLibrary.Models;
    using System.Linq;
    public interface IBooksServices
    {
        IQueryable<Book> GetAll();

        void AddBook(Book book);
        IQueryable<Book> SearchByGenre(string genre);

        IQueryable<Book> SearchByTitle(string title);

        IQueryable<Book> SearchByPage(int pagesCount);
    }
}
