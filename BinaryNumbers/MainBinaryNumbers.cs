using System;
using System.Linq;

namespace HackerRank.BinaryNumbers
{
    public class MainBinaryNumbers
    {
        public static void CalculateBinaryNumber()
        {
            var n = Convert.ToInt32(Console.ReadLine());

            var binaryN = Convert.ToString(n, 2);

            var consecutivesOnes = 0;

            if (!binaryN.Contains("0"))
            {
                Console.WriteLine(binaryN.Length);
            }
            else
            {
                var stringSplitted = binaryN.Split('0');

                foreach (var splitted in stringSplitted)
                {
                    if (splitted.Length > consecutivesOnes) consecutivesOnes = splitted.Length;
                }

                Console.WriteLine(consecutivesOnes);
            }
        }

        public static void CalculateBinaryNumber2()
        {
            var n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Convert.ToString(n, 2).Split('0').Max(x => x.Length));
        }
    }
}
