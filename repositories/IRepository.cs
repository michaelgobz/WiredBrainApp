namespace WiredBrainApp.Repositories 
{
    public interface IRepository<T> where T : IEntity
    {
        public T GetItemById(int Id);
        void Add();
        void Save();
        void Remove();
    }

}