using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using HackerRank.BirthdayCakeCandles;
using HackerRank.CamelCase;
using HackerRank.IntroToConditionalStatements;
using HackerRank.Operators;
using HackerRank.TimeConversion;

namespace HackerRank
{
    class Program
    {

        // Complete the factorial function below.
        static int factorial(int n)
        {
            //if (n <= 1) return n;
            //var numeroAnterior = n - 1;
            //var resultadoFatorial = factorial(numeroAnterior);
            //var valorN = n * resultadoFatorial;
            //return valorN;

            if (n <= 1) return n;
            var numeroAnterior = n - 1;
            var resultadoFatorial = factorial(numeroAnterior);
            var valorN = n * resultadoFatorial;
            return n * factorial(n - 1);
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int result = factorial(n);
        }
    }
}
