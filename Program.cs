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
                Console.WriteLine("Usage: dotnet run <month> <day> <year>");
                return;
            }
            if (int.TryParse(args[0], out int month) &&
                int.TryParse(args[1], out int day) &&
                int.TryParse(args[2], out int year))
            {
                int dayOfWeek = DayOfWeek.DayOfWeeks(day, month, year);
                Console.WriteLine($"Day of the week: {dayOfWeek}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid integers for month, day, and year.");
            }
        }
    }
}
