using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DictionariesAndMaps
{
    public class MainDictionariesAndMaps
    {
        public static void DictionariesAndMaps()
        {
            var contactsCount = Convert.ToInt32(Console.ReadLine());
            var phoneBook = new Dictionary<string, string>();

            for (var i = 0; i < contactsCount; i++)
            {
                var contact = Console.ReadLine().Split(' ');
                phoneBook.Add(contact[0], contact[1]);
            }

            while (true)
            {
                var name = Console.ReadLine();
                Console.WriteLine(phoneBook.ContainsKey(name) ? $"{name}={phoneBook[name]}" : "Not found");
            }
        }
    }
}
