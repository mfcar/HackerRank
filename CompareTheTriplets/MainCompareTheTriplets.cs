using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.CompareTheTriplets
{
    public class MainCompareTheTriplets
    {
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            var aliceScore = 0;
            var bobScore = 0;

            for (var i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i]) aliceScore++;
                if (b[i] > a[i]) bobScore++;
            }

            return new List<int>{aliceScore, bobScore};
        }
    }
}
