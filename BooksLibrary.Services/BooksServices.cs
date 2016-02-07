namespace BooksLibrary.Services
{
    using BooksLibrary.Services.Contracts;
    using System.Linq;
    using BooksLibrary.Models;
    using BooksLibrary.Data.UnitsOfWork;
    public class BooksServices : IBooksServices
    {
        private IUnitOfWork books;

        public BooksServices(IUnitOfWork books)
        {
            this.books = books;
        }
        public void AddBook(Book book)
        {
            var repo = this.books.Get<Book>();
            repo.Add(book);
            repo.SaveChanges();
        }

        public IQueryable<Book> GetAll()
        {
            var repo = this.books.Get<Book>();
            return repo.All().OrderByDescending(book => book.CreationDate);
        }

        public IQueryable<Book> SearchByGenre(string genre)
        {
            var repo = this.books.Get<Book>();
            return repo.All().Where(book => book.Genre.GenreName == genre);
        }

        public IQueryable<Book> SearchByPage(int pagesCount)
        {
            var repo = this.books.Get<Book>();
            return repo.All().Where(book => book.PageCount == pagesCount);
        }

        public IQueryable<Book> SearchByTitle(string title)
        {
            var repo = this.books.Get<Book>();
            var books = repo.All().Where(book => book.Title == title);
            return books;
        }
    }
}
