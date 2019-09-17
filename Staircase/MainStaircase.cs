using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Staircase
{
    public class MainStaircase
    {
        public static void Staircase(int n)
        {
            for (var i = 1; i <= n; i++)
            {
                var step = string.Empty;
                var spaces = n - i;
                var hashes = n - spaces;
                for (var j = 1; j <= spaces; j++)
                {
                    step += " ";
                }

                for (var k = 1; k <= hashes; k++)
                {
                    step += "#";
                }
                Console.WriteLine(step);
            }
            Console.Read();
        }
    }
}
