using System;
using System.Collections.Generic;
using System.Linq;


namespace _02._Sets_of_Elements_exersice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> fistSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
           // HashSet<int> equals = new HashSet<int>();

            int [] nm =Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = nm[0];
            int m = nm[1];

            for (int i = 0; i < 1; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    fistSet.Add(int.Parse(Console.ReadLine()));
                }
                for (int k = 0; k < m; k++)
                {
                    secondSet.Add(int.Parse(Console.ReadLine()));
                }
            }

            //foreach (var first in fistSet)
            //{
            //    if(fistSet.Contains(first) && secondSet.Contains(first))
            //    {
            //        equals.Add(first);
            //    }
            //}
            //foreach (var equal in equals)
            //{
            //    Console.Write($"{equal} ");
            //}
            fistSet.IntersectWith(secondSet);
            Console.WriteLine(string.Join(" ", fistSet));
        }
    }
}
