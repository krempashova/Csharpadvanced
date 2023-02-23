using System;
using System.Diagnostics;

int nameslenght = int.Parse(Console.ReadLine());

     List<string> names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();


Func<List<string>, Predicate<string>, List<string>> equalnameslenht = (names, match) =>
{
    List<string> result = new();
    foreach (var name in names)
    {
        if (match(name))
        {
            result.Add(name);
        }

    }



    return result;
};

names= equalnameslenht(names,n=>n.Length<= nameslenght);

Console.WriteLine(string.Join(Environment.NewLine,names));