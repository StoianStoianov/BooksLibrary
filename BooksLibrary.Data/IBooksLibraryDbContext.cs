namespace BooksLibrary.Data
{
    using BooksLibrary.Models;    
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
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
