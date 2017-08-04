using System;
using System.Collections.Generic;
using System.Text;

namespace StackImplementation
{
    class MyStack<T>
    {
        private T[] data { get; set; }
        private int SP { get; set; }
        private int Capacity { get; set; }

        public MyStack(int capacity)
        {
            this.Capacity = capacity;
            data = new T[Capacity];
            SP = -1;
            data[0] = default(T);
        }

        public void Push(T data)
        {
            ++SP;
            if (SP >= Capacity) growArray();
            this.data[SP] = data;
        }

        public T Pop()
        {
            if (SP < 0) throw new InvalidOperationException();
            T value = data[SP];
            data[SP] = default(T);
            SP--;
            return value;
        }
        public T Peak()
        {
            if (SP < 0) throw new InvalidOperationException();
            return data[SP];
        }
        private void growArray()
        {
            throw new NotImplementedException();
        }
    }
    }
}
