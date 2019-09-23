using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.IntroToConditionalStatements
{
   public class MainIntroToConditionalStatements
    {
        public static void ReturnConditional()
        {
            var N = 0;
            var even = N % 2 == 0;
            if (even)
            {
                if (N >= 2 && N <= 5) Console.WriteLine("Not Weird");
                if (N >= 6 && N <= 20) Console.WriteLine("Weird");
                if (N > 20) Console.WriteLine("Not Weird");
            } else {
                Console.WriteLine("Weird");
            }
        }
    }
}
