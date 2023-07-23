using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LogicalPrograms
{
    public class Program
    {    
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature:");
            if (double.TryParse(Console.ReadLine(), out double temperature))
            {
                Console.WriteLine("Enter 'C' for Celsius to Fahrenheit or 'F' for Fahrenheit to Celsius:");
                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                TemperatureConversion.temperatureConversion(choice, temperature);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid temperature.");
            }
        }
    }
}
