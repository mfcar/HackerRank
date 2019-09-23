using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.LetsReview
{
    public class MainLetsReview
    {
        public static void InputString()
        {
            var wordCount = Convert.ToInt16(Console.ReadLine());
            var wordList = new string[wordCount];
            for (var i = 0; i < wordList.Length; i++)
            {
                wordList[i] = Console.ReadLine();
            }

            foreach (var t in wordList)
            {
                var wordArray = t.ToCharArray();
                var evenWord = new StringBuilder();
                var oddWord = new StringBuilder();

                for (var i = 0; i < wordArray.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        evenWord.Append(wordArray[i]);
                    }
                    else
                    {
                        oddWord.Append(wordArray[i]);
                    }
                }

                Console.WriteLine($"{evenWord} {oddWord}");
            }
        }
    }
}
