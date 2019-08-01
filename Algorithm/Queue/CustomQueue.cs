using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class CustomQueue<T> : IEnumerable<T>
    {
        private Node head;
        private Node tail;

        public CustomQueue()
        {
            head = null;
            tail = null; 
        }

        public void EnQueue(T item)
        {
            if(head == null)
            {
                head = new Node(item);
                tail = head;
            }
            else
            {
                Node newNode = new Node(item, tail);
                tail = newNode;
            }
        }

        public T DeQueue()
        {
            if(head == null)
            {
                throw new InvalidOperationException("The Queue is empty");
            }
            T value = head.Data;
            head = head.Next;
            return value;
        }

        public T Peek()
        {
            if (head == null)
            {
                throw new InvalidOperationException("The Queue is empty");
            }
            return head.Data;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node currentNode = head;
            while(currentNode != null)
            {
                T value = currentNode.Data;
                currentNode = currentNode.Next;
                yield return value;
            }
        }

        public void Print()
        {
            StringBuilder result = new StringBuilder();
            Node currentNode = head;
            while(currentNode != null)
            {
                result.Append(currentNode.Data.ToString()  + ",");
                currentNode = currentNode.Next;
            }
            Console.WriteLine("Items from Queue : ");
            Console.WriteLine(result.ToString());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }

            public Node(T data, Node tail)
            {
                Data = data;
                Next = null;
                tail.Next = this;
            }
        }
    }
}
