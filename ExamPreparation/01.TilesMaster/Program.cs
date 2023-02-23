using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TilesMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> white = new(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse));

            Queue<int> grey = new(Console.ReadLine()
         .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse));

            Dictionary<string, int> madedareas = new Dictionary<string, int>();
            while (true)
            {

                int sum = white.Peek() + grey.Peek();
                if(sum==40)
                {

                }
                else if(sum==50)
                {
                    
                }

                else if (sum == 60)
                {

                }
                else if(sum==70)
                {

                }
                else
                {

                }

            }

        }
    }
}
