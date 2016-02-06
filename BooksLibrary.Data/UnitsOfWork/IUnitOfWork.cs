using BooksLibrary.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary.Data.UnitsOfWork
{
    public interface IUnitOfWork
    {
        IRepository<T> Get<T>()
            where T : class;
        int SaveChanges();
    }
}
