using System;
using System.Collections;
using System.Collections.Generic;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comand;
            Queue<string> customer = new Queue<string>();
            while ((comand=Console.ReadLine())!= "End")
            {
                if(comand=="Paid")
                {
                    while (customer.Count>0)
                    {
                        Console.WriteLine(customer.Dequeue());
                    }

                    continue;
                }
                string customerName=comand;
                customer.Enqueue(customerName);

            }

            Console.WriteLine($"{customer.Count} people remaining.");




        }
    }
}
