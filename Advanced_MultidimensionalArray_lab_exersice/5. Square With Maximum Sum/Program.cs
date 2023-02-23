using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int rows = elements[0];
            int colls = elements[1];
            int[,] matrix = new int[rows, colls];
            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < colls; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxColl = 0;
            for (int row = 0; row < rows-1; row++)
            {

                for (int col = 0; col < colls-1; col++)
                {
                    
                    int currsum = 0;
                    currsum = matrix[row, col] + matrix[row, col + 1] 
                        + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if(currsum>maxSum)
                    {
                        maxSum = currsum;
                        maxRow = row;
                        maxColl = col;
                    }
                    
                }
            }
            Console.WriteLine($"{matrix[maxRow,maxColl]} {matrix[maxRow,maxColl+1]}");
            Console.WriteLine($"{matrix[maxRow+1,maxColl]} {matrix[maxRow+1, maxColl+1]}");
            Console.WriteLine(maxSum);

        }
    }
}