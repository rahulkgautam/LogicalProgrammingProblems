using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class FibonacciSeries
    {
        public void PrintFibonacciSeries(int number)
        {
            int first = 0;
            int second = 1;

            Console.WriteLine("Fibonacci Series:");
            Console.Write("{0} {1} ", first, second);
            for (int i = 2; i < number; i++)
            {
                int next = first + second;
                Console.Write("{0} ", next);

                first = second;
                second = next;
            }
        }
    }
}
