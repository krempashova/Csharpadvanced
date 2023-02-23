using System;
using System.Collections.Generic;

namespace _03._Periodic_Table_exersice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> chemicalS = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int J = 0; J < elements.Length; J++)
                {
                    chemicalS.Add(elements[J]);
                }
            }
            foreach (var chemical in chemicalS)
            {
                Console.Write($"{chemical} ");
            }
        }
    }
}
