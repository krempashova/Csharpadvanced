using System;
using System.Linq;

Action<string[], string> printwithtitle = (namesnotitle, title) =>
{
    foreach (var name in namesnotitle)
    {
        Console.WriteLine($"{title} {name}");
    }
};
   string[] namesnotitle = Console.ReadLine()
   .Split(" ", StringSplitOptions.RemoveEmptyEntries);
printwithtitle(namesnotitle, "Sir");