using System;
using System.Drawing;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] dimension = Console.ReadLine()
                           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();
            int rows = dimension[0];
            int cols = dimension[1];
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            string comand;
            while ((comand=Console.ReadLine())!="END")
            {
                string[] tokens = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                //SWAP 0 0 1 1
                string action = tokens[0];

                if(action=="swap" 
                    &&  tokens.Length==5
                    && int.Parse(tokens[1]) >= 0 && int.Parse(tokens[1]) < rows
                    && int.Parse(tokens[2]) >= 0 && int.Parse(tokens[2]) < cols
                    && int.Parse(tokens[3]) >= 0 && int.Parse(tokens[3]) < rows
                    && int.Parse(tokens[4]) >= 0 && int.Parse(tokens[4]) < cols)
                {
                    string swaped = matrix[int.Parse(tokens[1]), int.Parse(tokens[2])];
                    matrix[int.Parse(tokens[1]), int.Parse(tokens[2])]
                        = matrix[int.Parse(tokens[3]), int.Parse(tokens[4])];
                    matrix[int.Parse(tokens[3]), int.Parse(tokens[4])] = swaped;

                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write($"{matrix[row, col]} ");
                        }

                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }


            }
        }
    }
}
