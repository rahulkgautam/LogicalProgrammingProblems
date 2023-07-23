using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class ReverseNumber
    {
        public void ReverseInputNumber(int number)
        {
            int rem, reverse = 0;
            while (number != 0){
                rem = number % 10;
                reverse = (reverse * 10) + rem;
                number /= 10;
            }
            Console.WriteLine("Reverse Number " + reverse);
        }
    }
}
