using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary.Data.Repositories
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly IBooksLibraryDbContext data;

        private readonly IDbSet<TEntity> set;

        public EFRepository(IBooksLibraryDbContext data)
        {
            this.data = data;
            this.set = data.Set<TEntity>();

        }
        public void Add(TEntity entity)
        {
            this.ChangeState(entity, EntityState.Added);
        }

        public IQueryable<TEntity> All()
        {
            return this.set;
        }

        public TEntity FindById(int id)
        {
            return this.set.Find(id);
        }

        public void Remove(TEntity entity)
        {
            this.ChangeState(entity, EntityState.Deleted);
        }

        public void SaveChanges()
        {
            this.data.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            this.ChangeState(entity, EntityState.Modified);
        }

        private void ChangeState(TEntity entity, EntityState state)
        {
            var dbEntry = this.data.Entry(entity);
            dbEntry.State = state;
        }
    }
}
