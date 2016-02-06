using BooksLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary.Services.Contracts
{
    public interface IBooksServices
    {
        IQueryable<Book> GetAll();

        void AddBook(Book book);
    }
}
