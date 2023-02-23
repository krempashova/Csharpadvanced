using System;
using System.Collections;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string comand;
            int countpassedcars = 0;
            Queue<string> cars = new Queue<string>();
            while ((comand=Console.ReadLine())!="end")
            {
                if(comand!="green")
                {
                    cars.Enqueue(comand);   
                }
                if(comand=="green" && cars.Count>0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if(cars.Count>0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            countpassedcars++;
                        }
                        
                        
                    }
                }



            }

            Console.WriteLine($"{countpassedcars} cars passed the crossroads.");


        }
    }
}
