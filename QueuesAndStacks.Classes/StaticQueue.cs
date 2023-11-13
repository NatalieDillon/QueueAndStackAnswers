using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuesAndStacks.Classes
{
    public class StaticQueue<T> : IStaticQueue<T>
    {
        // Fields
        private T[] _innerArray;
        private int _front = 0;
        private int _back = 0;

        // Properties
        public int Size { get; private set; }
        public int Capacity { get; private set; }

        // Constructor
        public StaticQueue(int capacity)
        {
            Capacity = capacity;
            _innerArray = new T[capacity];
        }

        // Methods
        public T? DeQueue()
        {
            if (IsEmpty())
            {
                return default;
            }
            T item = _innerArray[_front];
            _front = (_front + 1) % Capacity;
            Size--;
            return item;
        }

        public string Display()
        {
            if (IsEmpty())
            {
                return "[]";
            }
            int count = 0;
            int index = _front;
            StringBuilder sb = new();
            sb.Append('[');
            while (count < Size - 1)
            {
                sb.Append($"{_innerArray[index]}, ");
                index = (index + 1) % Capacity;
                count++;
            }
            sb.Append($"{_innerArray[index]}]");
            return sb.ToString();
        }

        public void EnQueue(T item)
        {
            if (IsFull())
            {
                throw new InvalidOperationException($"Queue is full");
            }
            _innerArray[_back] = item;
            _back = (_back + 1) % Capacity;
            Size++;
        }

        public bool IsEmpty()
        {
            return Size == 0;
        }

        public bool IsFull()
        {
            return Size == Capacity;
        }
    }
}
