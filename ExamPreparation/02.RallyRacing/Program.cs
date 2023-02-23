using System;
{
    int size = int.Parse(Console.ReadLine());
    string racecarnum = Console.ReadLine();
    bool isFoundTunel = false;
    bool isCarfoundF = false;
    int passedkm = 0;
    int firstTunelRow = 0;
    int firstTunelCol = 0;
    int secondTunelRow = 0;
    int secondTunleCol = 0;

    string[,] matrix = new string[size, size];

    for (int row = 0; row < size; row++)
    {
        string[] data = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        for (int col = 0; col < size; col++)
        {

            matrix[row, col] = data[col];

            if (matrix[row, col] == "T" && !isFoundTunel)
            {
                firstTunelRow = row;
                firstTunelCol = col;
                isFoundTunel = true;
            }
            else if (matrix[row, col] == "T" && isFoundTunel)
            {
                secondTunelRow = row;
                secondTunleCol = col;
            }
        }
    }

    string command = string.Empty;
    int carRow = 0;
    int carCol = 0;
    while ((command = Console.ReadLine()) != "End")
    {
        switch (command)
        {
            case "left":
                carCol--;
                break;
            case "right":
                carCol++;
                break;

            case "up":
                carRow--;
                break;
            case "down":
                carRow++;
                break;

        }

        if (matrix[carRow, carCol] == ".")
        {
            passedkm += 10;

        }
        if (matrix[carRow, carCol] == "T")
        {
            if (carRow == firstTunelRow && carCol == firstTunelCol)
            {
                matrix[carRow, carCol] = ".";
                carRow = secondTunelRow;
                carCol = secondTunleCol;
            }
            else
            {
                carRow = firstTunelRow;
                carCol = firstTunelCol;
            }
            passedkm += 30;
            matrix[carRow, carCol] = ".";

        }
        if (matrix[carRow, carCol] =="F")
        {
            isCarfoundF = true;
            passedkm += 10;
            Console.WriteLine($"Racing car {racecarnum} finished the stage!");
            break;
        }
    }

    
        matrix[carRow, carCol] ="C";

    if (command == "End" && !isCarfoundF)
    {
        Console.WriteLine($"Racing car {racecarnum} DNF.");
    


     }

    Console.WriteLine($"Distance covered {passedkm} km.");


    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col]);
        }

        Console.WriteLine();
    }


}