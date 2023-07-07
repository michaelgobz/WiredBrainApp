using System;
using System.Linq;

namespace WiredBrainApp
{
    public class SimpleStack<Ttype>
    {
        private readonly Ttype[] _items;
        private int _currentIndex = -1;

        public int Count {
            get {
                return _currentIndex + 1;
            }
        }
        
        public SimpleStack() =>  _items = new Ttype[40];
        
        public void Push( Ttype value) => _items[++_currentIndex] = value;

        public Ttype Pop () => _items[_currentIndex--];
        

    }
}