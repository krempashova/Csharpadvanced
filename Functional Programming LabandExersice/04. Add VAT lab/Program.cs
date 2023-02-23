using System;
using System.Linq;

 
double[] priceswithoutVat = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .Select(n=>n*1.20)
    .ToArray();
foreach (var item in priceswithoutVat)
{
    Console.WriteLine($"{item:f2}");
}