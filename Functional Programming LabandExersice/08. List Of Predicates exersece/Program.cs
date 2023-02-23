using System;

  List <Predicate<int>> predicate = new();

   int end = int.Parse(Console.ReadLine());

     HashSet<int> dividers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToHashSet();
foreach (var divider in dividers)
{
    predicate.Add(n => n % divider == 0);
}

   int[] numbers=Enumerable.Range(1,end).ToArray();

foreach (var number in numbers)
{
    bool isDivided = true;

    foreach (var match in predicate)
    {
        if(!match(number))
        {
            isDivided = false;
            break;
        }
    }

    
    if(isDivided)
    {
        Console.Write($"{number} ");
    }
}
