int size = int.Parse(Console.ReadLine());
char[,] matrix = new char[size, size];
int startrow = 0;
int startcol = 0;
int damaged = 0;
int countbattle = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string rowData = Console.ReadLine();


    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        
        matrix[row, col] = rowData[col];

        if (matrix[row, col] =='S')
        {
            startrow = row;
            startcol = col;
            matrix[startrow, startcol] ='-';
        }
    }
}

while (true)
{
    string comand = string.Empty;
    switch (comand=Console.ReadLine())
    {
        case "up":
            startrow--;
            break;
        case "down":
            startrow++;
            break;
        case "left":
            startcol--;
            break;
        case "right":
            startcol++;
            break;
    }
    
    if (matrix[startrow,startcol]=='*')
    {
        
        damaged++;

        matrix[startrow, startcol] ='-';
        if(damaged>2)
        {
            //the batle is over
            Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{startrow}, {startcol}]!");
            break;
        }
    }
    else if (matrix[startrow,startcol]=='C')
    {
        //DESTROING THE ENEMY
        countbattle++;
        matrix[startrow, startcol] = '-';
        if(countbattle==3)
        {
            //the batle is over
            Console.WriteLine($"Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
            break;

        }

    }

         

}
        matrix[startrow, startcol] = 'S';
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write(matrix[row, col]);
    }

    Console.WriteLine();
}
