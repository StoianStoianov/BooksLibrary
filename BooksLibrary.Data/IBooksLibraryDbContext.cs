using BooksLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary.Data
{
    public interface IBooksLibraryDbContext
    {
        IDbSet<User> Users { get; set; }

        IDbSet<Book> Books { get; set; }

        IDbSet<Genre> Genres { get; set; }
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();

        
    }
}
