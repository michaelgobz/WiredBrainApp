using System.Collections.Generic;

namespace WiredBrainApp {
    public class Respository<T> {

        private readonly List<T> _items = new List<T>();

        public void Add(T item){
            _items.Add(item);
        }

        public void Save(){
            foreach( var item in _items){
                System.Console.WriteLine(item);
            }
        }

    }
}