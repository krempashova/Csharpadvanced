using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[]nums=Console.ReadLine()//1 2 3 4 5 6
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]%2==0)
                {
                    queue.Enqueue(nums[i]);   
                }
            }

            Console.WriteLine(string.Join(", ",queue));
        }
    }
}
