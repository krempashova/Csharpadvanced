using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int raCkCount = 1;
            int[] clothesintheBox=Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            int currentrackcapacity = rackCapacity;
            Stack<int> clothes = new Stack<int>(clothesintheBox);

            while (clothes.Any())
           
            {
                int currentclothes=clothes.Peek();
                currentrackcapacity -= currentclothes;
                if(currentrackcapacity<0)
                {
                    raCkCount++;
                    currentrackcapacity = rackCapacity;
                    continue;
                }

                clothes.Pop();


            }

            Console.WriteLine(raCkCount);

        }
    }
}
