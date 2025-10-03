using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_task.Classess
{
    internal class MyStack<T>
    {
        private List<T> items = new List<T>();

        public void Push(T item) => items.Add(item);

        public T Pop()
        {
            if (items.Count == 0) throw new InvalidOperationException("Stack is empty");
            T val = items[^1];
            items.RemoveAt(items.Count - 1);
            return val;
        }

        public T Peek()
        {
            if (items.Count == 0) throw new InvalidOperationException("Stack is empty");
            return items[^1];
        }

        public int Count => items.Count;
    }
}
