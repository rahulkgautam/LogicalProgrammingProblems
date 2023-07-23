using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LogicalPrograms
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the change in Rs to be returned by the Vending Machine:");
            if (int.TryParse(Console.ReadLine(), out int changeAmount))
            {
                int[] notes = VendingMachine.GetChange(changeAmount);

                Console.WriteLine($"Minimum number of notes needed: {notes.Length}");
                Console.WriteLine("Notes to be returned:");
                foreach (int note in notes)
                {
                    Console.Write(note + " ");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
