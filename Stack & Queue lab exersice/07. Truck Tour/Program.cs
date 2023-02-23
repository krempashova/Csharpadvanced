using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

           Queue<int>diference = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int amountOfPetrol = input[0];
                int distanceToNextPump = input[1];

                diference.Enqueue(amountOfPetrol - distanceToNextPump);
            }
            
            int index = 0;

            while (true)
            {
                var copyDifference = new Queue<int>(diference);

                int fuel = int.MinValue;

                while (copyDifference.Any())
                {
                    int currentDiffernce = copyDifference.Peek();

                    if (currentDiffernce > 0 && fuel == int.MinValue)
                    {
                        fuel = copyDifference.Dequeue();
                        diference.Enqueue(diference.Dequeue());
                    }
                    else if (currentDiffernce < 0 && fuel == int.MinValue)
                    {
                        copyDifference.Enqueue(copyDifference.Dequeue());
                        diference.Enqueue(diference.Dequeue());
                        index++;
                    }
                    else
                    {
                        fuel += copyDifference.Dequeue();

                        if (fuel < 0)
                        {
                            break;
                        }
                    }
                }

                if (fuel >= 0)
                {
                    Console.WriteLine(index);
                    return;
                }

                index++;
            }
        }
    }
}
