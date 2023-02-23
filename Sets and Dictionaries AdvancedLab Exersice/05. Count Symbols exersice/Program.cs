using System;
using System.Collections.Generic;

namespace _05._Count_Symbols_exersice
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
         SortedDictionary<char,int> symbols = new SortedDictionary<char,int>();

            string text = Console.ReadLine();
            foreach (var character in text)
            {
                if(!symbols.ContainsKey(character))
                {
                    symbols.Add(character, 1);
                }
                else
                {
                    symbols[character]++;
                }

            }
            foreach (var item in symbols)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
