using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("=======**Welcome To Logical Programming Problems**========");

                Console.WriteLine("Enter a number Fibonacci Series");
                int number = Convert.ToInt32(Console.ReadLine());
                var fibonacciSeries = new FibonacciSeries();
                fibonacciSeries.PrintFibonacciSeries(number);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Please Enter only Number");
            }
        }
    }
}
