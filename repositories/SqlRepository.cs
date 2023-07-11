using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WiredBrainApp.entities;
using WiredBrainApp.Dbcontext;

namespace WiredBrainApp.Repositories {
    public class SqlRespository<T> : IRepository where T : class, IEntity {

        private readonly Dbcontext _dbContext;
        private readonly DbSet<T> _dbSet;

        public SqlRespository(Dbcontext dbcontext)
        {
            _dbContext = dbcontext;
            _dbSet = _dbContext.Set<T>();
        }

        public void Add(T item){
            _dbSet.Add(item);
        }

        public void Save(){
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