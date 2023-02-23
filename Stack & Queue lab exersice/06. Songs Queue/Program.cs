using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ");

            Queue<string> songsList = new Queue<string>(input);
            while (songsList.Any())

            {
                string[] cmArg = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string comand = cmArg[0];

                switch (comand)
                {
                    case "Play":
                        songsList.Dequeue();
                        break;
                    case "Add":
                        string songName = string.Join(" ", cmArg.Skip(1));
                        if(!songsList.Contains(songName))
                        {
                            songsList.Enqueue(songName);    
                        }
                        else
                        {
                            Console.WriteLine($"{songName} is already contained!");
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ",songsList));
                        break;

                    
                }

            }

            Console.WriteLine("No more songs!");
           

        }
    }
}
