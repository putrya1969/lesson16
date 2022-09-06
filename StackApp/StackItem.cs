using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
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
