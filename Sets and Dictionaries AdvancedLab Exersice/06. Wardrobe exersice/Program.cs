using System;
using System.Collections.Generic;

namespace _06._Wardrobe_exersice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardober 
                = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                string[] tokens = Console.ReadLine()
                    .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

                string color = tokens[0];//Blue -> dress,jeans,hat

                if (!wardober.ContainsKey(color))
                {
                    wardober.Add(color, new Dictionary<string, int>());
                }
                for (int j = 1; j < tokens.Length; j++)
                {
                    string dresses = tokens[j];
                    if (!wardober[color].ContainsKey(dresses))
                    {
                        wardober[color].Add(dresses, 1);
                    }
                    else
                    {
                        wardober[color][dresses]++;
                    }
                   
                }
            }

            string[] clothestofind = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries); //Blue dress
            string colortoFind = clothestofind[0];
            string dresstoFind = clothestofind[1];
            
                foreach (var item in wardober)
                {
                    Console.WriteLine($"{item.Key} clothes:");
                    foreach (var dress in item.Value)
                    {
                        Console.Write($"* {dress.Key} - {dress.Value}");
                        
                           if(colortoFind== item.Key && dresstoFind==dress.Key)
                    {
                        Console.WriteLine($" (found!)");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    }
                   
                }
           



        }
        }
    }

