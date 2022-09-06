using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    internal class StackEnumerator<T> : IEnumerator<T>
    {
        Stack<T> stack;
        StackItem<T> currentItem;
        public StackEnumerator(Stack<T> stack)
        {
            this.stack = stack;
            currentItem = null;
        }

        public T Current => currentItem.data;

        public bool MoveNext()
        {
            if (currentItem == null)
                currentItem = stack.top;
            else
                currentItem = currentItem.next;
            return currentItem != null;
        }
        #region
        object IEnumerator.Current => Current;

        public void Dispose()
        {

        }
        public void Reset()
        {

        }
        #endregion
    }
}
