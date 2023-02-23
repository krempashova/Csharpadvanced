using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace _01Count_Same_Value_in_ArrayLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> countvalues = new Dictionary<double, int>();

            //-2.5 4 3 -2.5 -5.5 4 3 3 -2.5 3
            double[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();
            foreach (var num in numbers)
            {
                if (!countvalues.ContainsKey(num))
                {
                    countvalues.Add(num, 0);
                }
                countvalues[num]++; 
            }
            foreach (var item in countvalues)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
                
            }
        }
    }
}
