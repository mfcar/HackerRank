using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Recursion3
{
    class MainRecursion3
    {
        // Complete the factorial function below.
        static int Factorial(int n)
        {
            if (n <= 1) return n;
            return n * Factorial(n - 1);
        }
    }
}
