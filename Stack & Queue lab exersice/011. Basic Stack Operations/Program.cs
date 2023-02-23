using System;
using System.Collections.Generic;
using System.Linq;

namespace _011._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[]input=Console.ReadLine() //5 2 13
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numToPush = input[0];//5
            int numToPop = input[1];    //2
            int numToPeek = input[2];  //13

            int[] receivednum = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> numbers = new Stack<int>();
            for (int i = 0; i < numToPush; i++)
            {
                numbers.Push(receivednum[i]);
            }


            for (int i = 0; i < numToPop; i++)
            {
                numbers.Pop();
               
            }
            if(numbers.Count==0)
            {
                Console.WriteLine("0");
                return;
            }
            
            if (numbers.Contains(numToPeek))
            {
                Console.WriteLine("true");
            }
            else if(!numbers.Contains(numToPeek))
            {
                int minnumber = numbers.Min();
                Console.WriteLine(minnumber);
            }
            
        }
    }
}
