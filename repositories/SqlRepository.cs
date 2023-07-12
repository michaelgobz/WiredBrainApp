using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WiredBrainApp.entities;
using System.Linq;
using WiredBrainApp.Dbcontext;

namespace WiredBrainApp.Repositories
{
    public class SqlRespository<T> : IRepository<T> where T : class, IEntity
    {

        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public SqlRespository(DbContext dbcontext)
        {
            _dbContext = dbcontext;
            _dbSet = _dbContext.Set<T>();
        }

        public IEnumerable<T> GetAll(){
            return _dbSet.ToList();
        }

        public void Add(T item)
        {
            _dbSet.Add(item);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }

        public T GetItemById(int id)
        {
            return _dbSet.Find(id);
        }
    }
}