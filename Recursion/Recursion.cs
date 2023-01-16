using System;

namespace HuffConsoleApp
{
    public class Recursion
    {
        public static void Main()
        {
            int n = 8;
            Console.WriteLine($"Fibonacci Sequence to term {n}: ");

            for (int i = 0; i < n; i++)
            {
                if (i < n - 1) Console.Write(Fibonacci(i) + ", ");
                else Console.Write(Fibonacci(i));
            }

            Console.WriteLine("\n2^6 = " + PowerOf(2, 6));

            Console.WriteLine($"\nDecreasing Numbers from {n} to 1: ");

            DecreasingNumbers(n);
        }

        public static int Fibonacci(int num)
        {   
            //exit case
            if (num < 2) return num;

            //recursive case
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }

        public static int PowerOf(int baseNum, int exp)
        {
            //exit case
            if (exp == 1) return baseNum;

            //recursive case
            return baseNum * PowerOf(baseNum, exp - 1);
        }

        public static int DecreasingNumbers(int num)
        {
            //exit case
            if (num == 0) return 0;

            //recursive case
            Console.Write(num + " ");
            return DecreasingNumbers(num - 1);
        }
    }
}
