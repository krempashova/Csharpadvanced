using System;
using System.Linq;


namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                jaggedArray[row] = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
            }
            string comanad;
            while ((comanad=Console.ReadLine())!="END")
            {
                string[] token = comanad.Split(" ");
                string action = token[0].Trim();   
                int row = int.Parse(token[1]);
                int coll = int.Parse(token[2]);
                int value = int.Parse(token[3]);
                if(row<0 || coll<0 || row>=jaggedArray.Length || coll >= jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    switch (action)
                    {

                        case "Add":
                            jaggedArray[row][coll] += value;
                            break;
                        case "Subtract":
                            jaggedArray[row][coll] -= value;
                            break;
                    }
                }
            }
            foreach (int[] array in jaggedArray)
            {
                Console.WriteLine(string.Join(" ",array));
               
            }
        }
    }
}
