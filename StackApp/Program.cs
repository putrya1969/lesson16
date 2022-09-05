using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            stack.Push(5);
            stack.Push(8);
            stack.Push(3);
            stack.Push(7);
            stack.Push(1);
            Console.WriteLine($"In stack {stack.Count} elements");
            Console.WriteLine($"Top element is {stack.Peek()}");
            stack.Clear();
            Console.ReadKey();
        }
    }

    class Stack<T>
    {
        StackItem<T> top;
        public int Count { get; set; } = 0;

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
            while (Count != 0)
                Pop(); 
        }

        public T Peek()
        {
            return top.data;
        }
    }

    class StackItem<T>
    {
        public T data;
        public StackItem<T> next;
        public StackItem(T data)
        {
            this.data = data;
            next = null;
        }
    }
}
