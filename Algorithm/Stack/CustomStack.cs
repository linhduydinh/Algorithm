using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private Node top;

        public CustomStack()
        {
            top = null;
        }

        public void Push(T item)
        {
            if(top == null)
            {
                top = new Node(item);
            }
            else
            {
                Node newNode = new Node(item, top);
                top = newNode;
            }
        }

        public T Pop()
        {
            if(top == null)
            {
                throw new InvalidOperationException("The Stack is empty");
            }
            T value = top.Item;
            top = top.Next;
            return value;
        }

        public T Peek()
        {
            if (top == null)
            {
                throw new InvalidOperationException("The Stack is empty");
            }
            return top.Item;
        }


        private class Node
        {
            public T Item { get; set; }
            public Node Next { get; set; }

            public Node(T item)
            {
                Item = item;
                Next = null;
            }

            public Node(T item, Node next)
            {
                Item = item;
                Next = next;
            }
        }

        public void PrintStack()
        {
            StringBuilder result = new StringBuilder();

            Node currentNode = this.top;
            while (currentNode != null)
            {
                result.Append(currentNode.Item.ToString());
                currentNode = currentNode.Next;
            }
            System.Console.WriteLine(result.ToString());
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node currentNode = top;
            while(currentNode != null)
            {
                T value = currentNode.Item;
                currentNode = currentNode.Next;
                yield return value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
