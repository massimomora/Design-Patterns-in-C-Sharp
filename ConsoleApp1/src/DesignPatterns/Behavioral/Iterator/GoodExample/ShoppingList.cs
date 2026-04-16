using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Iterator.GoodExample
{
    public class ShoppingList<T>
    {
        private List<T> _list = new List<T>();

        public void Push(T itemName)
        {
            _list.Add(itemName);
        }

        public T Pop()
        {
            var last = _list.Last();
            _list.Remove(last);
            return last;
        }

        public IIterator<T> CreateIterator()
        {
            return new ListIterator(this);
        }

        private class ListIterator : IIterator<T>
        {
            private ShoppingList<T> _shoppingList;
            private int _index;

            public ListIterator(ShoppingList<T> shoppingList)
            {
                _shoppingList = shoppingList;
            }

            public T Current()
            {
                return _shoppingList._list[_index];
            }

            public void Next()
            {
                _index++;
            }

            public bool HasNext()
            {
                return _index < _shoppingList._list.Count;
            }

        }

    }
}