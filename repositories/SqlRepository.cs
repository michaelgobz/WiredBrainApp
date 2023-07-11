using System.Collections.Generic;
using WiredBrainApp.entities;
using WiredBrainApp.Dbcontext;

namespace WiredBrainApp {
    public class SqlRespository<T> where T : IEntity {

        private readonly List<T> _items = new List<T>();

        public void Add(T item){
            _items.Add(item);
        }

        public void Save(){
            foreach( var item in _items){
                System.Console.WriteLine(item);
            }
        }

        public void Remove(T item)
        {
			_items.Remove(item);
		}

        public T GetItemById(int id)
        {
            return _items.Find(id);
        }

    }
}