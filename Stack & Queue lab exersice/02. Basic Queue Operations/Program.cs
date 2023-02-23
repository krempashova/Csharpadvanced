using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] receivednums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int numToEnqueu = input[0];
            int numToDequeu = input[1];
            int numTopeek = input[2];
            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < numToEnqueu; i++)
            {
                numbers.Enqueue(receivednums[i]);

            }
            for (int i = 0; i < numToDequeu; i++)
            {
                numbers.Dequeue();
            }
            if(numbers.Count==0)
            {
                Console.WriteLine("0");
                return;
            }
            if(numbers.Contains(numTopeek))
            {
                Console.WriteLine("true");
            }
            else if(!numbers.Contains(numTopeek))
            {
                int smallestNum = numbers.Min();
                Console.WriteLine(smallestNum);
            }



        }
    }
}
