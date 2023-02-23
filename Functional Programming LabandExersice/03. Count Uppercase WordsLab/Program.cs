using System;

Predicate<string> Upercase = s => s[0] == char.ToUpper(s[0]) && char.IsLetter(s[0]);

string[] words = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Where(s => Upercase(s))
    .ToArray();

foreach (var word in words)
{
    Console.WriteLine(string.Join(Environment.NewLine,word));
}

