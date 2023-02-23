using System;
using System.Collections.Generic;
using System.Dynamic;

namespace _02.HelpAMole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startRow = 0;
            int startCol = 0;
            int firstspecialRowPos = 0;
            int firstspecialColpos = 0;
            int secondSpecialPosRow = 0;
            int secondSpecialPosCoL = 0;
            bool isFound = false;
            int points = 0;

            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();


                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                    if (matrix[row, col] == 'M')
                    {
                        startRow = row;
                        startCol = col;
                    }
                    if (matrix[row, col] == 'S' && !isFound)
                    {

                        isFound = true;
                        firstspecialRowPos = row;
                        firstspecialColpos = col;

                    }
                    else if (matrix[row, col] == 'S' && isFound)
                    {
                        //we found second 
                        secondSpecialPosRow = row;
                        secondSpecialPosCoL = col;
                    }
                }
            }

            matrix[startRow, startCol] = '-';
            string comand = string.Empty;
            
            while ((comand = Console.ReadLine()) != "End" && points<25)
            {

                switch (comand)
                {
                    case "up":
                        startRow--;
                        break;
                    case "down":
                        startRow++;
                        break;
                    case "left":
                        startCol--;
                        break;
                    case "right":
                        startCol++;
                        break;

                }
                if (!iSValidFiled(startRow, startCol, matrix))
                {
                    Console.WriteLine("Don't try to escape the playing field!");

                     if(startCol<0)
                    {
                        startCol++;
                    }
                     if(startCol>=size)
                    {
                        startCol--;
                    }
                     if(startRow<0)
                    
                        {
                        startRow++;
                        } 
                     if(startRow>=size)
                    {
                        startRow--;
                    }
                    continue;
                }

                if (startRow == firstspecialRowPos && startCol == firstspecialColpos)
                {
                    matrix[startRow, startCol] = '-';

                    startRow = secondSpecialPosRow;
                    startCol = secondSpecialPosCoL;
                    points -= 3;

                }

                if (startRow == secondSpecialPosRow && startCol == secondSpecialPosCoL)
                {
                    matrix[startRow, startCol] = '-';
                    startRow = firstspecialRowPos;
                    startCol = firstspecialColpos;
                   


                }

                if (char.IsDigit(matrix[startRow,startCol]))
                {
                    points += int.Parse((matrix[startRow, startCol]).ToString());
                    matrix[startRow, startCol] = '-';
                }
               
              
            }
            matrix[startRow, startCol] = 'M';
            if(points>=25)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {points} points.");
            }
            else 
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of { points} points.");
            }
            //Printing Matrix :
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }

        }

        public static bool iSValidFiled(int startRow, int startCol, char[,] matrix)
        {
            return startRow >= 0 && startRow < matrix.GetLength(0)
                && startCol >= 0 && startCol < matrix.GetLength(1);
        }

      
       
    }
}