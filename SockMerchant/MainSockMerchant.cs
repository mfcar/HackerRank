using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.SockMerchant
{
    public class MainSockMerchant
    {
        public static int SockMerchant(int n, int[] ar)
        {
            var pairsCount = 0;
            var colorStack = new Dictionary<int, int>();

            foreach (var sock in ar)
            {
                if (!colorStack.ContainsKey(sock))
                {
                    colorStack.Add(sock, 1);
                }
                else
                {
                    colorStack[sock]++;
                }
            }

            foreach (var color in colorStack)
            {
                pairsCount = pairsCount + (color.Value / 2);
            }

            return pairsCount;
        }
    }
}

// Sample Input
// 9
// 10 20 20 10 10 30 50 10 20

// Sample Output
// 3
