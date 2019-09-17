using System.Collections.Generic;
using HackerRank.AVeryBigSum;
using HackerRank.CompareTheTriplets;
using HackerRank.RepeatedString;
using HackerRank.Staircase;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            var alice = new List<int> { 5, 6, 7 };
            var bob = new List<int> { 3, 6, 10 };
            MainCompareTheTriplets.CompareTriplets(alice, bob);
        }
    }
}
