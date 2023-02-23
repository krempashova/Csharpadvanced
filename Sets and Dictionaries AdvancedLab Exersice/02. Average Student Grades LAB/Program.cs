using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();
        for (int i = 0; i < n; i++)
        {

            string[] students = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = students[0];
            decimal grade = decimal.Parse(students[1]);
            if (!studentGrades.ContainsKey(name))

            {
                studentGrades.Add(name, new List<decimal>());
            }

            studentGrades[name].Add(grade);




        }

        foreach (var item in studentGrades)
        { 
            
            Console.Write($"{item.Key} -> {string.Join(" ",item.Value):f2} (avg: {item.Value.Average()})");
         
        }
    }
}