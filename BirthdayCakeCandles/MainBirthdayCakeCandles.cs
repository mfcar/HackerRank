using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.BirthdayCakeCandles
{
    public class MainBirthdayCakeCandles
    {
        public static int BirthdayCakeCandles(int[] ar)
        {
            var tallerCandle = ar.Concat(new[] {0}).Max();

            return ar.Count(c => c == tallerCandle);
        }
    }
}
