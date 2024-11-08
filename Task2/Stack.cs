using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Stack<T>
    {
        private T[] _array;
        private int _index;

        public Stack() : this(10)
        {

        }

        public Stack(int initialCapacity)
        {
            _array = new T[initialCapacity];
            _index = -1;
        }

        private void Resize()
        {
            var newArray = new T[_array.Length * 2];
            _array.CopyTo(newArray, 0);
            _array = newArray;
        }

        public bool IsEmpty()
        {
            return _index == -1;
        }

        public int Count()
        {
            return _index + 1;
        }

        public T Push(T item)
        {
            if (_array.Length == _index + 1)
            {
                Resize();
            }

            _array[++_index] = item;
            return item;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("stack is empty.");
            }

            return _array[_index--];
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("stack is empty.");
            }
            return _array[_index];
        }
    }
}
