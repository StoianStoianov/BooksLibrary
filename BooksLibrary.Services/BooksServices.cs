using BooksLibrary.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksLibrary.Models;
using BooksLibrary.Data.Repositories;
using BooksLibrary.Data.UnitsOfWork;

namespace BooksLibrary.Services
{
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
            throw new NotImplementedException();
        }
    }
}
