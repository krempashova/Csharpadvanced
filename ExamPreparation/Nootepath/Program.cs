// stack  reading DIRECTLY  from Console:
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Text;

Stack<int>stack= new(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

// Queue reading Durectly from Console:
Queue<int> queue = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));



//Reading the matrix from Console:
int size = int.Parse(Console.ReadLine());

string[] sizes = Console.ReadLine().Split(", ");
int rows = int.Parse(sizes[0]);
int cols = int.Parse(sizes[1]);

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = data[col];
    }
}


// second Reading Matrix:
int[,] matrix2 = new int[rows, cols];


for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] rowData = Console.ReadLine().Split()
        .Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = rowData[col];
    }
}


//Printing Matrix :
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write(matrix[row, col] + " ");
    }

    Console.WriteLine();
}

//Methods for Matrix for Reading and printing with Generics:

//Method Reading Generic:
static T[,] ReadMatrix<T>(Func<T[]> rowDataGetter, int rows, int cols)
{
    T[,] matrix = new T[rows, cols];
    for (int row = 0; row < rows; row++)
    {
        T[] rowData = rowDataGetter();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = rowData[col];
        }
    }

    return matrix;
}

//Methot Printing Generic:
static void PrintMatrix<T>(T[,] matrix, Action<T> printer)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            printer(matrix[row, col]);
        }

        Console.WriteLine();
    }
}
// Overide To String():
public override string ToString()
{
    StringBuilder sb = new();
    sb.AppendLine($"{Brand} CPU:");
    sb.AppendLine($"{Frequency:f1} GHZ);
    sb.AppendLine($"{Cores} ");

    return sb.ToString().Trim();
       
       

}
// inicializaciq na list( ot daden class) za class:
//Vinagi se pravi v constuctora:

private List<Shoe> shoes;// KATO FILED
public List<Shoe> Shoes => shoes;//KATO PROP
shoes = new List<Shoe>(); // V CONSTRUKTORA;

// get method in clAASS
public int Count { get { return player.Count; } }
//validation Of MATRIX IN METHOD
private static bool IsValid(int randomrow, int randomcol, char[,] matrix)
{
    return randomrow >= 0 && randomrow < matrix.GetLength(0)
        && randomcol >= 0 && randomcol < matrix.GetLength(1);
}
// Ako iskame da wzemem stoinmostta na col v matrica ( chislo )
points += int.Parse((matrix[startRow, startCol]).ToString());
// drug nachin za pechat  na ako ima neshto i ako e prazno ~
var flourLeft = flour.Count == 0 ? "None" : string.Join(", ", flour);
var waterLeft = water.Count == 0 ? "None" : string.Join(", ", water);