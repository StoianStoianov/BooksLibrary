using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksLibrary.Data.Repositories;

namespace BooksLibrary.Data.UnitsOfWork
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private IDictionary<string, object> repos;

        public EFUnitOfWork(BooksLibraryDbContext booksLibraryContext)
        {
            this.repos = new Dictionary<string, object>();
            this.BooksLibraryContext = booksLibraryContext;
        }

        public IBooksLibraryDbContext BooksLibraryContext { get; private set; }
        public IRepository<T> Get<T>() where T : class
        {
            var key = typeof(T).FullName;

            if (!this.repos.ContainsKey(key))
            {
                var repo = new EFRepository<T>(this.BooksLibraryContext);
                this.repos.Add(key, repo);
            }

            return (IRepository<T>)this.repos[key];
        }

        public int SaveChanges()
        {
            return this.BooksLibraryContext.SaveChanges();
        }
    }
}
