using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                 .Split(", ")
                 .Select(int.Parse)
                 .ToArray();
            int rows = input[0];
            int colls = input[1];
            int[,] matrix = new int[rows, colls];
            for (int row = 0; row < rows; row++)
            {

                int[] elements = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                for (int coll = 0; coll < colls; coll++)
                {
                    matrix[row, coll] = elements[coll];

                }

             }
                

                for (int coll = 0; coll < colls; coll++)
                {
                    int sumcolls = 0;
                    for (int row = 0; row < rows; row++)
                    {
                        sumcolls += matrix[row, coll];

                    }
                    Console.WriteLine(sumcolls);
                }



            }
        }
    }
