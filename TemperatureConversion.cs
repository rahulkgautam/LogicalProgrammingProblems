using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class TemperatureConversion
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static void temperatureConversion(char choice, double temperature)
        {
            if (choice == 'F' || choice == 'f')
            {
                double celsius = FahrenheitToCelsius(temperature);
                Console.WriteLine($"Temperature in Celsius: {celsius:F2} °C");
            }
            else if (choice == 'C' || choice == 'c')
            {
                double fahrenheit = CelsiusToFahrenheit(temperature);
                Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2} °F");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 'C' for Celsius to Fahrenheit or 'F' for Fahrenheit to Celsius.");
            }
        }
    }
}
