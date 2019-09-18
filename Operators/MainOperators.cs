using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Operators
{
    public class MainOperators
    {
        public static void Solve(double meal_cost, int tip_percent, int tax_percent)
        {
            var tip = (meal_cost / 100) * tip_percent;
            var tax = (meal_cost / 100) * tax_percent;
            var finalPrice = Math.Round(meal_cost + tip + tax);

            Console.WriteLine(finalPrice);
            Console.ReadKey();
        }
    }
}
