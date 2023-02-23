
using System;
using System.Linq;
using GenericSwapMethodString;

Box<string> box = new();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string item = Console.ReadLine();

    box.Add(item);
}

int[] indices = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

box.Swap(indices[0], indices[1]);

Console.WriteLine(box.ToString());