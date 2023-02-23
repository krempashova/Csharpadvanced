using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int quantity=int.Parse(Console.ReadLine());  //499

            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            Queue<int> orders = new Queue<int>(input);

            Console.WriteLine(orders.Max());
            for (int i = 0; i < input.Length; i++)
            {
                int currOrder = orders.Peek();
                if (quantity >= currOrder)
                {

                    quantity -= currOrder;
                    orders.Dequeue();

                }
                else if(quantity<currOrder)
                {
                    Console.WriteLine($"Orders left: {string.Join(" ",orders)}");
                    return;
                }
            }

            Console.WriteLine("Orders complete");
        }
    }
}

