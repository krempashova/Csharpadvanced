using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> stack = new Stack<int>(input);
            
            
            string comand;
            while((comand=Console.ReadLine().ToLower())!="end")
            {

                string[] todo = comand.Split();
                string action= todo[0]; 
                if(action=="add")
                {
                    int firstnum = int.Parse(todo[1]);
                    int secondnum = int.Parse(todo[2]);
                    stack.Push(firstnum);
                    stack.Push(secondnum);

                }
                else if(action=="remove")
                {
                    int n = int.Parse(todo[1]);
                    if (n <= stack.Count)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            stack.Pop();
                        }
                    }
                }






            }
            
            Console.WriteLine($"Sum: {stack.Sum()}");


        }
    }
}
