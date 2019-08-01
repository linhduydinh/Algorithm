using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //MyStack myStack = new MyStack();
            //StackLinkList<int> myStack = new StackLinkList<int>();
            //StackArray<int> myStack = new StackArray<int>();

            //CustomStack<int> myStack = new CustomStack<int>();

            //myStack.Push(10);
            //myStack.Push(20);
            //myStack.Push(30);
            //myStack.Push(40);
            //myStack.PrintStack();
            //myStack.Peek();
            //Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            //myStack.PrintStack();
            //myStack.Push(10);
            //myStack.Push(20);
            //myStack.Push(30);
            //myStack.Push(40);
            //myStack.PrintStack();

            CustomQueue<int> customQueue = new CustomQueue<int>();

            customQueue.EnQueue(10);
            customQueue.EnQueue(20);
            customQueue.EnQueue(30);
            customQueue.EnQueue(40);
            customQueue.Print();
            customQueue.Peek();
            Console.WriteLine("Item head from Queue : {0}", customQueue.DeQueue());
            customQueue.Print();
            customQueue.EnQueue(10);
            customQueue.EnQueue(20);
            customQueue.EnQueue(30);
            customQueue.EnQueue(40);
            customQueue.Print();

        }

    }
}
