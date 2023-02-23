using System;
using System.Linq;

namespace _01.SumMatrixElelemntLAB
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = input[0];
            int colls = input[1];


            
            int[,] matrix = new int[rows, colls];
            int sum = 0;
            for (int row = 0; row < rows; row++)
            {
                
                int[] rowData = Console.ReadLine()//7, 1, 3, 5, 6, 5
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

                for (int coll = 0; coll < colls; coll++)
                {
                    matrix[row, coll] = rowData[coll];
                    sum += rowData[coll]; 
                }
            }

            for (int row = 0; row < rows; row++)
            {
                
                for (int coll = 0; coll < colls; coll++)
                {
                    
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(colls);
            Console.WriteLine(sum);
        }
    }
}
