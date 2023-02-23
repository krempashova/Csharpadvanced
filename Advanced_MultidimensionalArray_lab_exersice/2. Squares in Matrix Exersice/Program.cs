using System;
using System.Linq;

namespace _2._Squares_in_Matrix_Exersice
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
            int equalcount = 0;
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                char[] elements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse).
                    ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] 
                        && matrix[row, col] ==matrix[row + 1, col]
                        && matrix[row, col] == matrix[row+1,col+1])
                    {
                        equalcount++;
                    }
                }
            }
            if(equalcount==0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(equalcount);
            }
        }
    }
}
