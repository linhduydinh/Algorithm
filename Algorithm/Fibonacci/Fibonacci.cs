namespace Algorithm
{
    public class Fibonacci
    {
        public static long[] my_memo;

        public static int Count = 0;
        public static long FibWithRecursive(int number)
        {
            if(number == 0)
            {
                Count++;
                return 0;
            }
            else if(number == 1)
            {
                Count++;
                return 1;
            }
            else
            {
                Count++;
                return FibWithRecursive(number - 1) + FibWithRecursive(number - 2);
            }
        }

        public static long FibWithLoop(int number)
        {
            long f1 = 1;
            long f2 = 1;
            Count = 2;
            long result = 0;
            for (int i = 2; i < number; i++)
            {
                result = f1 + f2;
                f1 = f2;
                f2 = result;
                Count++;
            }
            return result;
        }

        public static long FibWithMemo(int number, bool isMemo = false)
        {
            if (isMemo)
            {
                if (my_memo[number] != 0) return my_memo[number];
            }
            Count++;
            if (number == 0) return 0;
            if (number == 1) return 1;
            my_memo[number] = FibWithMemo(number - 1, isMemo) + FibWithMemo(number - 2, isMemo);
            return my_memo[number];
        }
    }
}
