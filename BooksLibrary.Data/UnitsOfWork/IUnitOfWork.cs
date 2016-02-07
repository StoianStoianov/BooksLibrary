namespace BooksLibrary.Data.UnitsOfWork
{
    using BooksLibrary.Data.Repositories;
    
    public interface IUnitOfWork
    {
        IRepository<T> Get<T>()
            where T : class;
        int SaveChanges();
    }
}
