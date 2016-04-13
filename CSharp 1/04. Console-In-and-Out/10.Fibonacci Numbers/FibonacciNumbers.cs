using System;

namespace _10.Fibonacci_Numbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            ulong sum = 0;
            ulong x = 0;
            ulong y = 1;

            if (number == 1)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.Write("{0}, {1}, ", x, y);
                for (int i = 2; i < number; i++)
                {
                    sum = x + y;
                    Console.Write("{0}", sum);
                    if (i < (number - 1))
                    {
                        Console.Write(", ");
                    }
                    x = y;
                    y = sum;
                }
            }
            Console.WriteLine();
        }
    }
}


