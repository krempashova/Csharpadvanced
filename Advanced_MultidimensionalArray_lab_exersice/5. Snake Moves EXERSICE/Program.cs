using System;
using System.Linq;

namespace _5._Snake_Moves_EXERSICE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            int rows= dimensions[0];
            int colls = dimensions[1];
            int textIndex = 0;
            char[,] matrix = new char[rows,colls];
            string text = Console.ReadLine();
            for (int row = 0; row < rows; row++)
            { 
                if (row % 2 == 0)
                {

                    for (int col = 0; col < colls; col++)
                    {
                        if(textIndex==text.Length)
                        {
                            textIndex = 0;
                           
                        }
                        matrix[row, col] = text[textIndex];
                        textIndex++;
                    }
                }
                else
                {
                    for (int col =colls-1 ; col >= 0; col--)
                    {
                        if(textIndex==text.Length)
                        {
                            textIndex = 0;
                        }
                        matrix[row,col] = text[textIndex];
                        textIndex++;
                    }
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < colls; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
