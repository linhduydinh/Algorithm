using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sorted
{
    public class InsertionSort
    {
        // var items = new int[] { 3, 1, 6, 4, 5, 2 };
        public int Sort(int[] items)
        {
            int count = 0;

            for (int i = 0; i < items.Length; i++)
            {
                int temp = items[i];
                int j = i;
                while(j > 0 && temp < items[j - 1])
                {
                    items[j] = items[j - 1];
                    j = j - 1;
                    count++;
                }
                items[j] = temp;
                Console.WriteLine(string.Join(",", items));
            }

            return count;
        }
    }
}
