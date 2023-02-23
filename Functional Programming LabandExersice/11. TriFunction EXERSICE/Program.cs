using System;

     int sum = int.Parse(Console.ReadLine());//350

    string[] names = Console.ReadLine()// MARY GOLD SPENSER
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

 Func<string, int, bool> equalsSumName = (name, sum) => name.Sum(ch => ch) >= sum;

 Func<string[],int ,Func<string, int, bool>, string>getFirstEqualOrLargerName=
    (names, sum, match) => names.FirstOrDefault(name => match(name, sum));

Console.WriteLine(getFirstEqualOrLargerName(names,sum, equalsSumName));