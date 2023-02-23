using System;

namespace _2.Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomrow = 0;
            int randomcol = 0;
            int foodquntity = 0;
            int fisrtLeirRow = 0;
            int firstleirCol = 0;
            int secondleirRow = 0;
            int secondleirCol = 0;
            bool isLeirFounf = false;
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();


                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    matrix[row, col] = rowData[col];

                    if (matrix[row, col] == 'S')
                    {
                        randomrow = row;
                        randomcol = col;
                        matrix[randomrow, randomcol] = '.';
                    }
                    if (matrix[row, col] == 'B' && !isLeirFounf)
                    {
                        isLeirFounf = true;
                        fisrtLeirRow = row;
                        firstleirCol = col;

                    }
                    else if (matrix[row, col] == 'B' && isLeirFounf)
                    {
                        //we found second leir
                        secondleirRow = row;
                        secondleirCol = col;
                    }
                }

            }
            string comand = string.Empty;
            while (IsValid(randomrow, randomcol,matrix) && foodquntity < 10)
            {
                switch (comand = Console.ReadLine())
                {
                    case "up":
                        randomrow--;
                       
                        break;
                    case "down":
                        randomrow++;


                        break;
                    case "left":
                        randomcol--;


                        break;
                    case "right":
                        randomcol++;

                        break;
                }
                if (!IsValid(randomrow, randomcol, matrix))
                {
                    break;
                }

                if (matrix[randomrow, randomcol] =='*')
                {

                    // we foound food
                    foodquntity++;
                    matrix[randomrow, randomcol] ='.';

                }
                if (randomrow == fisrtLeirRow && randomcol == firstleirCol)
                {
                    matrix[randomrow, randomcol] ='.';
                    // snake goes to leir.
                    randomrow = secondleirRow;
                    randomcol = secondleirCol;

                }
                if (randomrow == secondleirRow && randomcol == secondleirCol)
                {
                    matrix[randomrow, randomcol] = '.';
                   

                }
                if (matrix[randomrow,randomcol]=='-')
                {
                    matrix[randomrow, randomcol] = '.';
                }


            }
          

            if(!IsValid(randomrow, randomcol, matrix))
            {
                Console.WriteLine("Game over!");
            }
            else if(foodquntity>=10)
            {
                matrix[randomrow, randomcol] = 'S';
                Console.WriteLine("You won! You fed the snake.");
            }
            Console.WriteLine($"Food eaten: {foodquntity}");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }


        }

        private static bool IsValid(int randomrow, int randomcol, char[,] matrix)
        {
            return randomrow >= 0 && randomrow < matrix.GetLength(0)
                && randomcol >= 0 && randomcol < matrix.GetLength(1);
        }
    }

}