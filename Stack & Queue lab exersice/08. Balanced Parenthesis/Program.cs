using System;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isBalanced = true;
            string input = Console.ReadLine();
            Stack<Char> Openbrekets = new Stack<Char>();
            foreach (var character in input)
            {
                if (character == '(' || character == '[' || character == '{')

                {
                    Openbrekets.Push(character);

                }
                else
                {
                    if (Openbrekets.Count == 0)
                    {
                        isBalanced = false;
                        break;

                    }
                    char lastSymbol = Openbrekets.Pop();
                    if (character == ')' && lastSymbol != '(')
                    {
                        isBalanced = false;
                        break;
                    }
                    else if (character == '}' && lastSymbol != '{')
                    {
                        isBalanced = false;
                        break;
                    }
                    else if (character == ']' && lastSymbol != '[')
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }

            if(isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}