using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sorted
{
    // Worst case: O(n*n)
    // Best case: O(n) already sorted
    // Average case: O(n*n)

    public class BubbleSort
    {
        public int Sort(int[] items)
        {
            int numberSteps = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = i + 1; j < items.Length; j++)
                {
                    if (items[i] > items[j])
                    {
                        Swap(ref items[i], ref items[j]);
                    }
                    numberSteps++;
                }
            }
            return numberSteps;
        }


        // Optimized when the array is sorted !!!
        public int OptimizedSort(int[] items)
        {
            bool swapped;
            int numberSteps = 0;
            for (int i = 0; i < items.Length; i++)
            {
                swapped = false;
                for (int j = i + 1; j < items.Length; j++)
                {
                    if(items[i] > items[j])
                    {
                        Swap(ref items[i], ref items[j]);
                        swapped = true;
                    }
                    numberSteps++;
                }
                if (swapped == false) break;
            }
            return numberSteps;
        }


        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}
