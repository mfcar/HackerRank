using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.TimeConversion
{
    public class MainTimeConversion
    {
        public static string TimeConversion(string s)
        {
            var newDate = DateTime.Parse(s);
            return newDate.TimeOfDay.ToString();
        }
    }
}
