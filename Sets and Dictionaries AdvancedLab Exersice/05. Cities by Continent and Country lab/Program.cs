using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> countries
                = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);//Europe Bulgaria Sofia
                string continent= tokens[0];
                string country =
                    tokens[1];
                string city = tokens[2];

                if(!countries.ContainsKey(continent))
                {
                    countries.Add(continent,new Dictionary<string, List<string>>());
                }
                if (!countries[continent].ContainsKey(country)) 
                {

                    countries[continent].Add(country, new List<string>());
                }
               
                    countries[continent][country].Add(city);
                
            }

            foreach (var item in countries)
            {
                Console.WriteLine($"{item.Key}:");

                foreach (var conutry in item.Value)
                {
                    Console.WriteLine($"  {conutry.Key} -> {string.Join(", ",conutry.Value)}");

                    
                        
                }
            }
            
        }
    }
}
