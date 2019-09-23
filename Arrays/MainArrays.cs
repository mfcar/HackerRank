using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Arrays
{
    public class MainArrays
    {
        public void Arrays()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            Array.Reverse(arr);

            var result = string.Empty;
            foreach (var i in arr)
            {
                result += $"{i} ";
            }
            Console.WriteLine(result);
        }
    }
}
