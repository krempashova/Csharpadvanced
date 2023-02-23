using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                   
                    
                int action = int.Parse(input[0]);
                if(action==1)
                {
                    int numToPush = int.Parse(input[1]);
                    stack.Push(numToPush);  
                }
                else if(action==2)
                {
                    if(stack.Any())
                    {
                        stack.Pop();
                    }
                    
                }
                else if(action==3)
                {
                   
                    if(stack.Any())
                    {
                        int maxelement = stack.Max();
                        Console.WriteLine(maxelement);
                    }
                    
                }
                else if(action==4)
                {
                    
                    if(stack.Any())
                    {
                        int minelement = stack.Min();
                        Console.WriteLine(minelement);
                    }
                   
                }



            }
            
                Console.WriteLine(string.Join(", ", stack));
            
            


        }
    }
}
