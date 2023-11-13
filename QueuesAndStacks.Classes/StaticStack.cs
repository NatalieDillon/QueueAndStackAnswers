using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuesAndStacks.Classes
{
    public class StaticStack<T> : IStaticStack<T>
    {
        // Fields
        private T[] _innerArray;
        private int _top = -1;

        // Properties
        public int Capacity { get; private set; }

        // Constructor
        public StaticStack(int capacity)
        {
            Capacity = capacity;
            _innerArray = new T[Capacity];
        }

        public bool IsEmpty()
        {
            return _top == -1;
        }

        public bool IsFull()
        {
            return _top == Capacity - 1;
        }

        public T Peek()
        {
            if (!IsEmpty())
            {
                return _innerArray[_top];
            }
            throw new InvalidOperationException();
        }

        public T Pop()
        {
            if (!IsEmpty())
            {
                T item = _innerArray[_top];
                _top -= 1;
                return item;
            }
            throw new InvalidOperationException();
        }

        public void Push(T item)
        {
            if (IsFull())
            {
                throw new StackOverflowException();
            }
            _top += 1;
            _innerArray[_top] = item;
        }

        public string Display()
        {
            if (IsEmpty())
            {
                return "[]";
            }
            StringBuilder sb = new();
            sb.Append('[');
            for (int i = _top; i > 0; i--)
            {
                sb.Append($"{_innerArray[i]}, ");
            }
            sb.Append($"{_innerArray[0]}]");
            return sb.ToString();
        }
    }
}
