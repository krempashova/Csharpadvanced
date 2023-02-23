using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5
            string input = Console.ReadLine();
            Stack<int> breketsindexes = new Stack<int>();

            
            {
                for (int i=0;  i<input.Length; i++)
                {
                    if (input[i] == '(')
                    {
                        breketsindexes.Push(i);
                    }
                    if (input[i]==')') 
                    {

                        int startindex=breketsindexes.Pop();
                        int lenght = i - startindex + 1;
                        Console.WriteLine(input.Substring(startindex,lenght));
                      
                    }
                }

            }
        }
    }
}