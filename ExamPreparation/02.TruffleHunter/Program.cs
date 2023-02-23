using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace _02.TruffleHunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            
            char[,] matrix = new char[size, size];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                    

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            //•	Black truffle - 'B'
            //•	Summer truffle -'S'
            //•	White truffle -'W'
            int blackTrCount = 0;
            int summerTrCount = 0;
            int whiteTrCount = 0;
            int countEatenTrufles = 0;

            string comand = string.Empty;
            while ((comand=Console.ReadLine())!="Stop the hunt")
            {
                string[] arg = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = arg[0];
                int row = int.Parse(arg[1]);
                int col = int.Parse(arg[2]);

                if (action=="Collect")
                {
                    if (matrix[row,col]=='B')
                    {
                        blackTrCount++;
                    }
                    else if (matrix[row,col]=='S')
                    {
                        summerTrCount++;
                    }
                    else if (matrix[row,col]=='W')
                    {
                        whiteTrCount++;
                    }
                    matrix[row, col] = '-';

                }
                else if(action=="Wild_Boar")
                {
                    string direction = arg[3];
                    if(direction=="up")
                    {
                        while (row>=0)
                        {
                            if (matrix[row, col] !='-')
                            {
                                countEatenTrufles++;
                                matrix[row, col] = '-';
                            }
                            row -= 2;
                        }
                    }
                    else if(direction=="down")
                    {
                        while (row < size)
                        {
                            if (matrix[row, col] != '-')
                            {
                                countEatenTrufles++;
                                matrix[row, col] = '-';
                            }
                            row += 2;
                        }

                    }
                    else if(direction=="left")
                    {
                        while (col >=0)
                        {
                            if (matrix[row, col] != '-')
                            {
                                countEatenTrufles++;
                                matrix[row, col] = '-';
                            }
                            col -= 2;
                        }
                    }
                    else
                    {

                        while (col< size)
                        {
                            if (matrix[row, col] !='-')
                            {
                                countEatenTrufles++;
                                matrix[row, col] = '-';
                            }
                            col += 2;
                        }

                    }
                }


            }
            Console.WriteLine($"Peter manages to harvest {blackTrCount} black, {summerTrCount} summer, and {whiteTrCount} white truffles.");
            Console.WriteLine($"The wild boar has eaten {countEatenTrufles} truffles.");

            //Printing Matrix :
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }

        }
    }
}
