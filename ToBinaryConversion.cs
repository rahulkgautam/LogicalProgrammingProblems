using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class ToBinaryConversion
    {
        public static void ToBinary()
        {
            int n, count = 0, a;
            string x = "";

            Console.WriteLine("Enter any decimal number:");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                a = n % 2;
                if (a == 1)
                {
                    count++;
                }
                x = a + "" + x;
                n = n / 2;
            }
            Console.WriteLine("Binary number:" + x);
            Console.WriteLine("No. of 1s:" + count);
        }
    }
}
