using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace _01.Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daturaCounter = 0;
            int cherryCounter = 0;
            int smokeCounter = 0;
            bool allBombs = false;
            Queue<int> bombeffect = new Queue<int>(Console.ReadLine()//
          .Split(", ", StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse));


            Stack<int> bombcasing = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse));

            Dictionary<string, int> pouchbombsCount = new Dictionary<string, int>();

            while (bombeffect.Any() && bombcasing.Any())
            {
                if (bombeffect.Peek() + bombcasing.Peek() == 40)
                {
                    daturaCounter++;
                    bombcasing.Pop();
                    bombeffect.Dequeue();
                }
                else if (bombeffect.Peek() + bombcasing.Peek() == 60)
                {
                    cherryCounter++;
                    bombcasing.Pop();
                    bombeffect.Dequeue();
                }
                else if (bombeffect.Peek() + bombcasing.Peek() == 120)
                {
                    smokeCounter++;
                    bombcasing.Pop();
                    bombeffect.Dequeue();
                }
                else
                {
                     int newbomb=bombcasing.Pop()-5;
                    bombcasing.Push(newbomb);
                }
                if (daturaCounter >= 3 && cherryCounter >= 3 && smokeCounter >= 3)
                {
                    allBombs = true;
                    break;
                }
            }

            if (allBombs)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombeffect.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else if (bombeffect.Count > 0)
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombeffect)}");

            }
            if (bombcasing.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else if (bombcasing.Count > 0)
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombcasing)}");

            }

            Console.WriteLine($"Cherry Bombs: {cherryCounter}");
            Console.WriteLine($"Datura Bombs: {daturaCounter}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeCounter}");
        }


    }
    }
