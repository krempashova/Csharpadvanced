using System;
using GenericBoxofInteger;




Box<int> box = new();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    int value =int.Parse(Console.ReadLine());
    box.Add(value);
}


Console.WriteLine(box.ToString());

