using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class StackLinkList<T> : IEnumerable<T>
    {
        LinkedList<T> stack = new LinkedList<T>();

        public IEnumerator<T> GetEnumerator()
        {
            return stack.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return stack.GetEnumerator();
        }

        public void Clear()
        {
            stack.Clear();
        }

        public void Push(T item)
        {
            stack.AddFirst(item);
        }

        public T Pop()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("The Stack is empty");
            }
            T value = stack.First.Value;
            stack.RemoveFirst();
            return value;
        }

        public T Peek()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("The Stack is empty");
            }
            return stack.First.Value;
        }

        public void PrintStack()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("The Stack is empty");
            }
            Console.WriteLine("Items in the Stack are:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
