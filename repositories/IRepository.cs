using WiredBrainApp.entities;
namespace WiredBrainApp.Repositories 
{
    public interface IRepository<T> where T : IEntity
    {
        public IEnumerable<T> GetAll();
        public T GetItemById(int Id);
        void Add(T item);
        void Save();
        void Remove(T item);

    }

}