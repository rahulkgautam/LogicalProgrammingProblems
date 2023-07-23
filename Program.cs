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

                Console.WriteLine("Enter a number");
                int number = Convert.ToInt32(Console.ReadLine());
                var primeNumber = new PrimeNumber();
                primeNumber.CheckPrimeNumber(number);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Please Enter only Number");
            }
        }
    }
}
