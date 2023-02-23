using System;
using System.Security.Cryptography.X509Certificates;

List<int> nums = Console.ReadLine()//1 4 3 2 1 7 13
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
     int min = int.MaxValue;

Func<List<int>, int> minnum = nums =>
{
    foreach (var num in nums)
    {
        if (num < min)
        {
            min = num;
        }
    }
    return min;
};

Console.WriteLine(minnum(nums));


   
