using System;
using System.Windows.Markup;


Box<string> box = new();
int  n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string value = Console.ReadLine();
    box.Add(value);
}


Console.WriteLine(box.ToString());

