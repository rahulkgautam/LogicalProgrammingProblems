using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LogicalPrograms
{

   

    public class Program
    {
        public static void Main(string[] args)
        {
            long number, sum;
            Console.WriteLine("Enter the number: ");
            number = Convert.ToInt64(Console.ReadLine());
            sum = PerfectNumber.IsPerfect(number);
            if (sum == number)
                Console.WriteLine(number + " is a perfect number");
            else
                Console.WriteLine(number + " is not a perfect number");
        }
    }
 }