using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.CamelCase
{
    public class MainCamelCase
    {
        public static int Camelcase(string s)
        {
            // return s.Count(x => string.Equals(x.ToString(), x.ToString().ToUpper(), StringComparison.Ordinal)) + 1;

            return s.Count(char.IsUpper) + 1;
        }
    }
}
