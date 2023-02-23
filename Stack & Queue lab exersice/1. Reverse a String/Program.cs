using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace _1._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char>stack = new Stack<char>();

            foreach (var character in input)
            {
                stack.Push(character);
            }
            while (stack.Count!=0)
            {
                Console.Write(stack.Pop());
            }

        }
    }
}
