using System;
using System.Linq;

namespace _3._Primary_Diagonal_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());
            int rows = size;
            int colls = size;
            int[,] matix = new int[rows, colls];
            for (int row = 0; row < rows; row++)
            {
                int[] elements = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                for (int coll = 0; coll < colls; coll++)
                {
                    matix[row, coll] = elements[coll]; 
                }
                
            }

            int sumdiagonal = 0;
            for (int i = 0; i < size; i++)
            {
                sumdiagonal += matix[i, i];
            }
            Console.WriteLine(sumdiagonal);
        }
    }
}
