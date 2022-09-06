using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    class Stack<T> : IEnumerable<T>
    {
        public StackItem<T> top;
        public int Count { get; private set; } = 0;

        public void Push(T data)
        {
            var currentTop = top;
            top = new StackItem<T>(data) { next = currentTop };
            Count++;
        }

        public T Pop()
        {
            T data = top.data;
            top = top.next;
            Count--;
            return data;
        }

        public void Clear()
        {
            //while (Count != 0)
            //    Pop();
            top = null;
            Count = 0;
        }

        public T Peek()
        {
            return top.data;
        }

        public IEnumerator<T> GetEnumerator()
        {
            //Enumerator implementation
            //return new StackEnumerator<T>(this);
            //yield return implementation
            var current = top;
            while (current!=null)
            {
                yield return current.data;
                current = current.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
