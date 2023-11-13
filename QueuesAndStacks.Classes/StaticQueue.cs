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
            throw new NotImplementedException();
        }

        public string Display()
        {
            throw new NotImplementedException();
        }

        public void EnQueue(T item)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public bool IsFull()
        {
            throw new NotImplementedException();
        }
    }
}
