using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class StackArray<T> : IEnumerable<T>
    {
        T[] stack = new T[0];
        int size; 

        public void Push(T value)
        {
            if(size == stack.Count())
            {
                int newLength = size == 0 ? 4 : size * 2;
                T[] newArray = new T[newLength];
                stack.CopyTo(newArray, 0);
                stack = newArray;
            }
            stack[size] = value;
            size++;
        }

        public T Pop()
        {
            if(size == 0)
            {
                throw new InvalidOperationException("Empty");
            }
            size--;
            return stack[size];
        }

        public T Peek()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Empty");
            }
            return stack[size - 1];
        }

        public void Clear()
        {
            size = 0;
        }

        public void PrintStack()
        {
            if (stack.Count() == 0)
            {
                throw new InvalidOperationException("The Stack is empty");
            }
            Console.WriteLine("Items in the Stack are :");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = size - 1; i >= 0; i--)
            {
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
