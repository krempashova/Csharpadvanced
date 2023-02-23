using System;
using System.Collections;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int potetopass = 0;
            string[] childnames = Console.ReadLine().Split();
            int n=int.Parse(Console.ReadLine());
            Queue<string> potato = new Queue<string>(childnames);
            while (potato.Count>1)
            {
                potetopass++;
                string child = potato.Dequeue();

                if(potetopass==n)
                {
                    potetopass = 0;
                    Console.WriteLine($"Removed {child}");
                }
                else
                {
                    potato.Enqueue(child);
                }
            }

            Console.WriteLine($"Last is {potato.Dequeue()}");
        }
    }
}
