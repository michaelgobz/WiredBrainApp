using System;
using System.Linq;

namespace WiredBrainApp
{
    public class SimpleStack
    {
        private readonly double[] _items;
        private int _currentIndex = -1;

        public int count {
            get {
                return _items.Count();
            }
        }
        
        public SimpleStack() =>  _items = new double[20];
        
        public void Push( double value) => _items[++_currentIndex] = value;

        public double Pop () => _items[_currentIndex--];
        

    }
}