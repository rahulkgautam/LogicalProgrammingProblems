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

                Console.WriteLine("Enter 2 or more digit a number");
                int number = Convert.ToInt32(Console.ReadLine());
                var reverseNumber = new ReverseNumber();
                reverseNumber.ReverseInputNumber(number);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Please Enter only Number");
            }
        }
    }
}
