using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary.Data.Repositories
{
    public interface IRepository<TEntity>
    {
        IQueryable<TEntity> All();

        TEntity FindById(int id);
        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);

        void SaveChanges();
    }
}
