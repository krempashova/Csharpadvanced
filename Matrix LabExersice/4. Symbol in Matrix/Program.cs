using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            char[,] matrix = new char[n, n];
            for (int row = 0; row < n; row++)
            {
                string rowData = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {

                    matrix[row, col] = rowData[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            string output = string.Empty;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (symbol == matrix[row,col])
                    {
                        output = $"({row}, {col})";
                        break;

                    }

                }
                if (output!=string.Empty)
                {
                    break;
                }
                
            }
            if(output!=string.Empty)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }

        }
    }
}
