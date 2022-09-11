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
            foreach (var item in stack)
                Console.WriteLine(item);
            stack.Clear();
            Console.WriteLine(stack.Count); 
            Console.ReadKey();
        }
    }
}
//checked
