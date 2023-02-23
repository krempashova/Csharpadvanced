using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _01.FlowerWreaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int leftflowersstorage = 0;
            int wreathsCount = 0;
            Stack<int> lilies = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
          .Select(int.Parse));

      Queue<int> roses = new Queue<int>(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

            while (lilies.Any() && roses.Any())
            {
                int currentwreath = lilies.Peek() + roses.Peek();

                if(currentwreath==15)
                {
                    wreathsCount++;
                    lilies.Pop();
                    roses.Dequeue(); //we meed it
                }
                else if(currentwreath<15)
                {
                    int leftlilies = lilies.Pop();
                    int leftroses = roses.Dequeue();
                    leftflowersstorage += leftlilies;
                    leftflowersstorage += leftroses;
                }
                else
                {
                    int newlilies = lilies.Pop() - 2;
                    lilies.Push(newlilies);
                        
                     
                }



            }
            if (leftflowersstorage >= 15)

            {
                int morewreath = leftflowersstorage / 15;
                wreathsCount += morewreath;

            }
            if(wreathsCount>=5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathsCount} wreaths!" );
            }
            else

            {
                Console.WriteLine($"You didn't make it, you need {5-wreathsCount} wreaths more!");
            }


        }
    }
}
