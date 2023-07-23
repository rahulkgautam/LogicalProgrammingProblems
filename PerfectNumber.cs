using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        public static long IsPerfect(long num)
        {
            long sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                    Console.WriteLine(i);
                }
            }
            return sum;
        }
    }
}
