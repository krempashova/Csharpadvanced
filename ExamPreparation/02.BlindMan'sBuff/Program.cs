using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

string[] sizes = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizes[0]);
int cols = int.Parse(sizes[1]);
int startRow = 0;
int startCol = 0;
int moves = 0;
int touchedOponents = 0;
char[,] matrix = new char[rows, cols];

for (int row = 0; row < rows; row++)
{
    char[] rowData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = rowData[col];
        if (matrix[row, col] == 'B')
        {
            //WE START FROM HERE
            startRow = row;
            startCol = col;
        }

    }
}

    string comand = string.Empty;
    while ((comand = Console.ReadLine()) != "Finish")
    {
           matrix[startRow, startCol] = '-';
    if (touchedOponents >= 3)
        {
            break;
        }
        if(comand=="up")
        {
            if (IsPositionValid(startRow-1,startCol,rows,cols) && matrix[startRow-1,startCol]=='-')
            {
            
                moves++;
                startRow--;
           
            }
            else if(IsPositionValid(startRow-1, startCol, rows, cols) && matrix[startRow-1, startCol] =='O')
            {
                continue;
            }
            else if(IsPositionValid(startRow-1, startCol, rows, cols) && matrix[startRow-1, startCol] =='P')
            {
                touchedOponents++;
                moves++;
                startRow--;
                matrix[startRow, startCol] ='-';
            }
            else if (!IsPositionValid(startRow-1, startCol, rows, cols))
            {
                continue;
            }
            
        }
        else if(comand=="down")
        {

            if (IsPositionValid(startRow+1, startCol, rows, cols) && matrix[startRow+1, startCol] == '-')
            {
                moves++;
                startRow++;
            }
            else if (IsPositionValid(startRow+1, startCol, rows, cols) && matrix[startRow+1, startCol] == 'O')
            {
                continue;
            }
            else if (IsPositionValid(startRow+1, startCol, rows, cols) && matrix[startRow+1, startCol] == 'P')
            {
                touchedOponents++;
                moves++;
                startRow++;
                matrix[startRow, startCol] = '-';
            }
            else if (!IsPositionValid(startRow+1, startCol, rows, cols))
            {
                continue;
            }

        }
        else if(comand=="left")
        {
            if (IsPositionValid(startRow, startCol-1, rows, cols) && matrix[startRow, startCol-1] == '-')
            {
                moves++;
                startCol--;
            }
            else if (IsPositionValid(startRow, startCol-1, rows, cols) && matrix[startRow, startCol-1] == 'O')
            {
                continue;
            }
            else if (IsPositionValid(startRow, startCol-1, rows, cols) && matrix[startRow, startCol-1] == 'P')
            {
                touchedOponents++;
                moves++;
                startCol--;
                matrix[startRow, startCol] = '-';
            }
            else if (!IsPositionValid(startRow, startCol-1, rows, cols))
            {
                continue;
            }
        }
        else
        {
            if (IsPositionValid(startRow, startCol+1, rows, cols) && matrix[startRow, startCol+1] == '-')
            {
                moves++;
                startCol++;
            }
            else if (IsPositionValid(startRow, startCol+1, rows, cols) && matrix[startRow, startCol+1] == 'O')
            {
                continue;
            }
            else if (IsPositionValid(startRow, startCol+1, rows, cols) && matrix[startRow, startCol+1] == 'P')
            {
                touchedOponents++;
                moves++;
                startCol++;
                matrix[startRow, startCol] = '-';
            }
            else if (!IsPositionValid(startRow, startCol+1, rows, cols))
            {
                continue;
            }
        }

    }


    Console.WriteLine("Game over!");
    Console.WriteLine($"Touched opponents: {touchedOponents} Moves made: {moves}");

     bool IsPositionValid(int startRow, int StartCol, int rows, int cols)
    {
        if (startRow < 0 || startRow >= rows)
        {
            return false;
        }
        if (StartCol < 0 || StartCol >= cols)
        {
            return false;
        }

        return true;
    }

