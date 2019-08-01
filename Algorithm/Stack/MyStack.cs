using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class MyStack
    {

        static readonly int MAX = 100;
        int[] myStack = new int[MAX];
        int top;

        public MyStack()
        {
            top = -1;
        }

        public bool isEmpty()
        {
            return top < 0;
        }


        public bool Push(int number)
        {
            if(top >= MAX)
            {
                Console.WriteLine("Stack overflow");
                return false;
            }
            else
            {
                myStack[++top] = number;
                return true;
            }
        }

        public int Pop()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack underflow");
                return 0;
            }
            else
            {
                int value = myStack[top--];
                return value;
            }
        }

        public void Peek()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack underflow");
                return;
            }
            else
            {
                Console.WriteLine("The top most element of Stack is: {0} ", myStack[top]);
            }
        }

        internal void PrintStack()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(myStack[i]);
                }
            }
        }
    }
}
