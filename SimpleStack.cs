using System;
using System.Linq;

namespace WiredBrainApp
{
    public class SimpleStack
    {
        private readonly object[] _items;
        private int _currentIndex = -1;

        public int count {
            get {
                return _currentIndex + 1;
            }
        }
        
        public SimpleStack() =>  _items = new object[20];
        
        public void Push( object value) => _items[++_currentIndex] = value;

        public object Pop () => _items[_currentIndex--];
        

    }
}