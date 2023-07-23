using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LogicalPrograms
{
    class StopWatch
    {
        public static void StopWatchs()
        {
            Console.WriteLine("Stopwatch Program");
            Console.WriteLine("++++++++++=======================+++++++++++++");

            Console.WriteLine("Press 'S' to start the stopwatch.");
            Console.WriteLine("Press 'E' to end the stopwatch.");
            Console.WriteLine("Press 'Q' to quit the program.");

            bool stopwatchRunning = false;
            Stopwatch stopwatch = new Stopwatch();

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.S)
                {
                    if (!stopwatchRunning)
                    {
                        stopwatch.Reset();
                        stopwatch.Start();
                        stopwatchRunning = true;
                        Console.WriteLine("Stopwatch started!");
                    }
                }
                else if (keyInfo.Key == ConsoleKey.E)
                {
                    if (stopwatchRunning)
                    {
                        stopwatch.Stop();
                        stopwatchRunning = false;
                        Console.WriteLine("Stopwatch stopped!");
                        TimeSpan elapsed = stopwatch.Elapsed;
                        Console.WriteLine("Elapsed time: " + elapsed);
                    }
                }
                else if (keyInfo.Key == ConsoleKey.Q)
                {
                    if (stopwatchRunning)
                    {
                        stopwatch.Stop();
                        stopwatchRunning = false;
                    }
                    break;
                }
            }

            Console.WriteLine("Program terminated.");
        }
    }
    
}
