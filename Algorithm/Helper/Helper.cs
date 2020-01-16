using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public static class Helper
    {
        public static void Swap<T>(ref T item1, ref T item2)
        {
            var temp = item2;
            item2 = item1;
            item1 = temp;
        }
    }
}
