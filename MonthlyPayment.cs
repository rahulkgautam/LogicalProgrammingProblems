using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class MonthlyPayment
    {
        public static double CalculateMonthlyPayment(double P, int Y, double R)
        {
            // Calculate the monthly interest rate
            double r = R / (12 * 100);

            // Calculate the total number of payments (months)
            int n = Y * 12;

            // Calculate the monthly payment using the formula
            double monthlyPayment = (P * r) / (1 - Math.Pow(1 + r, -n));

            return monthlyPayment;
        }
    }
}
