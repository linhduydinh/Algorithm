using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.Sorted;

namespace Algorithm
{
    public class Student { }

    public static class Extension
    {
        public static IEnumerable<Student> MyWhere<Student>(
                            this IEnumerable<Student> source,
                            Func<IEnumerable<Student>, bool> predicate)
        {
            return new List<Student>();
        }


    }

   

    public class Program
    {
        public delegate void WorkPerform(int hours, WorkType workType);

        static void WorkPerform1(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerform1 execute {0} - {1}", hours, workType);
        }

        static void WorkPerform2(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerform2 execute {0} - {1}", hours, workType);
        }

        public static void Main(string[] args)
        {
            var items = new int[] { 1,2,3,4,5 };


            var bubbleSort = new BubbleSort();
            var count = bubbleSort.OptimizedSort(items);

            Console.WriteLine(string.Join(",", items));
            Console.WriteLine(count);


            //var missing = new HashSet<int>();
            //var store = new HashSet<int>();
            //int count = 0;
            //int max = 0;

            //for (int i = 0; i < a.Length; i++)
            //{
            //    max = Math.Max(max, a[i]);

            //    if(max == i + 1)
            //    {
            //        count++;
            //    }

            //}

            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (!store.Contains(i + 1) && i + 1 != a[i])
            //        missing.Add(i + 1);
            //    if (i + 1 < a[i])
            //        store.Add(a[i]);
            //    else
            //        missing.Remove(a[i]);
            //    if (missing.Count() == 0)
            //        count++;
            //}

            //WorkPerform del1 = new WorkPerform(WorkPerform1);
            //WorkPerform del2 = new WorkPerform(WorkPerform2);

            //del1 += del2;

            //del1(5, WorkType.GoToMeeting);


            //Func<int, int, int> func = (x, y) => x * y;
            //Console.WriteLine(func(2, 3));

            //string S = "Sun 10:00-20:00\nFri 05:00-10:00\nFri 16:30-23:50\nSat 10:00-24:00\nSun 01:00-04:00\nSat 02:00-06:00\nTue 03:30-18:15\nTue 19:00-20:00\nWed 04:25-15:14\nWed 15:14-22:40\nThu 00:00-23:59\nMon 05:00-13:00\nMon 15:00-21:00";

            //int totalTime = 7 * 24 * 60;
            //List<string> schedules = S.Split('\n').ToList();

            //Dictionary<string, Time> abc = new Dictionary<string, Time>();

            //string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"};

            //List<string> final = new List<string>();

            //for (int i = 0; i < days.Count(); i++)
            //{
            //    var d = schedules.Where(x => x.Contains(days[i])).ToList();

            //    List<string> temp = new List<string>();

            //    for (int j = 0; j < d.Count(); j++)
            //    {
            //        temp.Add(d[j].Substring(4, 11));
            //    }
            //    temp.Sort();

            //    final.AddRange(temp);
            //}

            //int maxMinutes = 0;
            //for (int i = 0; i < final.Count - 1; i++)
            //{
            //    int startTime;
            //    int endTime;
            //    int time;
            //    if (i == final.Count - 1)
            //    {
            //        startTime = int.Parse(final[i].Substring(6, 2)) * 60 + int.Parse(final[i].Substring(9, 2));
            //        endTime = int.Parse(final[0].Substring(0, 2)) * 60 + int.Parse(final[0].Substring(3, 2));
            //    }
            //    else
            //    {
            //        startTime = int.Parse(final[i].Substring(6, 2)) * 60 + int.Parse(final[i].Substring(9, 2));
            //        endTime = int.Parse(final[i + 1].Substring(0, 2)) * 60 + int.Parse(final[i + 1].Substring(3, 2));
            //    }

            //    if(endTime < startTime)
            //    {
            //        time = (24 * 60) - startTime + endTime;
            //    }
            //    else
            //    {
            //        time = endTime - startTime;
            //    }
            //    if (maxMinutes < time)
            //    {
            //        maxMinutes = time;
            //    }
            //}

            //return maxMinutes;

            //          schedule = schedule
            //.OrderBy(d => DateTime.ParseExact(d, "dd'/'MM'/'yyyy", CultureInfo.InvariantCulture))
            //.ToArray();

            //          var max_profit = 0;
            //          var min = 200001;
            //          for (var i = 0; i < A.Length; i++)
            //          {
            //              if (min > A[i])
            //              {
            //                  min = A[i];
            //              }
            //              else
            //              {
            //                  max_profit = Math.Max(max_profit, A[i] - min);
            //              }
            //          }
            //          return max_profit;

            //return dp[A.length - 1];
            //return count;
            //return numSlice;

        }

        //return count;
        //return intersectCount;




        //Console.WriteLine("Enter number between 2 and 1300 for Fibonacci calculation:");
        //int k = int.Parse(Console.ReadLine());
        //Fibonacci.my_memo = new long[k + 1];

        //my_time = DateTime.Now;
        //Fibonacci.Count = 0;
        //Console.WriteLine("\n{0}", Fibonacci.FibWithRecursive(k));
        //Console.WriteLine("Calculations {0}", Fibonacci.Count);
        //Console.WriteLine(DateTime.Now - my_time);

        //my_time = DateTime.Now;
        //Fibonacci.Count = 0;
        //Console.WriteLine("\n{0}", Fibonacci.FibWithLoop(k));
        //Console.WriteLine("Calculations {0}", Fibonacci.Count);
        //Console.WriteLine(DateTime.Now - my_time);

        //my_time = DateTime.Now;
        //Fibonacci.Count = 0;
        //Console.WriteLine("\n{0}", Fibonacci.FibWithMemo(k, true));
        //Console.WriteLine("Calculations {0}", Fibonacci.Count);
        //Console.WriteLine(DateTime.Now - my_time);

        //my_time = DateTime.Now;
        //Fibonacci.Count = 0;
        //Console.WriteLine("\n{0}", Fibonacci.FibWithMemo(k));
        //Console.WriteLine("Calculations {0}", Fibonacci.Count);
        //Console.WriteLine(DateTime.Now - my_time);



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

        //CustomQueue<int> customQueue = new CustomQueue<int>();

        //customQueue.EnQueue(10);
        //customQueue.EnQueue(20);
        //customQueue.EnQueue(30);
        //customQueue.EnQueue(40);
        //customQueue.Print();
        //customQueue.Peek();
        //Console.WriteLine("Item head from Queue : {0}", customQueue.DeQueue());
        //customQueue.Print();
        //customQueue.EnQueue(10);
        //customQueue.EnQueue(20);
        //customQueue.EnQueue(30);
        //customQueue.EnQueue(40);
        //customQueue.Print();



    }

    public enum WorkType
    {
        GoToMeeting,
        Golf,
        GoToSchool
    }
}
