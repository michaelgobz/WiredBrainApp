using WiredBrainApp.entities;
namespace WiredBrainApp.Repositories 
{
    public interface IWriteRepository<in T> {
        void Add(T item);
        void Save();
        void Remove(T item);

    }

    public interface IReadRepository<out T> {
        public IEnumerable<T>? GetAll();
        public T? GetItemById(int Id);
    }
    public interface IRepository<T> : IReadRepository<T> , IWriteRepository<T> 
    where T : IEntity
    {
    }

}