using System.Collections.Generic;
using WiredBrainApp.entities;

namespace WiredBrainApp.Repositories {
    public class ListRespository<T> : IRepository<T>  where T : class, IEntity
    {

        private readonly List<T> _items = new List<T>();

        public void Add(T item){
            item.Id = _items.Count + 1;
            _items.Add(item);
        }

        public void Save(){
            foreach( var item in _items){
                System.Console.WriteLine(item);
            }
        }

        public void Remove(T item){
            _items.Remove(item);
        }

        public T GetItemById(int id){

            return _items.Single(item => item.Id == id);
        }

    }
}