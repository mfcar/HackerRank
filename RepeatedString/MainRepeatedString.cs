using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.RepeatedString
{
    public class MainRepeatedString
    {
        public static long RepeatedString(string s, long n)
        {
            var repeatTimes = (n / s.Length) + 1;

            var aCount = 0;
            var aCountString = s.Count(c => c == 'a');
            var stringSize = 0;
            
            for (var i = 0; i < repeatTimes; i++)
            {
                stringSize += s.Length;
                // Get last string
                if (stringSize > n)
                {
                    var sum = stringSize - n;
                    stringSize = (int) (stringSize - sum);
                    aCount += s.Substring(0, (int)(s.Length - sum)).Count(c => c == 'a');
                } else {
                    aCount += aCountString;
                }
            }

            return aCount;
        }
    }
}

// aba
// 10
// 7

// a
// 1000000000000
// 1000000000000

// abcd
// 3
// 1

//var value1 = n / s.Length;
//var repeatTimes = value1 + 1;
//var completeString = new StringBuilder();
//for (var i = 0; i<repeatTimes; i++)
//{
//completeString.Append(s);
//if (completeString.Length > n)
//{
//    var sum = (int)(completeString.Length - n);
//    completeString.Remove(completeString.Length - sum, sum);
//}
//}

//return completeString.ToString().ToCharArray().Count(character => character == 'a');