using System;
using System.Runtime.CompilerServices;

namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            if (size < 3)
            {
                Console.WriteLine(0);
                return;
            }

            char[,] matrix = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                string elements = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = elements[col];
                }

            }
            int removedhorsers = 0;
            while (true)
            {
                int horserow = 0;
                int horsecol = 0;
                int attackes = 0;
                for (int row  = 0; row < size; row++)
                {


                    for (int col = 0; col < size; col++)
                    {

                        if (matrix[row,col]=='K')
                        {
                            int tempAttacks = CountAttack(matrix, row, col);
                        }
                    }
                }






            }


                    
                }

        private static int CountAttack(char[,] matrix, int row, int col)
        {
            int attack = 0;
            if(IsValid(row-2,col+1,matrix))
            {
                attack++;
            }
            if (IsValid(row-2,col-2,matrix))
            {
                attack++;
            }
            if(Isvalid(row-1,co))
        }

        bool IsValid(int row, int col, char[,] matrix)
        {

            return row >= 0
                 && row < matrix.GetLength(0)
                 && col >= 0
                 && col < matrix.GetLength(1)
                 && matrix[row, col] == 'K';
        }
    }

 }

       