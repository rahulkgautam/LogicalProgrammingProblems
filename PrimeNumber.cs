using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        public void CheckPrimeNumber(int number)
        {
            int count=0;
            
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    count++;
            }
            if (count == 2)
                Console.WriteLine("Prime Number");
            else
                Console.WriteLine("Not Prime Number");
        }
    }
}
