using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LogicalPrograms
{
    public class Program
    {
       public static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Usage: dotnet run <principal> <years> <interest_rate>");
                return;
            }

            if (double.TryParse(args[0], out double principal) &&
                int.TryParse(args[1], out int years) &&
                double.TryParse(args[2], out double interestRate))
            {
                double monthlyPayment = MonthlyPayment.CalculateMonthlyPayment(principal, years, interestRate);
                Console.WriteLine($"Monthly Payment: {monthlyPayment:F2}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers for principal, years, and interest rate.");
            }
        }
    }
}
