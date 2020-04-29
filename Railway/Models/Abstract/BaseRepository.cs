using System;
using System.Linq;
using System.Linq.Expressions;

using Railway.Models.Database;
using Railway.Models.Interfaces;

using Microsoft.EntityFrameworkCore;

namespace Railway.Models.Abstract
{
    public class BaseRepository<T> : IRepository<T> where T : class, IIteaModel
    {
        private readonly IteaDbContext dbContext;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(IteaDbContext dbContext)
        {
            this.dbContext = dbContext;
            dbSet = this.dbContext.Set<T>();
        }

        public void Create(T item)
        {
            dbSet.Add(item);
            dbContext.SaveChanges();
        }

        public T FindById(int id)
        {
            return dbSet.Find(id);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Where(predicate);
        }

        public void Remove(int item)
        {
            dbSet.Remove(FindById(item));
            dbContext.SaveChanges();
        }

        public void Update(T item)
        {
            dbContext.Entry(item).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return dbSet;
        }
    }
}
