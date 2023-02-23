using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator_Exersice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rows = int.Parse(Console.ReadLine());
            int [][] jaggedArray = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                int[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                jaggedArray[row] = tokens;
            }           
                for (int row = 0; row < rows-1; row++)
                {
                    if (jaggedArray[row].Length == jaggedArray[row+1].Length)
                    {
                        for (int col = 0; col < jaggedArray[row].Length; col++)
                        {

                            jaggedArray[row][col] *= 2;
                            jaggedArray[row + 1][col] *= 2;
                        }
                    }
                    else
                    {
                        for (int col = 0; col < jaggedArray[row].Length;
                           col++)
                        {
                            jaggedArray[row][col] /= 2;

                        }
                        for (int col = 0; col < jaggedArray[row+1].Length; col++)
                        {
                            jaggedArray[row + 1][col] /= 2;
                        }

                    }
                }
            string command;
            while ((command=Console.ReadLine())!="End")
            {
                string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = input[0];
                int row= int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);
                switch (action)
                {
                    case "Add":
                        if(IsValidIndexes(row, col, jaggedArray))
                        {
                            jaggedArray[row][col] += value;
                        }

                        break;
                    case "Subtract":
                        if (IsValidIndexes(row, col, jaggedArray))
                        {
                            jaggedArray[row][col] -= value;
                        }

                        break;
                    
                }

            }
            

            foreach (int[] array in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", array));
            };
        }

         static bool IsValidIndexes(int row, int col, int[][]jaggedArray)
        {
            
                 return row >= 0

                && row < jaggedArray.Length
                && col >= 0
                && col < jaggedArray[row].Length;
        }
    }
}
